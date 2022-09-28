
namespace InvoiceSystem
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressData = new System.Windows.Forms.TextBox();
            this.txtnameData = new System.Windows.Forms.TextBox();
            this.txtDatedata = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewinvoice = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.InvoiceNumberDatalb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custmer Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            // 
            // txtAddressData
            // 
            this.txtAddressData.Location = new System.Drawing.Point(627, 97);
            this.txtAddressData.Multiline = true;
            this.txtAddressData.Name = "txtAddressData";
            this.txtAddressData.Size = new System.Drawing.Size(193, 101);
            this.txtAddressData.TabIndex = 5;
            // 
            // txtnameData
            // 
            this.txtnameData.Location = new System.Drawing.Point(627, 29);
            this.txtnameData.Name = "txtnameData";
            this.txtnameData.Size = new System.Drawing.Size(193, 26);
            this.txtnameData.TabIndex = 6;
            // 
            // txtDatedata
            // 
            this.txtDatedata.CustomFormat = "yyyy-MM-dd";
            this.txtDatedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatedata.Location = new System.Drawing.Point(231, 95);
            this.txtDatedata.Name = "txtDatedata";
            this.txtDatedata.Size = new System.Drawing.Size(200, 26);
            this.txtDatedata.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Paid",
            "UnPaid"});
            this.cmbStatus.Location = new System.Drawing.Point(231, 170);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbStatus.TabIndex = 9;
            // 
            // dataGridViewinvoice
            // 
            this.dataGridViewinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinvoice.Location = new System.Drawing.Point(155, 245);
            this.dataGridViewinvoice.Name = "dataGridViewinvoice";
            this.dataGridViewinvoice.RowHeadersWidth = 62;
            this.dataGridViewinvoice.RowTemplate.Height = 28;
            this.dataGridViewinvoice.Size = new System.Drawing.Size(590, 278);
            this.dataGridViewinvoice.TabIndex = 10;
            this.dataGridViewinvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewinvoice_CellContentClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(628, 553);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 57);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Invoice :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(510, 573);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 37);
            this.lblTotalAmount.TabIndex = 13;
            // 
            // InvoiceNumberDatalb
            // 
            this.InvoiceNumberDatalb.AutoSize = true;
            this.InvoiceNumberDatalb.Location = new System.Drawing.Point(227, 35);
            this.InvoiceNumberDatalb.Name = "InvoiceNumberDatalb";
            this.InvoiceNumberDatalb.Size = new System.Drawing.Size(0, 20);
            this.InvoiceNumberDatalb.TabIndex = 14;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.InvoiceNumberDatalb);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dataGridViewinvoice);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtDatedata);
            this.Controls.Add(this.txtnameData);
            this.Controls.Add(this.txtAddressData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressData;
        private System.Windows.Forms.TextBox txtnameData;
        private System.Windows.Forms.DateTimePicker txtDatedata;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dataGridViewinvoice;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label InvoiceNumberDatalb;
    }
}