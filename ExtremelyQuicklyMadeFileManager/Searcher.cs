using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    class Searcher
    {
        TextBox _path;
        ComboBox _type;
        ComboBox _extensions;
        TextBox _fileName;
        DateTimePicker _time;
        CheckBox _dateCheck;

        public Searcher(TextBox path, ComboBox type, ComboBox exts, TextBox fileName, DateTimePicker time, CheckBox check)
        {
            _path = path;
            _type = type;
            _extensions = exts;
            _fileName = fileName;
            _time = time;
            _dateCheck = check;
        }

        public List<DirectoryInfo> Search()
        {
            var found = new List<DirectoryInfo>();

            string pattern = "";

            if (_fileName.TextLength > 0)
                pattern = _fileName.Text + '?' + _extensions.SelectedItem.ToString();
            else
                pattern = '*' + _extensions.SelectedItem.ToString();

            IEnumerable<string> files;

            if (_type.SelectedIndex == 0)
                files = GetFiles(_path.Text, pattern);
            else
                files = Directory.GetFiles(_path.Text, pattern, SearchOption.TopDirectoryOnly);

            if (_dateCheck.Checked)
            {
                files = from f in files
                        where (new DirectoryInfo(f)).CreationTime == _time.Value
                        select f;
            }

            foreach (var i in files)
            {
                found.Add(new DirectoryInfo(i));
            }

            return found;
        }

        public IEnumerable<string> GetFiles(string root, string searchPattern)//, SearchOption option)
        {
            Stack<string> pending = new Stack<string>();
            pending.Push(root);
            while (pending.Count != 0)
            {
                var path = pending.Pop();
                string[] next = null;
                try
                {
                    next = Directory.GetFiles(path, searchPattern);//, option);
                }
                catch { }
                if (next != null && next.Length != 0)
                    foreach (var file in next) yield return file;
                try
                {
                    next = Directory.GetDirectories(path);
                    foreach (var subdir in next) pending.Push(subdir);
                }
                catch { }
            }
        }
    }
}
