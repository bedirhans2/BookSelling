namespace BookSelling
{
    partial class frm_cust_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_custemail = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_custid = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Email";
            // 
            // txt_custname
            // 
            this.txt_custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_custname.Location = new System.Drawing.Point(245, 84);
            this.txt_custname.Multiline = true;
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(356, 32);
            this.txt_custname.TabIndex = 3;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_surname.Location = new System.Drawing.Point(245, 144);
            this.txt_surname.Multiline = true;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(356, 32);
            this.txt_surname.TabIndex = 4;
            // 
            // txt_custemail
            // 
            this.txt_custemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_custemail.Location = new System.Drawing.Point(245, 204);
            this.txt_custemail.Multiline = true;
            this.txt_custemail.Name = "txt_custemail";
            this.txt_custemail.Size = new System.Drawing.Size(356, 32);
            this.txt_custemail.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(436, 315);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 49);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Location = new System.Drawing.Point(61, 287);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(76, 21);
            this.chk_update.TabIndex = 24;
            this.chk_update.Text = "Update";
            this.chk_update.UseVisualStyleBackColor = true;
            this.chk_update.CheckedChanged += new System.EventHandler(this.chk_update_CheckedChanged);
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Location = new System.Drawing.Point(467, 288);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(55, 21);
            this.chk_add.TabIndex = 22;
            this.chk_add.Text = "Add";
            this.chk_add.UseVisualStyleBackColor = true;
            this.chk_add.CheckedChanged += new System.EventHandler(this.chk_add_CheckedChanged);
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Location = new System.Drawing.Point(254, 287);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(71, 21);
            this.chk_delete.TabIndex = 23;
            this.chk_delete.Text = "Delete";
            this.chk_delete.UseVisualStyleBackColor = true;
            this.chk_delete.CheckedChanged += new System.EventHandler(this.chk_delete_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer ID:";
            // 
            // txt_custid
            // 
            this.txt_custid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_custid.Location = new System.Drawing.Point(245, 27);
            this.txt_custid.Multiline = true;
            this.txt_custid.Name = "txt_custid";
            this.txt_custid.Size = new System.Drawing.Size(356, 32);
            this.txt_custid.TabIndex = 26;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(236, 314);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 49);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(42, 315);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(123, 48);
            this.btn_upd.TabIndex = 28;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // frm_cust_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 384);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_custid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_update);
            this.Controls.Add(this.chk_delete);
            this.Controls.Add(this.chk_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_custemail);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_custname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_cust_add";
            this.Text = "Customer Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_custname;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_custemail;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckBox chk_update;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_custid;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_upd;
    }
}