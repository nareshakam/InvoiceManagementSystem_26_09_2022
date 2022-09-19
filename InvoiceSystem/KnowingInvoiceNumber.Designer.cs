
namespace InvoiceSystem
{
    partial class KnowingInvoiceNumber
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
            this.BtnScearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameData = new System.Windows.Forms.TextBox();
            this.txtdatedata = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInvoicecearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicecearch)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnScearch
            // 
            this.BtnScearch.Location = new System.Drawing.Point(358, 147);
            this.BtnScearch.Name = "BtnScearch";
            this.BtnScearch.Size = new System.Drawing.Size(75, 23);
            this.BtnScearch.TabIndex = 0;
            this.BtnScearch.Text = "Scearch";
            this.BtnScearch.UseVisualStyleBackColor = true;
            this.BtnScearch.Click += new System.EventHandler(this.BtnScearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CustmerName :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :-";
            // 
            // txtNameData
            // 
            this.txtNameData.Location = new System.Drawing.Point(133, 59);
            this.txtNameData.Name = "txtNameData";
            this.txtNameData.Size = new System.Drawing.Size(100, 20);
            this.txtNameData.TabIndex = 3;
            this.txtNameData.TextChanged += new System.EventHandler(this.txtNameData_TextChanged);
            // 
            // txtdatedata
            // 
            this.txtdatedata.CustomFormat = "yyyy-MM-dd";
            this.txtdatedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdatedata.Location = new System.Drawing.Point(325, 59);
            this.txtdatedata.Name = "txtdatedata";
            this.txtdatedata.Size = new System.Drawing.Size(108, 20);
            this.txtdatedata.TabIndex = 4;
            // 
            // dataGridViewInvoicecearch
            // 
            this.dataGridViewInvoicecearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicecearch.Location = new System.Drawing.Point(48, 220);
            this.dataGridViewInvoicecearch.Name = "dataGridViewInvoicecearch";
            this.dataGridViewInvoicecearch.Size = new System.Drawing.Size(385, 173);
            this.dataGridViewInvoicecearch.TabIndex = 5;
            // 
            // KnowingInvoiceNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 428);
            this.Controls.Add(this.dataGridViewInvoicecearch);
            this.Controls.Add(this.txtdatedata);
            this.Controls.Add(this.txtNameData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnScearch);
            this.Name = "KnowingInvoiceNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnowingInvoiceNumber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicecearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameData;
        private System.Windows.Forms.DateTimePicker txtdatedata;
        private System.Windows.Forms.DataGridView dataGridViewInvoicecearch;
    }
}