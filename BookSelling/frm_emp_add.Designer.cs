namespace BookSelling
{
    partial class frm_emp_add
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_empsurname = new System.Windows.Forms.TextBox();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_empemail = new System.Windows.Forms.TextBox();
            this.txt_empass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(467, 367);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 49);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_empsurname
            // 
            this.txt_empsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_empsurname.Location = new System.Drawing.Point(255, 141);
            this.txt_empsurname.Multiline = true;
            this.txt_empsurname.Name = "txt_empsurname";
            this.txt_empsurname.Size = new System.Drawing.Size(356, 32);
            this.txt_empsurname.TabIndex = 12;
            // 
            // txt_empname
            // 
            this.txt_empname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_empname.Location = new System.Drawing.Point(255, 88);
            this.txt_empname.Multiline = true;
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(356, 32);
            this.txt_empname.TabIndex = 11;
            // 
            // txt_empid
            // 
            this.txt_empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_empid.Location = new System.Drawing.Point(255, 28);
            this.txt_empid.Multiline = true;
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(356, 32);
            this.txt_empid.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Employee Password:";
            // 
            // txt_empemail
            // 
            this.txt_empemail.Location = new System.Drawing.Point(255, 196);
            this.txt_empemail.Multiline = true;
            this.txt_empemail.Name = "txt_empemail";
            this.txt_empemail.Size = new System.Drawing.Size(356, 32);
            this.txt_empemail.TabIndex = 15;
            // 
            // txt_empass
            // 
            this.txt_empass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_empass.Location = new System.Drawing.Point(255, 253);
            this.txt_empass.Multiline = true;
            this.txt_empass.Name = "txt_empass";
            this.txt_empass.Size = new System.Drawing.Size(356, 32);
            this.txt_empass.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Employee Name:";
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Location = new System.Drawing.Point(510, 340);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(55, 21);
            this.chk_add.TabIndex = 18;
            this.chk_add.Text = "Add";
            this.chk_add.UseVisualStyleBackColor = true;
            this.chk_add.CheckedChanged += new System.EventHandler(this.chk_add_CheckedChanged);
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Location = new System.Drawing.Point(287, 340);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(71, 21);
            this.chk_delete.TabIndex = 19;
            this.chk_delete.Text = "Delete";
            this.chk_delete.UseVisualStyleBackColor = true;
            this.chk_delete.CheckedChanged += new System.EventHandler(this.chk_delete_CheckedChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(265, 368);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 49);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(53, 368);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(123, 48);
            this.btn_upd.TabIndex = 30;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Location = new System.Drawing.Point(72, 340);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(76, 21);
            this.chk_update.TabIndex = 29;
            this.chk_update.Text = "Update";
            this.chk_update.UseVisualStyleBackColor = true;
            this.chk_update.CheckedChanged += new System.EventHandler(this.chk_update_CheckedChanged);
            // 
            // frm_emp_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.chk_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.chk_delete);
            this.Controls.Add(this.chk_add);
            this.Controls.Add(this.txt_empass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_empemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_empsurname);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_emp_add";
            this.Text = "Employee Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_empsurname;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_empemail;
        private System.Windows.Forms.TextBox txt_empass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.CheckBox chk_update;
    }
}