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
    public partial class FormOperator : Form
    {
        private string _imgName;
        private int _idCompany;
        public FormOperator()
        {
            InitializeComponent();
        }

        //path
        private static string path()
        {
            string path = Application.StartupPath + "/imgPlane/";
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        //Method connect
        private void connect()
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var planes = from p in dc.Plane
                             join c in dc.Company
                             on p.CompanyId equals c.Id
                             join m in dc.tbl_planeMoreInfo
                             on p.Id equals m.idp
                             select new
                             {
                                 p.Id,
                                 p.pName,
                                 c.cName,
                                 m.year,
                                 m.Serial
                             };
                dtGrid.DataSource = planes.ToList();
                //select images
                var imgs = from p in dc.Plane
                           join m in dc.tbl_planeMoreInfo
                           on p.Id equals m.idp
                           select new { m.pic };

                //show images in datagridvieaw
                int i = 0;
                foreach (var pic in imgs)
                {
                    try
                    {
                        dtGrid.Rows[i].Cells[0].Value = Image.FromFile(path() + pic.pic.ToString());
                        i++;
                    }
                    catch (FileNotFoundException)
                    {

                    }
                    catch
                    {
                        MessageBox.Show("مشکلی پیش آمده است \n لطفا با پشتیبانی تماس بگیرید",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Method Combobox Sources
        private void CompanySource()
        {
            //combobox
            using (dcAirplane dc = new dcAirplane())
            {
                var companies = from c in dc.Company
                                select c.cName;
                comboCompany.DataSource = companies.ToList();
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
            if (txtName.Text == string.Empty || txtCapacity.Text == string.Empty ||
                txtYear.Text == string.Empty || txtSerial.Text == string.Empty)
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtCapacity, lblRedCapacity);
                RedLabels(txtYear, lblRedYear);
                RedLabels(txtSerial, lblRedSerial);
                return false;
            }
            else
                return true;
        }

        //Method clear all
        private void ClearAll()
        {
            txtName.Text = txtCapacity.Text = txtSerial.Text = txtYear.Text = string.Empty;
            CompanySource();
            imgPlane.Image = Properties.Resources.planeIcon1;
            _imgName = string.Empty;
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            connect();
            ClearAll();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCapacity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int capacity = Convert.ToInt32(txtCapacity.Text);
                if (e.KeyCode == Keys.Add)
                {
                    capacity++;
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    capacity--;
                }
                txtCapacity.Text = capacity.ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtYear.Text.Length == 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            //not be null
            if (!NullTxt())
            {
                return;
            }
            else
            {
                RedLabels(txtName, lblRedName);
                RedLabels(txtCapacity, lblRedCapacity);
                RedLabels(txtYear, lblRedYear);
                RedLabels(txtSerial, lblRedSerial);
            }
            //
            //check year
            DateTime date = DateTime.Now;
            int ThisYear = Convert.ToInt32(date.ToString("yyyy"));
            int PlaneYear = Convert.ToInt32(txtYear.Text);
            if (PlaneYear > ThisYear)
            {
                MessageBox.Show("سال ساخت صحیح نمی باشد", "Incorrect Year",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblRedYear.Visible = true;
                return;
            }
            else
                lblRedYear.Visible = false;
            //
            //check capacity
            int capacity = Convert.ToInt32(txtCapacity.Text);
            if (capacity < 20)
            {
                MessageBox.Show("ظرفیت نباید کمتر از 20 نفر باشد", "Incorrect Caoacity",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblRedCapacity.Visible = true;
                return;
            }
            else if (capacity > 350)
            {
                MessageBox.Show("ظرفیت نباید بیشتر از 350 نفر باشد", "Incorrect Caoacity",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblRedCapacity.Visible = true;
                return;
            }
            else
                lblRedCapacity.Visible = false;
            //
            //if img was null
            if (string.IsNullOrEmpty(_imgName))
            {
                _imgName = "planeIcon.png";
            }
            //
            try
            {
                using (dcAirplane dc = new dcAirplane())
                {
                    Plane tbP = new Plane()
                    {
                        pName = txtName.Text,
                        CompanyId = _idCompany,
                        Capacity = Convert.ToInt32(txtCapacity.Text)
                    };
                    dc.Plane.Add(tbP);
                    dc.SaveChanges();

                    var lastPlane = (from p in dc.Plane
                                     orderby p.Id
                                     descending
                                     select p).FirstOrDefault();
                    tbl_planeMoreInfo tbPMI = new tbl_planeMoreInfo()
                    {
                        idp = lastPlane.Id,
                        pic = _imgName,
                        Serial = txtSerial.Text,
                        year = Convert.ToInt32(txtYear.Text)
                    };
                    dc.tbl_planeMoreInfo.Add(tbPMI);
                    dc.SaveChanges();
                    ClearAll();
                    connect();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است \n لطفا با پشتیبانی تماس بگیرید",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var company = (from c in dc.Company
                               join p in dc.tbl_companyPic
                               on c.Id equals p.idc
                               where c.cName == comboCompany.Text
                               select p).FirstOrDefault();
                _idCompany = company.id;
                string CompanyPath = Application.StartupPath + "/imgCompany/";
                if (Directory.Exists(CompanyPath))
                {
                    Directory.CreateDirectory(CompanyPath);
                }
                imgCompany.Image = Image.FromFile(CompanyPath + company.pic);
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "image File (*.jpg;*.png) | *.jpg;*.png";
            openFile.Title = "انتخاب عکس هواپیما";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgPlane.ImageLocation = openFile.FileName;

                //copy img
                try
                {
                    File.Copy(openFile.FileName, path() + openFile.SafeFileName);
                    _imgName = openFile.SafeFileName;
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
