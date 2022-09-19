
namespace InvoiceSystem
{
    partial class HomePageForm
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
            this.BtnScearch = new System.Windows.Forms.Button();
            this.dataGridViewscarch = new System.Windows.Forms.DataGridView();
            this.txtInvoiceNumberData = new System.Windows.Forms.TextBox();
            this.txtNamedata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewscarch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "InvoiceNumber :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custmer Name :-";
            // 
            // BtnScearch
            // 
            this.BtnScearch.Location = new System.Drawing.Point(856, 49);
            this.BtnScearch.Name = "BtnScearch";
            this.BtnScearch.Size = new System.Drawing.Size(117, 44);
            this.BtnScearch.TabIndex = 2;
            this.BtnScearch.Text = "Scearch";
            this.BtnScearch.UseVisualStyleBackColor = true;
            this.BtnScearch.Click += new System.EventHandler(this.BtnScearch_Click);
            // 
            // dataGridViewscarch
            // 
            this.dataGridViewscarch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewscarch.Location = new System.Drawing.Point(100, 156);
            this.dataGridViewscarch.Name = "dataGridViewscarch";
            this.dataGridViewscarch.RowHeadersWidth = 62;
            this.dataGridViewscarch.RowTemplate.Height = 28;
            this.dataGridViewscarch.Size = new System.Drawing.Size(873, 281);
            this.dataGridViewscarch.TabIndex = 3;
            // 
            // txtInvoiceNumberData
            // 
            this.txtInvoiceNumberData.Location = new System.Drawing.Point(262, 61);
            this.txtInvoiceNumberData.MaxLength = 7;
            this.txtInvoiceNumberData.Name = "txtInvoiceNumberData";
            this.txtInvoiceNumberData.Size = new System.Drawing.Size(175, 26);
            this.txtInvoiceNumberData.TabIndex = 4;
            // 
            // txtNamedata
            // 
            this.txtNamedata.Location = new System.Drawing.Point(634, 58);
            this.txtNamedata.Name = "txtNamedata";
            this.txtNamedata.Size = new System.Drawing.Size(175, 26);
            this.txtNamedata.TabIndex = 5;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 659);
            this.Controls.Add(this.txtNamedata);
            this.Controls.Add(this.txtInvoiceNumberData);
            this.Controls.Add(this.dataGridViewscarch);
            this.Controls.Add(this.BtnScearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewscarch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnScearch;
        private System.Windows.Forms.DataGridView dataGridViewscarch;
        private System.Windows.Forms.TextBox txtInvoiceNumberData;
        private System.Windows.Forms.TextBox txtNamedata;
    }
}