﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSelll.KULLANICI;
//using WindowsFormsAppSelll.YETKI;

namespace WindowsFormsAppSelll
{
    internal static class Program
    {
        
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(11));
        }
    }
}
