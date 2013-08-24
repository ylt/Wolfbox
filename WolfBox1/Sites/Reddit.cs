using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace WolfBox1.Sites
{
    class Reddit : Site
    {
        private WebClient w = new WebClient();

        private BindingList<SiteEntry> entries;

        private string siteURL;
        public Reddit(string siteURL)
        {
            this.siteURL = siteURL;

            string jsonText = w.DownloadString(siteURL);
            RedditJSON jimages = JsonConvert.DeserializeObject<RedditJSON>(jsonText);

            entries = new BindingList<SiteEntry>();


            foreach (Child image in jimages.data.children)
            {
                Data2 data = image.data;

                if (data.is_self == false)
                {

                    RedditEntry entry = new RedditEntry(this, data);
                    entries.Add(entry);
                    entry.DownloadPreview();
                }
            }


            DataSource = entries;
        }

        public string SiteURL
        {
            get
            {
                return siteURL;
            }
        }

        override public BindingList<SiteEntry> getPosts()
        {
            return entries;
        }


        override public string ToString()
        {
            return "Reddit[URL:" + siteURL + ", hits: " + entries.Count.ToString() + "]";
        }
    }

    class RedditEntry : SiteEntry
    {

        private Reddit bsite;
        private Data2 image;

        public RedditEntry(Reddit site, Data2 image)
        {
            this.site = this.bsite = site;
            this.image = image;
        }

        override public string PreviewURL
        {
            get
            {
                return image.thumbnail;
            }
        }

        override public string ImageURL
        {
            get
            {
                return image.url;
            }
        }

        override public string Link
        {
            get
            {
                return image.url;
            }
        }

        override public int Id
        {
            get
            {
                return -1;
            }
        }

        override public string Tags
        {
            get
            {
                return image.title;
            }
        }
    }

    public class MediaEmbed
    {
    }

    public class Data2
    {
        public string domain { get; set; }
        public object banned_by { get; set; }
        public MediaEmbed media_embed { get; set; }
        public string subreddit { get; set; }
        public object selftext_html { get; set; }
        public string selftext { get; set; }
        public object likes { get; set; }
        public bool saved { get; set; }
        public string id { get; set; }
        public bool clicked { get; set; }
        public bool stickied { get; set; }
        public string author { get; set; }
        public object media { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool over_18 { get; set; }
        public bool hidden { get; set; }
        public string thumbnail { get; set; }
        public string subreddit_id { get; set; }
        public bool edited { get; set; }
        public object link_flair_css_class { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public bool is_self { get; set; }
        public string permalink { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public string url { get; set; }
        public string author_flair_text { get; set; }
        public string title { get; set; }
        public double created_utc { get; set; }
        public object link_flair_text { get; set; }
        public int ups { get; set; }
        public int num_comments { get; set; }
        public object num_reports { get; set; }
        public object distinguished { get; set; }
    }

    public class Child
    {
        public string kind { get; set; }
        public Data2 data { get; set; }
    }

    public class Data
    {
        public string modhash { get; set; }
        public List<Child> children { get; set; }
        public string after { get; set; }
        public object before { get; set; }
    }

    public class RedditJSON
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }
}
