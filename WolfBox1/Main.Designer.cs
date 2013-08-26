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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serverlist = new System.Windows.Forms.ComboBox();
            this.listb = new System.Windows.Forms.Button();
            this.downloadsb = new System.Windows.Forms.Button();
            this.tagsb = new System.Windows.Forms.TextBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.list = new System.Windows.Forms.DataGridView();
            this.pageb = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Preview = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverlist
            // 
            this.serverlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverlist.FormattingEnabled = true;
            this.serverlist.Items.AddRange(new object[] {
            "Konachan",
            "Danbooru",
            "Gelbooru"});
            this.serverlist.Location = new System.Drawing.Point(13, 29);
            this.serverlist.Name = "serverlist";
            this.serverlist.Size = new System.Drawing.Size(197, 21);
            this.serverlist.TabIndex = 0;
            // 
            // listb
            // 
            this.listb.Location = new System.Drawing.Point(216, 27);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(75, 23);
            this.listb.TabIndex = 3;
            this.listb.Text = "List/Refresh";
            this.listb.UseVisualStyleBackColor = true;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // downloadsb
            // 
            this.downloadsb.Location = new System.Drawing.Point(297, 27);
            this.downloadsb.Name = "downloadsb";
            this.downloadsb.Size = new System.Drawing.Size(110, 23);
            this.downloadsb.TabIndex = 4;
            this.downloadsb.Text = "Download Selected";
            this.downloadsb.UseVisualStyleBackColor = true;
            this.downloadsb.Click += new System.EventHandler(this.downloadsb_Click);
            // 
            // tagsb
            // 
            this.tagsb.Location = new System.Drawing.Point(60, 56);
            this.tagsb.Name = "tagsb";
            this.tagsb.Size = new System.Drawing.Size(347, 20);
            this.tagsb.TabIndex = 6;
            this.tagsb.Text = "Tags...";
            this.tagsb.Enter += new System.EventHandler(this.tagsb_Enter);
            this.tagsb.Leave += new System.EventHandler(this.tagsb_Leave);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglist.ImageSize = new System.Drawing.Size(256, 256);
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
            this.list.AllowUserToResizeColumns = false;
            this.list.AllowUserToResizeRows = false;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.list.Location = new System.Drawing.Point(13, 82);
            this.list.Name = "list";
            this.list.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.list.RowHeadersVisible = false;
            this.list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.list.RowTemplate.Height = 200;
            this.list.RowTemplate.ReadOnly = true;
            this.list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.ShowCellToolTips = false;
            this.list.ShowEditingIcon = false;
            this.list.ShowRowErrors = false;
            this.list.Size = new System.Drawing.Size(945, 304);
            this.list.TabIndex = 7;
            this.list.SelectionChanged += new System.EventHandler(this.list_SelectionChanged);
            // 
            // pageb
            // 
            this.pageb.Location = new System.Drawing.Point(15, 56);
            this.pageb.Name = "pageb";
            this.pageb.Size = new System.Drawing.Size(39, 20);
            this.pageb.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.settingsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputFolderToolStripMenuItem,
            this.outputFormatToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // outputFolderToolStripMenuItem
            // 
            this.outputFolderToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.outputFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.outputFolderToolStripMenuItem.Name = "outputFolderToolStripMenuItem";
            this.outputFolderToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.outputFolderToolStripMenuItem.Text = "Output Folder...";
            this.outputFolderToolStripMenuItem.Click += new System.EventHandler(this.outputFolderToolStripMenuItem_Click);
            // 
            // outputFormatToolStripMenuItem
            // 
            this.outputFormatToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.outputFormatToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.outputFormatToolStripMenuItem.Name = "outputFormatToolStripMenuItem";
            this.outputFormatToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.outputFormatToolStripMenuItem.Text = "Output Format...";
            this.outputFormatToolStripMenuItem.Click += new System.EventHandler(this.outputFormatToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(970, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusl
            // 
            this.statusl.Name = "statusl";
            this.statusl.Size = new System.Drawing.Size(121, 17);
            this.statusl.Text = "Welcome to WolfBox!";
            // 
            // Preview
            // 
            this.Preview.DataPropertyName = "PreviewImage";
            this.Preview.FillWeight = 213.198F;
            this.Preview.HeaderText = "Preview";
            this.Preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 47.95577F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.FillWeight = 58.51339F;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Uploader
            // 
            this.Uploader.DataPropertyName = "Uploader";
            this.Uploader.FillWeight = 53.87841F;
            this.Uploader.HeaderText = "Uploader";
            this.Uploader.Name = "Uploader";
            this.Uploader.ReadOnly = true;
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.FillWeight = 37.28549F;
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.ReadOnly = true;
            this.Progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.FillWeight = 289.169F;
            this.Tags.HeaderText = "Tags";
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 417);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.NumericUpDown pageb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFormatToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusl;
        private System.Windows.Forms.DataGridViewImageColumn Preview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
    }
}

