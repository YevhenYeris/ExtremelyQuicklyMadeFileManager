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
        BrowsePanel leftPanel;
        BrowsePanel rightPanel;

        private Searcher _searcher;

        public FileManager(BrowsePanel left, BrowsePanel right)
        {
            leftPanel = left;
            rightPanel = right;
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

        public void LeftPanelClicked(TreeNode node)
        {
            leftPanel.UpdateNode(node);
        }

        public void RightPanelClicked(TreeNode node)
        {
            rightPanel.UpdateNode(node);
        }

        public void UpdateLeft()
        {
            leftPanel.SetDisplayedDrive();
        }

        public void UpdateRight()
        {
            rightPanel.SetDisplayedDrive();
        }

        public void LeftNodeClicked(TreeNode node)
        {
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
    }
}
