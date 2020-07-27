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
    public partial class frm_product_add : Form
    {
        private BookSellingContext db;
        public frm_product_add()
        {
            InitializeComponent();
            db = new BookSellingContext();
            label1.Visible = false;
            txt_proid.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using(BookSellingContext db= new BookSellingContext())
                {
                    Products prod = new Products();
                    prod.Name = txt_proname.Text.Trim();
                    prod.Desciption = txt_desc.Text.Trim();
                    prod.Price = Convert.ToDecimal(txt_price.Text);
                    prod.Quantity = Convert.ToInt16(txt_quantity.Text);
                    db.Products.Add(prod);
                    db.SaveChanges();
                    MessageBox.Show("Product Added");
                    txt_proname.Text = " ";
                    txt_desc.Text = " ";
                    txt_price.Text = " ";
                    txt_quantity.Text = " ";
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Products pro = new Products();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_proid.Text);
            pro = db.Products.First(p => p.ProductId == id);
            db.Products.Remove(pro);
            db.SaveChanges();
            MessageBox.Show("Product Deleted");

        }

        private void chk_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_delete.Checked)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = false;
                label1.Visible = true;
                txt_proid.Visible = true;
                btn_delete.Enabled = true;

            }
            if (chk_delete.Checked == false)
            {
                btn_add.Enabled = false;
                chk_add.Enabled = true;
                btn_delete.Enabled = false;
                label1.Visible = false;
                txt_proid.Visible = false;

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
                chk_update.Enabled = true;
                btn_upd.Enabled = false;

            }
        }
        Products proupd = new Products();
        private void btn_upd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_proid.Text);
            proupd = db.Products.First(p => p.ProductId == id);
            proupd.Name = txt_proname.Text.Trim();
            proupd.Desciption = txt_desc.Text.Trim();
            proupd.Price = Convert.ToDecimal(txt_price.Text);
            proupd.Quantity = Convert.ToInt16(txt_quantity.Text);
            db.SaveChanges();
            MessageBox.Show("Product Updated");
            txt_proname.Text = " ";
            txt_desc.Text = " ";
            txt_price.Text = " ";
            txt_quantity.Text = " ";
            txt_proid.Text = " ";
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
                txt_proid.Visible = true;
            }
            if (chk_update.Checked == false)
            {
                btn_add.Enabled = false;
                chk_delete.Enabled = true;
                btn_delete.Enabled = false;
                btn_upd.Enabled = false;
                chk_add.Enabled = true;
                label1.Visible = false;
                txt_proid.Visible = false;
            }
        }
    }
}
