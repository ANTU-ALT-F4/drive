using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSS03
{
    class ChuoiKetNoi
    {
        public static string sqlcon = @"Data Source=FIT;Initial Catalog=ITSS03;User ID=sa;Password=123456";
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

        public static void HienThi(string chuoi, DataGridView db1)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();
            bd = new SqlCommandBuilder(ad);

            ad.Fill(dt);
            db1.DataSource = dt;
        }

        public static void xulycbb(string chuoi,ComboBox cbx)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();

                ad.Fill(dt);
                cbx.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        public static void GuiYeuCau(string sql)
        {
            cn = new SqlConnection(sqlcon);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void TTCSDL(string sql, SqlDataAdapter adx, SqlCommand cmdx, DataSet dsx) //dsx tự cho ví dụ bạn thêm vào các chuỗi truy vấn khác nhau thì để dsx thành ds1,ds2,ds3
        {
            cn = new SqlConnection(sqlcon);
            cn.Open();
            cmdx = new SqlCommand(sql, cn);
            adx = new SqlDataAdapter(cmdx);
            dsx = new DataSet();
            adx.Fill(dsx);
            cn.Close();
        }

    }
}
