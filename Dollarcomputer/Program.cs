using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollarcomputer
{
    static class Program
    {
        public static Startupform startupform;
        public static splashform splash;
        public static selectform select;
        public static productinfoform product;
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash = new splashform();
            startupform = new Startupform();
            select = new selectform();
            product = new productinfoform();
            Application.Run(new splashform());
        }
    }
}
