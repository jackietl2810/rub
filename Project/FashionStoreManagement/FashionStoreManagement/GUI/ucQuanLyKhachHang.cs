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
    public partial class ucCustomerManagement : UserControl
    {
        public ucCustomerManagement()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addManage manage = new addManage();
            manage.ShowDialog();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupManage manage = new groupManage();
            manage.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupManage manage = new groupManage();
            manage.ShowDialog();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn xóa !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
