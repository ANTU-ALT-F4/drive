using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSS02
{
    public partial class fLogin : Form
    {
        public static string isadmin;
        public static string idnv;
        SqlCommand cmd;
        SqlDataReader rd;
        SqlConnection cnn;
        int dem;
        public static string chuoi = "";
        public fLogin()
        {
            cnn = new SqlConnection(ChuoiKetNoi.Sqlcon);
            InitializeComponent();
        }
        public bool IsLogin(string user, string pass)
        {
            string query = "SELECT * FROM employees where username = '" + user + "' and password = '" + pass + "'";
            try
            {
                    cnn.Open();
                    cmd = new SqlCommand(query, cnn);
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        if (rd["isadmin"].ToString() == "1")
                        {
                            isadmin = "1";
                            idnv = rd["id"].ToString();
                            MessageBox.Show(isadmin);

                            rd.Close();
                            cnn.Close();
                            return true;
                        }
                        else
                        {
                            isadmin = "0";
                            idnv = rd["id"].ToString();
                            MessageBox.Show(isadmin);

                            rd.Close();
                            cnn.Close();
                            return true;
                        }
                    }
                    else
                    {
                        rd.Close();
                        cnn.Close();
                        return false;
                    }
            }
            catch (Exception ex)
            {
                cnn.Close();
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt_username.Text;
            String pass = txt_password.Text;
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Vui lòng tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Select();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Select();
                return;
            }
            if (IsLogin(user, pass))
            {
                MessageBox.Show($"Xin chào {user} đã quay trở lại!");
                this.Hide();
                var f = new Main();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã đăng nhập thất bại vui lòng kiểm tra lại  ", "Đăng nhập thất bại lần " + dem, MessageBoxButtons.OK);
                txt_username.Select();
                if (dem == 3)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khoá khi nhập sai 3 lần", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Ban muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == thoat)
            {
                Application.Exit();
            }
        }
    }
}
