using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    class BrowsePanel : IPanelObserver
    {
        FileManager _manager;

        private TreeView _directoryView;
        private ListView _fileView;
        private ComboBox _dirCombo;
        private ComboBox _extCombo;
        private TextBox _textBox;
        private Button _searchBtn;

        public ListView FileView
        {
            get { return _fileView; }
            set { _fileView = value; }
        }

        public TreeView DirectoryView
        {
            get { return _directoryView; }
        }

        public TextBox TextBox
        {
            get { return _textBox; }
        }

        public ComboBox Extension
        {
            get { return _extCombo; }
        }

        public void Update()
        {
            string path = _manager.ChangedPath;

            if (_directoryView.Nodes.Find(path, true).Length > 0)
            {
                TreeNode node = _directoryView.Nodes.Find(path, true)[0];

                //if (node.Nodes.Count == 0 || (node.Nodes.Count > 0 && !HasChilds(node)))

                UpdateNode(node);
                _textBox.Text = _directoryView.SelectedNode.Name;
            }
        }

        bool HasChilds(TreeNode node)
        {
            foreach(var n in node.Nodes)
            {
                if (node.Nodes.Count > 0)
                    return true;
            }
            return false;
        }

        public void SetManager(FileManager manager)
        {
            _manager = manager;
        }

        public BrowsePanel(TreeView treeView, ListView listView,
                    ComboBox dirComboBox, ComboBox extComboBox, TextBox textBox, Button button)
        {
            _directoryView = treeView;
            _fileView = listView;
            _dirCombo = dirComboBox;
            _extCombo = extComboBox;
            _textBox = textBox;
            _searchBtn = button;
        }

        public void Init()
        {
            SetDisplayedDrive();
        }

        public bool HasSender(object sender)
        {
            return _directoryView.Equals(sender)
                || _fileView.Equals(sender)
                || _dirCombo.Equals(sender)
                || _fileView.Equals(sender)
                || _textBox.Equals(sender)
                || _searchBtn.Equals(sender);
        }

        public void UpdateNode(TreeNode node)
        {
            _fileView.Items.Clear();
     
            CreateDirectoryNode(node);
            node.Expand();
        }


        private TreeNode CreateDirectoryNode(TreeNode node)
        {
            try
            {
                string path = node.Name;
                var info = new DirectoryInfo(path);

                node.Nodes.Clear();

                foreach (var dir in info.GetDirectories())
                {
                    if (!node.Nodes.Contains(new TreeNode(dir.Name)))
                        node.Nodes.Add(dir.FullName, dir.Name, 0);//CreateDirectoryNode(dir));
                }

                foreach (var file in info.GetFiles())
                {
                    if (/*_extCombo.SelectedValue.ToString()*/ _extCombo.SelectedValue.ToString().ToLower() == file.Extension.ToLower() && !_fileView.Items.ContainsKey(file.Name))
                        _fileView.Items.Add(file.FullName, file.Name, 0 );
                }
            }
            catch (Exception exc)
            {

            }
            return node;
        }

        private void UpdatePanel()
        {
            _fileView.Items.Clear();

            var items = _fileView.Items;
            for (int i = 0; i < items.Count; ++i)
            {
                FileInfo file = new FileInfo(items[i].Name);
                if (!file.Exists)
                {
                    items.RemoveAt(i);
                }
                else
                {
                    _fileView.Items.Add(file.FullName, file.Name, 0);
                }
            }
        }

        private string GetPath(TreeNode node)
        {
            if (node.Parent != null)
                return GetPath(node.Parent) + '/' + node.Text;
            return node.Text + '/';
        }

        public void SetDisplayedDrive()
        {
            _directoryView.Nodes.Clear();

            string selected = _dirCombo.SelectedValue.ToString();

            _directoryView.Nodes.Add(selected, selected, 0);

            _textBox.Text = selected;
        }

        public void SetDirDataSource(List<string> source)
        {
            _dirCombo.DataSource = source;
        }

        public void SetExtDataSource(List<string> source)
        {
            _extCombo.DataSource = source;
        }

        public void SetFiles(List<DirectoryInfo> files)
        {
            _fileView.Items.Clear();
            foreach (var i in files)
                _fileView.Items.Add(i.FullName, i.Name, 0);
        }
    }
}
