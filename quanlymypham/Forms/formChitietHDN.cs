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
    public partial class formChitietHDN : Form
    {
        public formChitietHDN()
        {
            InitializeComponent();
        }

        private void formChitietHDN_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            txtSoHDN.ReadOnly = true;
            txtTennv.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtMaNCC.ReadOnly = true;
            txtMaNV.ReadOnly = true;

        }
    }
}
