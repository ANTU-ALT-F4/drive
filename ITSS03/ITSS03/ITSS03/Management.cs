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
    public partial class Management : Form
    {
        public static string idemermain;
        public static string asid;
        public static string asn;
        public static string aname;
        public static string depart;
        SqlConnection cn;
        public Management()
        {
            cn = new SqlConnection(ChuoiKetNoi.sqlcon);
            InitializeComponent();
        }
        public void reload()
        {
            if (Form1.isadmin == "1")
            {
                string chuoi = "Select  employees.id,emergencymaintenances.id as idemmain,assetid, assetsn, assetname, emreportdate,emenddate,(firstname+' '+lastname) as emfullname, departments.name, priorites.id\r\n    from assets,employees, emergencymaintenances, departmentlocations,departments, priorites\r\n\twhere employees.id= assets.employeeid and assets.id = emergencymaintenances.assetid\r\n\t\tand assets.departmentlocationid = departmentlocations.id\r\n\t\tand departments.id = departmentlocations.departmentid and priorites.id = emergencymaintenances.priorityid\r\n\t ORDER BY (CASE WHEN emenddate is null THEN 1 WHEN emenddate is not null THEN 2 ELSE 100 END) ASC,priorites.id  ASC, emreportdate ASC;";
                ChuoiKetNoi.HienThi(chuoi, dgv_management);

            }
        }

        private void Management_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dgv_management_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idemermain = dgv_management.Rows[e.RowIndex].Cells["idemmain"].Value.ToString();
            asid = dgv_management.Rows[e.RowIndex].Cells["assetid"].Value.ToString();
            asn = dgv_management.Rows[e.RowIndex].Cells["assetsn"].Value.ToString();
            aname = dgv_management.Rows[e.RowIndex].Cells["assetname"].Value.ToString();
            depart = dgv_management.Rows[e.RowIndex].Cells["department"].Value.ToString();
        }

        private void btn_ManageRequest_Click(object sender, EventArgs e)
        {
            try
            {
                idemermain = idemermain;
                asid = asid;
                asn = asn;
                aname = aname;
                depart = depart;
                MessageBox.Show("" + idemermain + "," + asid + ", " + asn + ", " + aname + ", " + depart + "");
                Hide();
                var f = new Request();
                f.ShowDialog();
                Show();
            }
            catch (Exception ex) { }
        }
    }
}
