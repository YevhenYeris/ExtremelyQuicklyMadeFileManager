using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace ExtremelyQuicklyMadeFileManager
{
    class FileManager
    {
        List<IPanelObserver> _observers;
        List<BrowsePanel> _panels;

        BrowsePanel leftPanel;
        BrowsePanel rightPanel;

        private Searcher _searcher;

        string _changedPath;

        public string ChangedPath
        {
            get { return (new PathManager()).ShortenPath(_changedPath); }
            set
            {
                _changedPath = value;
                Notify();
            }
        }

        private string _fileBuff = "";
        public string CopyFileBuff
        {
            get
            {
                return _fileBuff;
            }
            set
            {
                _fileBuff = value;
            }
        }

        private string _dirBuff = "";
        public string CopyDirBuff
        {
            get
            {
                return _dirBuff;
            }
            set
            {
                if (_dirBuff.Length > 0)
                {
                    MoveDirectory(_dirBuff, value);
                    _dirBuff = string.Empty;
                }
                else if (_fileBuff.Length > 0)
                {
                    MoveToDirectory(_fileBuff, value);
                    _fileBuff = string.Empty;
                }
                else
                {
                    _dirBuff = value;
                }
            }
        }

        public FileManager(BrowsePanel left, BrowsePanel right)
        {
            leftPanel = left;
            rightPanel = right;

            leftPanel.SetManager(this);
            rightPanel.SetManager(this);

            _panels = new List<BrowsePanel>();
            _observers = new List<IPanelObserver>() { left, right};

            AddPanel(left);
            AddPanel(right);
        }

        #region Observer
        public void Delete(List<string> paths)
        {
            foreach (string path in paths)
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                directory.Attributes = FileAttributes.Normal;
                foreach (var dir in directory.GetDirectories())
                {
                    dir.Attributes = FileAttributes.Normal;
                    foreach (var file in dir.GetFiles())
                    {
                        file.Attributes = FileAttributes.Normal;
                        file.Delete();
                    }
                    dir.Delete();
                }

                foreach (var file in directory.GetFiles())
                {
                    file.Attributes = FileAttributes.Normal;
                    file.Delete();
                }

                directory.Delete();
                ChangedPath = path;
            }
        }

        public void DeleteFiles(List<string> files)
        {
            foreach (string path in files)
            {
                FileInfo file = new FileInfo(path);
                file.Attributes = FileAttributes.Normal;
                file.Delete();
                ChangedPath = path;
            }
        }

        public void CreateFolder(string path)
        {
            string dirPath = (new PathManager()).GetNewDirectoryName(path);
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            dir.Create();
            ChangedPath = dirPath;
        }

        public void CreateFile(object sender, string ext)
        {
            string path = "";
            foreach(var panel in _panels)
            {
                if (panel.HasSender(sender))
                {
                    path = panel.TextBox.Text;
                    break;
                }
            }
            string filePath = (new PathManager()).GetNewFileName(path, ext);
            FileInfo file = new FileInfo(filePath);
            file.Create().Close();
            ChangedPath = filePath;
        }

        public void Move(string from, string to)
        {
            File.Move(from, to);
            ChangedPath = from;
            ChangedPath = to;
        }

        public void MoveToDirectory(string from, string to)
        {
            to += @"\" + Path.GetFileName(from);
            File.Move(from, to);
            ChangedPath = from;
            ChangedPath = to;
        }

        public void MoveDirectory(string from, string to)
        {
            Directory.Move(from, to);
            ChangedPath = from;
            ChangedPath = to;
        }

        public void Copy(TreeNode node)
        {
            PathManager pManager = new PathManager();
            string path = pManager.ShortenPath(node.Name);
            string newFolder = pManager.GetNewDirectoryName(path, node.Text);

            DirectoryCopy(node.Name, newFolder);

            ChangedPath = node.Name;
        }

        public void Copy(string filePath)
        {
            PathManager pManager = new PathManager();
            string path = pManager.ShortenPath(filePath);
            string ext = Path.GetExtension(filePath);
            string name = Path.GetFileName(filePath);
            File.Copy(filePath, pManager.GetNewFileName(path, ext, name));
            ChangedPath = path;
        }

        public void Notify()
        {
            foreach (var sub in _observers)
            {
                sub.Update();
            }
        }
        #endregion

        private static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, tempPath);
            }
        }

        public void AddPanel(BrowsePanel panel)
        {
            _panels.Add(panel);
        }

        public void SetSearcher(Searcher searcher)
        {
            _searcher = searcher;
        }

        public void Init()
        {
            // Set data sources for comboboxes
            var list = System.IO.DriveInfo.GetDrives();
            List<string> source1 = new List<string>();
            foreach (var i in list)
            {
                source1.Add(i.Name);
            }

            List<string> source2 = new List<string>();
            foreach (var i in list)
            {
                source2.Add(i.Name);
            }

            leftPanel.SetDirDataSource(source1);
            rightPanel.SetDirDataSource(source2);

            List<string> source3 = new List<string>() { ".txt", ".html", ".bin" };
            List<string> source4 = new List<string>() { ".txt", ".html", ".bin" };
            leftPanel.SetExtDataSource(source3);
            rightPanel.SetExtDataSource(source4);

            leftPanel.Init();
            rightPanel.Init();
        }

        public void PanelClicked(TreeNode node, object sender)
        {
            foreach (var panel in _panels)
            {
                if (panel.HasSender(sender))
                {
                    panel.UpdateNode(node);
                    break;
                }
            }
        }

        public void UpdateDirCombo(object sender)
        {
            foreach (var panel in _panels)
            {
                if (panel.HasSender(sender))
                {
                    panel.SetDisplayedDrive();
                    break;
                }
            }
        }

        public void Search(ListView view)
        {
            var found = _searcher.Search();
            view.Items.Clear();

            foreach(var i in found)
            {
                view.Items.Add(i.FullName, i.Name, 0);
            }
        }

        public void Search(object sender, TextBox name, ComboBox type, DateTimePicker time, CheckBox timeCheck)
        {
            foreach(var panel in _panels)
            {
                if (panel.HasSender(sender))
                {
                    Searcher srchr = new Searcher(panel.TextBox, type, panel.Extension, name, time, timeCheck);
                    SetSearcher(srchr);
                    Search(panel.FileView);
                    break;
                }
            }
        }

        public void NodeClicked(object sender, TreeNode node)
        {
            foreach(var panel in _panels)
            {
                if (panel.HasSender(sender))
                {
                    panel.TextBox.Text = node.Name;
                }
            }
        }
    }
}
