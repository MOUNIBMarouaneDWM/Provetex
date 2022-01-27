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
    public partial class F_CU : Form
    {
        public F_CU()
        {
            InitializeComponent();
        }
        //methods
        //
        private void Register()
        {
            try
            {
                var supplier = new supplier
                {
                    C_name_supplier = Textbox_name.Text,
                    C_phone_supplier = Textbox_phone.Text,
                    C_email_supplier = Textbox_email.Text,
                    C_adress_supplier = Textbox_adrs.Text,
                    created_at = DateTime.Today,
                    updated_at = DateTime.Today
                };
                Program.provetex.suppliers.Add(supplier);
                Program.provetex.SaveChanges();
                MessageBox.Show("added seccese");
                Textbox_name.Text = Textbox_adrs.Text=Textbox_phone.Text=Textbox_email.Text="";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private new void Update()
        {
            var supplier = Program.provetex.suppliers.Find(Program.id_supplier);
            supplier.C_name_supplier = Textbox_name.Text;
            supplier.C_adress_supplier = Textbox_adrs.Text;
            supplier.C_email_supplier = Textbox_email.Text;
            supplier.C_phone_supplier = Textbox_phone.Text;
            supplier.updated_at = DateTime.Today;
            Program.provetex.SaveChanges();
            Program.updateSupplier = false;
            this.Close();
        }
        //
        private void F_CU_Load(object sender, EventArgs e)
        {
            if (Program.updateSupplier == false)
                Button_save.ButtonText = "save";
            else
            {
                Button_save.ButtonText = "Update";
                var supplier = Program.provetex.suppliers.Find(Program.id_supplier);
                Textbox_name.Text = supplier.C_name_supplier;
                Textbox_adrs.Text = supplier.C_adress_supplier;
                Textbox_phone.Text = supplier.C_phone_supplier;
                Textbox_email.Text = supplier.C_email_supplier;
                
            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Program.updateSupplier = false;
            this.Close();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            if (Button_save.ButtonText.ToLower() == "save")
                Register();
            else
                Update();

        }

    }
}
