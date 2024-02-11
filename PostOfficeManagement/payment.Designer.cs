namespace PostOfficeManagement
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlExam = new System.Windows.Forms.Panel();
            this.txtExamCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.txtChassisNumber = new System.Windows.Forms.TextBox();
            this.txtVehicalNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMobile = new System.Windows.Forms.Panel();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLife = new System.Windows.Forms.Panel();
            this.txtPolicyNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOther.SuspendLayout();
            this.pnlExam.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            this.pnlMobile.SuspendLayout();
            this.pnlLife.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(12, 487);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 51;
            this.dataGridViewPayment.RowTemplate.Height = 24;
            this.dataGridViewPayment.Size = new System.Drawing.Size(1222, 167);
            this.dataGridViewPayment.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPaymentType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 100);
            this.panel1.TabIndex = 1;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Ceylon Electricity Board",
            "National Water Supply and Drainage Board",
            "Sri Lanka Telecom",
            "Mobitel Sri Lanka",
            "Ceylinco Life Insurance",
            "Sri Lanka Insurance",
            "Exam Fee",
            "Fine",
            "Money Order",
            "Money Order Withdrawals"});
            this.cmbPaymentType.Location = new System.Drawing.Point(282, 35);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(577, 39);
            this.cmbPaymentType.TabIndex = 28;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "Payment Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pnlOther);
            this.panel2.Controls.Add(this.pnlExam);
            this.panel2.Controls.Add(this.pnlVehicle);
            this.panel2.Controls.Add(this.pnlMobile);
            this.panel2.Controls.Add(this.pnlLife);
            this.panel2.Controls.Add(this.pnlAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 116);
            this.panel2.TabIndex = 2;
            // 
            // pnlOther
            // 
            this.pnlOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOther.Controls.Add(this.txtID);
            this.pnlOther.Controls.Add(this.txtName);
            this.pnlOther.Controls.Add(this.label6);
            this.pnlOther.Controls.Add(this.label7);
            this.pnlOther.Location = new System.Drawing.Point(2, 16);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(1242, 100);
            this.pnlOther.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(799, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(344, 37);
            this.txtID.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(278, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 37);
            this.txtName.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(708, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID";
            // 
            // pnlExam
            // 
            this.pnlExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExam.Controls.Add(this.txtExamCode);
            this.pnlExam.Controls.Add(this.label5);
            this.pnlExam.Location = new System.Drawing.Point(2, 16);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.Size = new System.Drawing.Size(1243, 100);
            this.pnlExam.TabIndex = 3;
            // 
            // txtExamCode
            // 
            this.txtExamCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamCode.Location = new System.Drawing.Point(279, 31);
            this.txtExamCode.Name = "txtExamCode";
            this.txtExamCode.Size = new System.Drawing.Size(344, 37);
            this.txtExamCode.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Exam Code";
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVehicle.Controls.Add(this.txtChassisNumber);
            this.pnlVehicle.Controls.Add(this.txtVehicalNumber);
            this.pnlVehicle.Controls.Add(this.label4);
            this.pnlVehicle.Controls.Add(this.label3);
            this.pnlVehicle.Location = new System.Drawing.Point(3, 16);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(1243, 100);
            this.pnlVehicle.TabIndex = 35;
            // 
            // txtChassisNumber
            // 
            this.txtChassisNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassisNumber.Location = new System.Drawing.Point(890, 29);
            this.txtChassisNumber.Name = "txtChassisNumber";
            this.txtChassisNumber.Size = new System.Drawing.Size(344, 37);
            this.txtChassisNumber.TabIndex = 37;
            // 
            // txtVehicalNumber
            // 
            this.txtVehicalNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicalNumber.Location = new System.Drawing.Point(279, 29);
            this.txtVehicalNumber.Name = "txtVehicalNumber";
            this.txtVehicalNumber.Size = new System.Drawing.Size(344, 37);
            this.txtVehicalNumber.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Chassis Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vehicle Number";
            // 
            // pnlMobile
            // 
            this.pnlMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMobile.Controls.Add(this.txtTelephoneNumber);
            this.pnlMobile.Controls.Add(this.label2);
            this.pnlMobile.Location = new System.Drawing.Point(3, 16);
            this.pnlMobile.Name = "pnlMobile";
            this.pnlMobile.Size = new System.Drawing.Size(1243, 100);
            this.pnlMobile.TabIndex = 3;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNumber.Location = new System.Drawing.Point(282, 29);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(344, 37);
            this.txtTelephoneNumber.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tp. Number";
            // 
            // pnlLife
            // 
            this.pnlLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLife.BackColor = System.Drawing.Color.Transparent;
            this.pnlLife.Controls.Add(this.txtPolicyNumber);
            this.pnlLife.Controls.Add(this.label1);
            this.pnlLife.Location = new System.Drawing.Point(3, 16);
            this.pnlLife.Name = "pnlLife";
            this.pnlLife.Size = new System.Drawing.Size(1240, 100);
            this.pnlLife.TabIndex = 0;
            // 
            // txtPolicyNumber
            // 
            this.txtPolicyNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicyNumber.Location = new System.Drawing.Point(279, 32);
            this.txtPolicyNumber.Name = "txtPolicyNumber";
            this.txtPolicyNumber.Size = new System.Drawing.Size(344, 37);
            this.txtPolicyNumber.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Policy Number";
            // 
            // pnlAccount
            // 
            this.pnlAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccount.Controls.Add(this.txtAccount);
            this.pnlAccount.Controls.Add(this.txtAccountNumber);
            this.pnlAccount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAccount.Location = new System.Drawing.Point(0, 16);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1240, 100);
            this.pnlAccount.TabIndex = 3;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(279, 35);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(344, 37);
            this.txtAccount.TabIndex = 29;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AutoSize = true;
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAccountNumber.Location = new System.Drawing.Point(12, 38);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(159, 31);
            this.txtAccountNumber.TabIndex = 30;
            this.txtAccountNumber.Text = "Account No.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblServiceCharge);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 100);
            this.panel3.TabIndex = 3;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.Location = new System.Drawing.Point(955, 44);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(109, 31);
            this.lblServiceCharge.TabIndex = 34;
            this.lblServiceCharge.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(710, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Service Charge";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(279, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(344, 37);
            this.txtAmount.TabIndex = 31;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(21, 355);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(145, 46);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(217, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1075, 355);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 46);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(801, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "mm/dd/yy";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 666);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPayment);
            this.Name = "payment";
            this.Text = "payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.payment_Load);
            this.Click += new System.EventHandler(this.payment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            this.pnlExam.ResumeLayout(false);
            this.pnlExam.PerformLayout();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            this.pnlMobile.ResumeLayout(false);
            this.pnlMobile.PerformLayout();
            this.pnlLife.ResumeLayout(false);
            this.pnlLife.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Panel pnlLife;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label txtAccountNumber;
        private System.Windows.Forms.TextBox txtPolicyNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMobile;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.TextBox txtVehicalNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChassisNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlExam;
        private System.Windows.Forms.TextBox txtExamCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox textBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}