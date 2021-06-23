namespace Olympiad.forms
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblInform = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.imgTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnChange = new FontAwesome.Sharp.IconButton();
            this.imgCaptcha = new System.Windows.Forms.PictureBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.timercounter = new System.Windows.Forms.Timer(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelTitle.Controls.Add(this.lblTimer);
            this.panelTitle.Controls.Add(this.lblInform);
            this.panelTitle.Controls.Add(this.btnBack);
            this.panelTitle.Controls.Add(this.imgTitle);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTitle.Size = new System.Drawing.Size(484, 85);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblTimer.Location = new System.Drawing.Point(404, 58);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(19, 13);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "00";
            this.lblTimer.Visible = false;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblInform.Location = new System.Drawing.Point(364, 32);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(108, 13);
            this.lblInform.TabIndex = 9;
            this.lblInform.Text = "ثانیه تا باز شدن صفحه";
            this.lblInform.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "بازگشت";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.imgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgTitle.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.imgTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imgTitle.IconSize = 45;
            this.imgTitle.Location = new System.Drawing.Point(303, 24);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(45, 47);
            this.imgTitle.TabIndex = 1;
            this.imgTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(178, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "فرم ورود کاربران";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelInfo.Controls.Add(this.btnLogin);
            this.panelInfo.Controls.Add(this.btnChange);
            this.panelInfo.Controls.Add(this.imgCaptcha);
            this.panelInfo.Controls.Add(this.txtCaptcha);
            this.panelInfo.Controls.Add(this.txtPassword);
            this.panelInfo.Controls.Add(this.txtUsername);
            this.panelInfo.Controls.Add(this.lblUsername);
            this.panelInfo.Controls.Add(this.lblPassword);
            this.panelInfo.Controls.Add(this.lblCaptcha);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 85);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelInfo.Size = new System.Drawing.Size(484, 378);
            this.panelInfo.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(320, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLogin.Size = new System.Drawing.Size(100, 50);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "ورود";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnChange.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnChange.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChange.Location = new System.Drawing.Point(219, 214);
            this.btnChange.Name = "btnChange";
            this.btnChange.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnChange.Size = new System.Drawing.Size(45, 45);
            this.btnChange.TabIndex = 1;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // imgCaptcha
            // 
            this.imgCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCaptcha.Location = new System.Drawing.Point(93, 214);
            this.imgCaptcha.Name = "imgCaptcha";
            this.imgCaptcha.Size = new System.Drawing.Size(120, 120);
            this.imgCaptcha.TabIndex = 7;
            this.imgCaptcha.TabStop = false;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCaptcha.Location = new System.Drawing.Point(84, 154);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(135, 23);
            this.txtCaptcha.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(84, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.Location = new System.Drawing.Point(84, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 23);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(288, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "نام کاربری / ایمیل :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPassword.Location = new System.Drawing.Point(324, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "رمز عبور :";
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblCaptcha.Location = new System.Drawing.Point(331, 157);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(56, 17);
            this.lblCaptcha.TabIndex = 3;
            this.lblCaptcha.Text = "کد امنیتی :";
            // 
            // timercounter
            // 
            this.timercounter.Interval = 1000;
            this.timercounter.Tick += new System.EventHandler(this.timercounter_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCaptcha;
        private FontAwesome.Sharp.IconPictureBox imgTitle;
        private FontAwesome.Sharp.IconButton btnChange;
        private System.Windows.Forms.PictureBox imgCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblInform;
        private System.Windows.Forms.Timer timercounter;
    }
}