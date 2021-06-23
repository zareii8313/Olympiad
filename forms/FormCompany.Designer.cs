namespace Olympiad.forms
{
    partial class FormCompany
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.DateBirth = new System.Windows.Forms.DateTimePicker();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.lblErrorImgSize = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRedPassport = new System.Windows.Forms.Label();
            this.lblRedEmail = new System.Windows.Forms.Label();
            this.lblRedRecruitment = new System.Windows.Forms.Label();
            this.lblRedName = new System.Windows.Forms.Label();
            this.btnAddPlane = new FontAwesome.Sharp.IconButton();
            this.btnAddImg = new FontAwesome.Sharp.IconButton();
            this.imgPilot = new System.Windows.Forms.PictureBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRecruitment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPersonnelPic = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblRecruitment = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnEditUser = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.imgTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRedImageSize = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilot)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelInfo.Controls.Add(this.DateBirth);
            this.panelInfo.Controls.Add(this.comboRole);
            this.panelInfo.Controls.Add(this.lblErrorImgSize);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Controls.Add(this.lblRedPassport);
            this.panelInfo.Controls.Add(this.lblRedEmail);
            this.panelInfo.Controls.Add(this.lblRedImageSize);
            this.panelInfo.Controls.Add(this.lblRedRecruitment);
            this.panelInfo.Controls.Add(this.lblRedName);
            this.panelInfo.Controls.Add(this.btnAddPlane);
            this.panelInfo.Controls.Add(this.btnAddImg);
            this.panelInfo.Controls.Add(this.imgPilot);
            this.panelInfo.Controls.Add(this.txtPassport);
            this.panelInfo.Controls.Add(this.txtEmail);
            this.panelInfo.Controls.Add(this.txtRecruitment);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.lblPersonnelPic);
            this.panelInfo.Controls.Add(this.lblEmail);
            this.panelInfo.Controls.Add(this.lblBirth);
            this.panelInfo.Controls.Add(this.lblRecruitment);
            this.panelInfo.Controls.Add(this.lblPassport);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 85);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelInfo.Size = new System.Drawing.Size(484, 378);
            this.panelInfo.TabIndex = 1;
            // 
            // DateBirth
            // 
            this.DateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirth.Location = new System.Drawing.Point(31, 101);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateBirth.Size = new System.Drawing.Size(97, 20);
            this.DateBirth.TabIndex = 19;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(14, 168);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(121, 21);
            this.comboRole.TabIndex = 13;
            // 
            // lblErrorImgSize
            // 
            this.lblErrorImgSize.AutoSize = true;
            this.lblErrorImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorImgSize.ForeColor = System.Drawing.Color.White;
            this.lblErrorImgSize.Location = new System.Drawing.Point(23, 350);
            this.lblErrorImgSize.Name = "lblErrorImgSize";
            this.lblErrorImgSize.Size = new System.Drawing.Size(207, 17);
            this.lblErrorImgSize.TabIndex = 11;
            this.lblErrorImgSize.Text = "سایز تصویر نباید بیشتر از 1 گیگابایت باشد.";
            this.lblErrorImgSize.Visible = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblRole.Location = new System.Drawing.Point(166, 168);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 17);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "نقش :";
            // 
            // lblRedPassport
            // 
            this.lblRedPassport.BackColor = System.Drawing.Color.Red;
            this.lblRedPassport.Location = new System.Drawing.Point(358, 101);
            this.lblRedPassport.Name = "lblRedPassport";
            this.lblRedPassport.Size = new System.Drawing.Size(10, 23);
            this.lblRedPassport.TabIndex = 10;
            this.lblRedPassport.Visible = false;
            // 
            // lblRedEmail
            // 
            this.lblRedEmail.BackColor = System.Drawing.Color.Red;
            this.lblRedEmail.Location = new System.Drawing.Point(133, 25);
            this.lblRedEmail.Name = "lblRedEmail";
            this.lblRedEmail.Size = new System.Drawing.Size(10, 23);
            this.lblRedEmail.TabIndex = 10;
            this.lblRedEmail.Visible = false;
            // 
            // lblRedRecruitment
            // 
            this.lblRedRecruitment.BackColor = System.Drawing.Color.Red;
            this.lblRedRecruitment.Location = new System.Drawing.Point(358, 165);
            this.lblRedRecruitment.Name = "lblRedRecruitment";
            this.lblRedRecruitment.Size = new System.Drawing.Size(10, 23);
            this.lblRedRecruitment.TabIndex = 10;
            this.lblRedRecruitment.Visible = false;
            // 
            // lblRedName
            // 
            this.lblRedName.BackColor = System.Drawing.Color.Red;
            this.lblRedName.Location = new System.Drawing.Point(358, 25);
            this.lblRedName.Name = "lblRedName";
            this.lblRedName.Size = new System.Drawing.Size(10, 23);
            this.lblRedName.TabIndex = 10;
            this.lblRedName.Visible = false;
            // 
            // btnAddPlane
            // 
            this.btnAddPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddPlane.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddPlane.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddPlane.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPlane.IconSize = 40;
            this.btnAddPlane.Location = new System.Drawing.Point(300, 276);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(150, 52);
            this.btnAddPlane.TabIndex = 9;
            this.btnAddPlane.Text = "ثبت خلبان / مهماندار";
            this.btnAddPlane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddImg.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddImg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddImg.IconSize = 30;
            this.btnAddImg.Location = new System.Drawing.Point(112, 310);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddImg.Size = new System.Drawing.Size(30, 30);
            this.btnAddImg.TabIndex = 8;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // imgPilot
            // 
            this.imgPilot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPilot.Image = global::Olympiad.Properties.Resources.pilot;
            this.imgPilot.Location = new System.Drawing.Point(31, 265);
            this.imgPilot.Name = "imgPilot";
            this.imgPilot.Size = new System.Drawing.Size(75, 75);
            this.imgPilot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilot.TabIndex = 7;
            this.imgPilot.TabStop = false;
            // 
            // txtPassport
            // 
            this.txtPassport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassport.Location = new System.Drawing.Point(237, 101);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(121, 23);
            this.txtPassport.TabIndex = 3;
            this.txtPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassport_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.Location = new System.Drawing.Point(12, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtRecruitment
            // 
            this.txtRecruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtRecruitment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRecruitment.Location = new System.Drawing.Point(237, 165);
            this.txtRecruitment.Name = "txtRecruitment";
            this.txtRecruitment.Size = new System.Drawing.Size(121, 23);
            this.txtRecruitment.TabIndex = 3;
            this.txtRecruitment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecruitment_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(237, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblPersonnelPic
            // 
            this.lblPersonnelPic.AutoSize = true;
            this.lblPersonnelPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonnelPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPersonnelPic.Location = new System.Drawing.Point(112, 241);
            this.lblPersonnelPic.Name = "lblPersonnelPic";
            this.lblPersonnelPic.Size = new System.Drawing.Size(118, 17);
            this.lblPersonnelPic.TabIndex = 2;
            this.lblPersonnelPic.Text = "عکس خلبان / مهماندار :\r\n";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblEmail.Location = new System.Drawing.Point(164, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "ایمیل :";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblBirth.Location = new System.Drawing.Point(146, 104);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(55, 17);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "سال تولد :";
            // 
            // lblRecruitment
            // 
            this.lblRecruitment.AutoSize = true;
            this.lblRecruitment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecruitment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblRecruitment.Location = new System.Drawing.Point(399, 168);
            this.lblRecruitment.Name = "lblRecruitment";
            this.lblRecruitment.Size = new System.Drawing.Size(73, 17);
            this.lblRecruitment.TabIndex = 2;
            this.lblRecruitment.Text = "سال استخدام :";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPassport.Location = new System.Drawing.Point(371, 104);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(101, 17);
            this.lblPassport.TabIndex = 2;
            this.lblPassport.Text = "کد ملی یا پاسپورت :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(374, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "نام و نام خانوادگی :";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelTitle.Controls.Add(this.btnEditUser);
            this.panelTitle.Controls.Add(this.btnBack);
            this.panelTitle.Controls.Add(this.imgTitle);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTitle.Size = new System.Drawing.Size(484, 85);
            this.panelTitle.TabIndex = 2;
            // 
            // btnEditUser
            // 
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnEditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUser.Location = new System.Drawing.Point(364, 19);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(110, 50);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "ویرایش پروفایل";
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(12, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "بازگشت";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.imgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgTitle.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.imgTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.imgTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imgTitle.IconSize = 38;
            this.imgTitle.Location = new System.Drawing.Point(225, 41);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(41, 38);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgTitle.TabIndex = 2;
            this.imgTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "فرم ثبت خلبانان و مهمانداران\r\n";
            // 
            // lblRedImageSize
            // 
            this.lblRedImageSize.BackColor = System.Drawing.Color.Red;
            this.lblRedImageSize.Location = new System.Drawing.Point(236, 350);
            this.lblRedImageSize.Name = "lblRedImageSize";
            this.lblRedImageSize.Size = new System.Drawing.Size(10, 23);
            this.lblRedImageSize.TabIndex = 10;
            this.lblRedImageSize.Visible = false;
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompany";
            this.Load += new System.EventHandler(this.FormCompany_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilot)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblRedPassport;
        private System.Windows.Forms.Label lblRedRecruitment;
        private System.Windows.Forms.Label lblRedName;
        private FontAwesome.Sharp.IconButton btnAddPlane;
        private FontAwesome.Sharp.IconButton btnAddImg;
        private System.Windows.Forms.PictureBox imgPilot;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtRecruitment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPersonnelPic;
        private System.Windows.Forms.Label lblRecruitment;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnEditUser;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconPictureBox imgTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRedEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DateTimePicker DateBirth;
        private System.Windows.Forms.Label lblErrorImgSize;
        private System.Windows.Forms.Label lblRedImageSize;
    }
}