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
    public partial class frm_cust_add : Form
    {
        private BookSellingContext db;
        public frm_cust_add()
        {
            InitializeComponent();
            label4.Visible = false;
            txt_custid.Visible = false;
            db = new BookSellingContext();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (BookSellingContext db = new BookSellingContext())
                {
                    Customers custs = new Customers();
                    custs.FirstName = txt_custname.Text.Trim();
                    custs.LastName = txt_surname.Text.Trim();
                    custs.Email = txt_custemail.Text.Trim();
                    db.Customers.Add(custs);
                    db.SaveChanges();
                    MessageBox.Show("Customer Added");
                    txt_custname.Text = " ";
                    txt_surname.Text = " ";
                    txt_custemail.Text = " ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chk_add_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_add.Checked)
            {
                btn_add.Enabled = true;
                chk_delete.Enabled = false;
                btn_delete.Enabled = false;
            }
            if (chk_add.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        private void chk_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_delete.Checked)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = false;
                label4.Visible = true;
                txt_custid.Visible = true;
                btn_delete.Enabled = true;

            }
            if (chk_delete.Checked == false)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = true;
                btn_delete.Enabled = false;
                label4.Visible = false;
                txt_custid.Visible = false;

            }
        }
        Customers custss = new Customers();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_custid.Text);
            custss = db.Customers.First(p => p.CustId == id);
            db.Customers.Remove(custss);
            db.SaveChanges();
            MessageBox.Show("Customer Deleted");
        }

        private void chk_update_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_update.Checked)
            {
                btn_upd.Enabled = true;
                chk_delete.Enabled = false;
                btn_delete.Enabled = false;
                chk_add.Enabled = false;
                btn_add.Enabled = false;
                label4.Visible = true;
                txt_custid.Visible = true;
            }
            if (chk_update.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
                btn_upd.Enabled = false;
                chk_add.Enabled = true;
                label4.Visible = false;
                txt_custid.Visible = false;
            }
        }

        Customers custom = new Customers();
        private void btn_upd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_custid.Text);
            custom = db.Customers.First(p => p.CustId == id);
            custom.FirstName = txt_custname.Text.Trim();
            custom.LastName = txt_surname.Text.Trim();
            custom.Email = txt_custemail.Text.Trim();
            db.SaveChanges();
            MessageBox.Show("Customer Updated");
            txt_custname.Text = " ";
            txt_surname.Text = " ";
            txt_custemail.Text = " ";
            txt_custid.Text = " ";
        }
    }
}
