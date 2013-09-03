using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WolfBox1.Manager
{
    abstract class SiteList
    {
        private XmlNode data;
        public SiteList(XmlNode node) //pass in the List element
        {
            this.data = node;
        }

    }

    class SiteListJson : SiteList
    {
        private XmlNode tdata; //type data
        public SiteListJson(XmlNode node) : base(node)
        {
            this.tdata = node.SelectSingleNode("/Json");
        }
    }

    class SiteListXml : SiteList
    {

        private XmlNode tdata; //type data
        public SiteListXml(XmlNode node) : base(node)
        {
            this.tdata = node.SelectSingleNode("/Xml");
        }
    }

    class SiteListHtmlJson : SiteList //for those fucked up booru's
    {
        public SiteListHtmlJson(XmlNode node) : base(node)
        {
        }
    }

    public abstract class SiteEntry
    {
        public abstract DateTime CreationTime { get; }
        public abstract string Author { get; }
    }

    public class SiteListEntry : SiteEntry
    {
    }

    public class SiteListEntryJson
    {
    }

    public class SiteListEntryXml
    {
    }

    public class SiteListEntryHtmlXml
    {
    }


    //public class SitePageEntry
}
