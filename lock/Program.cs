using lockd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @lock
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
            String pku = @lock.Properties.Settings.Default.pass + "";
            if (1<pku.Length)
            {
           Application.Run(new Form1());
            }
            else
                {
 Application.Run(new FirstPassGet());
                }


        }



    }
}
