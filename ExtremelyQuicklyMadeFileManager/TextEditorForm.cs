using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExtremelyQuicklyMadeFileManager
{
    public partial class TextEditorForm : Form
    {
        string path;

        public TextEditorForm(string path)
        {
            InitializeComponent();
            this.path = path;

            FileStream fileOrig = File.OpenRead(path);

            //fileOrig = fileOrig;

            richTextBox.Text = File.ReadAllText(path);

            //fileOrig.Close();
            fileOrig.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, string.Empty);
            FileStream fs = File.OpenWrite(path);

            
            byte[] info = new UTF8Encoding(true).GetBytes(richTextBox.Text);
            fs.Write(info, 0, info.Length);

            fs.Close();

            this.Close();
        }
    }
}
