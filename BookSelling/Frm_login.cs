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
    public partial class Frm_login : Form
    {
        BookSellingContext db;
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();
        public Frm_login()
        {
            InitializeComponent();
            db = new BookSellingContext();
        }
        private Form1 frm1;
      /*  private void btn_login_Click(object sender, EventArgs e)
        {
            string usern = txt_usern.Text;
            string pass = txt_passw.Text;
            try
            {
                emp1 = db.Employee.First(u => u.FirstName == usern);
                emp2 = db.Employee.First(p => p.Password == pass);
                if (emp1.FirstName == usern && emp2.Password == pass)
                {
                    frm1 = new Form1();
                    frm1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("invalid mail or password");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            string usern = txt_usern.Text;
            string pass = txt_passw.Text;
            try
            {
                emp1 = db.Employee.First(u => u.FirstName == usern);
                emp2 = db.Employee.First(p => p.Password == pass);
                if (emp1.FirstName == usern && emp2.Password == pass)
                {
                    frm1 = new Form1();
                    frm1.ShowDialog();

                }
                else
                {
                    MessageBox.Show("invalid mail or password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
