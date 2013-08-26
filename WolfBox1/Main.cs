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
        }

        // Useful function

        //public static string FormatWith(this string format, params object[] args)
        //{
        //    if (format == null)
        //        throw new ArgumentNullException("format");

        //    return string.Format(format, args);
        //}

        // End of useful function

        private void Form1_Load(object sender, EventArgs e)
        {
            serverlist.SelectedIndex = 0;
            tagsb.ForeColor = Color.Gray;
        }

        private void pageb_Leave(object sender, EventArgs e)
        {
            if (pageb.Text == "")
            {
                pageb.Value = 1;
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
            if (pageb.Value == 0 || !double.TryParse(pageb.Text, out num))
            {
                pageb.ForeColor = Color.Black;
                pageb.Value = 1;
            }
            if (tagsb.Text == "Tags...")
            {
                tagsb.Text = "";
            }

            statusl.Text = "Loading posts...";

            //list.Rows.Clear();
            list.AutoGenerateColumns = false;
            //try
            //{
                if (serverlist.Text == "Konachan")
                {
                    Site test = new Moebooru("http://konachan.com", "page=" + pageb.Text + "&tags=" + tagsb.Text);
                    list.DataSource = test.bs;
                }
                else if (serverlist.Text == "Danbooru")
                {
                    Site test = new Danbooru("http://danbooru.donmai.us", "page=" + pageb.Text + "&tags=" + tagsb.Text);
                    list.DataSource = test.bs;
                }
                else if (serverlist.Text == "Gelbooru")
                {
                    //list.AutoGenerateColumns = false;
                    //Needs check... Motherfucker seems to be different to others and trying to be cool n' shit when it's not.
                    Site test = new Gelbooru("http://gelbooru.com", "touhou");
                    list.DataSource = test.bs;
                }

                statusl.Text = "Posts loaded!";
            //}
            //catch { }
        }

        private void downloadsb_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in list.SelectedRows)
            {
                try
                {
                    //SiteEntry entry = (SiteEntry)list.SelectedRows[0].DataBoundItem;
                    SiteEntry entry = (SiteEntry)row.DataBoundItem;
                    statusl.Text = "Downloading...";

                    //entry.DownloadImage(Properties.Settings.Default["folder"].ToString()+"\\"+entry.Id + ".jpg");

                    // Check if there's an output folder.
                    if (Properties.Settings.Default["folder"].ToString() == "")
                    {
                        MessageBox.Show("It seems like this is your first time running WolfBox. Please select a folder to output all of your images.", "Select an output folder", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        DialogResult result = fb.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            statusl.Text = "Output folder set to " + fb.SelectedPath;
                            Properties.Settings.Default["folder"] = fb.SelectedPath;
                        }
                    }

                    var data = new
                    {
                        author = entry.Author,
                        id = entry.Id,
                        tags = entry.Tags,
                    };

                    entry.DownloadImage(Properties.Settings.Default["folder"] + "\\" + Properties.Settings.Default["fname"].ToString().FormatWith(data) + ".jpg");
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    //w.DownloadFile(entry.ImageURL, Properties.Settings.Default["folder"].ToString());
                }
                catch (Exception ex)
                { MessageBox.Show("ERROR: " + ex.Message.ToString() + "\n Please check your options") ; }
            }
        }

        private void list_SelectionChanged(object sender, EventArgs e)
        {
            int count = list.SelectedRows.Count;
            foreach (DataGridViewRow row in list.Rows)
            {
                if (row.Selected == true)
                {
                    row.Height = Math.Max(200/count, 30);
                }
                else
                {
                    row.Height = 21;
                }
            }
        }

        private void outputFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fb.ShowDialog();
            if (result == DialogResult.OK)
            {
                statusl.Text = "Output folder set to " + fb.SelectedPath;
                Properties.Settings.Default["folder"] = fb.SelectedPath;
            }
        }

        private void outputFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

    }
}

