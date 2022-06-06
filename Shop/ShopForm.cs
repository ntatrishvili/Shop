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
    public partial class ShopForm : Form
    {
        private User user = new User();
        public ShopForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
