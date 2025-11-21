namespace Bai05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTCong = new System.Windows.Forms.Button();
            this.BTTru = new System.Windows.Forms.Button();
            this.BTNhan = new System.Windows.Forms.Button();
            this.BTChia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTCong
            // 
            this.BTCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCong.Location = new System.Drawing.Point(123, 261);
            this.BTCong.Name = "BTCong";
            this.BTCong.Size = new System.Drawing.Size(94, 39);
            this.BTCong.TabIndex = 0;
            this.BTCong.Text = "+";
            this.BTCong.UseVisualStyleBackColor = true;
            this.BTCong.Click += new System.EventHandler(this.BTCong_Click);
            // 
            // BTTru
            // 
            this.BTTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTru.Location = new System.Drawing.Point(302, 260);
            this.BTTru.Name = "BTTru";
            this.BTTru.Size = new System.Drawing.Size(94, 39);
            this.BTTru.TabIndex = 1;
            this.BTTru.Text = "-";
            this.BTTru.UseVisualStyleBackColor = true;
            this.BTTru.Click += new System.EventHandler(this.BTTru_Click);
            // 
            // BTNhan
            // 
            this.BTNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNhan.Location = new System.Drawing.Point(498, 261);
            this.BTNhan.Name = "BTNhan";
            this.BTNhan.Size = new System.Drawing.Size(94, 39);
            this.BTNhan.TabIndex = 2;
            this.BTNhan.Text = "x";
            this.BTNhan.UseVisualStyleBackColor = true;
            this.BTNhan.Click += new System.EventHandler(this.BTNhan_Click);
            // 
            // BTChia
            // 
            this.BTChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTChia.Location = new System.Drawing.Point(644, 261);
            this.BTChia.Name = "BTChia";
            this.BTChia.Size = new System.Drawing.Size(94, 39);
            this.BTChia.TabIndex = 3;
            this.BTChia.Text = "/";
            this.BTChia.UseVisualStyleBackColor = true;
            this.BTChia.Click += new System.EventHandler(this.BTChia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number 2";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(375, 71);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(241, 26);
            this.txtBox1.TabIndex = 6;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(375, 160);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(241, 26);
            this.txtBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(375, 343);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(241, 26);
            this.Res.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTChia);
            this.Controls.Add(this.BTNhan);
            this.Controls.Add(this.BTTru);
            this.Controls.Add(this.BTCong);
            this.Name = "Form1";
            this.Text = "Lab3-Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCong;
        private System.Windows.Forms.Button BTTru;
        private System.Windows.Forms.Button BTNhan;
        private System.Windows.Forms.Button BTChia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Res;
    }
}

