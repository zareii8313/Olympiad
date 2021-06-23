using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Olympiad.forms
{
    public partial class FormCompany : Form
    {
        private string _imgPilot;
        private int _RoleId;
        //کار های مونده
        //1 چک کردن سایز عکس
        //2 ساخت یه یونیکد برای عکس های کپی شده
        //3 گزارشگیری
        //4 ساخت کارت برای مهماندار
        public FormCompany()
        {
            InitializeComponent();
        }

        //Method Path
        private static string path()
        {
            string path = Application.StartupPath + "/imgPilot/";
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        //Method Roles in combo
        private void RolesSource()
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var Roles = from r in dc.tbl_Role
                            select r.r_role;
                comboRole.DataSource = Roles.ToList();
            }
        }

        //Method Red Labels
        private void RedLabels(TextBox txt, Label lbl)
        {
            if (txt.Text == string.Empty)
            {
                lbl.Visible = true;
            }
            else
            {
                lbl.Visible = false;
            }
        }

        //Method NullTxt
        private bool NullTxt()
        {
            if (txtName.Text == string.Empty || txtPassport.Text == string.Empty ||
                txtEmail.Text == string.Empty || txtRecruitment.Text == string.Empty)
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtPassport, lblRedPassport);
                RedLabels(txtEmail, lblRedEmail);
                RedLabels(txtRecruitment, lblRedRecruitment);
                return false;
            }
            else
                return true;
        }

        //Method clear all
        private void ClearAll()
        {
            txtName.Text = txtEmail.Text = txtPassport.Text = txtRecruitment.Text = string.Empty;
            RolesSource();
            imgPilot.Image = Properties.Resources.pilot;
            _imgPilot = string.Empty;
        }

        //Method img size
        private bool imgSize(string imgName)
        {
            string imgPath = path() + imgName;
            int fileLength = Convert.ToInt32(new FileInfo(imgPath).Length);
            //if (fileLength < 1073741824)
            if (fileLength < 100)
            {
                return true;
            }
            else
                return false;
        }

        private void txtPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtPassport.Text.Length == 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

        private void txtRecruitment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtRecruitment.Text.Length == 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            //NotBeNull
            if (!NullTxt())
            {
                return;
            }
            else
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtPassport, lblRedPassport);
                RedLabels(txtEmail, lblRedEmail);
                RedLabels(txtRecruitment, lblRedRecruitment);
            }
            //Passport Lenght
            if (txtPassport.Text.Length < 10)
            {
                MessageBox.Show("شماره پاسپورت یا کدملی باید حتما 10 رقم باشد", "Invalid Passport",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblRedPassport.Visible = true;
                return;
            }
            else
                lblRedPassport.Visible = false;
            //if img was null
            if (string.IsNullOrEmpty(_imgPilot))
            {
                _imgPilot = "pilot.png";
            }
            //check img size
            if (!imgSize(_imgPilot))
            {
                lblErrorImgSize.Visible = true;
                return;
            }
            else
                lblErrorImgSize.Visible = false;

            using (dcAirplane dc = new dcAirplane())
            {
                //Find role id
                var Role = (from r in dc.tbl_Role
                            where r.r_role == comboRole.Text
                            select r).FirstOrDefault();
                _RoleId = Role.r_id;
                //Add pilot
                tbl_Pilot tbl = new tbl_Pilot()
                {
                    p_FullName = txtName.Text,
                    p_Passport = int.Parse(txtPassport.Text),
                    p_email = txtEmail.Text,
                    p_Recruitment = int.Parse(txtRecruitment.Text),
                    p_BirthDate = DateBirth.Value,
                    p_pic = _imgPilot,
                    p_RoleId = _RoleId
                };
                dc.tbl_Pilot.Add(tbl);
                dc.SaveChanges();
                ClearAll();
                //Find the last record
                var lastPilot = (from p in dc.tbl_Pilot
                                 orderby p.p_id
                                 descending
                                 select p).FirstOrDefault();
                if (lastPilot.p_RoleId == 1)
                {
                   
                }
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "image File (*.jpg;*.png;*.bmp;) | *.jpg;*.png;*.bmp";
            openFile.Title = "انتخاب عکس خلبان یا مهماندار";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgPilot.ImageLocation = openFile.FileName;

                //copy img
                try
                {
                    File.Copy(openFile.FileName, path() + openFile.SafeFileName);
                    _imgPilot = openFile.SafeFileName;
                }
                catch (IOException)
                {
                    MessageBox.Show("این عکس قبلا انتخاب شده است \n لطفا عکس دیگری انتخاب کنید",
                        "ExistedImage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("مشکلی پیش آمده است \n لطفا با پشتیبانی تماس بگیرید",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

            }
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            RolesSource();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var lastUser = (from l in dc.tbl_log
                                orderby l.id
                                descending
                                select l).FirstOrDefault();
                DateTime dateTime = DateTime.Now;
                lastUser.logout = dateTime;
                dc.SaveChanges();
            }

            FormMainMenu fmm = new FormMainMenu();
            Hide();
            fmm.ShowDialog();
            Close();
        }
    }
}
