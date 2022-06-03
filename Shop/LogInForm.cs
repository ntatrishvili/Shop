using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class LogInForm: Form
    { 
        public LogInForm()
        {
            InitializeComponent();
        }
        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            User user = Procedures.LogIn(textBoxEmail.Text, textBoxPassword.Text);
            if (user.Id == -1)
                MessageBox.Show("Cound not log you in!\nPlease check your email and password!");
            else
            {
                ShopForm shopForm = new ShopForm(user);

            }
        }
    }
}
