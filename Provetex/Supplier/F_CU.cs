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
                    update_at = DateTime.Today

                };
                Program.provetex.suppliers.Add(supplier);
                Program.provetex.SaveChanges();
                MessageBox.Show("added seccese");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Update()
        {
            //update
        }

        //
        private void F_CU_Load(object sender, EventArgs e)
        {
            if (Program.updateSupplier == false)
                Button_save.ButtonText = "save";
            else
                Button_save.ButtonText = "uppdate";

        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            (this.Owner as Dashboard).Enabled = true;
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
