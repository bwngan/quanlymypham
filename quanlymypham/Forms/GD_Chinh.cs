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
        public GD_Chinh()
        {
            InitializeComponent();
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
                Sidebar.Width -= 10;
                if (Sidebar.Width <= 42)
                {
                    SidebarTransition.Stop();
                    SidebarExpand = false;
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width >= 232)
                {
                    SidebarTransition.Stop();
                    SidebarExpand = true;
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
    }
}
