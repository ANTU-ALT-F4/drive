using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ITSS04
{
    public partial class WarehouseManagement : Form
    {
        //Lấy dữ liệu của form1 để edit thông tin các bảng order , orderitems
        string orderid = Form1.orderid;
        string bool_edit = Form1.bool_edit;
        string idsup = "";
        string idsource = "";
        SqlConnection cn;
        SqlDataAdapter ad1,ad2;
        SqlCommand cmd1,cmd2;
        DataSet ds1,ds2;
        public WarehouseManagement()
        {
            cn = new SqlConnection(ChuoiKetNoi.sqlcon);
            InitializeComponent();
            ShowDGV(orderid);

            if (orderid != "") {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("Select sourcewarehouseid,destinationwarehouseid from orders where id = '" + orderid + "'", cn))
                    {
                        using (var render = cmd.ExecuteReader())
                        {
                            while (render.Read())
                            {
                                idsup = render[0].ToString();
                                idsource = render[1].ToString();
                            }
                        }
                    }
                    cn.Close();
                    swarehouses();
                    int usup = int.Parse(idsup) - 1;
                    int uidsource = int.Parse(idsource) -1;
                    cb_sware.SelectedIndex = usup;
                    dWarehouse();
                    cb_dware.SelectedIndex = uidsource;
                    Partsname();
                }
                catch (Exception ex)
                {

                }
            }
            else {
                swarehouses();
                cb_sware.SelectedIndex = -1;
                dWarehouse();
                cb_dware.SelectedIndex = -1;
                Partsname();
            }
        }

        public void ShowDGV(string orderid)
        {
            cn.Open();
            using (var cmd = new SqlCommand("Select orderitems.partid as partid,name, batchnumber, amount, orderitems.id from orderitems, parts where orderitems.orderid= '"+ orderid + "' and orderitems.partid = parts.id", cn))
            {
                using (var render = cmd.ExecuteReader())
                {
                    while (render.Read())
                    {
                        var partid = render[0].ToString();
                        var partname = render[1].ToString();
                        var batchnumber = render[2].ToString();
                        var amount = render[3].ToString();
                        var idorder = render[4].ToString();
                        dgv_order.Rows.Add(partid, partname, batchnumber, amount, idorder);
                    }
                }
            }
            cn.Close();
        }

        private void swarehouses()
        {
            string swarehouses = "Select * from warehouses";
            ChuoiKetNoi.xulycbx(swarehouses, cb_sware);
            cb_sware.DisplayMember = "name";
            cb_sware.ValueMember = "id";
        }

        private void dWarehouse()
        {

            string dWarehouse = "Select * from warehouses";
            ChuoiKetNoi.xulycbx(dWarehouse, cb_dware);
            cb_dware.DisplayMember = "name";
            cb_dware.ValueMember = "id";
        }

        private void Partsname()
        {

            string Partsname = "Select * from parts";
            ChuoiKetNoi.xulycbx(Partsname, cb_part);
            cb_part.DisplayMember = "name";
            cb_part.ValueMember = "id";
            cb_part.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        bool kiemtrabnumber; 
        private void btn_addlist_Click(object sender, EventArgs e)
        {
            if (kiemtrabnumber == true)
            {
                if (string.IsNullOrEmpty(txt_bnumber.Text))
                {
                    MessageBox.Show("Insert Batch number", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_bnumber.Select();
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_amount.Text))
            {
                MessageBox.Show("Insert Amount", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_amount.Select();
                return;
            }
            var idpart = cb_part.SelectedValue.ToString();
            var partname = cb_part.Text;
            var batchnumber = txt_bnumber.Text;
            var amount = txt_amount.Text;
            dgv_order.Rows.Add(idpart, partname, batchnumber, amount);
            txt_bnumber.Clear();
            txt_amount.Clear();
        }

        bool kiemtra()
        {
            if (cb_sware.SelectedIndex < 0)
            {
                MessageBox.Show("Select suppliers", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cb_dware.SelectedIndex < 0)
            {
                MessageBox.Show("Select warehouses", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cb_part.SelectedIndex < 0)
            {
                MessageBox.Show("Select Partsname", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(dateTP.Text))
            {
                MessageBox.Show("Insert Date", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTP.Select();
                return false;
            }
            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtra();

                DateTime date = dateTP.Value;
                string insert = "INSERT INTO orders VALUES ('1','" + cb_sware.SelectedValue.ToString() + "','" + cb_sware.SelectedValue.ToString() + "','" + cb_dware.SelectedValue.ToString() + "','" + date.ToString("yyyy-MM-dd") + "')";
                ChuoiKetNoi.TTCSDL(insert, ad1, cmd1, ds1);

                cn.Open();
                //Lay ma order
                var id_order = 0;
                SqlCommand sql = new SqlCommand("Select max(id) as id from orders", cn);
                SqlDataReader read = sql.ExecuteReader();
                if (read.Read())
                {
                    id_order = Convert.ToInt32(read["id"].ToString());
                }
                cn.Close();

                //Them bang orderitems
                if (dgv_order.RowCount < 1)
                {
                    MessageBox.Show("One Order", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i <= dgv_order.RowCount - 1; i++)
                    {
                        //Lay gia tri tung dong trong datagridview de them vao bang order
                        var partid1 = dgv_order.Rows[i].Cells["idpart"].Value.ToString();
                        var batchnumber1 = dgv_order.Rows[i].Cells["batchnumber"].Value.ToString();
                        var amount = dgv_order.Rows[i].Cells["amount"].Value.ToString();

                        if (dgv_order.Rows[i].Cells["batchnumber"].Value.ToString() == "NULL")
                        {
                            string truyvan = "insert into orderitems(orderid,partid,batchnumber,amount ) values(" + id_order + "," + partid1 + ",NULL," + amount + ")";
                            ChuoiKetNoi.TTCSDL(truyvan, ad2, cmd2, ds2);
                        }
                        else
                        {
                            string truyvan = "insert into orderitems(orderid,partid,batchnumber,amount ) values(" + id_order + "," + partid1 + ",'" + batchnumber1 + "'," + amount + ")";
                            ChuoiKetNoi.TTCSDL(truyvan, ad2, cmd2, ds2);
                        }
                    }
                }
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            if (bool_edit == "on")
            {
                btn_capnhat.Visible = true;
                //MessageBox.Show("On");
            }
            else if (bool_edit == "off")
            {
                btn_submit.Visible = true;
                //MessageBox.Show("OFF");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (cb_dware.SelectedIndex < 0)
            {
                MessageBox.Show("Select dwarehouses", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_sware.SelectedIndex < 0)
            {
                MessageBox.Show("Select swarehouses", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime date = dateTP.Value;

            string update = "UPDATE orders SET date = '"+ date.ToString("yyyy-MM-dd") + "', sourcewarehouseid = '" + cb_sware.SelectedValue.ToString() + "', destinationwarehouseid = '" + cb_dware.SelectedValue.ToString() + "' WHERE id = '" + orderid + "'";
            ChuoiKetNoi.TTCSDL(update, ad1, cmd1, ds1);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        string id = "";
        private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_order.Columns[e.ColumnIndex].Name == "Remove")
            {
                id = dgv_order.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                ChuoiKetNoi.delete("delete from orderitems where id = '"+ id + "'");
                dgv_order.Rows.Clear();
                ShowDGV(orderid);
            }
        }

        private void cb_part_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (cb_part.SelectedIndex.ToString() == "-1")
                {
                    txt_bnumber.Text = "";
                    txt_bnumber.Enabled = false;
                }
                else
                {

                    //label9.Text = cb_part.SelectedValue.ToString();
                    var idpart = cb_part.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand("select batchnumberhasrequired from parts where id = '" + idpart + "'", cn);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        if (read["batchnumberhasrequired"].ToString() == "1")
                        {
                            txt_bnumber.Enabled = true;
                            kiemtrabnumber = true;
                        }
                        else if (read["batchnumberhasrequired"].ToString() == "0")
                        {
                            txt_bnumber.Text = "";
                            txt_bnumber.Enabled = false;
                            kiemtrabnumber = false;
                        }
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
