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
    public partial class FormSignin : Form
    {
        private string _imguser;
        public FormSignin()
        {
            InitializeComponent();
        }

        private void FormSignin_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        //combobox datasource
        private void TypeSource()
        {
            //combobox
            using (dcAirplane dc = new dcAirplane())
            {
                var UserTypes = from t in dc.UserType
                                select t.Name;
                txtUserType.DataSource = UserTypes.ToList();
            }
        }

        //methos valid username
        private static bool ValidUsernsme(string username)
        {
            if (username.Length <= 5)
            {
                MessageBox.Show("نام کاربری باید بیش از 5 کاراکتر باشد"
                    , "InvalidLength", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            using (dcAirplane dc = new dcAirplane())
            {
                var users = (from u in dc.User
                            where u.Username==username
                            select u).FirstOrDefault();
                if (users==null)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("نام کاربری وارد شده موجود می باشد \n لطفا نام دیگری وارد کنید ",
                        "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
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
            if (txtName.Text == string.Empty || txtPassword.Text == string.Empty ||
                txtPassword2.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtPassword, lblRedPassword);
                RedLabels(txtPassword2, lblRedPassword2);
                RedLabels(txtUsername, lblRedUsername);
                return false;
            }
            else
                return true;
        }

        //Method Repeat Password
        private bool RepeatPassword(TextBox txt1, TextBox txt2)
        {
            if (txt1.Text == txt2.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("رمز تکرار شده با رمز عبور مطابقت ندارد",
                    "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Method Valid Age
        private bool ValidAge(DateTime UserDate)
        {
            DateTime NowDate = DateTime.Now;
            TimeSpan time = NowDate - UserDate;
            if (time.Days > 6570)
            {
                return true;
            }
            else
            {
                MessageBox.Show("سن کاربر باید بالای 18 سال باشد", "Invalid Age",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Method Clear All
        private void ClearAll()
        {
            txtName.Text = txtPassword.Text = txtPassword2.Text = txtUsername.Text = string.Empty;
            DateBirth.Value = DateTime.Now;
            TypeSource();
            imgUser.Image = Properties.Resources.user;
            _imguser = string.Empty;
        }

        //Method Path
        private static string path()
        {
            string path = Application.StartupPath + "/imgUser/";
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Not Be Null
            if (!NullTxt())
            {
                return;
            }
            else
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtPassword, lblRedPassword);
                RedLabels(txtPassword2, lblRedPassword2);
                RedLabels(txtUsername, lblRedUsername);
            }
            //Username
            if (!ValidUsernsme(txtUsername.Text))
            {
                lblRedUsername.Visible = true;
                return;
            }
            else
                lblRedUsername.Visible = false;
            //password
            if (!classes.ClassSigninPassword.ValidPassword(txtPassword.Text))
            {
                lblRedPassword.Visible = true;
                return;
            }
            else
                lblRedPassword.Visible = false;
            //password2
            if (!RepeatPassword(txtPassword, txtPassword2))
            {
                lblRedPassword2.Visible = true;
                return;
            }
            else
                lblRedPassword2.Visible = false;
            //age
            if (!ValidAge(DateBirth.Value))
            {
                lblRedBirth.Visible = true;
                return;
            }
            else
                lblRedBirth.Visible = false;
            //img
            if (string.IsNullOrEmpty(_imguser))
            {
                _imguser = "user.png";
            }

            try
            {
                using (dcAirplane dc = new dcAirplane())
                {
                    var Type = (from t in dc.UserType
                                where t.Name == txtUserType.Text
                                select t).FirstOrDefault();
                    User tblUser = new User()
                    {
                        FullName = txtName.Text,
                        PassWord = txtPassword.Text,
                        Username = txtUsername.Text,
                        TypeId = Type.Id,
                        Birthdate=DateBirth.Value
                    };
                    dc.User.Add(tblUser);
                    dc.SaveChanges();

                    var LastUsere = (from u in dc.User
                                     orderby u.Id
                                     descending
                                     select u).FirstOrDefault();
                    tbl_employee tbl = new tbl_employee()
                    {
                        e_pic = _imguser,
                        idu = LastUsere.Id
                    };
                    dc.tbl_employee.Add(tbl);
                    dc.SaveChanges();
                    ClearAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "image file (*.jpg;*.png) | *.jpg;*.png";
            openFile.Title = "انتخاب عکس کاربر";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgUser.ImageLocation = openFile.FileName;
                //cope img
                try
                {
                    File.Copy(openFile.FileName, path() + openFile.SafeFileName);
                    _imguser = openFile.SafeFileName;
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
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            Hide();
            fl.ShowDialog();
            Close();
        }
    }
}
