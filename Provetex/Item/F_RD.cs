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

        private void Button_add_Click(object sender, EventArgs e)
        {
            
        }

        private void F_RD_Load(object sender, EventArgs e)
        {
            Refresh();
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
                    var fourniss = Program.provetex.suppliers_items.Find(id);
                    Program.provetex.suppliers_items.Remove(fourniss);
                    Program.provetex.SaveChanges();
                    Refresh();
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

                //Program.updateItem = true;
                //Program.id_sup_item = id;
                //Program.updateItem = true;
                //if (Application.OpenForms.OfType<Item.frm_create>().Any())
                //    MessageBox.Show("Form is opened");
                //else
                //{
                //    Form form = new Item.frm_create();
                //    form.TopMost = true;
                //    form.Show();
                //}

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
            }).ToList();
            DataGrid_list.Columns["ID"].Visible = false;
            DataGrid_list.Columns["ID_articl"].Visible = false;
            DataGrid_list.Columns["ID_suplier"].Visible = false;

        }
    }
}
