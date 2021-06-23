namespace Olympiad.forms
{
    partial class FormOperator
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
            this.btnEditUser = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.imgTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblRedCapacity = new System.Windows.Forms.Label();
            this.lblRedSerial = new System.Windows.Forms.Label();
            this.lblRedYear = new System.Windows.Forms.Label();
            this.lblRedName = new System.Windows.Forms.Label();
            this.btnAddPlane = new FontAwesome.Sharp.IconButton();
            this.btnAddImg = new FontAwesome.Sharp.IconButton();
            this.imgPlane = new System.Windows.Forms.PictureBox();
            this.imgCompany = new System.Windows.Forms.PictureBox();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCompanyPic = new System.Windows.Forms.Label();
            this.lblPlanePic = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblcompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.imgColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
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
            this.panelTitle.TabIndex = 0;
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
            this.imgTitle.IconChar = FontAwesome.Sharp.IconChar.Plane;
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
            this.lblTitle.Size = new System.Drawing.Size(183, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "فرم مشاهده و ثبت هواپیما ها";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelInfo.Controls.Add(this.lblRedCapacity);
            this.panelInfo.Controls.Add(this.lblRedSerial);
            this.panelInfo.Controls.Add(this.lblRedYear);
            this.panelInfo.Controls.Add(this.lblRedName);
            this.panelInfo.Controls.Add(this.btnAddPlane);
            this.panelInfo.Controls.Add(this.btnAddImg);
            this.panelInfo.Controls.Add(this.imgPlane);
            this.panelInfo.Controls.Add(this.imgCompany);
            this.panelInfo.Controls.Add(this.comboCompany);
            this.panelInfo.Controls.Add(this.txtSerial);
            this.panelInfo.Controls.Add(this.txtCapacity);
            this.panelInfo.Controls.Add(this.txtYear);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.lblCompanyPic);
            this.panelInfo.Controls.Add(this.lblPlanePic);
            this.panelInfo.Controls.Add(this.lblSerial);
            this.panelInfo.Controls.Add(this.lblYear);
            this.panelInfo.Controls.Add(this.lblCapacity);
            this.panelInfo.Controls.Add(this.lblcompany);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.dtGrid);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 85);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelInfo.Size = new System.Drawing.Size(484, 378);
            this.panelInfo.TabIndex = 0;
            // 
            // lblRedCapacity
            // 
            this.lblRedCapacity.BackColor = System.Drawing.Color.Red;
            this.lblRedCapacity.Location = new System.Drawing.Point(358, 247);
            this.lblRedCapacity.Name = "lblRedCapacity";
            this.lblRedCapacity.Size = new System.Drawing.Size(10, 23);
            this.lblRedCapacity.TabIndex = 10;
            this.lblRedCapacity.Visible = false;
            // 
            // lblRedSerial
            // 
            this.lblRedSerial.BackColor = System.Drawing.Color.Red;
            this.lblRedSerial.Location = new System.Drawing.Point(112, 167);
            this.lblRedSerial.Name = "lblRedSerial";
            this.lblRedSerial.Size = new System.Drawing.Size(10, 23);
            this.lblRedSerial.TabIndex = 10;
            this.lblRedSerial.Visible = false;
            // 
            // lblRedYear
            // 
            this.lblRedYear.BackColor = System.Drawing.Color.Red;
            this.lblRedYear.Location = new System.Drawing.Point(358, 292);
            this.lblRedYear.Name = "lblRedYear";
            this.lblRedYear.Size = new System.Drawing.Size(10, 23);
            this.lblRedYear.TabIndex = 10;
            this.lblRedYear.Visible = false;
            // 
            // lblRedName
            // 
            this.lblRedName.BackColor = System.Drawing.Color.Red;
            this.lblRedName.Location = new System.Drawing.Point(358, 167);
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
            this.btnAddPlane.Location = new System.Drawing.Point(342, 327);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(110, 40);
            this.btnAddPlane.TabIndex = 9;
            this.btnAddPlane.Text = "ثبت هواپیما";
            this.btnAddPlane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.btnAddImg.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddImg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddImg.IconSize = 30;
            this.btnAddImg.Location = new System.Drawing.Point(105, 337);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddImg.Size = new System.Drawing.Size(30, 30);
            this.btnAddImg.TabIndex = 8;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // imgPlane
            // 
            this.imgPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPlane.Image = global::Olympiad.Properties.Resources.planeIcon1;
            this.imgPlane.Location = new System.Drawing.Point(24, 292);
            this.imgPlane.Name = "imgPlane";
            this.imgPlane.Size = new System.Drawing.Size(75, 75);
            this.imgPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlane.TabIndex = 7;
            this.imgPlane.TabStop = false;
            // 
            // imgCompany
            // 
            this.imgCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCompany.Location = new System.Drawing.Point(24, 206);
            this.imgCompany.Name = "imgCompany";
            this.imgCompany.Size = new System.Drawing.Size(75, 75);
            this.imgCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCompany.TabIndex = 6;
            this.imgCompany.TabStop = false;
            // 
            // comboCompany
            // 
            this.comboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(237, 209);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(121, 21);
            this.comboCompany.TabIndex = 5;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerial.Location = new System.Drawing.Point(12, 167);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(100, 23);
            this.txtSerial.TabIndex = 3;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCapacity.Location = new System.Drawing.Point(237, 247);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(121, 23);
            this.txtCapacity.TabIndex = 3;
            this.txtCapacity.Text = "20";
            this.txtCapacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCapacity_KeyDown);
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYear.Location = new System.Drawing.Point(237, 292);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 23);
            this.txtYear.TabIndex = 3;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(237, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblCompanyPic
            // 
            this.lblCompanyPic.AutoSize = true;
            this.lblCompanyPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCompanyPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblCompanyPic.Location = new System.Drawing.Point(128, 209);
            this.lblCompanyPic.Name = "lblCompanyPic";
            this.lblCompanyPic.Size = new System.Drawing.Size(81, 17);
            this.lblCompanyPic.TabIndex = 2;
            this.lblCompanyPic.Text = "لوگوی شرکت :";
            // 
            // lblPlanePic
            // 
            this.lblPlanePic.AutoSize = true;
            this.lblPlanePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlanePic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblPlanePic.Location = new System.Drawing.Point(128, 295);
            this.lblPlanePic.Name = "lblPlanePic";
            this.lblPlanePic.Size = new System.Drawing.Size(75, 17);
            this.lblPlanePic.TabIndex = 2;
            this.lblPlanePic.Text = "عکس هواپیما :";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblSerial.Location = new System.Drawing.Point(128, 170);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(75, 17);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "شماره سریال :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblYear.Location = new System.Drawing.Point(388, 295);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 17);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "سال ساخت :";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblCapacity.Location = new System.Drawing.Point(374, 250);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(81, 17);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "ظرفیت هواپیما :";
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblcompany.Location = new System.Drawing.Point(364, 206);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(91, 17);
            this.lblcompany.TabIndex = 2;
            this.lblcompany.Text = "شرکت هواپیمایی :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(395, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "نام هواپیما :";
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgColumn});
            this.dtGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.dtGrid.Location = new System.Drawing.Point(12, 17);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RowTemplate.Height = 40;
            this.dtGrid.Size = new System.Drawing.Size(460, 135);
            this.dtGrid.TabIndex = 0;
            // 
            // imgColumn
            // 
            this.imgColumn.HeaderText = "تصویر";
            this.imgColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imgColumn.Name = "imgColumn";
            this.imgColumn.ReadOnly = true;
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مشاهده و ثبت هواپیما";
            this.Load += new System.EventHandler(this.FormOperator_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox imgTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlanePic;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCompanyPic;
        private FontAwesome.Sharp.IconButton btnAddPlane;
        private FontAwesome.Sharp.IconButton btnAddImg;
        private System.Windows.Forms.PictureBox imgPlane;
        private System.Windows.Forms.PictureBox imgCompany;
        private System.Windows.Forms.TextBox txtSerial;
        private FontAwesome.Sharp.IconButton btnEditUser;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblRedCapacity;
        private System.Windows.Forms.Label lblRedSerial;
        private System.Windows.Forms.Label lblRedYear;
        private System.Windows.Forms.Label lblRedName;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.DataGridViewImageColumn imgColumn;
    }
}