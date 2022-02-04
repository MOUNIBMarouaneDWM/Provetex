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
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
        }

        //Methods
        //login
        private void Login()
        {
            var User = (from i in Program.provetex.Users
                        where i.C_user_name == Textbox_User.Text && i.C_password == Textbox_Password.Text
                        select i).ToList();
            if (User.Count != 0)
            {
                Form form = new Dashboard();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("the user name or the password incorect");
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            picture_hide.Visible = false;
            Button_login.Visible = false;

        }

        private void Icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button_login_Click(object sender, EventArgs e) => Login();

        private void LinkLabel_forgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Auth.F_forgot_password();
            form.Show();
            this.Hide();
        }

        private void Picture_show_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_show, picture_hide);

            if (Textbox_Password.Text != "")
                Textbox_Password.isPassword = false;
        }

        private void Picture_hide_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_hide, picture_show);

            if (Textbox_Password.Text != "")
                Textbox_Password.isPassword = true;
        }

        private void Textbox_Password_OnValueChanged(object sender, EventArgs e)
        {
            if (picture_hide.Visible)
                Textbox_Password.isPassword = false;
            else
                Textbox_Password.isPassword = true;
            if (Textbox_Password.Text != "" && Textbox_User.Text != "")
                Button_login.Visible = true;
            else
                Button_login.Visible = false;
        }

        private void Textbox_User_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox_Password.Text != "" && Textbox_User.Text != "")
                Button_login.Visible = true;
            else
                Button_login.Visible = false;
        }


    }
}
