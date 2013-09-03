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
        List<Platform> platforms;

        public PlatformManager()
        {
            string[] files = Directory.GetFiles("Platforms");
            foreach (string file in files)
            {
               
            }
        }

        public Platform GetPlatformByXmlName(string name)
        {
            //throws exception if name not found, or >1 entry
            return platforms.Single(s => s.XmlName == name);
        }
    }
}
