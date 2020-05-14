namespace UzoeziOkorozeLab1
{
    partial class frmUtilityBill
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
            this.txtCustomerType = new System.Windows.Forms.ComboBox();
            this.lblPeakHours = new System.Windows.Forms.Label();
            this.lblOffPeakHours = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtPeakHours = new System.Windows.Forms.TextBox();
            this.txtOffPeakHours = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCountCustomer = new System.Windows.Forms.Label();
            this.txtCountCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSelectCustomerType = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblLCustomerList = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.txtTotalAmountCharge = new System.Windows.Forms.TextBox();
            this.txtTotalIndustrialCharge = new System.Windows.Forms.TextBox();
            this.txtTotalCommercialCharge = new System.Windows.Forms.TextBox();
            this.txtTotalResidentialCharge = new System.Windows.Forms.TextBox();
            this.lblTotalAmountCharge = new System.Windows.Forms.Label();
            this.lblTotalIndustrialCharge = new System.Windows.Forms.Label();
            this.lblTotalCommercialCharge = new System.Windows.Forms.Label();
            this.lblTotalResidentialCharge = new System.Windows.Forms.Label();
            this.lblCustomerGroup = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerType.FormattingEnabled = true;
            this.txtCustomerType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.txtCustomerType.Location = new System.Drawing.Point(208, 94);
            this.txtCustomerType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(148, 28);
            this.txtCustomerType.TabIndex = 0;
            this.txtCustomerType.SelectedIndexChanged += new System.EventHandler(this.txtCustomerType_SelectedIndexChanged);
            // 
            // lblPeakHours
            // 
            this.lblPeakHours.AutoSize = true;
            this.lblPeakHours.Enabled = false;
            this.lblPeakHours.Location = new System.Drawing.Point(62, 148);
            this.lblPeakHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeakHours.Name = "lblPeakHours";
            this.lblPeakHours.Size = new System.Drawing.Size(136, 20);
            this.lblPeakHours.TabIndex = 1;
            this.lblPeakHours.Text = "Peak Hours kWh :";
            // 
            // lblOffPeakHours
            // 
            this.lblOffPeakHours.AutoSize = true;
            this.lblOffPeakHours.Enabled = false;
            this.lblOffPeakHours.Location = new System.Drawing.Point(35, 194);
            this.lblOffPeakHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffPeakHours.Name = "lblOffPeakHours";
            this.lblOffPeakHours.Size = new System.Drawing.Size(163, 20);
            this.lblOffPeakHours.TabIndex = 2;
            this.lblOffPeakHours.Text = "Off-Peak Hours kWh :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Enabled = false;
            this.lblTotalAmount.Location = new System.Drawing.Point(83, 241);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(112, 20);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // txtPeakHours
            // 
            this.txtPeakHours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPeakHours.Location = new System.Drawing.Point(208, 142);
            this.txtPeakHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeakHours.Name = "txtPeakHours";
            this.txtPeakHours.Size = new System.Drawing.Size(148, 26);
            this.txtPeakHours.TabIndex = 4;
            // 
            // txtOffPeakHours
            // 
            this.txtOffPeakHours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOffPeakHours.Location = new System.Drawing.Point(208, 188);
            this.txtOffPeakHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOffPeakHours.Name = "txtOffPeakHours";
            this.txtOffPeakHours.Size = new System.Drawing.Size(148, 26);
            this.txtOffPeakHours.TabIndex = 5;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(208, 238);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(148, 26);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(244, 274);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(469, 274);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(664, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Enabled = false;
            this.lblCustomerType.Location = new System.Drawing.Point(23, 94);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(173, 20);
            this.lblCustomerType.TabIndex = 10;
            this.lblCustomerType.Text = "Select Customer Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculate Your Utility Bill";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMessage.Location = new System.Drawing.Point(375, 94);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(364, 164);
            this.lblMessage.TabIndex = 12;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Enabled = false;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(471, 65);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(163, 20);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = "Information Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "City Power Company";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCountCustomer);
            this.panel1.Controls.Add(this.txtCountCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboSelectCustomerType);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.lblAccountNo);
            this.panel1.Controls.Add(this.lblLCustomerList);
            this.panel1.Controls.Add(this.lstCustomer);
            this.panel1.Controls.Add(this.txtTotalAmountCharge);
            this.panel1.Controls.Add(this.txtTotalIndustrialCharge);
            this.panel1.Controls.Add(this.txtTotalCommercialCharge);
            this.panel1.Controls.Add(this.txtTotalResidentialCharge);
            this.panel1.Controls.Add(this.lblTotalAmountCharge);
            this.panel1.Controls.Add(this.lblTotalIndustrialCharge);
            this.panel1.Controls.Add(this.lblTotalCommercialCharge);
            this.panel1.Controls.Add(this.lblTotalResidentialCharge);
            this.panel1.Controls.Add(this.lblCustomerGroup);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Location = new System.Drawing.Point(1, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 306);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCountCustomer
            // 
            this.lblCountCustomer.AutoSize = true;
            this.lblCountCustomer.Enabled = false;
            this.lblCountCustomer.Location = new System.Drawing.Point(430, 42);
            this.lblCountCustomer.Name = "lblCountCustomer";
            this.lblCountCustomer.Size = new System.Drawing.Size(181, 20);
            this.lblCountCustomer.TabIndex = 21;
            this.lblCountCustomer.Text = "Total Customer Number ";
            // 
            // txtCountCustomer
            // 
            this.txtCountCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.txtCountCustomer.Enabled = false;
            this.txtCountCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountCustomer.Location = new System.Drawing.Point(619, 42);
            this.txtCountCustomer.Name = "txtCountCustomer";
            this.txtCountCustomer.Size = new System.Drawing.Size(121, 26);
            this.txtCountCustomer.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Version 1.2";
            // 
            // cboSelectCustomerType
            // 
            this.cboSelectCustomerType.BackColor = System.Drawing.SystemColors.Info;
            this.cboSelectCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectCustomerType.FormattingEnabled = true;
            this.cboSelectCustomerType.Items.AddRange(new object[] {
            "R",
            "C",
            "I"});
            this.cboSelectCustomerType.Location = new System.Drawing.Point(305, 154);
            this.cboSelectCustomerType.Name = "cboSelectCustomerType";
            this.cboSelectCustomerType.Size = new System.Drawing.Size(117, 28);
            this.cboSelectCustomerType.TabIndex = 18;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(305, 102);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(117, 26);
            this.txtAccountNumber.TabIndex = 17;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Enabled = false;
            this.lblAccountNo.Location = new System.Drawing.Point(301, 79);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(128, 20);
            this.lblAccountNo.TabIndex = 16;
            this.lblAccountNo.Text = "Account Number";
            // 
            // lblLCustomerList
            // 
            this.lblLCustomerList.AutoSize = true;
            this.lblLCustomerList.Enabled = false;
            this.lblLCustomerList.Location = new System.Drawing.Point(90, 19);
            this.lblLCustomerList.Name = "lblLCustomerList";
            this.lblLCustomerList.Size = new System.Drawing.Size(107, 20);
            this.lblLCustomerList.TabIndex = 15;
            this.lblLCustomerList.Text = "Customer List";
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 15;
            this.lstCustomer.Location = new System.Drawing.Point(11, 42);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(289, 244);
            this.lstCustomer.TabIndex = 14;
            // 
            // txtTotalAmountCharge
            // 
            this.txtTotalAmountCharge.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmountCharge.Enabled = false;
            this.txtTotalAmountCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountCharge.Location = new System.Drawing.Point(619, 204);
            this.txtTotalAmountCharge.Name = "txtTotalAmountCharge";
            this.txtTotalAmountCharge.Size = new System.Drawing.Size(121, 26);
            this.txtTotalAmountCharge.TabIndex = 13;
            // 
            // txtTotalIndustrialCharge
            // 
            this.txtTotalIndustrialCharge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalIndustrialCharge.Enabled = false;
            this.txtTotalIndustrialCharge.Location = new System.Drawing.Point(619, 162);
            this.txtTotalIndustrialCharge.Name = "txtTotalIndustrialCharge";
            this.txtTotalIndustrialCharge.Size = new System.Drawing.Size(121, 26);
            this.txtTotalIndustrialCharge.TabIndex = 12;
            // 
            // txtTotalCommercialCharge
            // 
            this.txtTotalCommercialCharge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalCommercialCharge.Enabled = false;
            this.txtTotalCommercialCharge.Location = new System.Drawing.Point(619, 120);
            this.txtTotalCommercialCharge.Name = "txtTotalCommercialCharge";
            this.txtTotalCommercialCharge.Size = new System.Drawing.Size(121, 26);
            this.txtTotalCommercialCharge.TabIndex = 11;
            // 
            // txtTotalResidentialCharge
            // 
            this.txtTotalResidentialCharge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalResidentialCharge.Enabled = false;
            this.txtTotalResidentialCharge.Location = new System.Drawing.Point(619, 79);
            this.txtTotalResidentialCharge.Name = "txtTotalResidentialCharge";
            this.txtTotalResidentialCharge.Size = new System.Drawing.Size(121, 26);
            this.txtTotalResidentialCharge.TabIndex = 10;
            // 
            // lblTotalAmountCharge
            // 
            this.lblTotalAmountCharge.AutoSize = true;
            this.lblTotalAmountCharge.Enabled = false;
            this.lblTotalAmountCharge.Location = new System.Drawing.Point(451, 204);
            this.lblTotalAmountCharge.Name = "lblTotalAmountCharge";
            this.lblTotalAmountCharge.Size = new System.Drawing.Size(160, 20);
            this.lblTotalAmountCharge.TabIndex = 8;
            this.lblTotalAmountCharge.Text = "Total Amount Charge";
            // 
            // lblTotalIndustrialCharge
            // 
            this.lblTotalIndustrialCharge.AutoSize = true;
            this.lblTotalIndustrialCharge.Enabled = false;
            this.lblTotalIndustrialCharge.Location = new System.Drawing.Point(442, 162);
            this.lblTotalIndustrialCharge.Name = "lblTotalIndustrialCharge";
            this.lblTotalIndustrialCharge.Size = new System.Drawing.Size(169, 20);
            this.lblTotalIndustrialCharge.TabIndex = 7;
            this.lblTotalIndustrialCharge.Text = "Total Industrial Charge";
            // 
            // lblTotalCommercialCharge
            // 
            this.lblTotalCommercialCharge.AutoSize = true;
            this.lblTotalCommercialCharge.Enabled = false;
            this.lblTotalCommercialCharge.Location = new System.Drawing.Point(428, 120);
            this.lblTotalCommercialCharge.Name = "lblTotalCommercialCharge";
            this.lblTotalCommercialCharge.Size = new System.Drawing.Size(187, 20);
            this.lblTotalCommercialCharge.TabIndex = 6;
            this.lblTotalCommercialCharge.Text = "Total Commercial Charge";
            // 
            // lblTotalResidentialCharge
            // 
            this.lblTotalResidentialCharge.AutoSize = true;
            this.lblTotalResidentialCharge.Enabled = false;
            this.lblTotalResidentialCharge.Location = new System.Drawing.Point(430, 79);
            this.lblTotalResidentialCharge.Name = "lblTotalResidentialCharge";
            this.lblTotalResidentialCharge.Size = new System.Drawing.Size(183, 20);
            this.lblTotalResidentialCharge.TabIndex = 5;
            this.lblTotalResidentialCharge.Text = "Total Residential Charge";
            // 
            // lblCustomerGroup
            // 
            this.lblCustomerGroup.AutoSize = true;
            this.lblCustomerGroup.Enabled = false;
            this.lblCustomerGroup.Location = new System.Drawing.Point(306, 131);
            this.lblCustomerGroup.Name = "lblCustomerGroup";
            this.lblCustomerGroup.Size = new System.Drawing.Size(116, 20);
            this.lblCustomerGroup.TabIndex = 4;
            this.lblCustomerGroup.Text = "Customer Type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(310, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(474, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Enabled = false;
            this.lblCustomerName.Location = new System.Drawing.Point(298, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(305, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(119, 26);
            this.txtCustomerName.TabIndex = 0;
            // 
            // frmUtilityBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(757, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtOffPeakHours);
            this.Controls.Add(this.txtPeakHours);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOffPeakHours);
            this.Controls.Add(this.lblPeakHours);
            this.Controls.Add(this.txtCustomerType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUtilityBill";
            this.Text = "City Power Company";
            this.Load += new System.EventHandler(this.frmUtilityBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtCustomerType;
        private System.Windows.Forms.Label lblPeakHours;
        private System.Windows.Forms.Label lblOffPeakHours;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtPeakHours;
        private System.Windows.Forms.TextBox txtOffPeakHours;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSelectCustomerType;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblLCustomerList;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.TextBox txtTotalAmountCharge;
        private System.Windows.Forms.TextBox txtTotalIndustrialCharge;
        private System.Windows.Forms.TextBox txtTotalCommercialCharge;
        private System.Windows.Forms.TextBox txtTotalResidentialCharge;
        private System.Windows.Forms.Label lblTotalAmountCharge;
        private System.Windows.Forms.Label lblTotalIndustrialCharge;
        private System.Windows.Forms.Label lblTotalCommercialCharge;
        private System.Windows.Forms.Label lblTotalResidentialCharge;
        private System.Windows.Forms.Label lblCustomerGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCountCustomer;
        private System.Windows.Forms.TextBox txtCountCustomer;
    }
}

