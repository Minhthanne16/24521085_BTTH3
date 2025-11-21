using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string textToDraw = "Paint Event";
            Font drawFont = new Font("Times New Roman", 12);
            Brush drawBrush = new SolidBrush(Color.Black);

            // Đo kích thước của chuỗi văn bản sẽ vẽ
            SizeF textSize = e.Graphics.MeasureString(textToDraw, drawFont);

            // tính toán tọa độ x,y tối đa để vẽ chuỗi
            int maxX = this.ClientSize.Width - (int)textSize.Width;
            int maxY = this.ClientSize.Height - (int)textSize.Height;
            if (maxX <= 0) maxX = 0;
            if (maxY <= 0) maxY = 0;

            // thiết lập tọa độ random giới hạn trong form
            int x = rand.Next(0, maxX + 1);
            int y = rand.Next(0, maxY + 1);

            // Vẽ chuỗi với tọa độ x,y ở trên
            e.Graphics.DrawString(textToDraw, drawFont, drawBrush, x, y);

            //Giải phóng tài nguyên
            drawFont.Dispose();
            drawBrush.Dispose();
        }
    }
}