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
            //strart app
            if (users.Count == 0)
                Application.Run(new Auth.F_register());
            else
                Application.Run(new Auth.F_login());
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
        public static bool FirstPurchase = true;
        public static bool UpdatePurchase = false;
        public static bool AddBon = false;
        ////peparer la connection
        public static SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=Provetex;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", cnx);
        public static SqlDataReader dr;
        // connection 
        public static void Cnnx()
        {
            if (cnx.State.ToString() != "Open")
                cnx.Open();
        }
        // deconnection
        public static void Deconnection()
        {
            if (cnx.State != ConnectionState.Closed)
                cnx.Close();
        }
        //Executer MAJ
        public static void ExecuterMaj(string req)
        {
            Cnnx();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
            Deconnection();
        }
        //Executer Selection 
        public static DataTable ExecuterSelection(string req)
        {
            Cnnx();
            cmd.CommandText = req;
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            Deconnection();
            return dt;
        }
        //Executer scalaire
        public static string ExecuterScalaire(string req)
        {
            Cnnx();
            cmd.CommandText = req;
            string affiFinal = cmd.ExecuteScalar().ToString();
            Deconnection();
            return affiFinal;
        }
    }
}
