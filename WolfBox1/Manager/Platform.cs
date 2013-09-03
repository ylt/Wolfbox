using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WolfBox1.Manager
{
    class Platform
    {
        private string fileName;
        private XmlDocument xmlDoc;

        public string XmlName
        {
            get
            {
                return xmlDoc.SelectSingleNode("/Platform/Details/XmlName").Value;
            }
        }

        public Platform(string filename)
        {
            this.fileName = filename;

            xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
        }

        
    }
}
