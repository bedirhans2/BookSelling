using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Model;
namespace BookSelling
{
    public partial class Form1 : Form
    {
        BookSellingContext db;
        public Form1()
        {
            InitializeComponent();
            db = new BookSellingContext();
        }

       

      
        private frm_cust_add Frm_Cust_Add;
        private void btn_add1_Click(object sender, EventArgs e)
        {
            if (Frm_Cust_Add==null || Frm_Cust_Add.IsDisposed)
            {
                Frm_Cust_Add = new frm_cust_add();
                Frm_Cust_Add.ShowDialog();
            }
        }

        private void btn_show1_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = db.Customers.ToList();
                dataGridView1.DataSource = (from C in db.Customers
                                            select new
                                            {
                                                C.CustId,
                                                C.FirstName,
                                                C.LastName,
                                                C.Email
                                            }).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = (from emp in db.Employee
                                            select new
                                            {
                                                emp.EmpId,
                                                emp.FirstName,
                                                emp.LastName,
                                                emp.Email,
                                                emp.Password                                               
                                            }).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private frm_emp_add Frm_Emp_Add;
        private void btn_add2_Click(object sender, EventArgs e)
        {
            if (Frm_Emp_Add == null || Frm_Emp_Add.IsDisposed)
            {
                Frm_Emp_Add = new frm_emp_add();
                Frm_Emp_Add.ShowDialog();
            }
        }

        private void btn_show3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource=(from ord in db.Orders
                                     select new
                                     {
                                         ord.OrderId,
                                         ord.CustId,
                                         ord.InvoiceCreationDate,
                                         ord.DeliveryDueDate,
                                         ord.PaymentDueDate
                                     }).ToList();
        }
        private frm_order_add Frm_Order_Add;
        private void btn_add3_Click(object sender, EventArgs e)
        {
            if (Frm_Order_Add == null || Frm_Order_Add.IsDisposed)
            {
                Frm_Order_Add = new frm_order_add();
                Frm_Order_Add.ShowDialog();
            }
        }


        private frm_product_add frm_Product_Add;
        private void btn_add4_Click(object sender, EventArgs e)
        {
            if(frm_Product_Add==null|| frm_Product_Add.IsDisposed)
            {
                frm_Product_Add = new frm_product_add();
                frm_Product_Add.ShowDialog();
            }
        }

        private void btn_show4_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = (from pro in db.Products
                                        select new
                                        {
                                            pro.ProductId,
                                            pro.Name,
                                            pro.Desciption,
                                            pro.Price,
                                            pro.Quantity
                                        }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
