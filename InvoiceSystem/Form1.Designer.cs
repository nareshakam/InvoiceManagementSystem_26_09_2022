
namespace InvoiceSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemslbl = new System.Windows.Forms.Label();
            this.noofitemslbl = new System.Windows.Forms.Label();
            this.costofitemlbl = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.NumSuger = new System.Windows.Forms.NumericUpDown();
            this.NumMilk = new System.Windows.Forms.NumericUpDown();
            this.NumBeans = new System.Windows.Forms.NumericUpDown();
            this.NumRice = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSugerAmount = new System.Windows.Forms.Label();
            this.NumBread = new System.Windows.Forms.NumericUpDown();
            this.lblMilkAmount = new System.Windows.Forms.Label();
            this.lblBeansAmount = new System.Windows.Forms.Label();
            this.lblRiceAmount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbSuger = new System.Windows.Forms.Label();
            this.lbMilk = new System.Windows.Forms.Label();
            this.lblBreadAmmount = new System.Windows.Forms.Label();
            this.lbBeans = new System.Windows.Forms.Label();
            this.lbRice = new System.Windows.Forms.Label();
            this.LBread = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRecipt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtReceipt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSuger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBread)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2115, 1034);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.itemslbl);
            this.panel3.Controls.Add(this.noofitemslbl);
            this.panel3.Controls.Add(this.costofitemlbl);
            this.panel3.Controls.Add(this.lblTotalQuantity);
            this.panel3.Controls.Add(this.NumSuger);
            this.panel3.Controls.Add(this.NumMilk);
            this.panel3.Controls.Add(this.NumBeans);
            this.panel3.Controls.Add(this.NumRice);
            this.panel3.Controls.Add(this.lblTotalAmount);
            this.panel3.Controls.Add(this.lblSugerAmount);
            this.panel3.Controls.Add(this.NumBread);
            this.panel3.Controls.Add(this.lblMilkAmount);
            this.panel3.Controls.Add(this.lblBeansAmount);
            this.panel3.Controls.Add(this.lblRiceAmount);
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.lbSuger);
            this.panel3.Controls.Add(this.lbMilk);
            this.panel3.Controls.Add(this.lblBreadAmmount);
            this.panel3.Controls.Add(this.lbBeans);
            this.panel3.Controls.Add(this.lbRice);
            this.panel3.Controls.Add(this.LBread);
            this.panel3.Location = new System.Drawing.Point(13, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 547);
            this.panel3.TabIndex = 0;
            // 
            // itemslbl
            // 
            this.itemslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemslbl.Location = new System.Drawing.Point(-2, 5);
            this.itemslbl.Name = "itemslbl";
            this.itemslbl.Size = new System.Drawing.Size(165, 48);
            this.itemslbl.TabIndex = 6;
            this.itemslbl.Text = "Items";
            // 
            // noofitemslbl
            // 
            this.noofitemslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofitemslbl.Location = new System.Drawing.Point(296, 5);
            this.noofitemslbl.Name = "noofitemslbl";
            this.noofitemslbl.Size = new System.Drawing.Size(227, 48);
            this.noofitemslbl.TabIndex = 5;
            this.noofitemslbl.Text = "No of Items";
            // 
            // costofitemlbl
            // 
            this.costofitemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costofitemlbl.Location = new System.Drawing.Point(609, 5);
            this.costofitemlbl.Name = "costofitemlbl";
            this.costofitemlbl.Size = new System.Drawing.Size(328, 48);
            this.costofitemlbl.TabIndex = 4;
            this.costofitemlbl.Text = "Cost of Items (rs.)";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.BackColor = System.Drawing.Color.White;
            this.lblTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(289, 476);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(220, 46);
            this.lblTotalQuantity.TabIndex = 3;
            this.lblTotalQuantity.Text = "0";
            this.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumSuger
            // 
            this.NumSuger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSuger.Location = new System.Drawing.Point(289, 321);
            this.NumSuger.Name = "NumSuger";
            this.NumSuger.Size = new System.Drawing.Size(220, 35);
            this.NumSuger.TabIndex = 2;
            this.NumSuger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumSuger.ValueChanged += new System.EventHandler(this.NumSuger_ValueChanged);
            // 
            // NumMilk
            // 
            this.NumMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMilk.Location = new System.Drawing.Point(289, 402);
            this.NumMilk.Name = "NumMilk";
            this.NumMilk.Size = new System.Drawing.Size(220, 35);
            this.NumMilk.TabIndex = 2;
            this.NumMilk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumMilk.ValueChanged += new System.EventHandler(this.NumMilk_ValueChanged);
            // 
            // NumBeans
            // 
            this.NumBeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBeans.Location = new System.Drawing.Point(289, 238);
            this.NumBeans.Name = "NumBeans";
            this.NumBeans.Size = new System.Drawing.Size(220, 35);
            this.NumBeans.TabIndex = 2;
            this.NumBeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumBeans.ValueChanged += new System.EventHandler(this.NumBeans_ValueChanged);
            // 
            // NumRice
            // 
            this.NumRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRice.Location = new System.Drawing.Point(289, 156);
            this.NumRice.Name = "NumRice";
            this.NumRice.Size = new System.Drawing.Size(220, 35);
            this.NumRice.TabIndex = 2;
            this.NumRice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumRice.ValueChanged += new System.EventHandler(this.NumRice_ValueChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(645, 472);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(168, 46);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Rs. 0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSugerAmount
            // 
            this.lblSugerAmount.BackColor = System.Drawing.Color.White;
            this.lblSugerAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSugerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugerAmount.Location = new System.Drawing.Point(645, 310);
            this.lblSugerAmount.Name = "lblSugerAmount";
            this.lblSugerAmount.Size = new System.Drawing.Size(168, 46);
            this.lblSugerAmount.TabIndex = 1;
            this.lblSugerAmount.Text = "0.00";
            this.lblSugerAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumBread
            // 
            this.NumBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBread.Location = new System.Drawing.Point(289, 73);
            this.NumBread.Name = "NumBread";
            this.NumBread.Size = new System.Drawing.Size(220, 35);
            this.NumBread.TabIndex = 2;
            this.NumBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumBread.ValueChanged += new System.EventHandler(this.NumBread_ValueChanged);
            // 
            // lblMilkAmount
            // 
            this.lblMilkAmount.BackColor = System.Drawing.Color.White;
            this.lblMilkAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMilkAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilkAmount.Location = new System.Drawing.Point(645, 389);
            this.lblMilkAmount.Name = "lblMilkAmount";
            this.lblMilkAmount.Size = new System.Drawing.Size(168, 46);
            this.lblMilkAmount.TabIndex = 1;
            this.lblMilkAmount.Text = "0.00";
            this.lblMilkAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBeansAmount
            // 
            this.lblBeansAmount.BackColor = System.Drawing.Color.White;
            this.lblBeansAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBeansAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeansAmount.Location = new System.Drawing.Point(645, 227);
            this.lblBeansAmount.Name = "lblBeansAmount";
            this.lblBeansAmount.Size = new System.Drawing.Size(168, 46);
            this.lblBeansAmount.TabIndex = 1;
            this.lblBeansAmount.Text = "0.00";
            this.lblBeansAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRiceAmount
            // 
            this.lblRiceAmount.BackColor = System.Drawing.Color.White;
            this.lblRiceAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiceAmount.Location = new System.Drawing.Point(645, 145);
            this.lblRiceAmount.Name = "lblRiceAmount";
            this.lblRiceAmount.Size = new System.Drawing.Size(168, 46);
            this.lblRiceAmount.TabIndex = 1;
            this.lblRiceAmount.Text = "0.00";
            this.lblRiceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(14, 485);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(165, 48);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total";
            // 
            // lbSuger
            // 
            this.lbSuger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuger.Location = new System.Drawing.Point(14, 323);
            this.lbSuger.Name = "lbSuger";
            this.lbSuger.Size = new System.Drawing.Size(165, 48);
            this.lbSuger.TabIndex = 0;
            this.lbSuger.Text = "Suger";
            // 
            // lbMilk
            // 
            this.lbMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMilk.Location = new System.Drawing.Point(14, 402);
            this.lbMilk.Name = "lbMilk";
            this.lbMilk.Size = new System.Drawing.Size(165, 48);
            this.lbMilk.TabIndex = 0;
            this.lbMilk.Text = "Milk";
            // 
            // lblBreadAmmount
            // 
            this.lblBreadAmmount.BackColor = System.Drawing.Color.White;
            this.lblBreadAmmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBreadAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadAmmount.Location = new System.Drawing.Point(645, 62);
            this.lblBreadAmmount.Name = "lblBreadAmmount";
            this.lblBreadAmmount.Size = new System.Drawing.Size(168, 46);
            this.lblBreadAmmount.TabIndex = 1;
            this.lblBreadAmmount.Text = "0.00";
            this.lblBreadAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBeans
            // 
            this.lbBeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeans.Location = new System.Drawing.Point(14, 240);
            this.lbBeans.Name = "lbBeans";
            this.lbBeans.Size = new System.Drawing.Size(165, 48);
            this.lbBeans.TabIndex = 0;
            this.lbBeans.Text = "Beans";
            // 
            // lbRice
            // 
            this.lbRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRice.Location = new System.Drawing.Point(14, 158);
            this.lbRice.Name = "lbRice";
            this.lbRice.Size = new System.Drawing.Size(165, 48);
            this.lbRice.TabIndex = 0;
            this.lbRice.Text = "Rice";
            // 
            // LBread
            // 
            this.LBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBread.Location = new System.Drawing.Point(14, 75);
            this.LBread.Name = "LBread";
            this.LBread.Size = new System.Drawing.Size(165, 48);
            this.LBread.TabIndex = 0;
            this.LBread.Text = "Bread";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.BtnExit);
            this.panel4.Controls.Add(this.BtnPrint);
            this.panel4.Controls.Add(this.BtnPayment);
            this.panel4.Controls.Add(this.BtnReset);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.BtnRecipt);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.BtnTotal);
            this.panel4.Location = new System.Drawing.Point(11, 690);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1671, 83);
            this.panel4.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Chocolate;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1467, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(197, 68);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Chocolate;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(588, 7);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(282, 68);
            this.BtnPrint.TabIndex = 3;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnPayment
            // 
            this.BtnPayment.BackColor = System.Drawing.Color.Chocolate;
            this.BtnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment.Location = new System.Drawing.Point(1170, 5);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(282, 68);
            this.BtnPayment.TabIndex = 5;
            this.BtnPayment.Text = "Payment";
            this.BtnPayment.UseVisualStyleBackColor = false;
            this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Chocolate;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(880, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(282, 68);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(295, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Recipt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnRecipt_Click);
            // 
            // BtnRecipt
            // 
            this.BtnRecipt.BackColor = System.Drawing.Color.Chocolate;
            this.BtnRecipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecipt.Location = new System.Drawing.Point(340, 5);
            this.BtnRecipt.Name = "BtnRecipt";
            this.BtnRecipt.Size = new System.Drawing.Size(237, 68);
            this.BtnRecipt.TabIndex = 1;
            this.BtnRecipt.Text = "Recipt";
            this.BtnRecipt.UseVisualStyleBackColor = false;
            this.BtnRecipt.Click += new System.EventHandler(this.BtnRecipt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // BtnTotal
            // 
            this.BtnTotal.BackColor = System.Drawing.Color.Chocolate;
            this.BtnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTotal.Location = new System.Drawing.Point(31, 7);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(256, 68);
            this.BtnTotal.TabIndex = 0;
            this.BtnTotal.Text = "Total";
            this.BtnTotal.UseVisualStyleBackColor = false;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.rtReceipt);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1041, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(641, 549);
            this.panel5.TabIndex = 0;
            // 
            // rtReceipt
            // 
            this.rtReceipt.Location = new System.Drawing.Point(42, 62);
            this.rtReceipt.Name = "rtReceipt";
            this.rtReceipt.Size = new System.Drawing.Size(562, 462);
            this.rtReceipt.TabIndex = 0;
            this.rtReceipt.Text = "";
            this.rtReceipt.TextChanged += new System.EventHandler(this.rtReceipt_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Receipt";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(24, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1658, 79);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Chocolate;
            this.label14.Location = new System.Drawing.Point(547, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(546, 64);
            this.label14.TabIndex = 1;
            this.label14.Text = "InvoiceManagement System";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 816);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumSuger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBread)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRecipt;
        private System.Windows.Forms.RichTextBox rtReceipt;
        private System.Windows.Forms.NumericUpDown NumSuger;
        private System.Windows.Forms.NumericUpDown NumMilk;
        private System.Windows.Forms.NumericUpDown NumBeans;
        private System.Windows.Forms.NumericUpDown NumRice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSugerAmount;
        private System.Windows.Forms.NumericUpDown NumBread;
        private System.Windows.Forms.Label lblMilkAmount;
        private System.Windows.Forms.Label lblBeansAmount;
        private System.Windows.Forms.Label lblRiceAmount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbSuger;
        private System.Windows.Forms.Label lbMilk;
        private System.Windows.Forms.Label lblBreadAmmount;
        private System.Windows.Forms.Label lbBeans;
        private System.Windows.Forms.Label lbRice;
        private System.Windows.Forms.Label LBread;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label itemslbl;
        private System.Windows.Forms.Label noofitemslbl;
        private System.Windows.Forms.Label costofitemlbl;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

