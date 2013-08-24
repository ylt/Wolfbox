namespace WolfBox1
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.outputformatl = new System.Windows.Forms.Label();
            this.outputformatbox = new System.Windows.Forms.TextBox();
            this.opsepline = new System.Windows.Forms.Label();
            this.ophelpl = new System.Windows.Forms.Label();
            this.formatsaveb = new System.Windows.Forms.Button();
            this.formatdefaultb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputformatl
            // 
            this.outputformatl.AutoSize = true;
            this.outputformatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputformatl.Location = new System.Drawing.Point(13, 13);
            this.outputformatl.Name = "outputformatl";
            this.outputformatl.Size = new System.Drawing.Size(74, 13);
            this.outputformatl.TabIndex = 0;
            this.outputformatl.Text = "Output Format";
            // 
            // outputformatbox
            // 
            this.outputformatbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputformatbox.Location = new System.Drawing.Point(12, 29);
            this.outputformatbox.Name = "outputformatbox";
            this.outputformatbox.Size = new System.Drawing.Size(260, 20);
            this.outputformatbox.TabIndex = 1;
            this.outputformatbox.Enter += new System.EventHandler(this.outputformatbox_Enter);
            this.outputformatbox.Leave += new System.EventHandler(this.outputformatbox_Leave);
            // 
            // opsepline
            // 
            this.opsepline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opsepline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opsepline.Location = new System.Drawing.Point(12, 56);
            this.opsepline.Name = "opsepline";
            this.opsepline.Size = new System.Drawing.Size(260, 2);
            this.opsepline.TabIndex = 2;
            // 
            // ophelpl
            // 
            this.ophelpl.AutoSize = true;
            this.ophelpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ophelpl.Location = new System.Drawing.Point(12, 58);
            this.ophelpl.Name = "ophelpl";
            this.ophelpl.Size = new System.Drawing.Size(245, 117);
            this.ophelpl.TabIndex = 3;
            this.ophelpl.Text = resources.GetString("ophelpl.Text");
            this.ophelpl.UseMnemonic = false;
            this.ophelpl.Visible = false;
            // 
            // formatsaveb
            // 
            this.formatsaveb.Location = new System.Drawing.Point(197, 194);
            this.formatsaveb.Name = "formatsaveb";
            this.formatsaveb.Size = new System.Drawing.Size(75, 23);
            this.formatsaveb.TabIndex = 4;
            this.formatsaveb.Text = "Save";
            this.formatsaveb.UseVisualStyleBackColor = true;
            this.formatsaveb.Click += new System.EventHandler(this.formatsaveb_Click);
            // 
            // formatdefaultb
            // 
            this.formatdefaultb.Location = new System.Drawing.Point(116, 194);
            this.formatdefaultb.Name = "formatdefaultb";
            this.formatdefaultb.Size = new System.Drawing.Size(75, 23);
            this.formatdefaultb.TabIndex = 5;
            this.formatdefaultb.Text = "Default";
            this.formatdefaultb.UseVisualStyleBackColor = true;
            this.formatdefaultb.Click += new System.EventHandler(this.formatdefaultb_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.formatdefaultb);
            this.Controls.Add(this.formatsaveb);
            this.Controls.Add(this.ophelpl);
            this.Controls.Add(this.opsepline);
            this.Controls.Add(this.outputformatbox);
            this.Controls.Add(this.outputformatl);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputformatl;
        private System.Windows.Forms.TextBox outputformatbox;
        private System.Windows.Forms.Label opsepline;
        private System.Windows.Forms.Label ophelpl;
        private System.Windows.Forms.Button formatsaveb;
        private System.Windows.Forms.Button formatdefaultb;
    }
}