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
    public partial class ucProductManagement : UserControl
    {
        public ucProductManagement()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            addHangHoa frmThemHang = new addHangHoa();
            frmThemHang.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            editProduct frmeditProduct = new editProduct();
            frmeditProduct.ShowDialog();
        }
    }
}
