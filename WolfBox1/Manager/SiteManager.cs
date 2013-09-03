using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WolfBox1.Manager
{
    class SiteManager
    {
        
        public SiteManager()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("sites.xml");

            XmlNodeList sites = xmlDoc.GetElementsByTagName("site");
            
            foreach(XmlNode node in sites)
            {

            }
        }

    }

}
