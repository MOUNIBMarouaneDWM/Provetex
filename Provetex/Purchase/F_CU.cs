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
        private void CreateFromPannier(int id_supplier, int id_item)
        {

        }
        private void UpdateMode(int id_purchase)
        {
            int id_item_selected = Program.id_sup_item.Value;
        }
        /// </methods>
        // Varibales
        private int? id_sup_item,bon_num;
        private decimal? prixHT, prixItem, prix_a_paid;
        

        private void F_CU_Load(object sender, EventArgs e)
        {
            radioButton_chique.Checked = true;
            panel_tva.Visible = false;
            label_total.Text = "";
            label_ht.Text = "";
            if (Program.pannier)
            {
                if (Program.id_sup_item != null)
                {
                    panel1.Enabled = true;
                    var supItem = Program.provetex.suppliers_items.Find(Program.id_sup_item);
                    label_item.Text = supItem.item.C_name_item;
                    label_sup.Text = supItem.supplier.C_name_supplier;
                    id_sup_item = supItem.C_id_suppliers_items;
                    label_unite.Text = supItem.C_unite;
                    prixItem = supItem.C_price;
                }
            }
            else if (Program.AddBon)
            {
                panel1.Enabled = false;
                var achat = Program.provetex.purchases.Find(Program.id_achat.Value);
                bon_num = (from i in Program.provetex.bons
                            where i.C_purchase == achat.C_id_purchase
                            select i).Count();
                bon_num += 1;
                label_sup.Text = achat.suppliers_items.supplier.C_name_supplier;
                label_item.Text = achat.suppliers_items.item.C_name_item;
                num_qtt.Text = achat.C_quantity.ToString();
                label_ht.Text = achat.C_prix_HT.ToString();
                label_total.Text = achat.C_prix_a_paid.ToString();
                label_bon_nm.Text = "BON "+ (bon_num);
            }
        }

        private void ComboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Program.pannier = false;
            Program.id_item_purchase = null;
            Program.id_suplier_purchase = null;
            this.Close();
        }

        private void CheckBox_tva_CheckedChanged(object sender, EventArgs e)
        {
            // [Montant HT] x (1 + ([Taux TVA] / 100))
            if (checkBox_tva.Checked)
                panel_tva.Visible = true;
            else
                panel_tva.Visible = false;
        }

        private void TextBox_tva_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_tva.Text.Equals(""))
            {
                decimal tva = decimal.Parse(textBox_tva.Text);
                prix_a_paid = prixHT * (1 + (tva / 100));
                label_total.Text = "" + prix_a_paid;
            }
            else
            {
                prix_a_paid = prixHT;
                label_total.Text = "" + prix_a_paid;
            }
        }



        private void Num_qtt_TextChanged(object sender, EventArgs e)
        {
            if (!Program.AddBon)
            {
                var supItem = Program.provetex.suppliers_items.Find(Program.id_sup_item);
                if (!num_qtt.Text.Equals(""))
                {
                    decimal qtt = decimal.Parse(num_qtt.Text);
                    prixHT = qtt * supItem.C_price;
                    label_ht.Text = "" + prixHT;
                    label_total.Text = "" + prixHT;
                    prix_a_paid = prixHT;
                }
                else
                {
                    label_total.Text = "";
                    label_ht.Text = "";
                }
            }


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
                panel_payement_chique.Visible = false;
                panel_payement_espece.Location = point;
            }

        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            string paymentType = "";

            if (Program.pannier)
            {
                decimal paid, rest;
                if (radioButton_chique.Checked)
                {
                    paymentType = "chique";
                    paid = decimal.Parse(Textbox_Pchiq.Text);
                    rest = prix_a_paid.Value - paid;

                    var purchase = new purchase
                    {
                        C_suppliers_items = id_sup_item.Value,
                        C_quantity = int.Parse(num_qtt.Text),
                        C_prix_HT = prixHT.Value,
                        C_prix_a_paid = prix_a_paid.Value,
                        C_paid = paid,
                        C_rest = rest,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.purchases.Add(purchase);
                    Program.provetex.SaveChanges();
                    var bon = new bon
                    {
                        C_serie_bon = int.Parse(Textbox_bonSerie.Text),
                        C_purchase = purchase.C_id_purchase,
                        C_numero_bon = 1,
                        C_payement_type = paymentType,
                        C_prix_bon = paid,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.bons.Add(bon);
                    Program.provetex.SaveChanges();
                    var chique = new chique
                    {
                        C_numero_chique = int.Parse(Textbox_numero_chiqu.Text),
                        C_bon = bon.C_numero_bon,
                        C_prix_chique = paid,
                        C_date_chique = Datepicker_date_chique.Value

                    };
                    Program.provetex.chiques.Add(chique);
                    Program.provetex.SaveChanges();
                    this.Hide();
                }
                else
                {
                    paymentType = "Especs";
                    paid = decimal.Parse(Textbox_PEsp.Text);
                    rest = prix_a_paid.Value - paid;
                    var purchase = new purchase
                    {
                        C_suppliers_items = id_sup_item.Value,
                        C_quantity = int.Parse(num_qtt.Text),
                        C_prix_HT = prixHT.Value,
                        C_prix_a_paid = prix_a_paid.Value,
                        C_paid = paid,
                        C_rest = rest,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.purchases.Add(purchase);
                    Program.provetex.SaveChanges();
                    var bon = new bon
                    {
                        C_serie_bon = int.Parse(Textbox_bonSerie.Text),
                        C_purchase = purchase.C_id_purchase,
                        C_numero_bon = 1,
                        C_payement_type = paymentType,
                        C_prix_bon = paid,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.bons.Add(bon);
                    Program.provetex.SaveChanges();
                }
                Program.pannier = false;
            }
            else if (Program.AddBon)
            {
                var achat = Program.provetex.purchases.Find(Program.id_achat.Value);
                decimal paid, rest;
                if (radioButton_chique.Checked)
                {
                    paymentType = "chique";
                    paid = decimal.Parse(Textbox_Pchiq.Text);
                    rest = achat.C_rest.Value - paid;
                    achat.C_rest = rest;

                    var bon = new bon
                    {
                        C_serie_bon = int.Parse(Textbox_bonSerie.Text),
                        C_purchase = achat.C_id_purchase,
                        C_numero_bon = bon_num,
                        C_payement_type = paymentType,
                        C_prix_bon = paid,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.bons.Add(bon);
                    Program.provetex.SaveChanges();
                    var chique = new chique
                    {
                        C_numero_chique = int.Parse(Textbox_numero_chiqu.Text),
                        C_bon = bon.C_numero_bon,
                        C_prix_chique = paid,
                        C_date_chique = Datepicker_date_chique.Value

                    };
                    Program.provetex.chiques.Add(chique);
                    Program.provetex.SaveChanges();
                    this.Hide();
                }
                else
                {
                    paymentType = "Especs";
                    paid = decimal.Parse(Textbox_PEsp.Text);
                    rest = achat.C_rest.Value - paid;

                    achat.C_rest = rest;
                    var bon = new bon
                    {
                        C_serie_bon = int.Parse(Textbox_bonSerie.Text),
                        C_purchase = achat.C_id_purchase,
                        C_numero_bon = bon_num,
                        C_payement_type = paymentType,
                        C_prix_bon = paid,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.bons.Add(bon);
                    Program.provetex.SaveChanges();
                    this.Hide();
                }
            }
        }
    }
}

//id_item = int.Parse(comboBox_item.SelectedValue.ToString());
//id_sup = int.Parse(comboBox_sup.SelectedValue.ToString());
//IQueryable<int> id_sup_item = from i in Program.provetex.suppliers_items
//                              where i.C_item == id_item && i.C_supplier == id_sup
//                              select i.C_id_suppliers_items;
//var sup_item = Program.provetex.suppliers_items.Find(id_sup_item.FirstOrDefault());
//total = int.Parse(num_qtt.Value.ToString()) * sup_item.C_price;

//label_totale.Text = "" + total;

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

//comboBox_sup.Enabled = true;
//int item = int.Parse(comboBox_item.SelectedValue.ToString());
//comboBox_sup.DataSource = Program.ExecuterSelection(@"select _name_supplier,_id_supplier
//from supplier
//where _id_supplier in (select _supplier
//from suppliers_items
//where _item=" + item + ")");
//comboBox_sup.ValueMember = "_id_supplier";
//comboBox_sup.DisplayMember = "_name_supplier";

//comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
//                                                           from item
//                                                           where item._id_item in (select _item
//                                                           from suppliers_items
//                                                           where _item=" + id_item + ")");
//comboBox_item.ValueMember = "_id_item";
//comboBox_item.DisplayMember = "_name_item";
//comboBox_sup.DataSource = Program.ExecuterSelection(@"select _id_supplier,_name_supplier
//                                                        from supplier
//                                                        where supplier._id_supplier in(select _supplier
//                                                        from suppliers_items
//                                                        where _supplier=" + id_sup + ")");
//comboBox_sup.ValueMember = "_id_supplier";
//comboBox_sup.DisplayMember = "_name_supplier";
//comboBox_item.Enabled = false;
//comboBox_sup.Enabled = false;

//private void CreateMode()
//{
//    comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
//                                                                from item
//                                                                where item._id_item in (select _item
//                                                                from suppliers_items)");
//    comboBox_item.ValueMember = "_id_item";
//    comboBox_item.DisplayMember = "_name_item";
//    comboBox_item.Enabled = true;
//}

//private void Custumaz()
//{
//    int? id_sup_item = Program.id_sup_item;
//    int? id_article = Program.id_item_purchase;
//    int? id_suplier = Program.id_suplier_purchase;

//    if (!Program.pannier)
//    {
//        //comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
//        //                                                        from item
//        //                                                        where item._id_item in (select _item
//        //                                                        from suppliers_items)");
//        //comboBox_item.ValueMember = "_id_item";
//        //comboBox_item.DisplayMember = "_name_item";
//        //comboBox_item.Enabled = true;
//    }
//    else
//    {
//        //comboBox_item.DataSource = Program.ExecuterSelection(@"select _id_item,_name_item
//        //                                                       from item
//        //                                                       where item._id_item in (select _item
//        //                                                       from suppliers_items
//        //                                                       where _item=" + id_article + ")");
//        //comboBox_item.ValueMember = "_id_item";
//        //comboBox_item.DisplayMember = "_name_item";
//        //comboBox_sup.DataSource = Program.ExecuterSelection(@"select _id_supplier,_name_supplier
//        //                                                    from supplier
//        //                                                    where supplier._id_supplier in(select _supplier
//        //                                                    from suppliers_items
//        //                                                    where _supplier=" + id_suplier + ")");
//        //comboBox_sup.ValueMember = "_id_supplier";
//        //comboBox_sup.DisplayMember = "_name_supplier";
//        //comboBox_item.Enabled = false;
//        //comboBox_sup.Enabled = false;
//    }
//}