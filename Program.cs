using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WolfBox1.Sites;
namespace WolfBox1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            /*Site test = new Booru("http://konachan.com/", "");
            foreach (SiteEntry entry in test)
            {
                Console.WriteLine(entry.Preview);
            }

            Console.ReadLine();*/
        }
    }
}
