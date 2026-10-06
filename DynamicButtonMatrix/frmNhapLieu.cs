using System;
using System.Windows.Forms;

namespace DynamicButtonMatrix
{
    public partial class frmNhapLieu : Form
    {
        public frmNhapLieu()
        {
            InitializeComponent();
        }

        // 2.4 Xử lý nút khởi tạo ở form khởi tạo
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int sodong, socot;
            if (!int.TryParse(txtSoDong.Text, out sodong) || sodong <= 0)
            {
                MessageBox.Show("Số dòng phải là số nguyên dương lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDong.Focus();
                return;
            }

            if (!int.TryParse(txtSoCot.Text, out socot) || socot <= 0)
            {
                MessageBox.Show("Số cột phải là số nguyên dương lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoCot.Focus();
                return;
            }

            if (sodong > 50 || socot > 50)
            {
                var result = MessageBox.Show($"Bạn đã nhập kích thước lớn ({sodong}x{socot} = {sodong * socot} button). Có muốn tiếp tục tạo không?",
                                             "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
            }

            frmXuat frmX = new frmXuat(sodong, socot);
            frmX.StartPosition = FormStartPosition.CenterScreen;
            frmX.ShowDialog(); // Hiện form xuất mảng
        }
    }
}
