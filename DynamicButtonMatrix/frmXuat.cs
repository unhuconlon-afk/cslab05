using System;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicButtonMatrix
{
    public partial class frmXuat : Form
    {
        // Automatic Properties theo hướng dẫn mục 2.3
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SoDong { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SoCot { get; set; }

        // Field kích thước và lề
        private int h = 42;
        private int margin = 6;

        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();

            this.SoDong = dong;
            this.SoCot = cot;

            // Thêm các control Button vào panelContainer theo ma trận dòng x cột
            panelContainer.SuspendLayout();

            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Button btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btn.BackColor = Color.FromArgb(235, 240, 248);
                    btn.FlatStyle = FlatStyle.Standard;

                    // Gắn sự kiện cho button theo đúng hướng dẫn tài liệu
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.MouseEnter += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i + 1, j + 1);

                    panelContainer.Controls.Add(btn);
                }
            }

            panelContainer.ResumeLayout(true);

            // Chỉnh lại kích thước Form theo công thức giáo trình
            int contentW = SoCot * (h + margin) + margin + 35;
            int contentH = SoDong * (h + margin) + margin + 80;

            // Giới hạn trong khoảng màn hình hợp lý [320x300, 1024x720]
            int formW = Math.Clamp(contentW, 360, 1100);
            int formH = Math.Clamp(contentH, 320, 750);

            this.ClientSize = new Size(formW, formH);
            this.Text = $"Ma trận mảng [{SoDong} dòng x {SoCot} cột] - Tổng cộng: {SoDong * SoCot} Buttons";
        }

        // Sự kiện khi rê chuột lên Button: cập nhật tiêu đề Form và thanh trạng thái
        private void HoChuotLenButton(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                string info = btn.Tag.ToString() ?? "";
                this.Text = $"{info} | Giá trị: {btn.Text}";
                lblStatus.Text = $"Đang trỏ vào: {info} (Giá trị button: {btn.Text})";
            }
        }

        // Sự kiện khi bấm vào Button: hiện MessageBox
        private void btn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show($"Bạn vừa nhấn Button có giá trị: {btn.Text}\nVị trí: {btn.Tag}",
                                "Thông báo Button Click",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
