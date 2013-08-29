using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfBox1.Sites
{
    public abstract class Site
    {

        public BindingSource bs = new BindingSource();

        public Site()
        {
        }

        public object DataSource
        {
            set
            {
                bs.DataSource = value;
            }
        }

        public abstract BindingList<SiteEntry> getPosts();


        override public string ToString()
        {
            return "Site";
        }

        public int Progress
        {
            get
            {
                int total = 0;
                int count = 0;
                foreach(SiteEntry entry in getPosts())
                {
                    if (entry.ProgressInt > 0)
                    {
                        total += entry.ProgressInt;
                        count++;
                    }
                }
                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return total / count;
                }
            }
        }
        public event SiteProgressChange ProgressChange;

        public void triggerProgressChange()
        {
            ProgressChange(this, new SiteProgressChangeArgs(this));
        }
    }

    public delegate void SiteProgressChange(object source, SiteProgressChangeArgs e);
    public class SiteProgressChangeArgs : EventArgs
    {
        private Site site;
        public Site Site
        {
            get
            {
                return site;
            }
        }
        public SiteProgressChangeArgs(Site site)
        {
            this.site = site;
        }
    }

    public abstract class SiteEntry : INotifyPropertyChanged
    {
        protected Site site;

        public abstract string Author { get; }
        public abstract string PreviewURL { get; }
        public abstract string ImageURL { get; }
        /*Image PreviewImage { get; }*/
        public abstract DateTime CreationTime { get; }
        public abstract string Link { get; }
        public abstract int Id { get; }
        public abstract string Tags { get; }


        private int progress;
        public string Progress
        {
            get
            {
                return progress + "%";
            }
        }

        public int ProgressInt
        {
            get
            {
                return progress;
            }
        }

        Image PreviewImageCache;

        public Image PreviewImage
        {
            get
            {
                if (PreviewImageCache != null)
                    return PreviewImageCache;
                else if (!asyncDownloading)
                {
                    //trigger download

                    DownloadPreview();
                    return null;
                }
                else
                {
                    return null;
                }
            }
        }

        bool asyncDownloading = false;
        private delegate void DownloadImageDelegate();
        public void DownloadPreview()
        {
            WebClient w = new WebClient();
            w.DownloadDataCompleted += new DownloadDataCompletedEventHandler(DownloadPreviewComplete);

            w.DownloadDataAsync(new Uri(PreviewURL));
            asyncDownloading = true;
        }

        public void DownloadPreviewComplete(object sender, DownloadDataCompletedEventArgs e)
        {

            byte[] bytes = e.Result;
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            PreviewImageCache = img;
            //site.Refresh(site.bs.List.IndexOf(this));
            RaisePropertyChanged("PreviewImage");
        }


        public void DownloadImage(string filename)
        {
            WebClient w = new WebClient();
            w.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadImageComplete); 
            w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadImageProgress);
            w.DownloadFileAsync(new Uri(ImageURL), filename);
        }

        Main main = new Main();

        public void DownloadImageProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage;

            RaisePropertyChanged("Progress");
            site.triggerProgressChange();
        }

        public void DownloadImageComplete(object sender, AsyncCompletedEventArgs e)
        {
        
        }

        //http://jesseliberty.com/2012/06/28/c-5making-inotifypropertychanged-easier/
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        

    }

    public abstract class SiteQuery
    {
    }

}

