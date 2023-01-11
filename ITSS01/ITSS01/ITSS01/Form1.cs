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

namespace ITSS01
{
    public partial class Form1 : Form
    {
        public static string orderid;
        public static string bool_edit;
        SqlConnection cn;
        public static string chuoi = "SELECT orders.id AS idorderitems, parts.name AS partname, transactiontype.name AS transactiontype, orders.date, SUM(orderitems.amount) AS amount,nhap.name as source,chuyenden.name as destination\r\nFROM transactiontype,suppliers,parts,orderitems\r\nINNER JOIN orders ON orders.id = orderitems.orderid\r\nLEFT JOIN warehouses as nhap ON nhap.id = orders.sourcewarehouseid\r\nLEFT JOIN warehouses as chuyenden ON chuyenden.id = orders.destinationwarehouseid\r\nWHERE orders.transactiontypeid = transactiontype.id\r\nAND orders.suppliersid = suppliers.id\r\nAND orderitems.partid = parts.id\r\nGROUP BY orders.id, parts.name, transactiontype.name, orders.date, orders.sourcewarehouseid,orders.destinationwarehouseid,nhap.name,chuyenden.name";
        public Form1()
        {
            cn = new SqlConnection(ChuoiKetNoi.sqlcon);
            InitializeComponent();
            loadulieu();
        }

        public void loadulieu()
        {
            ChuoiKetNoi.HienThi(chuoi, dgv_1);
        }
        string demhangtonkho = "";
        string tonghangtonkho = "";
        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_1.Columns[e.ColumnIndex].Name == "edit")
            {
                orderid = dgv_1.Rows[e.RowIndex].Cells["Column7"].Value.ToString() + "";
                bool_edit = "on";
                Hide();
                var f = new PurchaseOrders();
                f.ShowDialog();
                Show();

            }
            if (dgv_1.Columns[e.ColumnIndex].Name == "delete")
            {
                demhangtonkho = dgv_1.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
           
                cn.Open();
                using (var cmd = new SqlCommand("Select COUNT(orderitems.id) as id from orderitems WHERE orderitems.orderid = '" + demhangtonkho + "'", cn))
                {
                    using (var render = cmd.ExecuteReader())
                    {
                        while (render.Read())
                        {
                            tonghangtonkho = render["id"].ToString();
                        }
                    }
                }
                cn.Close();
                int tonghang = Convert.ToInt32(tonghangtonkho);
                if (tonghang == 0)
                {
                    MessageBox.Show("Được Xóa");
                }
                else
                {
                    MessageBox.Show("There are " + tonghangtonkho + " inventories of a part in a warehouse so  be prevented negative should be prevented");
                }
                
            }
        }

        private void dgv_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_1.RowCount > 0)
            {
                for (int i = 0; i < dgv_1.RowCount - 1; i++)
                {
                    if (dgv_1.Rows[i].Cells["transactiontype"].Value.ToString() == "Purchase Order")
                    {
                        dgv_1.Rows[i].Cells["amount"].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgv_1.Rows[i].Cells["amount"].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void Mstrip_POM_Click(object sender, EventArgs e)
        {
            orderid = "";
            bool_edit = "off";
            PurchaseOrders frmProduct = new PurchaseOrders();
            frmProduct.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            loadulieu();
        }
    }
}
