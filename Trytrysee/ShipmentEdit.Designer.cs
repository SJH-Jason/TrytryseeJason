namespace Trytrysee
{
    partial class ShipmentEdit
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
            this.txtShipmentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnArrival = new System.Windows.Forms.Button();
            this.btnCompletion = new System.Windows.Forms.Button();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.txtAction1 = new System.Windows.Forms.TextBox();
            this.txtAction2 = new System.Windows.Forms.TextBox();
            this.txtAction3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTime4 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShipmentId";
            // 
            // txtShipmentID
            // 
            this.txtShipmentID.Location = new System.Drawing.Point(129, 85);
            this.txtShipmentID.Name = "txtShipmentID";
            this.txtShipmentID.Size = new System.Drawing.Size(100, 25);
            this.txtShipmentID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "OrderId";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(129, 125);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 25);
            this.txtOrderId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "SellerId";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(129, 169);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(100, 25);
            this.txtSellerId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ShipmentDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ArrivalTimeDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ShipmentStatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "CompletionStatus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "CompletionDate";
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(88, 381);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(66, 31);
            this.btnShip.TabIndex = 4;
            this.btnShip.Text = "已出貨";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnArrival
            // 
            this.btnArrival.Enabled = false;
            this.btnArrival.Location = new System.Drawing.Point(354, 381);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(66, 31);
            this.btnArrival.TabIndex = 5;
            this.btnArrival.Text = "已送達";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // btnCompletion
            // 
            this.btnCompletion.Enabled = false;
            this.btnCompletion.Location = new System.Drawing.Point(620, 381);
            this.btnCompletion.Name = "btnCompletion";
            this.btnCompletion.Size = new System.Drawing.Size(66, 31);
            this.btnCompletion.TabIndex = 6;
            this.btnCompletion.Text = "結單";
            this.btnCompletion.UseVisualStyleBackColor = true;
            this.btnCompletion.Click += new System.EventHandler(this.btnCompletion_Click);
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(307, 78);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.ReadOnly = true;
            this.txtTime1.Size = new System.Drawing.Size(124, 25);
            this.txtTime1.TabIndex = 3;
            this.txtTime1.Text = "訂單時間";
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(321, 247);
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.ReadOnly = true;
            this.txtTime3.Size = new System.Drawing.Size(124, 25);
            this.txtTime3.TabIndex = 21;
            this.txtTime3.Text = "送達時間";
            // 
            // txtAction1
            // 
            this.txtAction1.Location = new System.Drawing.Point(59, 331);
            this.txtAction1.Name = "txtAction1";
            this.txtAction1.ReadOnly = true;
            this.txtAction1.Size = new System.Drawing.Size(124, 25);
            this.txtAction1.TabIndex = 22;
            this.txtAction1.Text = "準備中";
            // 
            // txtAction2
            // 
            this.txtAction2.Location = new System.Drawing.Point(321, 331);
            this.txtAction2.Name = "txtAction2";
            this.txtAction2.ReadOnly = true;
            this.txtAction2.Size = new System.Drawing.Size(124, 25);
            this.txtAction2.TabIndex = 23;
            this.txtAction2.Text = "運送中";
            // 
            // txtAction3
            // 
            this.txtAction3.Location = new System.Drawing.Point(583, 331);
            this.txtAction3.Name = "txtAction3";
            this.txtAction3.ReadOnly = true;
            this.txtAction3.Size = new System.Drawing.Size(124, 25);
            this.txtAction3.TabIndex = 25;
            this.txtAction3.Text = "等候中/等候領取/已領取/已完成";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "ReceiveStatus";
            // 
            // txtTime4
            // 
            this.txtTime4.Location = new System.Drawing.Point(583, 247);
            this.txtTime4.Name = "txtTime4";
            this.txtTime4.ReadOnly = true;
            this.txtTime4.Size = new System.Drawing.Size(124, 25);
            this.txtTime4.TabIndex = 27;
            this.txtTime4.Text = "完成時間";
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(59, 247);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.ReadOnly = true;
            this.txtTime2.Size = new System.Drawing.Size(124, 25);
            this.txtTime2.TabIndex = 29;
            this.txtTime2.Text = "出貨時間";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "ShipDate";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(675, 63);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(66, 31);
            this.btnEnd.TabIndex = 30;
            this.btnEnd.Text = "確認";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(307, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 31);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(49, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 36);
            this.label11.TabIndex = 32;
            this.label11.Text = "單筆出貨單";
            // 
            // ShipmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTime4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAction3);
            this.Controls.Add(this.txtAction2);
            this.Controls.Add(this.txtAction1);
            this.Controls.Add(this.txtTime3);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.btnCompletion);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtShipmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShipmentEdit";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShipmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.Button btnCompletion;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.TextBox txtAction1;
        private System.Windows.Forms.TextBox txtAction2;
        private System.Windows.Forms.TextBox txtAction3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTime4;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label11;
    }
}