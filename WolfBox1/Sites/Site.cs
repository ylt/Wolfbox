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
    abstract class Site
    {

        public BindingSource bs = new BindingSource();
        private DataGridView dgv;

        public Site(DataGridView dgv)
        {
            this.dgv = dgv;
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

    abstract class SiteEntry : INotifyPropertyChanged
    {
        protected Site site;

        public abstract string PreviewURL { get; }
        public abstract string ImageURL { get; }
        /*Image PreviewImage { get; }*/
        public abstract string Link { get; }
        public abstract int Id { get; }
        public abstract string Tags { get; }


        private int progress;
        public int Progress {
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

        public void DownloadImageProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage;
            //site.bs.ResetBindings(false);
            RaisePropertyChanged("Progress");
        }

        public void DownloadImageComplete(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void RaisePropertyChanged(string caller)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
