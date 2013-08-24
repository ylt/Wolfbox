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
            this.pageb = new System.Windows.Forms.TextBox();
            this.listb = new System.Windows.Forms.Button();
            this.downloadsb = new System.Windows.Forms.Button();
            this.downloadab = new System.Windows.Forms.Button();
            this.tagsb = new System.Windows.Forms.TextBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.list = new System.Windows.Forms.DataGridView();
            this.folderb = new System.Windows.Forms.Button();
            this.statusl = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // serverlist
            // 
            this.serverlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverlist.FormattingEnabled = true;
            this.serverlist.Items.AddRange(new object[] {
            "www.konachan.com",
            "www.danbooru.com",
            "www.gelbooru.com"});
            this.serverlist.Location = new System.Drawing.Point(13, 13);
            this.serverlist.Name = "serverlist";
            this.serverlist.Size = new System.Drawing.Size(197, 21);
            this.serverlist.TabIndex = 0;
            // 
            // pageb
            // 
            this.pageb.Location = new System.Drawing.Point(217, 13);
            this.pageb.Name = "pageb";
            this.pageb.Size = new System.Drawing.Size(58, 20);
            this.pageb.TabIndex = 2;
            this.pageb.Text = "Page...";
            this.pageb.Enter += new System.EventHandler(this.pageb_Enter);
            this.pageb.Leave += new System.EventHandler(this.pageb_Leave);
            // 
            // listb
            // 
            this.listb.Location = new System.Drawing.Point(282, 13);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(75, 23);
            this.listb.TabIndex = 3;
            this.listb.Text = "List/Refresh";
            this.listb.UseVisualStyleBackColor = true;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // downloadsb
            // 
            this.downloadsb.Location = new System.Drawing.Point(363, 13);
            this.downloadsb.Name = "downloadsb";
            this.downloadsb.Size = new System.Drawing.Size(110, 23);
            this.downloadsb.TabIndex = 4;
            this.downloadsb.Text = "Download Selected";
            this.downloadsb.UseVisualStyleBackColor = true;
            this.downloadsb.Click += new System.EventHandler(this.downloadsb_Click);
            // 
            // downloadab
            // 
            this.downloadab.Location = new System.Drawing.Point(479, 13);
            this.downloadab.Name = "downloadab";
            this.downloadab.Size = new System.Drawing.Size(77, 23);
            this.downloadab.TabIndex = 5;
            this.downloadab.Text = "Download All";
            this.downloadab.UseVisualStyleBackColor = true;
            // 
            // tagsb
            // 
            this.tagsb.Location = new System.Drawing.Point(13, 41);
            this.tagsb.Name = "tagsb";
            this.tagsb.Size = new System.Drawing.Size(544, 20);
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
            this.list.BackgroundColor = System.Drawing.Color.White;
            this.list.CausesValidation = false;
            this.list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preview,
            this.ID,
            this.Link,
            this.Progress,
            this.Tags});
            this.list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.list.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list.Location = new System.Drawing.Point(13, 104);
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
            this.list.Size = new System.Drawing.Size(945, 274);
            this.list.TabIndex = 7;
            this.list.SelectionChanged += new System.EventHandler(this.list_SelectionChanged);
            // 
            // folderb
            // 
            this.folderb.Location = new System.Drawing.Point(563, 13);
            this.folderb.Name = "folderb";
            this.folderb.Size = new System.Drawing.Size(95, 23);
            this.folderb.TabIndex = 8;
            this.folderb.Text = "Output Folder";
            this.folderb.UseVisualStyleBackColor = true;
            this.folderb.Click += new System.EventHandler(this.folderb_Click);
            this.folderb.MouseEnter += new System.EventHandler(this.folderb_MouseEnter);
            // 
            // statusl
            // 
            this.statusl.AutoSize = true;
            this.statusl.Location = new System.Drawing.Point(12, 76);
            this.statusl.Name = "statusl";
            this.statusl.Size = new System.Drawing.Size(110, 13);
            this.statusl.TabIndex = 9;
            this.statusl.Text = "Welcome to WolfBox!";
            // 
            // Preview
            // 
            this.Preview.DataPropertyName = "PreviewImage";
            this.Preview.FillWeight = 200F;
            this.Preview.HeaderText = "Preview";
            this.Preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            this.Preview.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 80;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Link.Width = 300;
            // 
            // Progress
            // 
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.ReadOnly = true;
            this.Progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Progress.Width = 50;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.HeaderText = "Tags";
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tags.Width = 500;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 390);
            this.Controls.Add(this.statusl);
            this.Controls.Add(this.folderb);
            this.Controls.Add(this.list);
            this.Controls.Add(this.tagsb);
            this.Controls.Add(this.downloadab);
            this.Controls.Add(this.downloadsb);
            this.Controls.Add(this.listb);
            this.Controls.Add(this.pageb);
            this.Controls.Add(this.serverlist);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverlist;
        private System.Windows.Forms.TextBox pageb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.Button downloadsb;
        private System.Windows.Forms.Button downloadab;
        private System.Windows.Forms.TextBox tagsb;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button folderb;
        private System.Windows.Forms.Label statusl;
        private System.Windows.Forms.DataGridViewImageColumn Preview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
    }
}

