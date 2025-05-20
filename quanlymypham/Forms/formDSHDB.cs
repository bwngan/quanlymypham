using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlymypham.Forms
{
    public partial class formDSHDB: Form
    {
        public formDSHDB()
        {
            InitializeComponent();
        }
        DataTable tblDSHDB;
        private void formDSHDB_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_dgridDSHDB();
        }
        private void Load_dgridDSHDB()
        {
            string sql;
            sql = " SELECT * FROM HoaDonBan";
            tblDSHDB = Functions.GetDataToTable(sql);
            dataGridViewHDB.DataSource = tblDSHDB;
            dataGridViewHDB.Columns[0].HeaderText = "Số hoá đơn bán";
            dataGridViewHDB.Columns[1].HeaderText = "Mã nhân viên";
            dataGridViewHDB.Columns[2].HeaderText = "Ngày bán";
            dataGridViewHDB.Columns[3].HeaderText = "Mã khách hàng";
            dataGridViewHDB.Columns[4].HeaderText = "Tổng tiền";
            dataGridViewHDB.Columns[0].Width = 80;
            dataGridViewHDB.Columns[1].Width = 100;
            dataGridViewHDB.Columns[2].Width = 80;
            dataGridViewHDB.Columns[3].Width = 80;
            dataGridViewHDB.Columns[4].Width = 100;
            dataGridViewHDB.AllowUserToAddRows = false;
            dataGridViewHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void formDSHDB_DoubleClick(object sender, EventArgs e)
        {
            formChitietHDB a = new formChitietHDB();
            a.Show();
        }

        private void btntaohoadonmoi_Click(object sender, EventArgs e)
        {
            var f = new formThemHDB();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
            if (main == null)
            {
                MessageBox.Show("Không tìm thấy form chính!");
                return;
            }

            

        }


    }
}
