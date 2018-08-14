namespace CPRG200Lab2
{
    partial class frmElectricityCharges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElectricityCharges));
            this.lblUsage = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtUsagePeak = new System.Windows.Forms.TextBox();
            this.lblUsagePeak = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumCust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIndTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(22, 145);
            this.lblUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(183, 20);
            this.lblUsage.TabIndex = 0;
            this.lblUsage.Text = "Electricity Usage in kWh:";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(217, 143);
            this.txtUsage.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(121, 26);
            this.txtUsage.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(74, 225);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(219, 43);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate and Add Record";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Charges:";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(25, 344);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 37);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 344);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Type:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.cboType.Location = new System.Drawing.Point(217, 107);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 28);
            this.cboType.TabIndex = 8;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtUsagePeak
            // 
            this.txtUsagePeak.Location = new System.Drawing.Point(217, 176);
            this.txtUsagePeak.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsagePeak.Name = "txtUsagePeak";
            this.txtUsagePeak.Size = new System.Drawing.Size(121, 26);
            this.txtUsagePeak.TabIndex = 10;
            this.txtUsagePeak.Tag = "peak usage";
            // 
            // lblUsagePeak
            // 
            this.lblUsagePeak.AutoSize = true;
            this.lblUsagePeak.Location = new System.Drawing.Point(22, 179);
            this.lblUsagePeak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsagePeak.Name = "lblUsagePeak";
            this.lblUsagePeak.Size = new System.Drawing.Size(152, 20);
            this.lblUsagePeak.TabIndex = 9;
            this.lblUsagePeak.Text = "Peak Usage in kWh:";
            // 
            // lblCharges
            // 
            this.lblCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharges.Location = new System.Drawing.Point(217, 294);
            this.lblCharges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(119, 27);
            this.lblCharges.TabIndex = 12;
            this.lblCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 26);
            this.txtName.TabIndex = 14;
            this.txtName.Tag = "customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Account Number:";
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Location = new System.Drawing.Point(216, 74);
            this.txtAcctNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(122, 26);
            this.txtAcctNum.TabIndex = 16;
            this.txtAcctNum.Tag = "account number";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(442, 40);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(362, 304);
            this.lstCustomers.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data for all customers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total number of customers:";
            // 
            // lblNumCust
            // 
            this.lblNumCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumCust.Location = new System.Drawing.Point(679, 360);
            this.lblNumCust.Name = "lblNumCust";
            this.lblNumCust.Size = new System.Drawing.Size(125, 31);
            this.lblNumCust.TabIndex = 20;
            this.lblNumCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total charges:";
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResTotal.Location = new System.Drawing.Point(679, 402);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(125, 31);
            this.lblResTotal.TabIndex = 22;
            this.lblResTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Residential:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Industrial:";
            // 
            // lblIndTotal
            // 
            this.lblIndTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndTotal.Location = new System.Drawing.Point(679, 468);
            this.lblIndTotal.Name = "lblIndTotal";
            this.lblIndTotal.Size = new System.Drawing.Size(125, 31);
            this.lblIndTotal.TabIndex = 24;
            this.lblIndTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(557, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Commercial:";
            // 
            // lblComTotal
            // 
            this.lblComTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComTotal.Location = new System.Drawing.Point(679, 435);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(125, 31);
            this.lblComTotal.TabIndex = 26;
            this.lblComTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Location = new System.Drawing.Point(679, 513);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(125, 31);
            this.lblGrandTotal.TabIndex = 29;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(442, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Grand total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 137);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmElectricityCharges
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(830, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblComTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIndTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblResTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumCust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.txtUsagePeak);
            this.Controls.Add(this.lblUsagePeak);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.lblUsage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmElectricityCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Electricity Charges";
            this.Load += new System.EventHandler(this.frmElectricityCharges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtUsagePeak;
        private System.Windows.Forms.Label lblUsagePeak;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumCust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIndTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

