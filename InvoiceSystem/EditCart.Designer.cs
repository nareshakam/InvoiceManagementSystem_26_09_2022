
namespace InvoiceSystem
{
    partial class EditCart
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
            this.BtnShowData = new System.Windows.Forms.Button();
            this.txtIInvoicenumber = new System.Windows.Forms.TextBox();
            this.dataGridViewedit = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProductname = new System.Windows.Forms.Label();
            this.lbproductPrice = new System.Windows.Forms.Label();
            this.cmdpq = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewedit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "InvoiceNumber :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // BtnShowData
            // 
            this.BtnShowData.Location = new System.Drawing.Point(610, 72);
            this.BtnShowData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnShowData.Name = "BtnShowData";
            this.BtnShowData.Size = new System.Drawing.Size(112, 35);
            this.BtnShowData.TabIndex = 2;
            this.BtnShowData.Text = "Show Data";
            this.BtnShowData.UseVisualStyleBackColor = true;
            this.BtnShowData.Click += new System.EventHandler(this.BtnShowData_Click);
            // 
            // txtIInvoicenumber
            // 
            this.txtIInvoicenumber.Location = new System.Drawing.Point(234, 75);
            this.txtIInvoicenumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIInvoicenumber.Name = "txtIInvoicenumber";
            this.txtIInvoicenumber.Size = new System.Drawing.Size(210, 26);
            this.txtIInvoicenumber.TabIndex = 3;
            // 
            // dataGridViewedit
            // 
            this.dataGridViewedit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewedit.Location = new System.Drawing.Point(96, 166);
            this.dataGridViewedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewedit.Name = "dataGridViewedit";
            this.dataGridViewedit.RowHeadersWidth = 62;
            this.dataGridViewedit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewedit.Size = new System.Drawing.Size(627, 231);
            this.dataGridViewedit.TabIndex = 4;
            this.dataGridViewedit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewedit_CellClick);
            this.dataGridViewedit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewedit_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Price :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product Quantity :-";
            // 
            // lbProductname
            // 
            this.lbProductname.AutoSize = true;
            this.lbProductname.Location = new System.Drawing.Point(218, 449);
            this.lbProductname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductname.Name = "lbProductname";
            this.lbProductname.Size = new System.Drawing.Size(0, 20);
            this.lbProductname.TabIndex = 5;
            // 
            // lbproductPrice
            // 
            this.lbproductPrice.AutoSize = true;
            this.lbproductPrice.Location = new System.Drawing.Point(218, 498);
            this.lbproductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbproductPrice.Name = "lbproductPrice";
            this.lbproductPrice.Size = new System.Drawing.Size(0, 20);
            this.lbproductPrice.TabIndex = 5;
            // 
            // cmdpq
            // 
            this.cmdpq.FormattingEnabled = true;
            this.cmdpq.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmdpq.Location = new System.Drawing.Point(633, 446);
            this.cmdpq.Name = "cmdpq";
            this.cmdpq.Size = new System.Drawing.Size(121, 28);
            this.cmdpq.TabIndex = 7;
            this.cmdpq.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(644, 514);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 35);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // EditCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 692);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.cmdpq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbproductPrice);
            this.Controls.Add(this.lbProductname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewedit);
            this.Controls.Add(this.txtIInvoicenumber);
            this.Controls.Add(this.BtnShowData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditCart";
            this.Text = "EditCart";
            this.Load += new System.EventHandler(this.EditCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnShowData;
        private System.Windows.Forms.TextBox txtIInvoicenumber;
        private System.Windows.Forms.DataGridView dataGridViewedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbProductname;
        private System.Windows.Forms.Label lbproductPrice;
        private System.Windows.Forms.ComboBox cmdpq;
        private System.Windows.Forms.Button BtnUpdate;
    }
}