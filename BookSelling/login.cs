using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSelling
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        BookSellingContext db = new BookSellingContext();
        private Form1 frm1;

        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach(var user in db.Employee)
            {
                if(user.Email.Replace(" "," ")==txt_email.Text&& user.Password.Replace(" ", " ") == txt_pass.Text)
                {
                    MessageBox.Show("Login Successful", "Login");
                    frm1 = new Form1();
                    frm1.ShowDialog();
                }
            }
        }
    }
}
