namespace ExtremelyQuicklyMadeFileManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rightTree = new System.Windows.Forms.TreeView();
            this.dirIconList = new System.Windows.Forms.ImageList(this.components);
            this.rightListView = new System.Windows.Forms.ListView();
            this.fileIconList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.leftTree = new System.Windows.Forms.TreeView();
            this.leftListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.leftDirCombo = new System.Windows.Forms.ComboBox();
            this.leftExtCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rightDirCombo = new System.Windows.Forms.ComboBox();
            this.rightExtCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.leftTextBox = new System.Windows.Forms.TextBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.rightButton = new System.Windows.Forms.Button();
            this.rightTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.791172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.20883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 776);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(603, 177);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rightTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightListView);
            this.splitContainer1.Size = new System.Drawing.Size(594, 529);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // rightTree
            // 
            this.rightTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTree.ImageIndex = 0;
            this.rightTree.ImageList = this.dirIconList;
            this.rightTree.Location = new System.Drawing.Point(0, 0);
            this.rightTree.Name = "rightTree";
            this.rightTree.SelectedImageIndex = 0;
            this.rightTree.Size = new System.Drawing.Size(195, 529);
            this.rightTree.TabIndex = 0;
            this.rightTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rightTree_AfterSelect);
            this.rightTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.rightTree_NodeMouseClick);
            this.rightTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.rightTree_NodeMouseDoubleClick);
            // 
            // dirIconList
            // 
            this.dirIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.dirIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dirIconList.ImageStream")));
            this.dirIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.dirIconList.Images.SetKeyName(0, "000013.JPG");
            // 
            // rightListView
            // 
            this.rightListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightListView.HideSelection = false;
            this.rightListView.LargeImageList = this.fileIconList;
            this.rightListView.Location = new System.Drawing.Point(0, 0);
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(395, 529);
            this.rightListView.SmallImageList = this.fileIconList;
            this.rightListView.TabIndex = 0;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.SelectedIndexChanged += new System.EventHandler(this.rightListView_SelectedIndexChanged);
            this.rightListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rightListView_MouseDoubleClick);
            // 
            // fileIconList
            // 
            this.fileIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.fileIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconList.ImageStream")));
            this.fileIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIconList.Images.SetKeyName(0, "000013.JPG");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 177);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.leftTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.leftListView);
            this.splitContainer2.Size = new System.Drawing.Size(594, 529);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // leftTree
            // 
            this.leftTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTree.ImageIndex = 0;
            this.leftTree.ImageList = this.dirIconList;
            this.leftTree.Location = new System.Drawing.Point(0, 0);
            this.leftTree.Name = "leftTree";
            this.leftTree.SelectedImageIndex = 0;
            this.leftTree.Size = new System.Drawing.Size(195, 529);
            this.leftTree.StateImageList = this.dirIconList;
            this.leftTree.TabIndex = 0;
            this.leftTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTree_NodeMouseClick);
            this.leftTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTree_NodeMouseDoubleClick);
            // 
            // leftListView
            // 
            this.leftListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftListView.HideSelection = false;
            this.leftListView.LargeImageList = this.fileIconList;
            this.leftListView.Location = new System.Drawing.Point(0, 0);
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(395, 529);
            this.leftListView.SmallImageList = this.fileIconList;
            this.leftListView.TabIndex = 0;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.ItemActivate += new System.EventHandler(this.leftListView_ItemActivate);
            this.leftListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.leftListView_ItemSelectionChanged);
            this.leftListView.SelectedIndexChanged += new System.EventHandler(this.leftListView_SelectedIndexChanged);
            this.leftListView.DoubleClick += new System.EventHandler(this.leftListView_DoubleClick);
            this.leftListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.leftListView_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.leftDirCombo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftExtCombo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 712);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 61);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // leftDirCombo
            // 
            this.leftDirCombo.FormattingEnabled = true;
            this.leftDirCombo.Location = new System.Drawing.Point(3, 3);
            this.leftDirCombo.Name = "leftDirCombo";
            this.leftDirCombo.Size = new System.Drawing.Size(151, 28);
            this.leftDirCombo.TabIndex = 0;
            this.leftDirCombo.SelectedIndexChanged += new System.EventHandler(this.leftDirCombo_SelectedIndexChanged);
            // 
            // leftExtCombo
            // 
            this.leftExtCombo.FormattingEnabled = true;
            this.leftExtCombo.Location = new System.Drawing.Point(300, 3);
            this.leftExtCombo.Name = "leftExtCombo";
            this.leftExtCombo.Size = new System.Drawing.Size(151, 28);
            this.leftExtCombo.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rightDirCombo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rightExtCombo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(603, 712);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 61);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // rightDirCombo
            // 
            this.rightDirCombo.FormattingEnabled = true;
            this.rightDirCombo.Location = new System.Drawing.Point(3, 3);
            this.rightDirCombo.Name = "rightDirCombo";
            this.rightDirCombo.Size = new System.Drawing.Size(151, 28);
            this.rightDirCombo.TabIndex = 0;
            this.rightDirCombo.SelectedIndexChanged += new System.EventHandler(this.rightDirCombo_SelectedIndexChanged);
            // 
            // rightExtCombo
            // 
            this.rightExtCombo.FormattingEnabled = true;
            this.rightExtCombo.Location = new System.Drawing.Point(300, 3);
            this.rightExtCombo.Name = "rightExtCombo";
            this.rightExtCombo.Size = new System.Drawing.Size(151, 28);
            this.rightExtCombo.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(594, 129);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.searchTypeComboBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.fileNameTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.resetButton, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.timeCheck, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(300, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(291, 123);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(25, 71);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 0;
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(25, 3);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(151, 28);
            this.searchTypeComboBox.TabIndex = 0;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(25, 37);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(25, 106);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 14);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "button1";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(3, 71);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(16, 24);
            this.timeCheck.TabIndex = 5;
            this.timeCheck.Text = "checkBox3";
            this.timeCheck.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel6.Controls.Add(this.leftTextBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.leftButton, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(594, 33);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // leftTextBox
            // 
            this.leftTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTextBox.Location = new System.Drawing.Point(3, 3);
            this.leftTextBox.Name = "leftTextBox";
            this.leftTextBox.Size = new System.Drawing.Size(517, 27);
            this.leftTextBox.TabIndex = 4;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(526, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(65, 27);
            this.leftButton.TabIndex = 5;
            this.leftButton.Text = "Search";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.22559F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.77441F));
            this.tableLayoutPanel7.Controls.Add(this.rightButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rightTextBox, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(603, 138);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(594, 33);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(533, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(58, 23);
            this.rightButton.TabIndex = 5;
            this.rightButton.Text = "Search";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // rightTextBox
            // 
            this.rightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTextBox.Location = new System.Drawing.Point(3, 3);
            this.rightTextBox.Name = "rightTextBox";
            this.rightTextBox.Size = new System.Drawing.Size(524, 27);
            this.rightTextBox.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 29);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView rightTree;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.ImageList fileIconList;
        private System.Windows.Forms.TreeView leftTree;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.ImageList dirIconList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox leftDirCombo;
        private System.Windows.Forms.ComboBox leftExtCombo;
        private System.Windows.Forms.ComboBox rightDirCombo;
        private System.Windows.Forms.ComboBox rightExtCombo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox leftTextBox;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.TextBox rightTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox timeCheck;
    }
}

