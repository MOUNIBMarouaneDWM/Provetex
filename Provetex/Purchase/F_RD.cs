using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Purchase
{
    public partial class F_RD : Form
    {
        public F_RD()
        {
            InitializeComponent();
        }
        /// <Methods>
        private void list_purchas()
        {
            DataGrid_list.DataSource = (from purchase in Program.provetex.purchases
                                        join supplier_item in Program.provetex.suppliers_items
                                        on purchase.C_suppliers_items equals supplier_item.C_id_suppliers_items
                                        select new
                                        {
                                            ID=purchase.C_id_purchase,
                                            FOURNISSEUR=supplier_item.supplier.C_name_supplier,
                                            ARTICLE=supplier_item.item.C_name_item,
                                            PRIX=supplier_item.C_price,
                                            QTT=purchase.C_quantity,
                                            TOTAL=purchase.C_quantity*supplier_item.C_price,
                                            PAID=purchase.C_paid,
                                            REST=purchase.C_rest                                           
                                        }).ToList();
            DataGrid_list.Columns["ID"].Visible = false;
        }
        /// </Methods>
        private void F_RD_Load(object sender, EventArgs e)
        {
            list_purchas();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Purchase.F_CU>().Any())
            {
                Form form = new Purchase.F_CU();
                //form.TopMost = true;
                form.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            list_purchas();
        }
    }
}
