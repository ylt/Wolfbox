﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;

namespace WolfBox1.Sites
{
    class Booru : Site
    {
        private WebClient w = new WebClient();

        private List<SiteEntry> entries;

        private string siteURL;
        private string search;
        public Booru(string siteURL, string search)
	    {
            this.siteURL = siteURL;
            this.search = search;

		    string jsonText = w.DownloadString(siteURL+"/post.json?"+search);
            List<BooruImage> jimages = JsonConvert.DeserializeObject<List<BooruImage>>(jsonText);
		
		    entries = new List<SiteEntry>();
            foreach (BooruImage jimage in jimages)
		    {
			    entries.Add(new BooruEntry(siteURL, jimage));
		    }
	    }

        override public List<SiteEntry> getPosts()
        {
            return entries;
        }

        
        override public string ToString()
        {
            return "Booru[URL:" + siteURL + ", Search: " + search + ", hits: " + entries.Count.ToString() + "]";
        }
    }

    class BooruEntry : SiteEntry
    {
       
        private string site;
        private BooruImage image;

        public BooruEntry(string site, BooruImage image)
        {
            this.site = site;
            this.image = image;
        }

        Image PreviewImageCache;

        public Image PreviewImage
        {
            get
            {
                if (PreviewImageCache != null)
                    return PreviewImageCache;
                else
                {
                    //trigger download
                    DownloadImageDelegate worker = new DownloadImageDelegate(DownloadImage);
                    AsyncCallback completedCallback = new AsyncCallback(DownloadComplete);

                    return null;
                }
            }
        }

        private delegate void DownloadImageDelegate();
        public void DownloadImage()
        {
            WebClient w = new WebClient();
            byte[] bytes = w.DownloadData(image.preview_url);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            PreviewImageCache = img;
        }

        public void DownloadComplete(IAsyncResult ar)
        {

        }

        public string PreviewURL
        {
            get
            {
                return image.preview_url;
            }
        }

        public string Link
        {
            get
            {
                return this.site + "/post/show/" + image.id + "/"; ;
            }
        }

        public int Id
        {
            get
            {
                return image.id;
            }
        }

        public string Tags
        {
            get
            {
                return image.tags;
            }
        }
    }

    public class BooruImage
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
