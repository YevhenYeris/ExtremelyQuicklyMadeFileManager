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

            //Ініціалізуємо панелі файлового менеджера
            BrowsePanel leftPanel = new BrowsePanel(leftTree, leftListView, leftDirCombo, leftExtCombo, leftTextBox, leftButton);
            BrowsePanel rightPanel = new BrowsePanel(rightTree, rightListView, rightDirCombo, rightExtCombo, rightTextBox, rightButton);

            manager = new FileManager(leftPanel, rightPanel);
            manager.Init();

            //Встановлюємо типи пошуку
            List<string> types = new List<string>() { "AllDirectories", "TopDirectoryOnly" };
            searchTypeComboBox.DataSource = types;
        }

        private void DirCombo_SelectedIndexChanged(object sender, EventArgs e)
            //Обрано новий диск
        {
            leftTextBox.Text = leftDirCombo.SelectedItem.ToString();
            manager.UpdateDirCombo(sender);
        }

        private void Tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
            //Подвійний клік на папці
        {
            var node = e.Node;
            manager.PanelClicked(node, sender);
        }

        private void searchButton_Click(object sender, EventArgs e)
            //Пошук
        {
            manager.Search(sender, fileNameTextBox, searchTypeComboBox, dateTimePicker, timeCheck);
        }

        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
            //Клік на папці
        {
            manager.NodeClicked(sender, e.Node);
        }

        private void ListView_KeyDown(object sender, KeyEventArgs e)
            //Обробка натискань клавіш на списку файлів
        {
            
            if (sender is ListView)
            {
                ListView view = sender as ListView;

                switch(e.KeyCode)
                {
                    case Keys.F1:
                        manager.CreateFile(sender, ".txt");
                        break;
                    case Keys.F3:
                        if (view.SelectedItems.Count > 0)
                        {
                            foreach (ListViewItem i in view.SelectedItems)
                            {
                                TextEditorForm editorForm = new TextEditorForm(i.Name, manager);
                                editorForm.Show();
                                break;
                            }
                        }
                        break;
                    case Keys.Delete:
                        var list = view.SelectedItems;
                        var res = new List<string>();
                        foreach (ListViewItem i in list)
                        {
                            res.Add(i.Name);
                        }
                        manager.DeleteFiles(res);
                        break;
                    case Keys.F2:
                        foreach (ListViewItem i in view.SelectedItems)
                        {
                            manager.Copy(i.Name);
                            break;
                        }
                        break;
                    case Keys.F4:
                        foreach (ListViewItem i in view.SelectedItems)
                        {
                            manager.CopyFileBuff = i.Name;
                            break;
                        }
                        break;
                }
            }
        }

        private void Tree_KeyDown(object sender, KeyEventArgs e)
            //Обробка натискань клавіш на дереві директорій
        {
            if (sender is TreeView)
            {
                TreeView view = sender as TreeView;

                switch (e.KeyCode)
                {
                    case Keys.F1:
                        if (view.SelectedNode != null)
                        {
                            manager.CreateFolder(view.SelectedNode.Name);
                        }
                        break;

                    case Keys.Delete:
                        manager.Delete(new List<string>() { view.SelectedNode.Name });
                        break;

                    case Keys.F2:
                        manager.Copy(view.SelectedNode);
                        break;

                    case Keys.F4:
                        manager.CopyDirBuff = view.SelectedNode.Name;
                        break;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timeCheck.Checked = false;
            fileNameTextBox.Text = string.Empty;
            searchTypeComboBox.SelectedIndex = 0;
        }
    }
}
