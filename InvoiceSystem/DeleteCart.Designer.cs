
namespace InvoiceSystem
{
    partial class DeleteCart
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
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnShowData = new System.Windows.Forms.Button();
            this.dataGridViewCustmerInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewCartInformation = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustmerInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number :-";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(154, 63);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(118, 20);
            this.txtInvoice.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(515, 66);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(76, 31);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnShowData
            // 
            this.BtnShowData.Location = new System.Drawing.Point(377, 63);
            this.BtnShowData.Name = "BtnShowData";
            this.BtnShowData.Size = new System.Drawing.Size(82, 31);
            this.BtnShowData.TabIndex = 5;
            this.BtnShowData.Text = "Show Data";
            this.BtnShowData.UseVisualStyleBackColor = true;
            this.BtnShowData.Click += new System.EventHandler(this.BtnShowData_Click);
            // 
            // dataGridViewCustmerInformation
            // 
            this.dataGridViewCustmerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustmerInformation.Location = new System.Drawing.Point(60, 120);
            this.dataGridViewCustmerInformation.Name = "dataGridViewCustmerInformation";
            this.dataGridViewCustmerInformation.Size = new System.Drawing.Size(604, 140);
            this.dataGridViewCustmerInformation.TabIndex = 6;
            // 
            // dataGridViewCartInformation
            // 
            this.dataGridViewCartInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartInformation.Location = new System.Drawing.Point(60, 288);
            this.dataGridViewCartInformation.Name = "dataGridViewCartInformation";
            this.dataGridViewCartInformation.Size = new System.Drawing.Size(604, 150);
            this.dataGridViewCartInformation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustmerDetails";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cart Information";
            // 
            // DeleteCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCartInformation);
            this.Controls.Add(this.dataGridViewCustmerInformation);
            this.Controls.Add(this.BtnShowData);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCart";
            this.Text = "DeleteCart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustmerInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnShowData;
        private System.Windows.Forms.DataGridView dataGridViewCustmerInformation;
        private System.Windows.Forms.DataGridView dataGridViewCartInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}