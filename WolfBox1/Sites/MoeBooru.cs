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
    class MoeBooru : Site
    {
        private WebClient w = new WebClient();

        private BindingList<SiteEntry> entries;

        private string siteURL;
        private string search;
        public MoeBooru(string siteURL, string search)
	    {
            this.siteURL = siteURL;
            this.search = search;

		    string jsonText = w.DownloadString(siteURL+"/post.json?"+search);
            List<MoeBooruImage> jimages = JsonConvert.DeserializeObject<List<MoeBooruImage>>(jsonText);
		
		    entries = new BindingList<SiteEntry>();
            foreach (MoeBooruImage jimage in jimages)
		    {
                MoeBooruEntry entry = new MoeBooruEntry(this, jimage);
			    entries.Add(entry);
                entry.DownloadPreview();
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
            return "Booru[URL:" + siteURL + ", Search: " + search + ", hits: " + entries.Count.ToString() + "]";
        }
    }

    class MoeBooruEntry : SiteEntry
    {
       
        private MoeBooru bsite;
        private MoeBooruImage image;

        public MoeBooruEntry(MoeBooru site, MoeBooruImage image)
        {
            this.site = this.bsite = site;
            this.image = image;
        }

        override public DateTime CreationTime
        {
            get
            {
                return Util.UnixTimeStampToDateTime(image.created_at);
            }
        }

        override public string Author
        {
            get
            {
                return image.author;
            }
        }

        override public string PreviewURL
        {
            get
            {
                return image.preview_url;
            }
        }

        override public string ImageURL
        {
            get
            {
                return image.file_url;
            }
        }

        override public string Link
        {
            get
            {
                return this.bsite.SiteURL + "/post/show/" + image.id + "/"; ;
            }
        }

        override public int Id
        {
            get
            {
                return image.id;
            }
        }

        override public string Tags
        {
            get
            {
                return image.tags;
            }
        }
    }

    public class MoeBooruImage
    {
        public int id { get; set; }
        public string tags { get; set; }

        public int created_at { get; set; }
        public int creator_id { get; set; }
        public string author { get; set; }
        public int change { get; set; }

        public string source { get; set; }
        public int score { get; set; }
        public string md5 { get; set; }
        public int file_size { get; set; }
        public string file_url { get; set; }
        public bool is_shown_in_index { get; set; }

        public string preview_url { get; set; }
        public int preview_width { get; set; }
        public int preview_height { get; set; }
        public int actual_preview_width { get; set; }
        public int actual_preview_height { get; set; }

        public string sample_url { get; set; }
        public int sample_width { get; set; }
        public int sample_height { get; set; }
        public int sample_file_size { get; set; }

        public string jpeg_url { get; set; }
        public int jpeg_width { get; set; }
        public int jpeg_height { get; set; }
        public int jpeg_file_size { get; set; }

        public string rating { get; set; }
        public bool has_children { get; set; }
        public object parent_id { get; set; }
        public string status { get; set; }

        public int width { get; set; }
        public int height { get; set; }

        public bool is_held { get; set; }

        public string frames_pending_string { get; set; }
        public List<object> frames_pending { get; set; }
        public string frames_string { get; set; }
        public List<object> frames { get; set; }
        public object flag_detail { get; set; }
    }
}
