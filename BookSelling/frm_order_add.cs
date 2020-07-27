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
   
    public partial class frm_order_add : Form
    {
        private BookSellingContext db;
        public frm_order_add()
        {
            InitializeComponent();
            db = new BookSellingContext();
            label4.Visible = false;
            txt_orderid.Visible = false;
        }

        Orders ords = new Orders();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_orderid.Text);
            ords = db.Orders.First(p => p.OrderId == id);
            db.Orders.Remove(ords);
            db.SaveChanges();
            MessageBox.Show("Order Deleted");

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using(BookSellingContext db = new BookSellingContext())
                {
                    Orders ordss = new Orders();
                    ordss.CustId = Convert.ToInt32(txt_custid.Text);
                    ordss.InvoiceCreationDate = dt_inv.Value;
                    ordss.DeliveryDueDate = dt_delivery.Value;
                    ordss.PaymentDueDate = dt_payment.Value;
                    db.Orders.Add(ordss);
                    db.SaveChanges();
                    MessageBox.Show("Order Added");
                    txt_custid.Text = " ";
                }
            }
            catch(Exception ex)
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
                txt_orderid.Visible = true;
                btn_delete.Enabled = true;

            }
            if (chk_delete.Checked == false)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = true;
                btn_delete.Enabled = false;
                label4.Visible = false;
                txt_orderid.Visible = false;

            }
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
                txt_orderid.Visible = true;
            }
            if (chk_update.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
                btn_upd.Enabled = false;
                chk_add.Enabled = true;
                label4.Visible = false;
                txt_orderid.Visible = false;
            }
        }
        Orders order = new Orders();
        private void btn_upd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_orderid.Text);
            order = db.Orders.First(p => p.OrderId == id);
            order.CustId = Convert.ToInt32(txt_custid.Text);
            order.InvoiceCreationDate = dt_inv.Value;
            order.DeliveryDueDate = dt_delivery.Value;
            order.PaymentDueDate = dt_payment.Value;
            db.SaveChanges();
            MessageBox.Show("Order Updated");
            txt_custid.Text = " ";
            txt_orderid.Text = " ";
        }
    }
}
