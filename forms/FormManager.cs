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
    public partial class FormManager : Form
    {
        
        public FormManager()
        {
            InitializeComponent();
        }

        //path
        private static string path()
        {
            string path = Application.StartupPath + "/images/";
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        //Method Connect
        private void connect()
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var users = from u in dc.User
                            select new
                            {
                                u.Id,
                                u.FullName,
                            };
                dtGrid.DataSource = users.ToList();

                var imgs = from u in dc.User
                           join m in dc.tbl_employee
                           on u.Id equals m.idu
                           select new { m.e_pic };

                int i = 0;
                foreach (var pic in imgs)
                {
                    try
                    {
                        dtGrid.Rows[i].Cells[0].Value = Image.FromFile(path() + pic.e_pic);
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

        private void FormManager_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (dcAirplane dc = new dcAirplane())
            {
                var SearchUser = from u in dc.User
                                 where u.FullName.Contains(txtSearch.Text)
                                 select new
                                 {
                                     u.Id,
                                     u.FullName
                                 };
                dtGrid.DataSource = SearchUser.ToList();

                var UserPics = from u in dc.User
                               join m in dc.tbl_employee
                               on u.Id equals m.idu
                               where u.FullName.Contains(txtSearch.Text)
                               select new { m.e_pic };

                int i = 0;
                foreach (var pic in UserPics)
                {
                    try
                    {
                        dtGrid.Rows[i].Cells[0].Value = Image.FromFile(path() + pic.e_pic);
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
