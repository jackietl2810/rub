﻿using System;
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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addHangHoa nhap = new addHangHoa();
            nhap.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addNhaCungCap nhacungcap = new addNhaCungCap();
            nhacungcap.ShowDialog();
        }
    }
}
