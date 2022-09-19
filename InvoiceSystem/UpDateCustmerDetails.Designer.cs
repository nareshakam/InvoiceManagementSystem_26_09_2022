
namespace InvoiceSystem
{
    partial class UpDateCustmerDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustmerName = new System.Windows.Forms.TextBox();
            this.txtDateData = new System.Windows.Forms.DateTimePicker();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewMainEdit = new System.Windows.Forms.DataGridView();
            this.lbInvoiceNumber = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "InvoiceNumber :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custmer Name :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "InvoiceDate :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custmer Address :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice Status :-\r\n";
            // 
            // txtCustmerName
            // 
            this.txtCustmerName.Location = new System.Drawing.Point(152, 36);
            this.txtCustmerName.Name = "txtCustmerName";
            this.txtCustmerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustmerName.TabIndex = 5;
            // 
            // txtDateData
            // 
            this.txtDateData.CustomFormat = "yyyy-MM-dd";
            this.txtDateData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateData.Location = new System.Drawing.Point(152, 72);
            this.txtDateData.Name = "txtDateData";
            this.txtDateData.Size = new System.Drawing.Size(100, 20);
            this.txtDateData.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(152, 105);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 5;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Paid",
            "UnPaid"});
            this.cmbstatus.Location = new System.Drawing.Point(152, 137);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(100, 21);
            this.cmbstatus.TabIndex = 7;
            // 
            // dataGridViewMainEdit
            // 
            this.dataGridViewMainEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainEdit.Location = new System.Drawing.Point(15, 188);
            this.dataGridViewMainEdit.Name = "dataGridViewMainEdit";
            this.dataGridViewMainEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainEdit.Size = new System.Drawing.Size(541, 150);
            this.dataGridViewMainEdit.TabIndex = 8;
            this.dataGridViewMainEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMainEdit_CellClick);
            // 
            // lbInvoiceNumber
            // 
            this.lbInvoiceNumber.AutoSize = true;
            this.lbInvoiceNumber.Location = new System.Drawing.Point(149, 9);
            this.lbInvoiceNumber.Name = "lbInvoiceNumber";
            this.lbInvoiceNumber.Size = new System.Drawing.Size(0, 13);
            this.lbInvoiceNumber.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(323, 134);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(418, 133);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UpDateCustmerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.dataGridViewMainEdit);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.txtDateData);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtCustmerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInvoiceNumber);
            this.Controls.Add(this.label1);
            this.Name = "UpDateCustmerDetails";
            this.Text = "UpDateCustmerDetails";
            this.Load += new System.EventHandler(this.UpDateCustmerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustmerName;
        private System.Windows.Forms.DateTimePicker txtDateData;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.DataGridView dataGridViewMainEdit;
        private System.Windows.Forms.Label lbInvoiceNumber;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}