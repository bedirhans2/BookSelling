namespace BookSelling
{
    partial class frm_product_add
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
            this.chk_delete = new System.Windows.Forms.CheckBox();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_proname = new System.Windows.Forms.TextBox();
            this.txt_proid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_upd = new System.Windows.Forms.Button();
            this.chk_update = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(225, 340);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 49);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // chk_delete
            // 
            this.chk_delete.AutoSize = true;
            this.chk_delete.Location = new System.Drawing.Point(250, 313);
            this.chk_delete.Name = "chk_delete";
            this.chk_delete.Size = new System.Drawing.Size(71, 21);
            this.chk_delete.TabIndex = 34;
            this.chk_delete.Text = "Delete";
            this.chk_delete.UseVisualStyleBackColor = true;
            this.chk_delete.CheckedChanged += new System.EventHandler(this.chk_delete_CheckedChanged);
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Location = new System.Drawing.Point(453, 313);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(55, 21);
            this.chk_add.TabIndex = 33;
            this.chk_add.Text = "Add";
            this.chk_add.UseVisualStyleBackColor = true;
            this.chk_add.CheckedChanged += new System.EventHandler(this.chk_add_CheckedChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_quantity.Location = new System.Drawing.Point(251, 250);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(356, 32);
            this.txt_quantity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name:";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(251, 193);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(356, 32);
            this.txt_price.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantity:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(410, 340);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 49);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_desc.Location = new System.Drawing.Point(251, 138);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(356, 32);
            this.txt_desc.TabIndex = 27;
            // 
            // txt_proname
            // 
            this.txt_proname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proname.Location = new System.Drawing.Point(251, 85);
            this.txt_proname.Multiline = true;
            this.txt_proname.Name = "txt_proname";
            this.txt_proname.Size = new System.Drawing.Size(356, 32);
            this.txt_proname.TabIndex = 26;
            // 
            // txt_proid
            // 
            this.txt_proid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proid.Location = new System.Drawing.Point(251, 25);
            this.txt_proid.Multiline = true;
            this.txt_proid.Name = "txt_proid";
            this.txt_proid.Size = new System.Drawing.Size(356, 32);
            this.txt_proid.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product ID:";
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(37, 340);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(123, 48);
            this.btn_upd.TabIndex = 38;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // chk_update
            // 
            this.chk_update.AutoSize = true;
            this.chk_update.Location = new System.Drawing.Point(56, 312);
            this.chk_update.Name = "chk_update";
            this.chk_update.Size = new System.Drawing.Size(76, 21);
            this.chk_update.TabIndex = 37;
            this.chk_update.Text = "Update";
            this.chk_update.UseVisualStyleBackColor = true;
            this.chk_update.CheckedChanged += new System.EventHandler(this.chk_update_CheckedChanged);
            // 
            // frm_product_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.chk_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.chk_delete);
            this.Controls.Add(this.chk_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_proname);
            this.Controls.Add(this.txt_proid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_product_add";
            this.Text = "Product Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox chk_delete;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_proname;
        private System.Windows.Forms.TextBox txt_proid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.CheckBox chk_update;
    }
}