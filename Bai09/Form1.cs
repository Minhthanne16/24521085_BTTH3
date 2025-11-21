using System;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboChuyenNganh.Items.Add("Hệ thống thông tin");
            cboChuyenNganh.Items.Add("Công nghệ phần mềm");
            cboChuyenNganh.Items.Add("An toàn thông tin");
            cboChuyenNganh.Items.Add("Mạng máy tính & Viễn thông");
            cboChuyenNganh.SelectedIndex = 0;

            lbMonHoc.Items.Add("Cơ sở dữ liệu");
            lbMonHoc.Items.Add("Cơ sở dữ liệu NC");
            lbMonHoc.Items.Add("Phân tích thiết kế HTTT");
            lbMonHoc.Items.Add("Lập trình trực quan");
            lbMonHoc.Items.Add("Cấu trúc dữ liệu & Giải thuật");
            lbMonHoc.Items.Add("Tin học cơ sở");

            // Cấu hình DataGridView
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.RowHeadersVisible = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lbMonHoc.SelectedItem != null)
            {
                lbMonDaChon.Items.Add(lbMonHoc.SelectedItem);
                lbMonHoc.Items.Remove(lbMonHoc.SelectedItem);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if (lbMonDaChon.SelectedItem != null)
            {
                lbMonHoc.Items.Add(lbMonDaChon.SelectedItem);
                lbMonDaChon.Items.Remove(lbMonDaChon.SelectedItem);
            }
        }
        private void ResetForm()
        {
            // 1. Xóa trắng các ô nhập liệu
            txtMSSV.Text = "";
            txtHoTen.Text = "";

            // 2. Đưa Chuyên ngành về mặc định (dòng đầu tiên)
            if (cboChuyenNganh.Items.Count > 0)
                cboChuyenNganh.SelectedIndex = 0;

            foreach (var item in lbMonDaChon.Items)
            {
                lbMonHoc.Items.Add(item);
            }
            // Sau khi trả về hết thì xóa sạch lbMonDaChon
            lbMonDaChon.Items.Clear();

            // 5. Đưa con trỏ chuột về ô MSSV để tiện nhập tiếp
            txtMSSV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Họ Tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();
                return;
            }

            // Lấy thông tin
            string mssv = txtMSSV.Text;
            string hoten = txtHoTen.Text;

            string chuyennganh = "";
            if (cboChuyenNganh.SelectedItem != null)
                chuyennganh = cboChuyenNganh.SelectedItem.ToString();

            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            int soMon = lbMonDaChon.Items.Count;

            // Thêm vào bảng
            dgvSinhVien.Rows.Add(mssv, hoten, chuyennganh, gioitinh, soMon);

            // Thông báo thành công (tùy chọn)
            MessageBox.Show("Lưu thông tin thành công!", "Thông báo");

            // --- GỌI HÀM RESET FORM TẠI ĐÂY ---
            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvSinhVien.Rows.Remove(dgvSinhVien.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng để xóa!", "Thông báo");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}