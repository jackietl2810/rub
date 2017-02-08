using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreManagement
{
    public partial class ucHoaDonBanHang : UserControl
    {
        public ucHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmTraHang frmTra = new fmTraHang();
            frmTra.ShowDialog();
            
        }
    }
}
