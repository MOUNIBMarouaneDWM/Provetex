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
        private void Custumaz()
        {
            int? id_sup_item = Program.id_sup_item;
            int? id_article = Program.id_item_purchase;
            int? id_suplier = Program.id_suplier_purchase;

            if (!Program.pannier)
            {
                comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
                                                                        from item
                                                                        where item._id_item in (select _item
                                                                        from suppliers_items)");
                comboBox_item.ValueMember = "_id_item";
                comboBox_item.DisplayMember = "_name_item";
                comboBox_item.Enabled = true;
            }
            else
            {
                comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
                                                                       from item
                                                                       where item._id_item in (select _item
                                                                       from suppliers_items
                                                                       where _item=" + id_article + ")");
                comboBox_item.ValueMember = "_id_item";
                comboBox_item.DisplayMember = "_name_item";
                comboBox_sup.DataSource = Program.ExecuterSelection(@"select _id_supplier,_name_supplier
                                                                    from supplier
                                                                    where supplier._id_supplier in(select _supplier
                                                                    from suppliers_items
                                                                    where _supplier=" + id_suplier + ")");
                comboBox_sup.ValueMember = "_id_supplier";
                comboBox_sup.DisplayMember = "_name_supplier";
                comboBox_item.Enabled = false;
                comboBox_sup.Enabled = false;
            }

        }

        private void Create()
        {
            comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
                                                                        from item
                                                                        where item._id_item in (select _item
                                                                        from suppliers_items)");
            comboBox_item.ValueMember = "_id_item";
            comboBox_item.DisplayMember = "_name_item";
            comboBox_item.Enabled = true;
        }
        private void CreateFromPannier(int id_supplier, int id_item)
        {
            comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
                                                                       from item
                                                                       where item._id_item in (select _item
                                                                       from suppliers_items
                                                                       where _item=" + id_item + ")");
            comboBox_item.ValueMember = "_id_item";
            comboBox_item.DisplayMember = "_name_item";
            comboBox_sup.DataSource = Program.ExecuterSelection(@"select _id_supplier,_name_supplier
                                                                    from supplier
                                                                    where supplier._id_supplier in(select _supplier
                                                                    from suppliers_items
                                                                    where _supplier=" + id_sup + ")");
            comboBox_sup.ValueMember = "_id_supplier";
            comboBox_sup.DisplayMember = "_name_supplier";
            comboBox_item.Enabled = false;
            comboBox_sup.Enabled = false;
        } 
        private void UpdateMode(int id_purchase)
        {

        }
        /// </methods>

        private void F_CU_Load(object sender, EventArgs e)
        {
            radioButton_chique.Checked = true;
        }

        private void ComboBox_item_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Button_back_Click(object sender, EventArgs e)
        {
            Program.pannier = false;
            Program.id_item_purchase = null;
            Program.id_suplier_purchase = null;
            this.Close();
        }

        private void Num_qtt_ValueChanged(object sender, EventArgs e)
        {
            id_item = int.Parse(comboBox_item.SelectedValue.ToString());
            id_sup = int.Parse(comboBox_sup.SelectedValue.ToString());
            IQueryable<int> id_sup_item = from i in Program.provetex.suppliers_items
                                          where i.C_item == id_item && i.C_supplier == id_sup
                                          select i.C_id_suppliers_items;
            var sup_item = Program.provetex.suppliers_items.Find(id_sup_item.FirstOrDefault());
            total = int.Parse(num_qtt.Value.ToString()) * sup_item.C_price;

            //label_totale.Text = "" + total;
        }



        private void CheckBox_tva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tva.Checked)
                panel_tva.Visible = true;
            else
                panel_tva.Visible = false;
        }

        private void RadioButton_chique_CheckedChanged(object sender, EventArgs e)
        {
            Point point = new Point(60, 85);
            if (radioButton_chique.Checked)
            {
                panel_payement_espece.Visible = false;
                panel_payement_chique.Visible = true;
            }
            else
            {
               panel_payement_espece.Visible = true;
                panel_payement_chique.Visible = true;
            }
            
        }


        private void Button_save_Click(object sender, EventArgs e)
        {
            if (Program.FirstPurchase)
            {

            }
            //id_item =int.Parse(comboBox_item.SelectedValue.ToString());
            //id_sup = int.Parse(comboBox_sup.SelectedValue.ToString());
            //IQueryable<int> id_sup_item = from i in Program.provetex.suppliers_items
            //                              where i.C_item == id_item && i.C_supplier == id_sup
            //                              select i.C_id_suppliers_items;
            //var sup_item = Program.provetex.suppliers_items.Find(id_sup_item.FirstOrDefault());
            //decimal rest;
            //decimal paid;
            //decimal prix_item=sup_item.C_price;
            // total = int.Parse(num_qtt.Value.ToString()) * prix_item;
            //if (checkBox_tva.Checked == false)
            //{
            //    //paid = int.Parse(Textbox_pricePaid.Text);
            //    //rest = total - paid;
            //}
            //else
            //{
            //    paid = total;
            //    rest = 0;
            //}
            //try
            //{
            //purchase purchase = new purchase {
            //    C_suppliers_items = id_sup_item.FirstOrDefault(),
            //    C_quantity = int.Parse(num_qtt.Value.ToString()),
            //    C_paid = paid,
            //    C_rest = rest,
            //    created_at = DateTime.Now,
            //    update_at = DateTime.Now
            //};
            //Program.provetex.purchases.Add(purchase);
            //Program.provetex.SaveChanges();
            //MessageBox.Show("achat ajouter avec succe");
            //this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter an avalible iformation(s)");
            //}
        }
    }
}
