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
    public partial class F_register : Form
    {
        public F_register()
        {
            InitializeComponent();
        }

        private void F_register_Load(object sender, EventArgs e)
        {

        }
        //Methods
        private void Costumize()
        {
            picture_hide.Visible = false;
            picture_hide2.Visible = false;
        }
        //check if the textbox is ampty
        private bool CheckInputsIsAmpty()
        {
            bool Chek_name;
            bool Chek_user;
            bool Chek_password;
            bool Chek_confirmed;
            bool Chek_answer;
            string name = Textbox_Name.Text;
            string user = Textbox_User.Text;
            string password = Textbox_Password.Text;
            string confirmed = Textbox_confirmed.Text;
            string answer = Textbox_answer.Text;
            if (name == "" || user == "" || password == "" || confirmed == "" || answer == "")
            {
                if (name != "")
                    Chek_name = false;
                else
                    Chek_name = true;

                if (user != "")
                    Chek_user = false;
                else
                    Chek_user = true;

                if (password != "")
                    Chek_password = false;
                else
                    Chek_password = true;

                if (confirmed != "")
                    Chek_confirmed = false;
                else
                    Chek_confirmed = true;

                if (answer != "")
                    Chek_answer = false;
                else
                    Chek_answer = true;
                return Chek_name || Chek_user || Chek_password || Chek_confirmed || Chek_answer;
            }
            return false;


        }
        //check the password and the confirme password are the same or not
        private bool Isthesame(string text1, string text2)
        {
            if (text1 == text2)
                return true;
            else
                return false;
        }
        //register
        private void Register(string name, string userName, string password, DateTime FavoritDate, string question, string answer)
        {
            try
            {
                var user = new User
                {
                    C_nom = name,
                    C_user_name = userName,
                    C_password = password,
                    C_favorite_date = FavoritDate,
                    C_question = question,
                    C_repence = answer
                };
                Program.provetex.Users.Add(user);
                Program.provetex.SaveChanges();
                MessageBox.Show("the register secess");

                //Program.entities.Client.Add(cl);
                //Program.entities.SaveChanges();
                Form form = new Auth.F_login();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void F_Register_Load(object sender, EventArgs e) => Costumize();

        private void Icon_close_Click(object sender, EventArgs e) => Application.Exit();

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (!CheckInputsIsAmpty())
            {
                if (Isthesame(Textbox_Password.Text, Textbox_confirmed.Text))
                {
                    Register(Textbox_Name.Text, Textbox_User.Text, Textbox_Password.Text, Datepicker_favoritDate.Value, Dropdown_question.selectedValue, Textbox_answer.Text);
                }
                else
                {
                    MessageBox.Show("Please Check the password and the confirme password");
                }
            }
            else
                MessageBox.Show("You need to complite the information");
        }

        private void Picture_hide2_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_hide2, picture_show2);
            if (Textbox_confirmed.Text != "")
                Textbox_confirmed.isPassword = true;
        }

        private void Picture_show2_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_show2, picture_hide2);
            if (Textbox_confirmed.Text != "")
                Textbox_confirmed.isPassword = false;
        }

        private void Picture_hide_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_hide, picture_show);
            if (Textbox_Password.Text != "")
                Textbox_Password.isPassword = true;
        }

        private void Picture_show_Click(object sender, EventArgs e)
        {
            Program.ShowOrHide(picture_show, picture_hide);
            if (Textbox_Password.Text != "")
                Textbox_Password.isPassword = false;
        }

        private void Textbox_Password_OnValueChanged(object sender, EventArgs e)
        {
            if (picture_hide.Visible)
                Textbox_Password.isPassword = false;
            else
                Textbox_Password.isPassword = true;
        }

        private void Textbox_confirmed_OnValueChanged(object sender, EventArgs e)
        {
            if (picture_hide2.Visible)
                Textbox_confirmed.isPassword = false;
            else
                Textbox_confirmed.isPassword = true;
        }

        private void Textbox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Textbox_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Textbox_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
