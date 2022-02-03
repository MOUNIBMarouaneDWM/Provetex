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
        private void List_purchas()
        {
            DataGrid_list.DataSource = (from purchase in Program.provetex.purchases
                                        join supplier_item in Program.provetex.suppliers_items
                                        on purchase.C_suppliers_items equals supplier_item.C_id_suppliers_items
                                        select new
                                        {
                                            ID = purchase.C_id_purchase,                                          
                                            FOURNISSEUR = supplier_item.supplier.C_name_supplier,
                                            ARTICLE = supplier_item.item.C_name_item,
                                            PRIX = supplier_item.C_price,
                                            QTT = purchase.C_quantity,
                                            TOTAL = purchase.C_quantity * supplier_item.C_price,
                                            PAID = purchase.C_paid,
                                            REST = purchase.C_rest,
                                            DATE= purchase.created_at
                                        }).ToList();
            DataGrid_list.Columns["ID"].Visible = false;
        }
        /// </Methods>
        private void F_RD_Load(object sender, EventArgs e)
        {
            List_purchas();
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            List_purchas();
        }

        private void DataGrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)DataGrid_list.Rows[index].Cells["ID"].Value;
            decimal rest = (decimal)DataGrid_list.Rows[index].Cells["REST"].Value;
            if (e.ColumnIndex == 0)//delet
            {
                DialogResult result = MessageBox.Show("Etes-vous sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var purchase = Program.provetex.purchases.Find(id);
                    Program.provetex.purchases.Remove(purchase);
                    Program.provetex.SaveChanges();
                    List_purchas();
                }
            }
            else if (e.ColumnIndex == 1)//add bon
            {
                if (rest != 0)
                {
                    Program.AddBon = true;
                    Program.id_achat = id;
                    Form form = new Purchase.F_CU();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("cant add bon");
                }
            }
            else
            {

            }
        }

        private void Textbox_searsh_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_searsh.Text == "")
                List_purchas();
            else
            {
                string text = Textbox_searsh.Text;
                DataGrid_list.DataSource = (from purchase in Program.provetex.purchases
                                            join supplier_item in Program.provetex.suppliers_items
                                            on purchase.C_suppliers_items equals supplier_item.C_id_suppliers_items
                                            where supplier_item.supplier.C_name_supplier.Contains(text) || supplier_item.item.C_name_item.Contains(text)
                                            select new
                                            {
                                                ID = purchase.C_id_purchase,
                                                FOURNISSEUR = supplier_item.supplier.C_name_supplier,
                                                ARTICLE = supplier_item.item.C_name_item,
                                                PRIX = supplier_item.C_price,
                                                QTT = purchase.C_quantity,
                                                TOTAL = purchase.C_quantity * supplier_item.C_price,
                                                PAID = purchase.C_paid,
                                                REST = purchase.C_rest,
                                                DATE=purchase.created_at
                                            }).ToList();
            }
        }
    }
}
