using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Supplier
{
    public partial class F_RD : Form
    {
        public F_RD()
        {
            InitializeComponent();
        }

        //Methods
        //
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        private void Refresh()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {

            DataGrid_list.DataSource = Program.provetex.suppliers.Select(sup => new
            {
                ID = sup.C_id_supplier,
                FOURNISSEUR = sup.C_name_supplier,
                ADRESSE = sup.C_adress_supplier,
                PHONE = sup.C_phone_supplier,
                EMAIL = sup.C_email_supplier,
                AJOUTER = sup.created_at,
                UPDATE = sup.updated_at
            }).ToList();
            DataGrid_list.Columns["ID"].Visible = false;

        }
        //
        private void F_RD_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Textbox_searsh_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_searsh.Text == "")
                Refresh();
            else
            {
                string text = Textbox_searsh.Text;
                DataGrid_list.DataSource = DataGrid_list.DataSource = (from sup in Program.provetex.suppliers
                                                                       where sup.C_name_supplier.Contains(text) || sup.C_adress_supplier.Contains(text) || sup.C_phone_supplier.Contains(text) || sup.C_email_supplier.Contains(text)
                                                                       select new
                                                                       {
                                                                           ID = sup.C_id_supplier,
                                                                           FOURNISSEUR = sup.C_name_supplier,
                                                                           ADRESSE = sup.C_adress_supplier,
                                                                           PHONE = sup.C_phone_supplier,
                                                                           EMAIL = sup.C_email_supplier,
                                                                           AJOUTER = sup.created_at,
                                                                           UPDATE = sup.updated_at
                                                                       }).ToList();
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Supplier.F_CU>().Any())
                MessageBox.Show("Form is opened");
            else
            {
                Form form = new Supplier.F_CU();
                form.TopMost = true;
                form.Show();
            }
        }

        private void DataGrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)DataGrid_list.Rows[index].Cells["ID"].Value;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Etes-vous sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var fourniss = Program.provetex.suppliers.Find(id);
                        Program.provetex.suppliers.Remove(fourniss);
                        Program.provetex.SaveChanges();
                        Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("Se fournisseur avais des achat,Vous pouvez pas le suprimer");
                    }

                }

            }
            else if (e.ColumnIndex == 1)
            {
                Program.updateSupplier = true;
                Program.id_supplier = id;
                Program.updateSupplier = true;
                if (Application.OpenForms.OfType<Supplier.F_CU>().Any())
                    MessageBox.Show("Form is opened");
                else
                {
                    Form form = new Supplier.F_CU();
                    form.TopMost = true;
                    form.Show();
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) => Refresh();

    }
}
