
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
            this.txtNameData = new System.Windows.Forms.TextBox();
            this.dataGridViewInvoicecearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnameerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicecearch)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnScearch
            // 
            this.BtnScearch.Location = new System.Drawing.Point(475, 91);
            this.BtnScearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnScearch.Name = "BtnScearch";
            this.BtnScearch.Size = new System.Drawing.Size(112, 35);
            this.BtnScearch.TabIndex = 0;
            this.BtnScearch.Text = "Scearch";
            this.BtnScearch.UseVisualStyleBackColor = true;
            this.BtnScearch.Click += new System.EventHandler(this.BtnScearch_Click);
            // 
            // txtNameData
            // 
            this.txtNameData.Location = new System.Drawing.Point(200, 91);
            this.txtNameData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameData.Name = "txtNameData";
            this.txtNameData.Size = new System.Drawing.Size(148, 26);
            this.txtNameData.TabIndex = 3;
            this.txtNameData.TextChanged += new System.EventHandler(this.txtNameData_TextChanged);
            // 
            // dataGridViewInvoicecearch
            // 
            this.dataGridViewInvoicecearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicecearch.Location = new System.Drawing.Point(72, 324);
            this.dataGridViewInvoicecearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInvoicecearch.Name = "dataGridViewInvoicecearch";
            this.dataGridViewInvoicecearch.RowHeadersWidth = 62;
            this.dataGridViewInvoicecearch.Size = new System.Drawing.Size(862, 266);
            this.dataGridViewInvoicecearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CustmerName :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnameerror
            // 
            this.lblnameerror.AutoSize = true;
            this.lblnameerror.ForeColor = System.Drawing.Color.Red;
            this.lblnameerror.Location = new System.Drawing.Point(196, 141);
            this.lblnameerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnameerror.Name = "lblnameerror";
            this.lblnameerror.Size = new System.Drawing.Size(0, 20);
            this.lblnameerror.TabIndex = 6;
            this.lblnameerror.Visible = false;
            // 
            // KnowingInvoiceNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 658);
            this.Controls.Add(this.lblnameerror);
            this.Controls.Add(this.dataGridViewInvoicecearch);
            this.Controls.Add(this.txtNameData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnScearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KnowingInvoiceNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnowingInvoiceNumber";
            this.Load += new System.EventHandler(this.KnowingInvoiceNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicecearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScearch;
        private System.Windows.Forms.TextBox txtNameData;
        private System.Windows.Forms.DataGridView dataGridViewInvoicecearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnameerror;
    }
}