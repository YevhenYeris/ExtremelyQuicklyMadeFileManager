using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExtremelyQuicklyMadeFileManager
{
    public partial class MainForm : Form
    {
        FileManager manager;

        public MainForm()
        {
            InitializeComponent();

            BrowsePanel leftPanel = new BrowsePanel(leftTree, leftListView, leftDirCombo, leftExtCombo);
            BrowsePanel rightPanel = new BrowsePanel(rightTree, rightListView, rightDirCombo, rightExtCombo);

            manager = new FileManager(leftPanel, rightPanel);
            manager.Init();

            List<string> types = new List<string>() { "AllDirectories", "TopDirectoryOnly" };
            searchTypeComboBox.DataSource = types;
        }

        private void leftDirCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftTextBox.Text = leftDirCombo.SelectedItem.ToString();
            manager.UpdateLeft();
        }

        private void leftTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            leftTextBox.Text = node.Name;
            manager.LeftPanelClicked(node);
        }

        private void rightTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            rightTextBox.Text = node.Name;
            manager.RightPanelClicked(node);
        }

        private void rightDirCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightTextBox.Text = rightDirCombo.SelectedItem.ToString();
            manager.UpdateRight();
        }

        private void rightTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void leftListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            Searcher searcher = new Searcher(leftTextBox, searchTypeComboBox, leftExtCombo, fileNameTextBox, dateTimePicker, timeCheck);
            manager.SetSearcher(searcher);
            manager.Search(leftListView);
        }

        private void leftTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            leftTextBox.Text = e.Node.Name;
            manager.LeftNodeClicked(e.Node);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            Searcher searcher = new Searcher(rightTextBox, searchTypeComboBox, rightExtCombo, fileNameTextBox, dateTimePicker, timeCheck);
            manager.SetSearcher(searcher);

            manager.Search(rightListView);
        }

        private void rightTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            rightTextBox.Text = e.Node.Name;
            //manager.RightNodeClicked(e.Node);
        }

        private void leftListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < leftListView.Items.Count; i++)
            {
                var rectangle = leftListView.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    TextEditorForm editorForm = new TextEditorForm(leftListView.Items[i].Name);
                    editorForm.Show();

                    return;
                }
            }
        }

        private void leftListView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void leftListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void leftListView_ItemActivate(object sender, EventArgs e)
        {
        }

        private void rightListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rightListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < leftListView.Items.Count; i++)
            {
                var rectangle = leftListView.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    TextEditorForm editorForm = new TextEditorForm(leftListView.Items[i].Name);
                    editorForm.Show();

                    return;
                }
            }
        }
    }
}
