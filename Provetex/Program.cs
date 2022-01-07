using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static int? id_item_purchase;
        public static int? id_suplier_purchase;
        public static int? id_sup_item;
        public static bool updateSupplier = false;
        public static bool pannier = false;
        ////peparer la connection
        public static SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=Provetex;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", cnx);
        public static SqlDataReader dr;
        // connection 
        public static void cnnx()
        {
            if (cnx.State.ToString() != "Open")
                cnx.Open();
        }
        // deconnection
        public static void deconnection()
        {
            if (cnx.State != ConnectionState.Closed)
                cnx.Close();
        }
        //Executer MAJ
        public static void ExecuterMaj(string req)
        {
            cnnx();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
            deconnection();
        }
        //Executer Selection 
        public static DataTable ExecuterSelection(string req)
        {
            cnnx();
            cmd.CommandText = req;
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            deconnection();
            return dt;
        }
        //Executer scalaire
        public static string ExecuterScalaire(string req)
        {
            cnnx();
            cmd.CommandText = req;
            string affiFinal = cmd.ExecuteScalar().ToString();
            deconnection();
            return affiFinal;
        }
    }
}
