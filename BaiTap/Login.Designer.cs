
namespace BaiTap
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbCashier = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(536, 266);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 49);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(455, 266);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(55, 49);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackColor = System.Drawing.Color.Silver;
            this.rdbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rdbAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbAdmin.Location = new System.Drawing.Point(306, 308);
            this.rdbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(81, 22);
            this.rdbAdmin.TabIndex = 12;
            this.rdbAdmin.Text = "Quản Lý";
            this.rdbAdmin.UseVisualStyleBackColor = false;
            // 
            // rdbCashier
            // 
            this.rdbCashier.AutoSize = true;
            this.rdbCashier.BackColor = System.Drawing.Color.Silver;
            this.rdbCashier.Checked = true;
            this.rdbCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rdbCashier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbCashier.Location = new System.Drawing.Point(306, 266);
            this.rdbCashier.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCashier.Name = "rdbCashier";
            this.rdbCashier.Size = new System.Drawing.Size(87, 22);
            this.rdbCashier.TabIndex = 11;
            this.rdbCashier.TabStop = true;
            this.rdbCashier.Text = "Thu ngân";
            this.rdbCashier.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txtPassword.Location = new System.Drawing.Point(300, 194);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(291, 32);
            this.txtPassword.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMatKhau.Location = new System.Drawing.Point(173, 201);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(87, 17);
            this.lblMatKhau.TabIndex = 10;
            this.lblMatKhau.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txtUsername.Location = new System.Drawing.Point(300, 107);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(291, 32);
            this.txtUsername.TabIndex = 8;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTaiKhoan.Location = new System.Drawing.Point(173, 114);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(93, 17);
            this.lblTaiKhoan.TabIndex = 7;
            this.lblTaiKhoan.Text = "UserName:";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.rdbCashier);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblTaiKhoan);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbCashier;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblTaiKhoan;
    }
}