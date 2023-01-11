using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSS02
{
    class ChuoiKetNoi
    {
        // xóa làm lại 10 lần không nhìn
        public static string Sqlcon = @"Data Source=FIT;Initial Catalog=ITSS02;User ID=sa;Password=123456";
        private static SqlConnection cn;

        public void Open()
        {
            cn.Open();
        }

        public void Close()
        {
            cn.Close();
        }

        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlCommandBuilder bd;
        public static SqlCommand cmd;

        public static void hienthi(string chuoi, DataGridView db1)
        {
            ad = new SqlDataAdapter(chuoi, Sqlcon);
            dt = new DataTable();
            bd = new SqlCommandBuilder(ad);
            ad.Fill(dt);
            db1.DataSource = dt;
        }

        public static void xulycbb(string chuoi, ComboBox cbx)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, Sqlcon);
                dt = new DataTable();

                ad.Fill(dt);
                cbx.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi " + ex);
            }
        }

        public static void GuiYeuCau(string sql)
        {
            cn = new SqlConnection(Sqlcon);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void TTCSDL(string sql, SqlDataAdapter adx, SqlCommand cmdx, DataSet dsx) //dsx tự cho ví dụ bạn thêm vào các chuỗi truy vấn khác nhau thì để dsx thành ds1,ds2,ds3
        {
            cn = new SqlConnection(Sqlcon);
            cn.Open();
            cmdx = new SqlCommand(sql, cn);
            adx = new SqlDataAdapter(cmdx);
            dsx = new DataSet();
            adx.Fill(dsx);
            cn.Close();
        }

        public static void delete(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cn = new SqlConnection(Sqlcon);
                    cn.Open();
                    cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bạn đã xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
