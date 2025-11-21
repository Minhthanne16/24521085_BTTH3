using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; 

namespace Bai01
{
    public partial class Form1 : Form
    {
        // Khai báo các control để hiển thị log
        private ListBox lstLog;
        private Label lblInstruction;

        public Form1()
        {
            InitializeCustomUI();

            LogEvent("1. Construction (Constructor)");
        }
        private void InitializeCustomUI()
        {
            this.Text = "Minh họa Vòng đời Form (Bai01)";
            this.Size = new Size(450, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            lstLog = new ListBox();
            lstLog.Dock = DockStyle.Fill;
            lstLog.Font = new Font("Times New Roman", 14); 
            this.Controls.Add(lstLog);
        }

        private void LogEvent(string eventName)
        {
            string message = $"{DateTime.Now:hh:mm:ss} -> {eventName}";

            if (lstLog != null && !lstLog.IsDisposed)
            {
                lstLog.Items.Add(message);
                lstLog.TopIndex = lstLog.Items.Count - 1; 
            }
            Debug.WriteLine(message);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LogEvent("2. Load");
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LogEvent("3. Activated (Focus)");
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LogEvent("4. Shown");
        }
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            LogEvent("--- Deactivate (Lost Focus) ---");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LogEvent("5. FormClosing");

            DialogResult result = MessageBox.Show("Sự kiện FormClosing đang chạy.\nBạn có chắc muốn đóng form?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
                LogEvent("-> Đã hủy đóng form");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            LogEvent("6. FormClosed");
            MessageBox.Show("FormClosed: Form đã đóng hoàn tất.");
        }
    }
}