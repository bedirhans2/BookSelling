using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSelling
{
 

    public partial class frm_emp_add : Form
    {
        private BookSellingContext db;
        public frm_emp_add()
        {
            InitializeComponent();
            label1.Visible = false;
            txt_empid.Visible = false;
            db = new BookSellingContext();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (BookSellingContext db = new BookSellingContext())
                {
                    Employee emp = new Employee();
                    emp.FirstName = txt_empname.Text.Trim();
                    emp.LastName = txt_empsurname.Text.Trim();
                    emp.Email = txt_empemail.Text.Trim();
                    emp.Password = txt_empass.Text.Trim();
                    db.Employee.Add(emp);
                    db.SaveChanges();
                    MessageBox.Show("Employee Added");
                    txt_empid.Text = " ";
                    txt_empname.Text = " ";
                    txt_empsurname.Text = " ";
                    txt_empemail.Text = " ";
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
                btn_upd.Enabled = false;
                chk_update.Enabled = false;
            }
            if (chk_add.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
                btn_upd.Enabled = false;
                chk_update.Enabled = true;
            }
        }

        private void chk_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_delete.Checked)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = false;
                label1.Visible = true;
                txt_empid.Visible = true;
                btn_delete.Enabled = true;
                btn_upd.Enabled = false;
                chk_update.Enabled = false;

            }
            if (chk_delete.Checked == false)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = true;
                btn_delete.Enabled = false;
                label1.Visible = false;
                txt_empid.Visible = false;
                btn_upd.Enabled = false;
                chk_update.Enabled = true;
            }
        }
        Employee emps = new Employee();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_empid.Text);
            emps = db.Employee.First(p=> p.EmpId==id);
            db.Employee.Remove(emps);
            db.SaveChanges();
            MessageBox.Show("Employee Deleted");
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
                label1.Visible = true;
                txt_empid.Visible = true;
            }
            if (chk_update.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
                btn_upd.Enabled = false;
                chk_add.Enabled = true;
                label1.Visible = false;
                txt_empid.Visible = false;
            }
        }


        Employee empl = new Employee();
        private void btn_upd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_empid.Text);
            empl = db.Employee.First(p => p.EmpId == id);
            empl.FirstName = txt_empname.Text.Trim();
            empl.LastName = txt_empsurname.Text.Trim();
            empl.Email = txt_empemail.Text.Trim();
            empl.Password = txt_empass.Text.Trim();
            db.SaveChanges();
            MessageBox.Show("Employee Updated");
            txt_empid.Text = " ";
            txt_empname.Text = " ";
            txt_empsurname.Text = " ";
            txt_empemail.Text = " ";
        }
    }
}
