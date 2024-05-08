using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("Login success");
                MDI mdi = new MDI();
                mdi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login fail");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
