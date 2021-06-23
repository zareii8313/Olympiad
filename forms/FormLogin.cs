using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympiad.forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        


        //Method Login
        private void UserLogin(string username)
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var findUser = (from u in dc.User
                              where u.Username == username
                              select u).FirstOrDefault();
                int idu = findUser.Id;
                DateTime dateTime = DateTime.Now;
                tbl_log tbl = new tbl_log()
                {
                    userid=idu,
                    login=dateTime,
                };
                dc.tbl_log.Add(tbl);
                dc.SaveChanges();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //create captcha img
            imgCaptcha.Image = classes.ClassCaptcha.createImg();
            //checking counter
            using (dcAirplane dc = new dcAirplane())
            {
                var lastLogin = (from i in dc.tbl_Incorrectlogin
                                 orderby i.id
                                 descending
                                 select i).FirstOrDefault();
                if (lastLogin != null)
                {
                    _counter = lastLogin.count;
                    _seconds = lastLogin.time;
                }
                else
                {
                    _counter = 0;
                    _seconds = 30;
                }
                if (_counter > 2)
                {
                    panelInfo.Enabled = false;
                    timercounter.Enabled = true;
                }
            }
        }

        int _counter = 0;
        int _seconds = 30;

        private void btnChange_Click(object sender, EventArgs e)
        {
            imgCaptcha.Image = classes.ClassCaptcha.createImg();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text)&&String.IsNullOrEmpty(txtPassword.Text))
            {
                FormSignin fs = new FormSignin();
                Hide();
                fs.ShowDialog();
                Close();
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("لطفا فیلد های خالی را پر کنید",
                    "EmptyFields",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            bool any;
            using (dcAirplane dc = new dcAirplane())
            {
                any = dc.User.Any(u => u.Username == txtUsername.Text);
                if (!any)
                {
                    MessageBox.Show("نام کاربری وارد شده در سیستم موجود نمی باشد",
                        "UserNotFound",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                var userInfo = (from u in dc.User
                                where u.Username == txtUsername.Text
                                select u).FirstOrDefault();
                if (userInfo.PassWord==txtPassword.Text)
                {
                    if (classes.ClassCaptcha.validate(txtCaptcha.Text))
                    {
                        switch (userInfo.TypeId)
                        {
                            case 1:
                                {
                                    UserLogin(txtUsername.Text);
                                    FormManager fm = new FormManager();
                                    Hide();
                                    fm.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 2:
                                {
                                    UserLogin(txtUsername.Text);
                                    FormCompany fc = new FormCompany();
                                    Hide();
                                    fc.ShowDialog();
                                    Close();
                                    break;
                                }
                            case 3:
                                {
                                    UserLogin(txtUsername.Text);
                                    FormOperator fo = new FormOperator();
                                    Hide();
                                    fo.ShowDialog();
                                    Close();
                                    break;
                                }
                            default:
                                MessageBox.Show("سفحه کاربری برای شما در نظر گرفته نشده است",
                                    "UserTypeNotFound",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("کد امنیتی وارد شده صحیح نمی باشد",
                            "InvalidCaptchaCode",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("رمز عبور وارد شده صحیح نمی باشد",
                        "InvalidPassword",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    _counter++;
                }

                if (_counter>2)
                {
                    panelInfo.Enabled = false;
                    timercounter.Enabled = true;
                }
            }
            using (dcAirplane dc= new dcAirplane())
            {
                tbl_Incorrectlogin tbi = new tbl_Incorrectlogin()
                {
                    count=_counter,
                    time=_seconds
                };
                dc.tbl_Incorrectlogin.Add(tbi);
                dc.SaveChanges();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu fmm = new FormMainMenu();
            Hide();
            fmm.ShowDialog();
            Close();
        }

        private void timercounter_Tick(object sender, EventArgs e)
        {
            lblInform.Visible = true;
            lblTimer.Visible = true;
            lblTimer.Text = _seconds.ToString();
            _seconds--;
            if (_seconds==0)
            {
                panelInfo.Enabled = true;
                _seconds = 30;
                _counter = 0; 
                lblTimer.Visible = false;
                lblInform.Visible = false;
                timercounter.Enabled = false;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save lock time
            using (dcAirplane dc = new dcAirplane())
            {
                tbl_Incorrectlogin tbi = new tbl_Incorrectlogin()
                {
                    count = _counter,
                    time = _seconds
                };
                dc.tbl_Incorrectlogin.Add(tbi);
                dc.SaveChanges();
            }
        }
    }
}
