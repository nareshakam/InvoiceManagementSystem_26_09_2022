
namespace InvoiceSystem
{
    partial class LoginPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtPasswordData = new System.Windows.Forms.TextBox();
            this.txtUserNameData = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblUsernameerror = new System.Windows.Forms.Label();
            this.lblpassworderror = new System.Windows.Forms.Label();
            this.CheckPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password :";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(261, 368);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(112, 38);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPasswordData
            // 
            this.txtPasswordData.Location = new System.Drawing.Point(210, 283);
            this.txtPasswordData.Name = "txtPasswordData";
            this.txtPasswordData.Size = new System.Drawing.Size(163, 26);
            this.txtPasswordData.TabIndex = 2;
            this.txtPasswordData.TextChanged += new System.EventHandler(this.txtPasswordData_TextChanged);
            // 
            // txtUserNameData
            // 
            this.txtUserNameData.Location = new System.Drawing.Point(210, 219);
            this.txtUserNameData.Name = "txtUserNameData";
            this.txtUserNameData.Size = new System.Drawing.Size(163, 26);
            this.txtUserNameData.TabIndex = 2;
            this.txtUserNameData.TextChanged += new System.EventHandler(this.txtUserNameData_TextChanged);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(206, 328);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessage.TabIndex = 3;
            this.lblErrorMessage.Visible = false;
            // 
            // lblUsernameerror
            // 
            this.lblUsernameerror.AutoSize = true;
            this.lblUsernameerror.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameerror.Location = new System.Drawing.Point(206, 248);
            this.lblUsernameerror.Name = "lblUsernameerror";
            this.lblUsernameerror.Size = new System.Drawing.Size(0, 20);
            this.lblUsernameerror.TabIndex = 4;
            this.lblUsernameerror.Visible = false;
            // 
            // lblpassworderror
            // 
            this.lblpassworderror.AutoSize = true;
            this.lblpassworderror.ForeColor = System.Drawing.Color.Red;
            this.lblpassworderror.Location = new System.Drawing.Point(212, 312);
            this.lblpassworderror.Name = "lblpassworderror";
            this.lblpassworderror.Size = new System.Drawing.Size(0, 20);
            this.lblpassworderror.TabIndex = 5;
            // 
            // CheckPass
            // 
            this.CheckPass.AutoSize = true;
            this.CheckPass.Location = new System.Drawing.Point(379, 285);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(75, 24);
            this.CheckPass.TabIndex = 6;
            this.CheckPass.Text = "Show";
            this.CheckPass.UseVisualStyleBackColor = true;
            this.CheckPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.CheckPass);
            this.Controls.Add(this.lblpassworderror);
            this.Controls.Add(this.lblUsernameerror);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.txtUserNameData);
            this.Controls.Add(this.txtPasswordData);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtPasswordData;
        private System.Windows.Forms.TextBox txtUserNameData;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblUsernameerror;
        private System.Windows.Forms.Label lblpassworderror;
        private System.Windows.Forms.CheckBox CheckPass;
    }
}