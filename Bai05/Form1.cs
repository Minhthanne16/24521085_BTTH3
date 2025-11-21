using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateAndGetInputs(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;

            if (!double.TryParse(txtBox1.Text, out num1))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho 'Number 1'.", "Lỗi Đầu Vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtBox2.Text, out num2))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho 'Number 2'.", "Lỗi Đầu Vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }


        private void BTCong_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (ValidateAndGetInputs(out num1, out num2))
            {
                double result = num1 + num2;
                Res.Text = result.ToString();
            }
        }

        private void BTTru_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (ValidateAndGetInputs(out num1, out num2))
            {
                double result = num1 - num2;
                Res.Text = result.ToString();
            }
        }

        private void BTNhan_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (ValidateAndGetInputs(out num1, out num2))
            {
                double result = num1 * num2;
                Res.Text = result.ToString();
            }
        }

        private void BTChia_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (ValidateAndGetInputs(out num1, out num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.", "Lỗi Phép Tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Res.Text = "Error";
                }
                else
                {
                    double result = num1 / num2;
                    Res.Text = result.ToString();
                }
            }
        }

   

  
    }
}