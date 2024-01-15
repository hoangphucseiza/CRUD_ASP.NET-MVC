INSERT INTO ChuyenBay (MaCH, Chuyen, DDi, DDen, Ngay, GBay, GDen, Thuong, Vip, MaMB)
VALUES ('CB001', 'Chuyến Bay 1', 'Ha Noi', 'Ho Chi Minh', '2024-01-15', '10:00 AM', '02:00 PM', 100, 50, 'MB001');


-- Thêm 5 dòng dữ liệu cho bảng HanhKhach
INSERT INTO HanhKhach (MaHK, HoTen, DiaChi, DienThoai)
VALUES 
    ('HK001', 'Nguyen Van A', '123 ABC Street', '0123456789'),
    ('HK002', 'Tran Thi B', '456 XYZ Street', '0987654321'),
    ('HK003', 'Le Van C', '789 DEF Street', '0123456789'),
    ('HK004', 'Pham Thi D', '101 GHI Street', '0987654321'),
    ('HK005', 'Hoang Van E', '202 JKL Street', '0123456789');

-- Thêm 5 dòng dữ liệu cho bảng CT_CB
INSERT INTO CT_CB (MaCH, MaHK, SoGhe, LoaiGhe)
VALUES 
    ('CB001', 'HK001', 'SoGheXYZ1', 1),
    ('CB001', 'HK002', 'SoGheXYZ2', 1),
    ('CB001', 'HK003', 'SoGheXYZ3', 0),
    ('CB001', 'HK004', 'SoGheXYZ4', 0),
    ('CB001', 'HK005', 'SoGheXYZ5', 1);
