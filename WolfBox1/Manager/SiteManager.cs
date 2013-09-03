using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WolfBox1.Manager
{
    class SiteManager
    {
        public SiteManager()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SitesXML));

            SitesXML sites = (SitesXML)serializer.Deserialize(new StreamReader("sites.xml"));

        }

    }

    [Serializable]
    [XmlRootAttribute("sites")]
    private class SitesXML
    {
        [XmlElement("site")]
        public SiteXML[] sites { get; set; }
    }

    [Serializable()]
    private class SiteXML
    {
        [XmlAttribute("platform")]
        public string Platform { get; set; }

        [XmlAttribute("domain")]
        public string Domain { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
