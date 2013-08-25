using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfBox1
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            outputformatbox.Text = Properties.Settings.Default["fname"].ToString();
        }

        private void outputformatbox_Enter(object sender, EventArgs e)
        {
            ophelpl.Visible = true;
        }

        private void outputformatbox_Leave(object sender, EventArgs e)
        {
            ophelpl.Visible = false;
        }

        private void formatsaveb_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["fname"] = outputformatbox.Text;
            this.Close();
        }

        private void formatdefaultb_Click(object sender, EventArgs e)
        {
            outputformatbox.Text = "{author} - {id} - {tags}";
            Properties.Settings.Default["fname"] = "{author} - {id} - {tags}";
        }
    }
}
