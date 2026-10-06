namespace DynamicButtonMatrix
{
    partial class frmNhapLieu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSoDong = new Label();
            txtSoDong = new TextBox();
            lblSoCot = new Label();
            txtSoCot = new TextBox();
            btnKhoiTao = new Button();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(24, 76, 120);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(384, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(384, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHẬP KÍCH THƯỚC MẢNG N DÒNG M CỘT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoDong
            // 
            lblSoDong.AutoSize = true;
            lblSoDong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoDong.Location = new Point(45, 80);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Size = new Size(65, 19);
            lblSoDong.TabIndex = 1;
            lblSoDong.Text = "Số dòng:";
            // 
            // txtSoDong
            // 
            txtSoDong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDong.Location = new Point(130, 77);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(200, 25);
            txtSoDong.TabIndex = 2;
            txtSoDong.Text = "5";
            // 
            // lblSoCot
            // 
            lblSoCot.AutoSize = true;
            lblSoCot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoCot.Location = new Point(45, 125);
            lblSoCot.Name = "lblSoCot";
            lblSoCot.Size = new Size(51, 19);
            lblSoCot.TabIndex = 3;
            lblSoCot.Text = "Số cột:";
            // 
            // txtSoCot
            // 
            txtSoCot.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoCot.Location = new Point(130, 122);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(200, 25);
            txtSoCot.TabIndex = 4;
            txtSoCot.Text = "6";
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.BackColor = Color.FromArgb(0, 123, 255);
            btnKhoiTao.FlatStyle = FlatStyle.Flat;
            btnKhoiTao.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoiTao.ForeColor = Color.White;
            btnKhoiTao.Location = new Point(100, 175);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(180, 40);
            btnKhoiTao.TabIndex = 5;
            btnKhoiTao.Text = "Khởi tạo mảng Button";
            btnKhoiTao.UseVisualStyleBackColor = false;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // frmNhapLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(384, 240);
            Controls.Add(btnKhoiTao);
            Controls.Add(txtSoCot);
            Controls.Add(lblSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(lblSoDong);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNhapLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập dữ liệu - Lab 05/06";
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSoDong;
        private TextBox txtSoDong;
        private Label lblSoCot;
        private TextBox txtSoCot;
        private Button btnKhoiTao;
    }
}
