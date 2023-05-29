namespace Trytrysee
{
    partial class SellerMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labSellerId = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.labSellerName = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerID,
            this.SellerName,
            this.SellerAccount,
            this.SellerPassword,
            this.SellerContact,
            this.ProductInventories,
            this.Products,
            this.Shipments});
            this.dataGridView1.Location = new System.Drawing.Point(65, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(889, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // SellerID
            // 
            this.SellerID.DataPropertyName = "SellerID";
            this.SellerID.HeaderText = "SellerID";
            this.SellerID.MinimumWidth = 6;
            this.SellerID.Name = "SellerID";
            this.SellerID.Width = 125;
            // 
            // SellerName
            // 
            this.SellerName.DataPropertyName = "SellerName";
            this.SellerName.HeaderText = "SellerName";
            this.SellerName.MinimumWidth = 6;
            this.SellerName.Name = "SellerName";
            this.SellerName.Width = 125;
            // 
            // SellerAccount
            // 
            this.SellerAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerAccount.DataPropertyName = "SellerAccount";
            this.SellerAccount.HeaderText = "SellerAccount";
            this.SellerAccount.MinimumWidth = 6;
            this.SellerAccount.Name = "SellerAccount";
            // 
            // SellerPassword
            // 
            this.SellerPassword.DataPropertyName = "SellerPassword";
            this.SellerPassword.HeaderText = "SellerPassword";
            this.SellerPassword.MinimumWidth = 6;
            this.SellerPassword.Name = "SellerPassword";
            this.SellerPassword.Width = 125;
            // 
            // SellerContact
            // 
            this.SellerContact.DataPropertyName = "SellerContact";
            this.SellerContact.HeaderText = "SellerContact";
            this.SellerContact.MinimumWidth = 6;
            this.SellerContact.Name = "SellerContact";
            this.SellerContact.Width = 125;
            // 
            // ProductInventories
            // 
            this.ProductInventories.DataPropertyName = "ProductInventories";
            this.ProductInventories.HeaderText = "ProductInventories";
            this.ProductInventories.MinimumWidth = 6;
            this.ProductInventories.Name = "ProductInventories";
            this.ProductInventories.Visible = false;
            this.ProductInventories.Width = 125;
            // 
            // Products
            // 
            this.Products.DataPropertyName = "Products";
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.Visible = false;
            this.Products.Width = 125;
            // 
            // Shipments
            // 
            this.Shipments.DataPropertyName = "Shipments";
            this.Shipments.HeaderText = "Shipments";
            this.Shipments.MinimumWidth = 6;
            this.Shipments.Name = "Shipments";
            this.Shipments.Visible = false;
            this.Shipments.Width = 125;
            // 
            // labSellerId
            // 
            this.labSellerId.AutoSize = true;
            this.labSellerId.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSellerId.Location = new System.Drawing.Point(90, 40);
            this.labSellerId.Name = "labSellerId";
            this.labSellerId.Size = new System.Drawing.Size(101, 29);
            this.labSellerId.TabIndex = 1;
            this.labSellerId.Text = "SellerId:";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSellerId.Location = new System.Drawing.Point(197, 36);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(180, 38);
            this.txtSellerId.TabIndex = 2;
            // 
            // labSellerName
            // 
            this.labSellerName.AutoSize = true;
            this.labSellerName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSellerName.Location = new System.Drawing.Point(404, 40);
            this.labSellerName.Name = "labSellerName";
            this.labSellerName.Size = new System.Drawing.Size(146, 29);
            this.labSellerName.TabIndex = 1;
            this.labSellerName.Text = "SellerName:";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSellerName.Location = new System.Drawing.Point(568, 37);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(180, 38);
            this.txtSellerName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(819, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(819, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SellerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSellerName);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.labSellerName);
            this.Controls.Add(this.labSellerId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SellerMain";
            this.Text = "SellerMain";
            this.Load += new System.EventHandler(this.SellerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipments;
        private System.Windows.Forms.Label labSellerId;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label labSellerName;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
    }
}