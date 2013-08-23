using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using Newtonsoft.Json;

using WolfBox1.Sites;

namespace WolfBox1
{
    public partial class Main : Form
    {
        WebClient w = new WebClient();
        FolderBrowserDialog fb = new FolderBrowserDialog();
        ToolTip tt = new ToolTip();

        public Main()
        {
            InitializeComponent();
            w.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverlist.SelectedIndex = 0;
            pageb.ForeColor = Color.Gray;
            tagsb.ForeColor = Color.Gray;
        }

        private void pageb_Enter(object sender, EventArgs e)
        {
            if (pageb.Text == "Page...")
            {
                pageb.Text = "";
                pageb.ForeColor = Color.Black;
            }
        }

        private void pageb_Leave(object sender, EventArgs e)
        {
            if (pageb.Text == "")
            {
                pageb.Text = "Page...";
                pageb.ForeColor = Color.Gray;
            }
        }

        private void tagsb_Enter(object sender, EventArgs e)
        {
            if (tagsb.Text == "Tags...")
            {
                tagsb.Text = "";
                tagsb.ForeColor = Color.Black;
            }
        }

        private void tagsb_Leave(object sender, EventArgs e)
        {
            if (tagsb.Text == "")
            {
                tagsb.Text = "Tags...";
                tagsb.ForeColor = Color.Gray;
            }
        }

        private void listb_Click(object sender, EventArgs e)
        {
            double num;
            if (pageb.Text == "Page..." || !double.TryParse(pageb.Text, out num))
            {
                pageb.ForeColor = Color.Black;
                pageb.Text = "1";
            }
            if (tagsb.Text == "Tags...")
            {
                tagsb.Text = "";
            }

            list.Rows.Clear();

            try
            {
                list.AutoGenerateColumns = false;


                Site test = new Booru(list, "http://konachan.com", "page=" + pageb.Text + "&tags=" + tagsb.Text);
                /*BindingSource bs = new BindingSource();
                bs.DataSource = test.getPosts();
                list.DataSource = bs;*/
                list.DataSource = test.bs;
            }
            catch { }
        }

        private void folderb_Click(object sender, EventArgs e)
        {
            DialogResult result = fb.ShowDialog();
            if (result == DialogResult.OK)
            {
                statusl.Text = "Output folder set to " + fb.SelectedPath;
                Properties.Settings.Default["folder"] = fb.SelectedPath;
            }
        }

        private void folderb_MouseEnter(object sender, EventArgs e)
        {
            tt.Show(Properties.Settings.Default["folder"].ToString(), folderb);
        }



        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            statusl.Text = e.ProgressPercentage.ToString();
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            statusl.Text = "Download completed!";
        }

        private void downloadsb_Click(object sender, EventArgs e)
        {
            try
            {
                SiteEntry entry = (SiteEntry)list.SelectedRows[0].DataBoundItem;
                MessageBox.Show("Downloading " + entry.Link);

                //w.DownloadFile(list.Rows[list.SelectedRows[0].Index].Cells[2].Value.ToString(), Properties.Settings.Default["folder"].ToString());
            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void list_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in list.Rows)
            {
                if (row.Selected == true)
                {
                    row.Height = 100;
                }
                else
                {
                    row.Height = 21;
                }
            }
        }

    }
}

