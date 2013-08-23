using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfBox1.Sites
{
    abstract class Site
    {

        public BindingSource bs = new BindingSource();

        public Site()
        {
            
        }

        public void Refresh()
        {
            bs.ResetBindings(false);
        }

        public object DataSource
        {
            set
            {
                bs.DataSource = value;
            }
        }

        public abstract List<SiteEntry> getPosts();


        override public string ToString()
        {
            return "Site";
        }
    }

    interface SiteEntry
    {
        string PreviewURL { get; }
        Image PreviewImage { get; }
        string Link { get; }
        int Id { get; }
        string Tags { get; }
    }
}
