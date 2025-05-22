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
    public partial class GD_Chinh : Form
    {
        formNV nhanvien;
        formNCC ncc;
        formSanPham sanpham;
        formKhachHang khachhang;
        formDSHDN dshdn;
        formThemHDN themhdn;
        formDSHDB dshdb;
        formThemHDB themhdb;
        formBaocaoDT baocaoDT;
        formBaocaoNV baocaoNV;
        formBaocaoSP baocaoSP;
       
        

        public GD_Chinh()
        {
            InitializeComponent();
            panelContent.Resize += PanelContent_Resize;
        }
        private void PanelContent_Resize(object sender, EventArgs e)
        {
            if (panelContent.Controls.Count > 0 && panelContent.Controls[0] is Form f)
            {
                f.Size = panelContent.ClientSize;
            }
        }
        bool QuanlychungExpand = false;
        private void QuanlychungTransition_Tick(object sender, EventArgs e)
        {
            if (QuanlychungExpand == false)
            {
                QuanlychungContainer.Height += 10;
                if (QuanlychungContainer.Height >= 220)
                {
                    QuanlychungTransition.Stop();
                    QuanlychungExpand = true;
                }
            }
            else
            {
                QuanlychungContainer.Height -= 10;
                if (QuanlychungContainer.Height <= 47)
                {
                    QuanlychungTransition.Stop();
                    QuanlychungExpand = false;
                }
            }

        }

        private void btnQuanlychung_Click(object sender, EventArgs e)
        {
            QuanlychungTransition.Start();
        }
        bool HoadonnhapExpand = false;

        private void HoadonnhapTransition_Tick(object sender, EventArgs e)
        {
            if (HoadonnhapExpand == false)
            {
                HoadonnhapContainer.Height += 10;
                if (HoadonnhapContainer.Height >= 139)
                {
                    HoadonnhapTransition.Stop();
                    HoadonnhapExpand = true;
                }
            }
            else
            {
                HoadonnhapContainer.Height -= 10;
                if (HoadonnhapContainer.Height <= 47)
                {
                    HoadonnhapTransition.Stop();
                    HoadonnhapExpand = false;
                }
            }

        }

        private void btnHoadonhap_Click(object sender, EventArgs e)
        {
            HoadonnhapTransition.Start();
        }
        bool HoadonbanExpand = false;

        private void HoadonbanTransition_Tick(object sender, EventArgs e)
        {
            if (HoadonbanExpand == false)
            {
                HoadonbanContainer.Height += 10;
                if (HoadonbanContainer.Height >= 139)
                {
                    HoadonbanTransition.Stop();
                    HoadonbanExpand = true;
                }
            }
            else
            {
                HoadonbanContainer.Height -= 10;
                if (HoadonbanContainer.Height <= 47)
                {
                    HoadonbanTransition.Stop();
                    HoadonbanExpand = false;
                }
            }

        }

        private void btnHoadonban_Click(object sender, EventArgs e)
        {
            HoadonbanTransition.Start();
        }
        bool SidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                panelContent.Width -= 10;
                if (panelContent.Width <= 42)
                {
                    SidebarExpand = false;
                    SidebarTransition.Stop();
                    QuanlychungContainer.Width = panelContent.Width;
                    HoadonnhapContainer.Width = panelContent.Width;
                    HoadonbanContainer.Width = panelContent.Width;
                    BaocaoContainer.Width = panelContent.Width;
                    pnDangxuat.Width = panelContent.Width;
                }
            }
            else
            {
                panelContent.Width += 10;
                if (panelContent.Width >= 232)
                {
                    SidebarExpand = true;
                    SidebarTransition.Stop();
                    QuanlychungContainer.Width = panelContent.Width;
                    HoadonnhapContainer.Width = panelContent.Width;
                    HoadonbanContainer.Width = panelContent.Width;
                    BaocaoContainer.Width = panelContent.Width;
                    pnDangxuat.Width = panelContent.Width;


                }
            }
        }

        private void btnMucluc_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        bool BaocaoExpand = false;
        private void BaocaoTransition_Tick(object sender, EventArgs e)
        {
            if (BaocaoExpand == false)
            {
                BaocaoContainer.Height += 10;
                if (BaocaoContainer.Height >= 174)
                {
                    BaocaoTransition.Stop();
                    BaocaoExpand = true;
                }
            }
            else
            {
                BaocaoContainer.Height -= 10;
                if (BaocaoContainer.Height <= 47)
                {
                    BaocaoTransition.Stop();
                    BaocaoExpand = false;
                }
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            BaocaoTransition.Start();
        }

        private void GD_Chinh_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            if (nhanvien == null || nhanvien.IsDisposed)
            {
                panelContent.Controls.Clear();
                nhanvien = new formNV();
                nhanvien.TopLevel = false;
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Dock = DockStyle.Fill;
                nhanvien.AutoSize = false;
                nhanvien.Size = panelContent.ClientSize;

                panelContent.Controls.Add(nhanvien);

                // Dòng này rất quan trọng nếu form con bị nhỏ
                nhanvien.Size = panelContent.ClientSize;
                nhanvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;


                nhanvien.Show();
            }
            else
            {
                nhanvien.BringToFront();
            }
        }


        private void btnNCC_Click(object sender, EventArgs e)
        {
            if (ncc == null)
            {
                ncc = new formNCC();
                ncc.TopLevel = false;
                ncc.FormBorderStyle = FormBorderStyle.None;
                ncc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(ncc);
                ncc.Show();
            }
            else
            {
                ncc.BringToFront();
            }
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            if (sanpham == null || sanpham.IsDisposed)
            {
                sanpham = new formSanPham();
                sanpham.TopLevel = false;
                sanpham.FormBorderStyle = FormBorderStyle.None;
                sanpham.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(sanpham);
                sanpham.Show();
            }
            else
            {
                sanpham.BringToFront();
            }
            
        }
        private void ResetMenuHighlight()
        {
            btnsanpham.BackColor = default(Color);
            btnkhachhang.BackColor = default(Color);
            btnNhanvien.BackColor = default(Color);
            btnNCC.BackColor = default(Color);
        }


        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            if (khachhang == null || khachhang.IsDisposed)
            {
                khachhang = new formKhachHang();
                khachhang.TopLevel = false;
                khachhang.FormBorderStyle = FormBorderStyle.None;
                khachhang.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(khachhang);
                khachhang.Show();
            }
            else
            {
                khachhang.BringToFront();
            }
           
        }
       

        private void btntaoHD_Click(object sender, EventArgs e)
        {
            if (themhdb == null || themhdb.IsDisposed)
            {
                themhdb = new formThemHDB();
                themhdb.TopLevel = false;
                themhdb.FormBorderStyle = FormBorderStyle.None;
                themhdb.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(themhdb);
                themhdb.Show();
            }
            else
            {
                themhdb.BringToFront();
            }
            
        }

        private void btndanhsachHD_Click(object sender, EventArgs e)
        {
            if (dshdb == null || dshdb.IsDisposed)
            {
                dshdb = new formDSHDB();
                dshdb.TopLevel = false;
                dshdb.FormBorderStyle = FormBorderStyle.None;
                dshdb.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(dshdb);
                dshdb.Show();
            }
            else
            {
                dshdb.BringToFront();
            }
          
        }

        private void btnDshoadon_Click(object sender, EventArgs e)
        {
            if (dshdn == null || dshdn.IsDisposed)
            {
                dshdn = new formDSHDN();
                dshdn.TopLevel = false;
                dshdn.FormBorderStyle = FormBorderStyle.None;
                dshdn.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(dshdn);
                dshdn.Size = panelContent.ClientSize;
                dshdn.Show();
            }
            else
            {
                dshdn.BringToFront();
            }
        }

        private void btnTaohoadon_Click(object sender, EventArgs e)
        {
            if(themhdn == null || themhdn.IsDisposed)
            {
                themhdn = new formThemHDN();
                themhdn.TopLevel = false;
                themhdn.FormBorderStyle = FormBorderStyle.None;
                themhdn.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(themhdn);
                themhdn.Show();
            }
            else
            {
                themhdn.BringToFront();
            }
        }

        private void btnBCKD_Click(object sender, EventArgs e)
        {
            if(baocaoDT == null || baocaoDT.IsDisposed)
            {
                baocaoDT = new formBaocaoDT();
                baocaoDT.TopLevel = false;
                baocaoDT.FormBorderStyle = FormBorderStyle.None;
                baocaoDT.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(baocaoDT);
                baocaoDT.Show();
            }
            else
            {
                baocaoDT.BringToFront();
            }
        }

        private void btnBCNV_Click(object sender, EventArgs e)
        {
            if(baocaoNV == null || baocaoNV.IsDisposed)
            {
                baocaoNV = new formBaocaoNV();
                baocaoNV.TopLevel = false;
                baocaoNV.FormBorderStyle = FormBorderStyle.None;
                baocaoNV.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(baocaoNV);
                baocaoNV.Show();
            }
            else
            {
                baocaoNV.BringToFront();
            }
        }

        private void btnBCSP_Click(object sender, EventArgs e)
        {
            if(baocaoSP == null || baocaoSP.IsDisposed)
            {
                baocaoSP = new formBaocaoSP();
                baocaoSP.TopLevel = false;
                baocaoSP.FormBorderStyle = FormBorderStyle.None;
                baocaoSP.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(baocaoSP);
                baocaoSP.Show();
            }
            else
            {
                baocaoSP.BringToFront();
            }
        }
    }
}
