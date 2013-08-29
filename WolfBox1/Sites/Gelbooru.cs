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
using System.Xml.Serialization;

namespace WolfBox1.Sites
{
    class Gelbooru : Booru
    {
        private WebClient w = new WebClient();

        private BindingList<SiteEntry> entries;

        private string siteURL;
        private string search;
        public Gelbooru(string siteURL, string search)
        {
            this.siteURL = siteURL;
            this.search = search;

            string jsonText = w.DownloadString(siteURL + "/index.php?page=dapi&s=post&q=index&tags=" + search);
            //List<GelbooruImage> jimages = JsonConvert.DeserializeObject<List<GelbooruImage>>(jsonText);
            XmlSerializer serializer = new XmlSerializer(typeof(GelbooruPage));
            GelbooruPage page;
            using (TextReader reader = new StringReader(jsonText))
            {
                page = (GelbooruPage)serializer.Deserialize(reader);
            }
            GelbooruImage[] jimages = page.posts;

            entries = new BindingList<SiteEntry>();
            foreach (GelbooruImage jimage in jimages)
            {
                GelbooruEntry entry = new GelbooruEntry(this, jimage);
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
            return "Gelbooru[URL:" + siteURL + ", Search: " + search + ", hits: " + entries.Count.ToString() + "]";
        }
    }

    class GelbooruEntry : BooruEntry
    {

        private Gelbooru bsite;
        private GelbooruImage image;

        public GelbooruEntry(Gelbooru site, GelbooruImage image)
        {
            this.site = this.bsite = site;
            this.image = image;
        }

        override public DateTime CreationTime
        {
            get
            {
                return Util.TimeStampToDateTime(image.created_at);
            }
        }

        override public string Author
        {
            get
            {
                return ":(";
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

    [Serializable()]
    [XmlRootAttribute("posts")]
    public class GelbooruPage
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlAttribute("offset")]
        public int Offset { get; set; }

        [XmlElement("post")]
        public GelbooruImage[] posts { get; set; }
    }

    [Serializable()]
    public class GelbooruImage
    {
        [XmlAttribute("id")]
        public int id { get; set; }
        [XmlAttribute("tags")]
        public string tags { get; set; }
        [XmlAttribute("created_at")]
        public string created_at { get; set; }
        [XmlAttribute("creator_id")]
        public int creator_id { get; set; }
        //[XmlAttribute("author")]
        //public string author { get; set; } - missing :(
        [XmlAttribute("change")]
        public int change { get; set; }
        
        [XmlAttribute("source")]
        public string source { get; set; }
        [XmlAttribute("score")]
        public int score { get; set; }
        [XmlAttribute("md5")]
        public string md5 { get; set; }
        [XmlAttribute("file_size")]
        public int file_size { get; set; }
        [XmlAttribute("file_url")]
        public string file_url { get; set;}

        //public bool is_shown_in_index { get; set; }

        [XmlAttribute("preview_url")]
        public string preview_url { get; set; }
        [XmlAttribute("preview_width")]
        public int preview_width { get; set; }
        [XmlAttribute("preview_height")]
        public int preview_height { get; set; }
        //public int actual_preview_width { get; set; }
        //public int actual_preview_height { get; set; }

        [XmlAttribute("sample_url")]
        public string sample_url { get; set; }
        [XmlAttribute("sample_width")]
        public int sample_width { get; set; }
        [XmlAttribute("sample_height")]
        public int sample_height { get; set; }
        //public int sample_file_size { get; set; }
        
        [XmlAttribute("jpeg_url")]
        public string jpeg_url { get; set; }
        [XmlAttribute("jpeg_width")]
        public int jpeg_width { get; set; }
        [XmlAttribute("jpeg_height")]
        public int jpeg_height { get; set; }
        
        [XmlAttribute("rating")]
        public string rating { get; set; }
        [XmlAttribute("has_children")]
        public bool has_children { get; set; }
        //[XmlAttribute("parent_id")]
        //public int? parent_id { get; set; }
        [XmlAttribute("status")]
        public string status { get; set; }
        
        [XmlAttribute("width")]
        public int width { get; set; }
        [XmlAttribute("height")]
        public int height { get; set; }

        [XmlAttribute("has_notes")]
        public bool has_notes { get; set; }
        [XmlAttribute("has_comments")]
        public bool has_comments { get; set; }
        
    }

}
