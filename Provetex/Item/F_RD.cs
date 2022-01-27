using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Item
{
    public partial class F_RD : Form
    {
        public F_RD()
        {
            InitializeComponent();
        }

        private void Form_load()
        {
            panel_choise.Visible = true;
            radioButton_notNew.Checked = true;
            Dropdown_list_article.Visible = true;
            Textbox_artcle.Visible = false;
        }

        private void F_RD_Load(object sender, EventArgs e)
        {
            Refresh();
            panel_form.Visible = false;
            Button_add.Visible = true;
            Dropdown_list_article.DataSource = (from i in Program.provetex.items
                                                select i).ToList();
            Dropdown_list_article.DisplayMember = "C_name_item";
            Dropdown_list_article.ValueMember = "C_id_item";
            comboBox_sup.DataSource = (from i in Program.provetex.suppliers
                                       select i ).ToList(); ;
            comboBox_sup.DisplayMember = "C_name_supplier";
            comboBox_sup.ValueMember = "C_id_supplier";

        }

        private void DataGrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)DataGrid_list.Rows[index].Cells["ID"].Value;
            int suplier = (int)DataGrid_list.Rows[index].Cells["ID_suplier"].Value;
            int articl=(int)DataGrid_list.Rows[index].Cells["ID_articl"].Value;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Etes-vous sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                    var fourniss = Program.provetex.suppliers_items.Find(id);
                    Program.provetex.suppliers_items.Remove(fourniss);
                    Program.provetex.SaveChanges();
                    Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("You cant delete this line");
                    }
                }

            }
            else if (e.ColumnIndex == 1)
            {
                Program.id_sup_item = id;
                Program.id_item_purchase = articl;
                Program.id_suplier_purchase = suplier;
                Program.pannier = true;
                Form form = new Purchase.F_CU();
                form.Show();


            }
        }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        private void Refresh()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {

            DataGrid_list.DataSource = Program.provetex.suppliers_items.Select(item => new
            {
                ID = item.C_id_suppliers_items,
                ID_articl=item.C_item,
                ID_suplier=item.C_supplier,
                Article = item.item.C_name_item,
                Fournisseur = item.supplier.C_name_supplier,
                Prix = item.C_price
            }).OrderBy(c=>c.Prix).ToList();
            DataGrid_list.Columns["ID"].Visible = false;
            DataGrid_list.Columns["ID_articl"].Visible = false;
            DataGrid_list.Columns["ID_suplier"].Visible = false;

        }

        private void Textbox_searsh_OnValueChanged(object sender, EventArgs e)
        {
            string text = Textbox_searsh.Text;
            DataGrid_list.DataSource = Program.provetex.suppliers_items.Where(c => c.item.C_name_item.Contains(text) || c.supplier.C_name_supplier.Contains(text) ).Select(item => new
            {
                ID = item.C_id_suppliers_items,
                ID_articl = item.C_item,
                ID_suplier = item.C_supplier,
                Article = item.item.C_name_item,
                Fournisseur = item.supplier.C_name_supplier,
                Prix = item.C_price
            }).OrderBy(c => c.Prix).ToList();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            panel_form.Visible = true;
            Form_load();
            Button_add.Visible = false;
            Button_save.ButtonText = "Enregistrer";
        }

        Point point = new Point(36, 58);

        private void radioButton_notNew_CheckedChanged(object sender, EventArgs e)
        {
            Textbox_artcle.Visible = false;
            Dropdown_list_article.Visible = true;
        }

        private void radioButton_new_CheckedChanged(object sender, EventArgs e)
        {
            Dropdown_list_article.Visible = false;
            Textbox_artcle.Visible = true;
            Textbox_artcle.Enabled = true;
            //Textbox_artcle.Location = point;
            Textbox_artcle.Text = "";
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            string action = Button_save.ButtonText;
            string sup = comboBox_sup.SelectedValue.ToString();
            int id_sup = int.Parse(sup);
            if (action.ToLower() == "enregistrer")
            {
                if (radioButton_new.Checked)
                {
                    string item_name = Textbox_artcle.Text;
                    decimal prix = decimal.Parse(Textbox_prix.Text);
                    if (item_name != "" && Textbox_prix.Text != "")
                    {
                        //add item in  items
                        var item = new item
                        {
                            C_name_item = item_name
                        };
                        Program.provetex.items.Add(item);
                        Program.provetex.SaveChanges();
                        //add item in supitem
                        var id = (from i in Program.provetex.items
                                  where i.C_name_item == item_name
                                  select new
                                  {
                                      i.C_id_item
                                  }).Single();
                        var item_sup = new suppliers_items
                        {
                            C_supplier = id_sup,
                            C_item = id.C_id_item,
                            C_unite = comboBox_unite.selectedValue,
                            C_price = prix,
                            created_at = DateTime.Now,
                            updated_at = DateTime.Now
                        };
                        Program.provetex.suppliers_items.Add(item_sup);
                        Program.provetex.SaveChanges();
                        MessageBox.Show("seccess");
                    }
                    else
                        MessageBox.Show("remplir les chom");
                }
                else if (radioButton_notNew.Checked)
                {
                    string item = Dropdown_list_article.SelectedValue.ToString();
                    int iditem = int.Parse(item);
                    decimal prix = decimal.Parse(Textbox_prix.Text);
                    var item_sup = new suppliers_items
                    {
                        C_supplier = id_sup,
                        C_item = iditem,
                        C_unite = comboBox_unite.selectedValue,
                        C_price = prix,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    Program.provetex.suppliers_items.Add(item_sup);
                    Program.provetex.SaveChanges();
                    MessageBox.Show("seccess");
                }
            }
            else
            {
                var item = Program.provetex.suppliers_items.Find(Program.id_sup_item);
                item.C_price = decimal.Parse(Textbox_prix.Text);
                item.updated_at = DateTime.Now;
                Program.provetex.SaveChanges();
                MessageBox.Show("update" + Program.id_sup_item.Value);
            }
            Button_add.Visible = true;
            Textbox_artcle.Text = Textbox_prix.Text = "";
            panel_form.Visible = false;
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Button_add.Visible = true;
            Textbox_artcle.Text = Textbox_prix.Text = "";
            panel_form.Visible = false;
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
