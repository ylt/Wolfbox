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
        public SiteList(XmlNode node) //pass in the List element
        {
        }
    }

    class SiteListJson : SiteList
    {

    }

    class SiteListXml : SiteList
    {
    }

    class SiteListHtmlJson : SiteList //for those fucked up booru's
    {
    }
}
