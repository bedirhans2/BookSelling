namespace BookSelling
{
    partial class frm_order_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_custid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_inv = new System.Windows.Forms.DateTimePicker();
            this.dt_delivery = new System.Windows.Forms.DateTimePicker();
            this.dt_payment = new System.Windows.Forms.DateTimePicker();
            this.btn_upd = new System.Windows.Forms.Button();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(247, 349);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 49);
            this.btn_delete.TabIndex = 40;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_orderid
            // 
            this.txt_orderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_orderid.Location = new System.Drawing.Point(248, 30);
            this.txt_orderid.Multiline = true;
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(356, 32);
            this.txt_orderid.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Order ID";
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Location = new System.Drawing.Point(265, 322);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(71, 21);
            this.chk_delete.TabIndex = 36;
            this.chk_delete.Text = "Delete";
            this.chk_delete.UseVisualStyleBackColor = true;
            this.chk_delete.CheckedChanged += new System.EventHandler(this.chk_delete_CheckedChanged);
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Location = new System.Drawing.Point(489, 322);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(55, 21);
            this.chk_add.TabIndex = 35;
            this.chk_add.Text = "Add";
            this.chk_add.UseVisualStyleBackColor = true;
            this.chk_add.CheckedChanged += new System.EventHandler(this.chk_add_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(458, 349);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 49);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_custid
            // 
            this.txt_custid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_custid.Location = new System.Drawing.Point(248, 87);
            this.txt_custid.Multiline = true;
            this.txt_custid.Name = "txt_custid";
            this.txt_custid.Size = new System.Drawing.Size(356, 32);
            this.txt_custid.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Delivery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Payment Due Date";
            // 
            // dt_inv
            // 
            this.dt_inv.Location = new System.Drawing.Point(239, 147);
            this.dt_inv.Name = "dt_inv";
            this.dt_inv.Size = new System.Drawing.Size(365, 22);
            this.dt_inv.TabIndex = 43;
            // 
            // dt_delivery
            // 
            this.dt_delivery.Location = new System.Drawing.Point(239, 198);
            this.dt_delivery.Name = "dt_delivery";
            this.dt_delivery.Size = new System.Drawing.Size(365, 22);
            this.dt_delivery.TabIndex = 44;
            // 
            // dt_payment
            // 
            this.dt_payment.Location = new System.Drawing.Point(239, 254);
            this.dt_payment.Name = "dt_payment";
            this.dt_payment.Size = new System.Drawing.Size(365, 22);
            this.dt_payment.TabIndex = 45;
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(36, 349);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(123, 48);
            this.btn_upd.TabIndex = 47;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Location = new System.Drawing.Point(55, 321);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(76, 21);
            this.chk_update.TabIndex = 46;
            this.chk_update.Text = "Update";
            this.chk_update.UseVisualStyleBackColor = true;
            this.chk_update.CheckedChanged += new System.EventHandler(this.chk_update_CheckedChanged);
            // 
            // frm_order_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.chk_update);
            this.Controls.Add(this.dt_payment);
            this.Controls.Add(this.dt_delivery);
            this.Controls.Add(this.dt_inv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_delete);
            this.Controls.Add(this.chk_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_custid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_order_add";
            this.Text = "Order Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_custid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_inv;
        private System.Windows.Forms.DateTimePicker dt_delivery;
        private System.Windows.Forms.DateTimePicker dt_payment;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.CheckBox chk_update;
    }
}