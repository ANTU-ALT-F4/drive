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

namespace ITSS02
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
            loadcbbpriorites();
        }
        public void loadcbbpriorites()
        {
            ChuoiKetNoi.xulycbb("Select * from priorites", cb_priority);
            cb_priority.DisplayMember = "name";
            cb_priority.ValueMember = "id";
            cb_priority.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        bool kiemtra()
        {
            if(cb_priority.SelectedIndex == -1)
            {
                MessageBox.Show("Select Priority","Status",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txt_de.Text))
            {
                MessageBox.Show("Insert Description of Emergency", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_de.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_oc.Text))
            {
                MessageBox.Show("Insert  Other Considerations", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_oc.Focus();
                return false;
            }
            return true;
        }

        private void btnSentReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtra())
                {
                    string idas = Main.idas;
                    DateTime now = DateTime.Now; //Lấy ngày hiện tại

                    string truyvan = "insert into emergencymaintenances(assetid,priorityid,descriptionemergency,otherconsiderations,emreportdate,emstartdate,emtechniciannote) values('" + idas + "', '" + cb_priority.SelectedValue.ToString() + "', '" + txt_de.Text + "', '" + txt_oc.Text + "', '" + now.ToString("yyyy-MM-dd") + "','" + now.ToString("yyyy-MM-dd") + "', '')";
                    ChuoiKetNoi.GuiYeuCau(truyvan);

                    MessageBox.Show("Da gui yeu cau bao tri!", "Thông báo", MessageBoxButtons.OK);
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gui yeu cau that bai!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void Request_Load(object sender, EventArgs e)
        {
            lb_asn.Text = Main.asn;
            lb_aname.Text = Main.aname;
            lb_dp.Text = Main.dp;
        }
    }
}
