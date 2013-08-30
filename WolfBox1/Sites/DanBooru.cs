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
    //http://danbooru.donmai.us/wiki_pages/43049
    public class DanbooruQuery : BooruQuery
    {
    }

    class Danbooru : Booru
    {
        private WebClient w = new WebClient();

        private BindingList<SiteEntry> entries;

        private string siteURL;
        private string search;
        public Danbooru(string siteURL, string search)
        {
            this.siteURL = siteURL;
            this.search = search;

            string jsonText = w.DownloadString(siteURL + "/posts.json?" + search);
            List<DanbooruImage> jimages = JsonConvert.DeserializeObject<List<DanbooruImage>>(jsonText);

            entries = new BindingList<SiteEntry>();
            foreach (DanbooruImage jimage in jimages)
            {
                DanbooruEntry entry = new DanbooruEntry(this, jimage);
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
            return "Danbooru[URL:" + siteURL + ", Search: " + search + ", hits: " + entries.Count.ToString() + "]";
        }
    }

    class DanbooruEntry : BooruEntry
    {

        private Danbooru bsite;
        private DanbooruImage image;

        public DanbooruEntry(Danbooru site, DanbooruImage image)
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
                return image.uploader_name;
            }
        }

        override public string PreviewURL
        {
            get
            {
                return bsite.SiteURL + image.preview_file_url;
            }
        }

        override public string ImageURL
        {
            get
            {
                return bsite.SiteURL + image.file_url;
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
                return image.tag_string;
            }
        }
    }

    public class DanbooruImage
    {
        public object approver_id { get; set; }
        public string created_at { get; set; }
        public int down_score { get; set; }
        public int fav_count { get; set; }
        public string fav_string { get; set; }
        public string file_ext { get; set; }
        public int file_size { get; set; }
        public bool has_children { get; set; }
        public int id { get; set; }
        public int image_height { get; set; }
        public int image_width { get; set; }
        public bool is_banned { get; set; }
        public bool is_deleted { get; set; }
        public bool is_flagged { get; set; }
        public bool is_note_locked { get; set; }
        public bool is_pending { get; set; }
        public bool is_rating_locked { get; set; }
        public bool is_status_locked { get; set; }
        public object last_commented_at { get; set; }
        public object last_noted_at { get; set; }
        public string md5 { get; set; }
        public int? parent_id { get; set; }
        public int? pixiv_id { get; set; }
        public string pool_string { get; set; }
        public string rating { get; set; }
        public int score { get; set; }
        public string source { get; set; }
        public int tag_count { get; set; }
        public int tag_count_artist { get; set; }
        public int tag_count_character { get; set; }
        public int tag_count_copyright { get; set; }
        public int tag_count_general { get; set; }
        public string tag_string { get; set; }
        public int up_score { get; set; }
        public string updated_at { get; set; }
        public int uploader_id { get; set; }
        public string uploader_name { get; set; }
        public bool has_large { get; set; }
        public string tag_string_artist { get; set; }
        public string tag_string_character { get; set; }
        public string tag_string_copyright { get; set; }
        public string tag_string_general { get; set; }
        public string file_url { get; set; }
        public string large_file_url { get; set; }
        public string preview_file_url { get; set; }
    }
}
