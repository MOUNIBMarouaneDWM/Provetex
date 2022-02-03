using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Auth
{
    public partial class F_forgot_password : Form
    {
        public F_forgot_password()
        {
            InitializeComponent();
        }

        private void F_forgot_password_Load(object sender, EventArgs e)
        {
            var user = (from i in Program.provetex.Users
                        select i).Single();
            label_question.Text = user.C_question;
        }

        Point point = new Point(380, 61);

        private void Button_confirme_Click(object sender, EventArgs e)
        {
            var user = (from i in Program.provetex.Users
                        select i).Single();
            if (user.C_favorite_date == Datepicker_favorit.Value && Textbox_answer.Text == user.C_repence)
            {
                Card_check.Visible = false;
                Card_check.Enabled = false;
                Card_reset_pass.Location = point;
                Card_reset_pass.Visible = true;
                Card_reset_pass.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wrong informations");
            }
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            if (Textbox_newPass.Text != "" && Textbox_confirme.Text != "" && Textbox_newPass.Text.Equals(Textbox_confirme.Text))
            {
                var user = (from i in Program.provetex.Users
                            select i).Single();
                user.C_password = Textbox_newPass.Text;
                Program.provetex.SaveChanges();
                MessageBox.Show("the password has been changed seccesfuly");
                Form form = new Auth.F_login();
                form.Show();
                this.Hide();
            }
        }

        private void Icon_back_Click(object sender, EventArgs e)
        {
            Form form = new Auth.F_login();
            form.Show();
            this.Hide();
        }

        private void Textbox_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Textbox_newPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_confirme_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

