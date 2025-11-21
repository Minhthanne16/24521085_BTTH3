using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);

            Color randomColor = Color.FromArgb(r, g, b);

            this.BackColor = randomColor;
        }
    }
}