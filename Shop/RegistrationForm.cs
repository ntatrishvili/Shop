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
    public partial class RegistrationForm : Form
    {
        User user = new User();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                user = new User(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxPassword.Text, new Address());
                bool registered = Procedures.RegisterUser(user);
                if (registered)
                {
                    MessageBox.Show("User Registered Successfully");
                    this.Hide();
                    LogInForm form1 = new LogInForm();
                    form1.Show();
                }
            }
        }

        private bool IsValid()
        {
            string errorText = "";
            if (textBoxName.Text == String.Empty || textBoxSurname.Text == String.Empty
                || textBoxEmail.Text == String.Empty || textBoxRepeatEmail.Text == String.Empty
                || textBoxPassword.Text == String.Empty || textBoxRepeatPassword.Text == String.Empty
                || textBoxCountry.Text == String.Empty || textBoxCity.Text == String.Empty
                || textBoxStreet.Text == String.Empty || textBoxHouse.Text == String.Empty
                || textBoxPostalCode.Text == String.Empty || textBoxPhone.Text == String.Empty)
                errorText += "Please fill in all the required fields!\n";
            if (textBoxEmail.Text != textBoxRepeatEmail.Text)
                errorText += "Your emails must match!\n";
            if (textBoxPassword.Text.Length < 8)
                errorText += "Password must be at least 8 characters!\n";
            else if (textBoxPassword.Text != textBoxRepeatPassword.Text)
                errorText += "Your passwords must match!";
            if (errorText.Length > 0)
            {
                MessageBox.Show(errorText);
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxShow_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
                textBoxPassword.PasswordChar = '*';
            else
                textBoxPassword.PasswordChar = '\0';
        }

        private void checkBoxShowRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
                textBoxRepeatPassword.PasswordChar = '*';
            else
                textBoxRepeatPassword.PasswordChar = '\0';
        }
    }
}
