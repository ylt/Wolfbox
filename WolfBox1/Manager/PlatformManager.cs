using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WolfBox1.Manager
{

    class PlatformManager
    {
        public PlatformManager()
        {
            string[] files = Directory.GetFiles("Platforms");
            foreach (string file in files)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file);
            }
        }
    }
}
