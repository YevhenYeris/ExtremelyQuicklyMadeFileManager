using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Drawing; 
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    class Editor
    {
        string _path;
        RichTextBox _textBox;
        FileStream _file;

        FileManager manager;

        public Editor(string path, RichTextBox box, FileManager manager)
        {
            _path = path;
            _textBox = box;
            _file = File.OpenRead(path);
            _textBox.Text = File.ReadAllText(path);
            _file.Close();

            this.manager = manager;
        }

        public void Save(string path)
        {
            File.WriteAllText(_path, string.Empty);
            FileStream fs = File.OpenWrite(_path);


            byte[] info = new UTF8Encoding(true).GetBytes(_textBox.Text);
            fs.Write(info, 0, info.Length);

            fs.Close();

            manager.Move(_path, path);
        }

        public void Select()
        {
            string text = _textBox.Text;

            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i].ToString().ToLower().ToCharArray().First() >= 'a'
                    && text[i].ToString().ToLower().ToCharArray().First() <= 'z')
                {
                    _textBox.SelectionBackColor = Color.Aqua;
                    _textBox.Select(i, 1);
                }
            }
        }

        public void Replace(string what, string with)
        {
            if (with.Length > 0 && what.Length > 0)
                _textBox.Text = _textBox.Text.Replace(what, with);
        }

        public void ToUpper()
        {
            _textBox.Text = ToUpper(_textBox.Text);
        }

        private string ToUpper(string text)
        {
            if (text.Length == 0)
                return text;

            string res = Char.ToUpper(text[0]).ToString();

            bool dot = false;

            for (int i = 1; i < text.Length; ++i)
            {
                if (!dot)
                    res += text[i];
                else
                    res += Char.ToUpper(text[i]);

                if (text[i] == '.')
                    dot = true;
                else
                    dot = false;
            }

            return res;
        }

        public void Simplify()
        {
            string res = "";
            string htmlText = _textBox.Text;

            //res = Regex.Replace(htmlText, @"<(\w+)\s.+?>", string.Empty/*@"<$1>"*/);
            res = Replace(htmlText);

            _textBox.Text = res;
        }

        private string Replace(string text)
        {
            string res = "";

            bool tagFound = false;
            bool write = true;

            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i] == ' ' && tagFound)
                    write = false;
                if (text[i] == '>')
                {
                    write = true;
                    tagFound = false;
                }

                if (write)
                    res += text[i];

                if (text[i] == '<')
                    tagFound = true;
            }

            return res;
        }

    }
}
