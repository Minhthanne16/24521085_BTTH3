using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {

        Double resultValue = 0; //Luu gia tri ket qua

        Double memory = 0; //Luu gia tri trong bo nho

        String operationPerformed = "";  //Luu phep tinh dang thuc hien

        bool isOperationPerformed = false;  //KT co an nut phep tinh khong

        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
          
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false; 

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))  
                    txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Lưu phép tính vừa chọn 
            operationPerformed = button.Text;

            // Lưu số đang có trên màn hình vào biến resultValue
            resultValue = Double.Parse(txtDisplay.Text);

            // Bật cờ hiệu để biết là người dùng đã chọn xong phép tính
            // (để lần sau nhập số sẽ xóa màn hình cũ đi)
            isOperationPerformed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        { 
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    // Có thể thêm kiểm tra chia cho 0 ở đây
                    if (Double.Parse(txtDisplay.Text) == 0)
                        MessageBox.Show("Không thể chia cho 0, vui lòng đổi số khác");
                    else
                        txtDisplay.Text = (resultValue / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }

            // Cập nhật lại resultValue bằng kết quả mới
            resultValue = Double.Parse(txtDisplay.Text);
            operationPerformed = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txtDisplay.Text);
            if (val < 0)
            {
                txtDisplay.Text = "Invalid Input";
            }
            else
                txtDisplay.Text = Math.Sqrt(val).ToString();
            isOperationPerformed = true; // danh dau la da tinh xong
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Xóa ký tự cuối cùng
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            // Nếu xóa hết sạch trơn thì gán lại về 0
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txtDisplay.Text); // chuyen noi dung display sang kieu double
            val = val * -1;
            txtDisplay.Text = val.ToString();
        }

        private void btnNghichDao_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txtDisplay.Text);
            if (val == 0)
            {
                MessageBox.Show("Không thể chia cho 0","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                resultValue = 0;
                operationPerformed = "";
            }
            else
            {
                val = 1 / val;
                txtDisplay.Text = val.ToString();
            }
            isOperationPerformed = true; // danh dau la da tinh xong
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txtDisplay.Text);
            val = val / 100;
            txtDisplay.Text = val.ToString();
            isOperationPerformed = true; // danh dau la da tinh xong
        }

        // Nút MS (Memory Store): Lưu số hiện tại vào bộ nhớ
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtDisplay.Text);

             lblmemory.Text = "M"; 
            isOperationPerformed = true;
        }

        // Nút MR (Memory Recall): Lấy số từ bộ nhớ ra màn hình
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
            isOperationPerformed = true;
        }

        // Nút MC (Memory Clear): Xóa bộ nhớ về 0
        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            lblmemory.Text = "";
        }

        // Nút M+ (Memory Add): Cộng thêm số hiện tại vào bộ nhớ
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thân Nhật Minh", "Nhà sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}