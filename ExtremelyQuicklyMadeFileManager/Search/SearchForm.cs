using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExtremelyQuicklyMadeFileManager
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            setFilters();
        }

        private void setFilters()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = "Path";
            row.Cells.Add(cell);
            row.Cells.Add(new DataGridViewTextBoxCell());
            rows.Add(row);
            cell.Value = "Weight";
            row.Cells.Add(cell);
            row.Cells.Add(new DataGridViewTextBoxCell());
            rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public List<FileInfo> SearchFiles()
        {
            List<FileInfo> found = new List<FileInfo>();

            string rootPath = "";


            if (pathBox.Text.Length > 0)
            {
                rootPath = pathBox.Text;
            }

            var info = new DirectoryInfo(rootPath);

            foreach(var file in info.GetFiles())
            {
                found.Add(file);
            }

            return found;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
