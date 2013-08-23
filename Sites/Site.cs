using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfBox1.Sites
{
    abstract class Site : IEnumerable<SiteEntry>
    {
        public abstract List<SiteEntry> getPosts();

        IEnumerator<SiteEntry> IEnumerable<SiteEntry>.GetEnumerator()
        {
            return getPosts().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)getPosts().GetEnumerator();
        }

        override public string ToString()
        {
            return "Site";
        }
    }

    interface SiteEntry
    {
        string Preview { get; }
        string Link { get; }
        int Id { get; }
        string Tags { get; }
    }
}
