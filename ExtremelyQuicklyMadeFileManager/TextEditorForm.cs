using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExtremelyQuicklyMadeFileManager
{
    partial class TextEditorForm : Form
    {
        string path;

        Editor editor;
        FileManager manager;

        public TextEditorForm(string path, FileManager manager)
        {
            InitializeComponent();

            editor = new Editor(path, richTextBox, manager);

            fileNameTextBox.Text = path;

            saveToolStripMenuItem.Click += save_Click;
            selectToolStripMenuItem.Click += select_Click;
            toUpperToolStripMenuItem.Click += toUpper_Click;
            replaceToolStripMenuItem.Click += replace_Click;
            simplifyToolStripMenuItem.Click += simplify_Click;
        }

        private void save_Click(object sender, EventArgs e)
        {
            editor.Save(fileNameTextBox.Text);
        }

        private void select_Click(object sender, EventArgs e)
        {
            editor.Select();
        }

        private void toUpper_Click(object sender, EventArgs e)
        {
            editor.ToUpper();
        }

        private void simplify_Click(object sender, EventArgs e)
        {
            editor.Simplify();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            string replaceWhat = textBox1.Text;
            string replaceWith = textBox2.Text;

            editor.Replace(replaceWhat, replaceWith);
        }
    }
}
