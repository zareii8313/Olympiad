namespace Olympiad.forms
{
    partial class FormSignin
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.imgSignUp = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblRedBirth = new System.Windows.Forms.Label();
            this.DateBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddImg = new FontAwesome.Sharp.IconButton();
            this.lblRedUsername = new System.Windows.Forms.Label();
            this.lblRedPassword2 = new System.Windows.Forms.Label();
            this.lblRedPassword = new System.Windows.Forms.Label();
            this.lblRedName = new System.Windows.Forms.Label();
            this.btnSignUp = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.txtUserType = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblUserpic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignUp)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelTitle.Controls.Add(this.imgSignUp);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTitle.Size = new System.Drawing.Size(484, 85);
            this.panelTitle.TabIndex = 0;
            // 
            // imgSignUp
            // 
            this.imgSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.imgSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgSignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.imgSignUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imgSignUp.IconSize = 55;
            this.imgSignUp.Location = new System.Drawing.Point(283, 17);
            this.imgSignUp.Name = "imgSignUp";
            this.imgSignUp.Size = new System.Drawing.Size(58, 55);
            this.imgSignUp.TabIndex = 1;
            this.imgSignUp.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(161, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "فرم ثبت نام کاربر";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelInfo.Controls.Add(this.lblRedBirth);
            this.panelInfo.Controls.Add(this.DateBirth);
            this.panelInfo.Controls.Add(this.btnAddImg);
            this.panelInfo.Controls.Add(this.lblRedUsername);
            this.panelInfo.Controls.Add(this.lblRedPassword2);
            this.panelInfo.Controls.Add(this.lblRedPassword);
            this.panelInfo.Controls.Add(this.lblRedName);
            this.panelInfo.Controls.Add(this.btnSignUp);
            this.panelInfo.Controls.Add(this.btnBack);
            this.panelInfo.Controls.Add(this.imgUser);
            this.panelInfo.Controls.Add(this.txtUserType);
            this.panelInfo.Controls.Add(this.txtUsername);
            this.panelInfo.Controls.Add(this.txtPassword2);
            this.panelInfo.Controls.Add(this.txtPassword);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.lblUserType);
            this.panelInfo.Controls.Add(this.lblUsername);
            this.panelInfo.Controls.Add(this.lblPassword2);
            this.panelInfo.Controls.Add(this.lblPassword);
            this.panelInfo.Controls.Add(this.lblBirth);
            this.panelInfo.Controls.Add(this.lblUserpic);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 85);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelInfo.Size = new System.Drawing.Size(484, 376);
            this.panelInfo.TabIndex = 0;
            // 
            // lblRedBirth
            // 
            this.lblRedBirth.BackColor = System.Drawing.Color.Red;
            this.lblRedBirth.Location = new System.Drawing.Point(109, 31);
            this.lblRedBirth.Name = "lblRedBirth";
            this.lblRedBirth.Size = new System.Drawing.Size(10, 23);
            this.lblRedBirth.TabIndex = 16;
            this.lblRedBirth.Visible = false;
            // 
            // DateBirth
            // 
            this.DateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirth.Location = new System.Drawing.Point(12, 32);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateBirth.Size = new System.Drawing.Size(97, 20);
            this.DateBirth.TabIndex = 18;
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddImg.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddImg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddImg.IconSize = 30;
            this.btnAddImg.Location = new System.Drawing.Point(128, 232);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddImg.Size = new System.Drawing.Size(30, 30);
            this.btnAddImg.TabIndex = 17;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // lblRedUsername
            // 
            this.lblRedUsername.BackColor = System.Drawing.Color.Red;
            this.lblRedUsername.Location = new System.Drawing.Point(355, 221);
            this.lblRedUsername.Name = "lblRedUsername";
            this.lblRedUsername.Size = new System.Drawing.Size(10, 23);
            this.lblRedUsername.TabIndex = 16;
            this.lblRedUsername.Visible = false;
            // 
            // lblRedPassword2
            // 
            this.lblRedPassword2.BackColor = System.Drawing.Color.Red;
            this.lblRedPassword2.Location = new System.Drawing.Point(355, 162);
            this.lblRedPassword2.Name = "lblRedPassword2";
            this.lblRedPassword2.Size = new System.Drawing.Size(10, 23);
            this.lblRedPassword2.TabIndex = 16;
            this.lblRedPassword2.Visible = false;
            // 
            // lblRedPassword
            // 
            this.lblRedPassword.BackColor = System.Drawing.Color.Red;
            this.lblRedPassword.Location = new System.Drawing.Point(355, 98);
            this.lblRedPassword.Name = "lblRedPassword";
            this.lblRedPassword.Size = new System.Drawing.Size(10, 23);
            this.lblRedPassword.TabIndex = 16;
            this.lblRedPassword.Visible = false;
            // 
            // lblRedName
            // 
            this.lblRedName.BackColor = System.Drawing.Color.Red;
            this.lblRedName.Location = new System.Drawing.Point(355, 32);
            this.lblRedName.Name = "lblRedName";
            this.lblRedName.Size = new System.Drawing.Size(10, 23);
            this.lblRedName.TabIndex = 16;
            this.lblRedName.Visible = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnSignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnSignUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUp.Location = new System.Drawing.Point(346, 303);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(110, 50);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "ثبت نام";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(27, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "بازگشت";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgUser
            // 
            this.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUser.Image = global::Olympiad.Properties.Resources.user;
            this.imgUser.Location = new System.Drawing.Point(22, 162);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(100, 100);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 15;
            this.imgUser.TabStop = false;
            // 
            // txtUserType
            // 
            this.txtUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUserType.FormattingEnabled = true;
            this.txtUserType.Location = new System.Drawing.Point(12, 100);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(113, 21);
            this.txtUserType.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUsername.Location = new System.Drawing.Point(226, 221);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 23);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword2.Location = new System.Drawing.Point(226, 162);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.ShortcutsEnabled = false;
            this.txtPassword2.Size = new System.Drawing.Size(129, 23);
            this.txtPassword2.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(226, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(129, 23);
            this.txtPassword.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(226, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 23);
            this.txtName.TabIndex = 12;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblUserType.Location = new System.Drawing.Point(131, 101);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(72, 17);
            this.lblUserType.TabIndex = 11;
            this.lblUserType.Text = "نوع کاربری :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(403, 227);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 17);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "نام کاربری :";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPassword2.Location = new System.Drawing.Point(376, 162);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(93, 17);
            this.lblPassword2.TabIndex = 11;
            this.lblPassword2.Text = "تکرار رمز عبور :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPassword.Location = new System.Drawing.Point(406, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 17);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "رمز عبور :";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblBirth.Location = new System.Drawing.Point(142, 35);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(61, 17);
            this.lblBirth.TabIndex = 11;
            this.lblBirth.Text = "تاریخ تولد :";
            // 
            // lblUserpic
            // 
            this.lblUserpic.AutoSize = true;
            this.lblUserpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserpic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblUserpic.Location = new System.Drawing.Point(161, 168);
            this.lblUserpic.Name = "lblUserpic";
            this.lblUserpic.Size = new System.Drawing.Size(42, 17);
            this.lblUserpic.TabIndex = 11;
            this.lblUserpic.Text = "عکس :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(371, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "نام و نام خانوادگی :";
            // 
            // FormSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormSignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت نام کاربر";
            this.Load += new System.EventHandler(this.FormSignin_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignUp)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox imgSignUp;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblUserpic;
        private FontAwesome.Sharp.IconButton btnSignUp;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.ComboBox txtUserType;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRedBirth;
        private System.Windows.Forms.Label lblRedUsername;
        private System.Windows.Forms.Label lblRedPassword2;
        private System.Windows.Forms.Label lblRedPassword;
        private System.Windows.Forms.Label lblRedName;
        private FontAwesome.Sharp.IconButton btnAddImg;
        private System.Windows.Forms.DateTimePicker DateBirth;
    }
}