# Windows Programming with C# - LAB 05: Dynamic Button Matrix

Kho lưu trữ bài tập thực hành môn **Lập trình trên môi trường Windows với C# (Windows Programming with C#)** - **LAB 05 / LAB 06**:
**Làm việc với Mảng động & Truyền dữ liệu giữa các Form (Windows Forms Application)**.

Giảng viên hướng dẫn: **ThS. Lương Trần Hy Hiến** - Khoa CNTT, ĐH Sư Phạm TP.HCM.

---

## Mục tiêu bài thực hành
1. **Truyền dữ liệu giữa các Form**:
   - Truyền tham số số dòng (`SoDong`) và số cột (`SoCot`) từ Form nhập liệu (`frmNhapLieu`) sang Form xuất ma trận (`frmXuat`) thông qua Constructor có tham số và Properties.
2. **Khởi tạo và định vị Control động trên Form**:
   - Sử dụng vòng lặp lồng nhau 2 chiều `for(i)` và `for(j)` để sinh động $M \times N$ control `Button`.
   - Tính toán tọa độ hiển thị `Left`, `Top`, kích thước $h = 42$, khoảng cách lề `margin = 6` một cách chính xác.
   - Gán nhãn số thứ tự tự động: `Text = (i * SoCot + j + 1).ToString()`.
   - Lưu trữ tọa độ dòng và cột vào thuộc tính `Tag = "Dòng i+1 cột j+1"`.
3. **Ủy quyền và xử lý sự kiện động (Dynamic Event Binding)**:
   - Gắn sự kiện `Click` cho từng Button: Hiển thị `MessageBox` thông báo giá trị và vị trí của button được nhấn.
   - Gắn sự kiện `MouseHover` & `MouseEnter`: Cập nhật tiêu đề Form (`this.Text`) và thanh trạng thái (`StatusStrip`) hiển thị vị trí (dòng, cột) đang trỏ chuột vào trong thời gian thực.
4. **Tự động điều chỉnh kích thước & Hỗ trợ cuộn**:
   - Tự động điều chỉnh kích thước Form theo kích thước ma trận.
   - Tích hợp thanh cuộn tự động (`AutoScroll`) trong Panel chứa để hỗ trợ hiển thị mượt mà ngay cả khi ma trận có kích thước lớn.

---

## Cấu trúc thư mục dự án

```text
cslab05/
├── .gitignore
├── README.md
├── DynamicButtonMatrix.sln            # Solution Visual Studio
└── DynamicButtonMatrix/
    ├── DynamicButtonMatrix.csproj     # File cấu hình dự án Windows Forms
    ├── Program.cs                     # Điểm khởi chạy ứng dụng (chạy frmNhapLieu)
    ├── frmNhapLieu.cs                 # Form nhập số dòng, số cột
    ├── frmNhapLieu.Designer.cs
    ├── frmXuat.cs                     # Form sinh động ma trận Button và xử lý sự kiện
    └── frmXuat.Designer.cs
```

---

## Hướng dẫn thực thi

### 1. Mở bằng Visual Studio
- Nhấp đúp vào file `DynamicButtonMatrix.sln`.
- Bấm phím **F5** (hoặc **Ctrl + F5**) để khởi chạy.
- Nhập số dòng (ví dụ: `5`), số cột (ví dụ: `6`) và bấm nút **Khởi tạo mảng Button**.

### 2. Chạy bằng .NET CLI
```bash
# Di chuyển vào thư mục cslab05 và chạy lệnh:
dotnet run --project DynamicButtonMatrix/DynamicButtonMatrix.csproj
```
