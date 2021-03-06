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
    public partial class F_Chiques : Form
    {
        public F_Chiques()
        {
            InitializeComponent();
        }
        private string state(DateTime date,DateTime sysdate)
        {
            string state = "";
            if (sysdate < date)
                state = "Not VALIDE";
            else
                state = "VALIDE";
            return state;
        }
        private void Actualiser()
        {
            DataGrid_list.DataSource = (from i in Program.provetex.chiques
                                        select new
                                        {
                                            NUMERO = i.C_numero_chique,
                                            FOURNISSEUR = i.bon.purchase.suppliers_items.supplier.C_name_supplier,
                                            PRIX = i.C_prix_chique,
                                            DATE = i.C_date_chique,
                                            STATE = state(i.C_date_chique.Value,DateTime.Today)
                                        }).ToList();
        }
        private void F_Chiques_Load(object sender, EventArgs e)
        {
            radioButton_num.Checked = true;
            Actualiser();
            //for (int i = 0; i < DataGrid_list.RowCount; i++)
            //{
            //    DateTime dateNOW = DateTime.Now;
            //    if(DateTime.Parse(DataGrid_list.Rows[i].Cells["DATE"].Value) < dateNOW)
            //    {

            //    }
            //}

        }



        private void Textbox_searsh_OnValueChanged(object sender, EventArgs e)
        {
            string text = Textbox_searsh.Text;
            if (radioButton_num.Checked)
            {
                if (text != "")
                {
                    try
                    {

                    int num = int.Parse(text);
                    DataGrid_list.DataSource = (from i in Program.provetex.chiques
                                                where i.C_numero_chique.Equals(num)
                                                select new
                                                {
                                                    NUMERO = i.C_numero_chique,
                                                    FOURNISSEUR = i.bon.purchase.suppliers_items.supplier.C_name_supplier,
                                                    PRIX = i.C_prix_chique,
                                                    DATE = i.C_date_chique,
                                                    STATE = state(i.C_date_chique.Value, DateTime.Today)
                                                }).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("this number is very long");
                        Textbox_searsh.Text = "";
                    }
                }
                else
                    Actualiser();
            }
            else if (radioButton_sup.Checked)
            {
                if (text != "")
                {
                    DataGrid_list.DataSource = (from i in Program.provetex.chiques
                                                where i.bon.purchase.suppliers_items.supplier.C_name_supplier.Contains(text)
                                                select new
                                                {
                                                    NUMERO = i.C_numero_chique,
                                                    FOURNISSEUR = i.bon.purchase.suppliers_items.supplier.C_name_supplier,
                                                    PRIX = i.C_prix_chique,
                                                    DATE = i.C_date_chique,
                                                    STATE = state(i.C_date_chique.Value, DateTime.Today)
                                                }).ToList();
                }
                else
                    Actualiser();
            }

        }

        private void Textbox_searsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton_num.Checked)
            {
                if (e.KeyChar == 46 && Textbox_searsh.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == 46 && Textbox_searsh.Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                    return;
                }
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
