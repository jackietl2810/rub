using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreManagement
{
    public partial class frmFashionStoreManagement : Form
    {
        public frmFashionStoreManagement()
        {
            InitializeComponent();
            
            ucSaleManagement ucsm = new ucSaleManagement();
            ucsm.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucsm);
           // mtpManage.Hide();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucProductManagement ucpm = new ucProductManagement();
            ucpm.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucpm);
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucEventManagement ucem = new ucEventManagement();
            ucem.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucem);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucHoaDonBanHang ucb = new ucHoaDonBanHang();
            ucb.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucb);
        }

        private void metroTabItem4_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucCustomerManagement uccm = new ucCustomerManagement();
            uccm.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(uccm);
        }

        private void metroTabItem1_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucSupplier ucs = new ucSupplier();
            ucs.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucs);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucStatisticsSale uss = new ucStatisticsSale();
            uss.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(uss);
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucManage add = new ucManage();
            add.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(add);
        }

        private void metroTabPanel4_Click(object sender, EventArgs e)
        {

        }

        private void mtiManage_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ucSaleManagement add = new ucSaleManagement();
            add.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(add);
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            ucProductManagement product = new ucProductManagement();
            controlPanel.Controls.Clear();

            product.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(product);
        }

        private void buttonItem3_Click_2(object sender, EventArgs e)
        {
            ucHoaDonNhapHang nhaphang = new ucHoaDonNhapHang();
            controlPanel.Controls.Clear();

            nhaphang.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(nhaphang);
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            traHang tra = new traHang();
            controlPanel.Controls.Clear();

            tra.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(tra);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            ucStoreSettings ucSS = new ucStoreSettings();
            controlPanel.Controls.Clear();

            ucSS.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucSS);
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            ucUserManage ucSS = new ucUserManage();
            controlPanel.Controls.Clear();
            ucSS.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(ucSS);
        }      
    }
}
