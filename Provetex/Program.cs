using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var users = (from i in provetex.Users
                         select i).ToList();
            //test
            //if (users.Count == 0)
            //    Application.Run(new Auth.F_register());
            //else
            //    Application.Run(new Auth.F_login());
            Application.Run(new Dashboard());
        }

        //Entity Provetex
        public static ProvetexEntities provetex = new ProvetexEntities();
        //methods
        //show or hide item
        public static void ShowOrHide(PictureBox pictureHide, PictureBox pictureShow)
        {
            if (pictureHide.Visible)
            {
                //Show the hide pic and hide the other
                pictureHide.Visible = false;
                pictureShow.Visible = true;
            }
        }

        //Globals
        public static int? id_supplier;
        public static int? id_achat;
        public static int? id_item;
        public static int? id_sup_item;
        public static bool updateSupplier = false;

    }
}
