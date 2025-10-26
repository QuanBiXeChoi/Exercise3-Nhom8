# BÀI TẬP NHÓM 8 - BÀI 3

## Viết ứng dụng quản lý người dùng với tính năng đăng nhập, đăng ký với TCP socket

Tạo ứng dụng quản lý người dùng với các tính năng đăng nhập, đăng ký sử dụng TCP socket trong Windows Forms bằng C\#. Thông tin người dùng được lưu trữ vào cơ sở dữ liệu SQL Server.

**Link GitHub:** [https://github.com/QuanBiXeChoi/Exercise3-Nhom8]

-----

### Tính năng chính

  * **Giao diện người dùng:**
      * Chức năng đăng ký gửi yêu cầu đến TCP server.
      * Chức năng đăng nhập có xác thực từ TCP server.
      * Đăng xuất và tự động đăng xuất khi token hết hạn.
      * Xem thông tin người dùng.

  * **Cơ sở dữ liệu:**
      * Lưu trữ thông tin người dùng.
      * Mã hóa mật khẩu để bảo mật.

  * **Giao tiếp Client-Server:**
      * Sử dụng TCP socket.
      * Quản lý đa kết nối bằng multiple thread.
      * Xử lý nhiều kết nối đồng thời trên server.

  * **Bảo mật và xác thực:**
      * Cấp phát Token cho Client khi đăng nhập thành công.

  * **Trải nghiệm người dùng:**
      * Xử lý exception để đảm bảo ứng dụng hoạt động ổn định.

-----

### Các thành phần cần thiết

  * Ít nhất 2 máy tính (hoặc chạy client và server trên cùng máy bằng localhost).
  * Có kết nối giữa hai máy với nhau nếu không dùng localhost (Ethernet, Wifi)
  * [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
  * [SQL Server 2022](https://www.microsoft.com/vi-vn/sql-server/sql-server-downloads)

-----

### Hướng dẫn cài đặt

#### 1\. Tải và cài đặt các phần mềm cần thiết

Đảm bảo bạn đã cài đặt Visual Studio 2022 và SQL Server 2022.

#### 2\. Cài đặt các thành phần cho Visual Studio 2022

Mở Visual Studio Installer và chắc chắn rằng các thành phần sau đã được cài đặt:

**Workloads:**

  * `.NET desktop development`
  * `Data storage and processing`
  * `.NET Framework 4.7.2` (hoặc cao hơn)

**Individual Components:**

  * `SQL Server Express LocalDB`
  * `SQL Server Data Tools`

#### 3\. Tải mã nguồn dự án

**Cách 1: Dùng `git clone`**

```bash
git clone https://github.com/Thay link
```

Sau đó, vào thư mục vừa tải về và mở file `Thay tên.sln`.

**Cách 2: Tải file .zip**

  * Tải file zip từ repository.
  * Giải nén file.
  * Vào thư mục vừa giải nén và mở file `Thay tên.sln`.

#### 4\. Tạo Server và Database

1.  Trên máy Server, kết nối đến Database `(localdb)\MSSQLLocalDB` bằng [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/ssms/) hoặc trực tiếp từ Visual Studio.
2.  Thực thi (execute) file `Exercise3.sql` để tạo cơ sở dữ liệu và các bảng cần thiết.

#### 5\. Build và chạy ứng dụng

1.  Trong Visual Studio, chuột phải vào project Server và chọn **"Set as Startup Project"**.
2.  Nhấn **Debug -\> Start Debugging** (hoặc F5) để chạy Server.
3.  Lặp lại các bước trên cho project Client.

-----

### Hướng dẫn sử dụng

**TCP Server:**

1.  Đảm bảo Database đã được tạo và đang chạy.
2.  Cấu hình Server (đảm bảo đúng tên đăng nhập và mật khẩu, địa chỉ Database).
3.  Chạy file `server.exe`. (Thay tên file)
4.  Lấy địa chỉ IP của máy Server để Client có thể kết nối.

**TCP Client:**

1.  Đảm bảo Server đã được bật.
2.  Mở file cấu hình của Client và cập nhật địa chỉ IP của Server.
3.  Chạy ứng dụng Client.
4.  Thực hiện các chức năng:
      * Đăng ký tài khoản
      * Đăng nhập bằng tài khoản vừa tạo.
      * Xem thông tin tài khoản và Log out tài khoản

-----

### Tài liệu tham khảo

  * [Tài liệu C\#](https://docs.microsoft.com/en-us/dotnet/csharp/)
  * [Tài liệu WinForms](https://learn.microsoft.com/vi-vn/dotnet/desktop/winforms/)
  * [Tài liệu SQL Server](https://learn.microsoft.com/en-us/sql/?view=sql-server-ver17)
  * [Tài liệu TCP Socket](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/socket-services)
  * Tài liệu của giáo viên

-----

### Credits

**Nhóm 8**

| Tên thành viên | MSSV |
| :--- | :--- |
| Nguyễn Quang Thế Anh | `24520115` |
| Nguyễn Nhật Anh | `24520112` |
| Nguyễn Hoàng Anh | `24520102` |
| Phạm Phú Quang | `24521478` |
| Trần Minh Hoàng Quân | `24521454` |


