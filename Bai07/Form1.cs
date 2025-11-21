using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
        }

        private double LayGiaTien(int soGhe)
        {
            if (soGhe <= 5) return 5000;
            else if (soGhe <= 10) return 6500;
            else return 8000;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            double tongTien = 0;

            foreach (Control c in grpGhe.Controls)
            {
                if (c is Button)
                {
                    Button btn = c as Button;

                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;

                        int soGhe = int.Parse(btn.Text);
                        tongTien += LayGiaTien(soGhe);
                    }
                }
            }

            txtThanhTien.Text = tongTien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpGhe.Controls)
            {
                if (c is Button)
                {
                    Button btn = c as Button;

                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }

            txtThanhTien.Text = "0";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}