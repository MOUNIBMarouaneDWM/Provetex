using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex
{
    public partial class Dashboard : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Dashboard()
        {
            InitializeComponent();
        }
        //
        //Methods
        //
        private void Costumize()
        {
            panel_submenu_fourni.Visible = false;
            panel_submenu_articles.Visible = false;
            panel_submenu_achat.Visible = false;
        }
        private void HideSubmenu()
        {
            if (panel_submenu_fourni.Visible)
                panel_submenu_fourni.Visible = false;
            if (panel_submenu_articles.Visible)
                panel_submenu_articles.Visible = false;
            if (panel_submenu_achat.Visible)
                panel_submenu_achat.Visible = false;
        }
        private void ShowSubmenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubmenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }
        public void Panelaffiche(object form_af)
        {

            int panelcont = this.panel_container.Controls.Count;
            if (panelcont > 0)
            {
                this.panel_container.Controls.RemoveAt(0);
            }
            Form fh = form_af as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_container.Controls.Add(fh);
            this.panel_container.Tag = fh;
            fh.Show();
        }
        //
        //
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Costumize();
        }
        private void panel_bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Fournisseur_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_submenu_fourni);
        }

        private void button_articles_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_submenu_articles);
        }

        private void button_achats_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_submenu_achat);
        }

        private void button_admin_Click(object sender, EventArgs e)
        {

        }

        private void button_add_fourni_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Supplier.F_CU>().Any())
            {
                Form form = new Supplier.F_CU();
                form.TopMost = true;
                form.Show();
            }

        }

        private void button_list_fourni_Click(object sender, EventArgs e)
        {
            Form form = new Supplier.F_RD();
            form.Owner = this;
            Panelaffiche(form);
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_details_fournis_Click(object sender, EventArgs e)
        {
            Form form = new Supplier.F_Details();
            Panelaffiche(form);
        }

        private void button_list_articles_Click(object sender, EventArgs e)
        {
            Form form = new Item.F_RD();
            Panelaffiche(form);
        }

        private void button_list_achat_Click(object sender, EventArgs e)
        {
            Form form = new Purchase.F_RD();
            Panelaffiche(form);
        }

        private void button_credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form is not ready for now !");
        }
    }
}
