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

namespace ITSS03
{
    public partial class Request : Form
    {
        SqlDataAdapter ad1;
        SqlCommand cmd1;
        DataSet ds1;
        public Request()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dgv_request.Rows.Add(cb_partname.SelectedValue.ToString(), cb_partname.Text, txt_amount.Text);
        }

        private void Request_Load(object sender, EventArgs e)
        {
            lb_asn.Text = Management.asn;
            lb_aname.Text = Management.aname;
            lb_depart.Text = Management.depart;
            //Load du lieu combobox
            ChuoiKetNoi.xulycbb("select * from parts", cb_partname);
            cb_partname.DisplayMember = "name";
            cb_partname.ValueMember = "id";
            cb_partname.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaystar = date_start.Value.ToString("yyyy-MM-dd");
                string ngayend = date_com.Value.ToString("yyyy-MM-dd");
                //MessageBox.Show(ngaystar);
                string update = "UPDATE emergencymaintenances SET emstartdate = '" + ngaystar + "',  emenddate= '" + ngayend + "', emtechniciannote ='" + txt_tech.Text + "' WHERE id=" + Management.idemermain + "";
                ChuoiKetNoi.TTCSDL(update, ad1, cmd1, ds1);

                //them du lieu cho bang part
                for (int i = 0; i <= dgv_request.RowCount - 1; i++)
                {
                    string insert = "insert into changedparts(emergencymaintenanceid, partid, amount) values (" + Management.idemermain + ",'" + dgv_request.Rows[i].Cells["idpart"].Value.ToString() + "'," + Convert.ToInt32(txt_amount.Text) + ")";
                    ChuoiKetNoi.GuiYeuCau(insert);

                }
                MessageBox.Show("Submit thanh cong!", "Thong bao.", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao.", MessageBoxButtons.OK);
            }
        }
    }
}
