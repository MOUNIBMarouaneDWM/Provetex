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
    public partial class F_CU : Form
    {
        public F_CU()
        {
            InitializeComponent();
        }
        /// <methods>
        private int id_sup, id_item;
        decimal total;
        private void custumaz()
        {
            //var supplier = (from sup_item in Program.provetex.suppliers_items
            //                where sup_item.C_supplier in(from sup in Program.provetex.suppliers
            //                                             select sup.C_id_supplier)ToList()
            //                           select new
            //                           {
            //                               name = sup.C_name_supplier,
            //                               id = sup.C_id_supplier
            //                           }).ToList();
            //comboBox_sup.DataSource = Program.ExecuterSelection(@"select s._id_supplier,s._name_supplier from supplier s 
            //                                                        where s._id_supplier in (select _supplier
            //                                                        from suppliers_items)");

            //comboBox_sup.ValueMember = "_id_supplier";
            //comboBox_sup.DisplayMember = "_name_supplier";
            comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
                                                                    from item
                                                                    where item._id_item in (select _item
                                                                    from suppliers_items)");
            comboBox_item.ValueMember = "_id_item";
            comboBox_item.DisplayMember = "_name_item";

        }
        /// </methods>

        private void F_CU_Load(object sender, EventArgs e)
        {
            custumaz();
        }

        private void comboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                comboBox_sup.Enabled = true;
                int item = int.Parse(comboBox_item.SelectedValue.ToString());
                comboBox_sup.DataSource = Program.ExecuterSelection(@"select _name_supplier,_id_supplier
                from supplier
                where _id_supplier in (select _supplier
                from suppliers_items
                where _item=" + item + ")");
                comboBox_sup.ValueMember = "_id_supplier";
                comboBox_sup.DisplayMember = "_name_supplier";
            }
            catch
            {
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Textbox_pricePaid.Text = "";
                Textbox_pricePaid.Enabled = false;
            }
            else
            {
                Textbox_pricePaid.Text = "";
                Textbox_pricePaid.Enabled = true;

            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num_qtt_ValueChanged(object sender, EventArgs e)
        {
            id_item = int.Parse(comboBox_item.SelectedValue.ToString());
            id_sup = int.Parse(comboBox_sup.SelectedValue.ToString());
            IQueryable<int> id_sup_item = from i in Program.provetex.suppliers_items
                                          where i.C_item == id_item && i.C_supplier == id_sup
                                          select i.C_id_suppliers_items;
            var sup_item = Program.provetex.suppliers_items.Find(id_sup_item.FirstOrDefault());
            total = int.Parse(num_qtt.Value.ToString()) * sup_item.C_price;

            label_totale.Text = "" + total;
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            id_item =int.Parse(comboBox_item.SelectedValue.ToString());
            id_sup = int.Parse(comboBox_sup.SelectedValue.ToString());
            IQueryable<int> id_sup_item = from i in Program.provetex.suppliers_items
                                          where i.C_item == id_item && i.C_supplier == id_sup
                                          select i.C_id_suppliers_items;
            var sup_item = Program.provetex.suppliers_items.Find(id_sup_item.FirstOrDefault());
            decimal rest;
            decimal paid;
            decimal prix_item=sup_item.C_price;
             total = int.Parse(num_qtt.Value.ToString()) * prix_item;
            if (checkBox1.Checked == false)
            {
                paid = int.Parse(Textbox_pricePaid.Text);
                rest = total - paid;
            }
            else
            {
                paid = total;
                rest = 0;
            }
            purchase purchase = new purchase {
                C_suppliers_items = id_sup_item.FirstOrDefault(),
                C_quantity = int.Parse(num_qtt.Value.ToString()),
                C_paid = paid,
                C_rest = rest,
                created_at = DateTime.Now,
                update_at = DateTime.Now
            };
            Program.provetex.purchases.Add(purchase);
            Program.provetex.SaveChanges();
            MessageBox.Show("achat ajouter avec succe");

        }
    }
}
