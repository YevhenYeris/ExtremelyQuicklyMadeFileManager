using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    class BrowsePanel
    {
        private TreeView _directoryView;
        private ListView _fileView;
        private ComboBox _dirCombo;
        private ComboBox _extCombo;

        public ListView FileView
        {
            get { return _fileView; }
            set { _fileView = value; }
        }

        public BrowsePanel(TreeView treeView, ListView listView,
                    ComboBox dirComboBox, ComboBox extComboBox)
        {
            _directoryView = treeView;
            _fileView = listView;
            _dirCombo = dirComboBox;
            _extCombo = extComboBox;
        }

        public void Init()
        {
            SetDisplayedDrive();
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
                    if (_extCombo.SelectedValue.ToString() == file.Extension && !_fileView.Items.ContainsKey(file.Name))
                        _fileView.Items.Add(file.FullName, file.Name, 0 );
                }
            }
            catch (Exception exc)
            {

            }
            return node;
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
