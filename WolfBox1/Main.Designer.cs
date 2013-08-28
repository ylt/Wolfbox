namespace WolfBox1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serverlist = new System.Windows.Forms.ComboBox();
            this.listb = new System.Windows.Forms.Button();
            this.downloadsb = new System.Windows.Forms.Button();
            this.tagsb = new System.Windows.Forms.TextBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.list = new System.Windows.Forms.DataGridView();
            this.Preview = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsm = new System.Windows.Forms.ToolStripMenuItem();
            this.ofolderm = new System.Windows.Forms.ToolStripMenuItem();
            this.oformatm = new System.Windows.Forms.ToolStripMenuItem();
            this.langm = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.francaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日本語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageb = new System.Windows.Forms.NumericUpDown();
            this.statusl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progresspb = new System.Windows.Forms.ToolStripProgressBar();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageb)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverlist
            // 
            resources.ApplyResources(this.serverlist, "serverlist");
            this.serverlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverlist.FormattingEnabled = true;
            this.serverlist.Items.AddRange(new object[] {
            resources.GetString("serverlist.Items"),
            resources.GetString("serverlist.Items1"),
            resources.GetString("serverlist.Items2")});
            this.serverlist.Name = "serverlist";
            // 
            // listb
            // 
            resources.ApplyResources(this.listb, "listb");
            this.listb.Name = "listb";
            this.listb.UseVisualStyleBackColor = true;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // downloadsb
            // 
            resources.ApplyResources(this.downloadsb, "downloadsb");
            this.downloadsb.Name = "downloadsb";
            this.downloadsb.UseVisualStyleBackColor = true;
            this.downloadsb.Click += new System.EventHandler(this.downloadsb_Click);
            // 
            // tagsb
            // 
            resources.ApplyResources(this.tagsb, "tagsb");
            this.tagsb.Name = "tagsb";
            this.tagsb.Enter += new System.EventHandler(this.tagsb_Enter);
            this.tagsb.Leave += new System.EventHandler(this.tagsb_Leave);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imglist, "imglist");
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // list
            // 
            resources.ApplyResources(this.list, "list");
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
            this.list.AllowUserToResizeColumns = false;
            this.list.AllowUserToResizeRows = false;
            this.list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list.BackgroundColor = System.Drawing.Color.White;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.CausesValidation = false;
            this.list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preview,
            this.ID,
            this.Author,
            this.Uploader,
            this.Progress,
            this.Tags});
            this.list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.list.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.list.RowHeadersVisible = false;
            this.list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.list.RowTemplate.Height = 200;
            this.list.RowTemplate.ReadOnly = true;
            this.list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.ShowCellToolTips = false;
            this.list.ShowEditingIcon = false;
            this.list.ShowRowErrors = false;
            this.list.SelectionChanged += new System.EventHandler(this.list_SelectionChanged);
            // 
            // Preview
            // 
            this.Preview.DataPropertyName = "PreviewImage";
            this.Preview.FillWeight = 213.198F;
            resources.ApplyResources(this.Preview, "Preview");
            this.Preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 47.95577F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.FillWeight = 58.51339F;
            resources.ApplyResources(this.Author, "Author");
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Uploader
            // 
            this.Uploader.DataPropertyName = "Uploader";
            this.Uploader.FillWeight = 53.87841F;
            resources.ApplyResources(this.Uploader, "Uploader");
            this.Uploader.Name = "Uploader";
            this.Uploader.ReadOnly = true;
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.FillWeight = 37.28549F;
            resources.ApplyResources(this.Progress, "Progress");
            this.Progress.Name = "Progress";
            this.Progress.ReadOnly = true;
            this.Progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.FillWeight = 289.169F;
            resources.ApplyResources(this.Tags, "Tags");
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsm});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsm
            // 
            resources.ApplyResources(this.settingsm, "settingsm");
            this.settingsm.BackColor = System.Drawing.Color.Transparent;
            this.settingsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofolderm,
            this.oformatm,
            this.langm});
            this.settingsm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsm.Name = "settingsm";
            // 
            // ofolderm
            // 
            resources.ApplyResources(this.ofolderm, "ofolderm");
            this.ofolderm.BackColor = System.Drawing.SystemColors.Control;
            this.ofolderm.ForeColor = System.Drawing.Color.Black;
            this.ofolderm.Name = "ofolderm";
            this.ofolderm.Click += new System.EventHandler(this.outputFolderToolStripMenuItem_Click);
            // 
            // oformatm
            // 
            resources.ApplyResources(this.oformatm, "oformatm");
            this.oformatm.BackColor = System.Drawing.SystemColors.Control;
            this.oformatm.ForeColor = System.Drawing.Color.Black;
            this.oformatm.Name = "oformatm";
            this.oformatm.Click += new System.EventHandler(this.outputFormatToolStripMenuItem_Click);
            // 
            // langm
            // 
            resources.ApplyResources(this.langm, "langm");
            this.langm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.españolToolStripMenuItem,
            this.francaisToolStripMenuItem,
            this.日本語ToolStripMenuItem});
            this.langm.Name = "langm";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // españolToolStripMenuItem
            // 
            resources.ApplyResources(this.españolToolStripMenuItem, "españolToolStripMenuItem");
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // francaisToolStripMenuItem
            // 
            resources.ApplyResources(this.francaisToolStripMenuItem, "francaisToolStripMenuItem");
            this.francaisToolStripMenuItem.Name = "francaisToolStripMenuItem";
            // 
            // 日本語ToolStripMenuItem
            // 
            resources.ApplyResources(this.日本語ToolStripMenuItem, "日本語ToolStripMenuItem");
            this.日本語ToolStripMenuItem.Name = "日本語ToolStripMenuItem";
            // 
            // pageb
            // 
            resources.ApplyResources(this.pageb, "pageb");
            this.pageb.Name = "pageb";
            // 
            // statusl
            // 
            resources.ApplyResources(this.statusl, "statusl");
            this.statusl.Name = "statusl";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusl,
            this.progresspb});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // progresspb
            // 
            resources.ApplyResources(this.progresspb, "progresspb");
            this.progresspb.Name = "progresspb";
            this.progresspb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresspb.Tag = "";
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pageb);
            this.Controls.Add(this.list);
            this.Controls.Add(this.tagsb);
            this.Controls.Add(this.downloadsb);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.serverlist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageb)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverlist;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.Button downloadsb;
        private System.Windows.Forms.TextBox tagsb;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsm;
        private System.Windows.Forms.ToolStripMenuItem ofolderm;
        private System.Windows.Forms.ToolStripMenuItem oformatm;
        private System.Windows.Forms.NumericUpDown pageb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        public System.Windows.Forms.ToolStripProgressBar progresspb;
        public System.Windows.Forms.DataGridView list;
        public System.Windows.Forms.ToolStripStatusLabel statusl;
        private System.Windows.Forms.ToolStripMenuItem langm;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem francaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日本語ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn Preview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
    }
}

