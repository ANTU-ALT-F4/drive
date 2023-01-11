using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ITSS02
{
    public partial class Main : Form
    {
        public static string idas = "";
        public static string asn;
        public static string aname;
        public static string dp;
        SqlConnection cn;
        public Main()
        {
            cn = new SqlConnection(ChuoiKetNoi.Sqlcon);
            InitializeComponent();
        }
        public void reload()
        {
            if (fLogin.isadmin == "1")
            {
                string chuoi = "select a.id,assetsn,assetname,emenddate,(select count(*) from emergencymaintenances where assetid=em.assetid ) as numem from assets a,emergencymaintenances em where a.id=em.assetid and emenddate =(select max(emenddate) from emergencymaintenances where assetid=a.id) order by assetid asc";
                ChuoiKetNoi.hienthi(chuoi, dgv_1);

            }
            else
            {
                string chuoi = "select a.id, assetsn,assetname,emenddate,(select count(*) from emergencymaintenances where assetid=em.assetid ) as numem from assets a,emergencymaintenances em where a.id=em.assetid and emenddate =(select max(emenddate) from emergencymaintenances where assetid=a.id) and employeeid = '" + fLogin.idnv + "' order by assetid asc";
                ChuoiKetNoi.hienthi(chuoi, dgv_1);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select assets.id,assetsn, assetname, departments.name from assets, departmentlocations, departments where assets.departmentlocationid = departmentlocations.id AND assets.id = '" + idas + "' AND departments.id = departmentlocations.departmentid", cn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read())
            {
                idas = doc[0].ToString();
                asn = doc[1].ToString();
                aname = doc[2].ToString();
                dp = doc[3].ToString();

                //MessageBox.Show(idas + asn+ aname+ dp);

                Hide();
                var f = new Request();
                f.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Khong lay duoc du lieu", "Thong bao", MessageBoxButtons.OK);
            }
            cn.Close();
        }

        private void dgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idas = dgv_1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                //chặn lỗi Crash phần mềm
            }
        }

        private void dgv_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //Kiểm tra xem yêu cầu đã hoàn thành chưa, nếu chưa thì màu đó 
                if (dgv_1.RowCount > 0)
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("select a.id from assets a, emergencymaintenances em where a.id = em.assetid and emenddate IS NULL  order by assetid asc", cn))
                    {
                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                for (int i = 0; i < dgv_1.RowCount - 1; i++)
                                {
                                    if (dgv_1.Rows[i].Cells["id"].Value.ToString() == rd["id"].ToString())
                                    {
                                        dgv_1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            reload();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
