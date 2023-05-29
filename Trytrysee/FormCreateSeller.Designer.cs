namespace Trytrysee
{
    partial class FormCreateSeller
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
            this.txtaddSellerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddSellerAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddSellerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddSellerContact = new System.Windows.Forms.TextBox();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "賣家名稱:";
            // 
            // txtaddSellerName
            // 
            this.txtaddSellerName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtaddSellerName.Location = new System.Drawing.Point(162, 44);
            this.txtaddSellerName.Name = "txtaddSellerName";
            this.txtaddSellerName.Size = new System.Drawing.Size(566, 34);
            this.txtaddSellerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "賣家帳號:";
            // 
            // txtAddSellerAccount
            // 
            this.txtAddSellerAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddSellerAccount.Location = new System.Drawing.Point(162, 92);
            this.txtAddSellerAccount.Name = "txtAddSellerAccount";
            this.txtAddSellerAccount.Size = new System.Drawing.Size(566, 34);
            this.txtAddSellerAccount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "賣家密碼:";
            // 
            // txtAddSellerPassword
            // 
            this.txtAddSellerPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddSellerPassword.Location = new System.Drawing.Point(162, 146);
            this.txtAddSellerPassword.Name = "txtAddSellerPassword";
            this.txtAddSellerPassword.Size = new System.Drawing.Size(566, 34);
            this.txtAddSellerPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "聯絡地址:";
            // 
            // txtAddSellerContact
            // 
            this.txtAddSellerContact.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddSellerContact.Location = new System.Drawing.Point(162, 198);
            this.txtAddSellerContact.Name = "txtAddSellerContact";
            this.txtAddSellerContact.Size = new System.Drawing.Size(566, 34);
            this.txtAddSellerContact.TabIndex = 1;
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddSeller.Location = new System.Drawing.Point(618, 281);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(110, 43);
            this.btnAddSeller.TabIndex = 2;
            this.btnAddSeller.Text = "註冊";
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // FormCreateSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.txtAddSellerContact);
            this.Controls.Add(this.txtAddSellerPassword);
            this.Controls.Add(this.txtAddSellerAccount);
            this.Controls.Add(this.txtaddSellerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateSeller";
            this.Text = "FormCreateSeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddSellerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddSellerAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddSellerPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddSellerContact;
        private System.Windows.Forms.Button btnAddSeller;
    }
}