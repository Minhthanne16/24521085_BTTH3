using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TinhTongTien()
        {
            double tongTien = 0;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                tongTien += double.Parse(item.SubItems[4].Text);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu()) return;

            ListViewItem itemFound = null;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSoTK.Text)
                {
                    itemFound = item;
                    break;
                }
            }

            if (itemFound == null)
            {
                int stt = lvTaiKhoan.Items.Count + 1;

                ListViewItem newItem = new ListViewItem(stt.ToString());
                newItem.SubItems.Add(txtSoTK.Text);
                newItem.SubItems.Add(txtTenKH.Text);
                newItem.SubItems.Add(txtDiaChi.Text);
                newItem.SubItems.Add(txtSoTien.Text);

                lvTaiKhoan.Items.Add(newItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
            else
            {
                itemFound.SubItems[2].Text = txtTenKH.Text;
                itemFound.SubItems[3].Text = txtDiaChi.Text;
                itemFound.SubItems[4].Text = txtSoTien.Text;

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
            }

            TinhTongTien();

            txtSoTK.Text = ""; txtTenKH.Text = ""; txtDiaChi.Text = ""; txtSoTien.Text = "";
            txtSoTK.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem itemToRemove = null;

            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                itemToRemove = lvTaiKhoan.SelectedItems[0];
            }
            else if (!string.IsNullOrWhiteSpace(txtSoTK.Text))
            {
                foreach (ListViewItem item in lvTaiKhoan.Items)
                {
                    if (item.SubItems[1].Text == txtSoTK.Text && item.SubItems[2].Text == txtTenKH.Text && item.SubItems[3].Text == txtDiaChi.Text)
                    {
                        itemToRemove = item;
                        break;
                    }
                }
            }

            if (itemToRemove != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lvTaiKhoan.Items.Remove(itemToRemove);

                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");

                    TinhTongTien();

                    for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
                    {
                        lvTaiKhoan.Items[i].Text = (i + 1).ToString();
                    }

                    txtSoTK.Text = ""; txtTenKH.Text = ""; txtDiaChi.Text = ""; txtSoTien.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa HOẶC nhập đúng Số Tài Khoản!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTaiKhoan.SelectedItems[0];

                txtSoTK.Text = selectedItem.SubItems[1].Text;
                txtTenKH.Text = selectedItem.SubItems[2].Text;
                txtDiaChi.Text = selectedItem.SubItems[3].Text;
                txtSoTien.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}