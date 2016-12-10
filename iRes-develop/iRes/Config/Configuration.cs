﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Title.Config {
    public class Configuration {

        public string GetProjectLinkDirectory()
        {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }

        //public string DATA_SOURCE = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";
        //public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
       // public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";
        public string DATA_SOURCE = @"Data Source=DESKTOP-4M4EC8O\SQLEXPRESS;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";//ThuanEnvity
    
        // Property of KhachHang
        public string KHACHHANG_MAKH = "MaKH";
        public string KHACHHANG_TENKH = "TenKH";
        public string KHACHHANG_DIACHI = "DiaChi";
        public string KHACHHANG_SDT = "SDT";
        public string KHACHHANG_EMAIL = "Email";
        public string KHACHHANG_SOLANAN = "SoLanAn";
        public string KHACHHANG_TONGTIEN = "TongTienDaChi";
        public string KHACHHANG_PHANLOAI = "PhanLoaiKH";

        // Property of MonAn
        public string MONAN_MAMON = "MaMon";
        public string MONAN_TENMON = "TenMon";
        public string MONAN_MANHOM = "MaNhom";
        public string MONAN_HINHANH = "HinhAnh";
        public string MONAN_SOLUONG = "SoLuong";
        public string MONAN_DONGIA = "DonGia";
        // Property of NhomMon
        public string NHOMMON_MANHOM = "MaNhom";
        public string NHOMMON_TENNHOM = "TenNhom";
        public string NHOMMON_TONGSOMON = "TongSoMon";
        // Property of BanAn
        public string BANAN_MABAN = "MaBan";
        public string BANAN_TRANGTHAI = "TrangThai";
        public string BANAN_MAHOADON = "MaHD";
        public string BANAN_TRANGTHAI_DANG_DUNG = "Đang dùng";
        public string BANAN_TRANGTHAI_TRONG = "Trống";

        // Property of ChiTietHoaDon
        public string CHI_TIET_HOA_DON_MA_HOA_DON = "MaHD";
        public string CHI_TIET_HOA_DON_MA_MON = "MaMon";
        public string CHI_TIET_HOA_DON_SO_LUONG = "SoLuong";
        public string CHI_TIET_HOA_DON_GIA_MON = "GiaMon";
        public string CHI_TIET_HOA_DON_THANH_TIEN = "ThanhTien";
        public string CHI_TIET_HOA_DON_GHI_CHU = "GhiChu";

        // Property of HoaDon
        public string HOA_DON_MA_HOA_DON = "MaHD";
        public string HOA_DON_THOI_GIAN = "ThoiGianAn";
        public string HOA_DON_MA_KHACH_HANG = "MaKH";
        public string HOA_DON_MA_NHAN_VIEN = "MaNV";
        public string HOA_DON_THANH_TIEN = "ThanhTien";
        public string HOA_DON_CHIET_KHAU = "ChietKhau";
        public string HOA_DON_TONG_TIEN = "TongTien";
 

        // Proceduces of NhanVien
        public string PROC_GET_LIST_NHANVIEN = "DanhSachNhanVien";
        public string PROC_INSERT_NHANVIEN = "ThemNhanVien";
        public string PROC_DELETE_NHANVIEN = "XoaNhanVien";
        public string PROC_UPDATE_NHANVIEN = "SuaNhanVien";

        // Proceduces of KhachHang
        public string PROC_GET_LIST_KHACHHANG = "DanhSachKhachHang";
        public string PROC_UPDATE_KHACHHANG = "SuaKhachHang";
        public string PROC_DELETE_KHACHHANG = "XoaKhachHang";
        public string PROC_INSERT_KHACHHANG  = "ThemKhachHang";

        // Proceduces of MonAn
        public string PROC_GET_LIST_MONAN = "DanhSachMonAn";
        public string PROC_GET_LIST_MONAN_BY_NHOM_MON = "DanhSachMonAnByNhomMon";
//        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\khanhlq\Documents\Visual Studio 2015\Projects\DevExpress\iRes\iRes\Resources\MonAn\'
//                                                + HinhAnh as nvarchar(4000)) as [Hình ảnh],
//                                                MaMon as [Mã món ăn], 
//                                                TenMon as [Tên món ăn],
//                                                MaNhom as [Mã nhóm],
//                                                DonGia as [Đơn giá],
//                                                SoLuongDangCo as [Số lương] from MonAn";
//        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\tran\Documents\Visual Studio 2012\Projects\iRes\iRes\Resources\MonAn\'
//                                                + HinhAnh as nvarchar(4000)) as [Hình ảnh],
//                                                MaMon as [Mã món ăn], 
//                                                TenMon as [Tên món ăn],
//                                                MaNhom as [Mã nhóm],
//                                                DonGia as [Đơn giá],
//                                                SoLuongDangCo as [Số lương] from MonAn";
        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\Thuan Nguyen\Desktop\iRes-develop\iRes-develop\iRes\Resources\MonAn\'
                                                + HinhAnh as nvarchar(4000)) as [Hình ảnh],
                                                MaMon as [Mã món ăn], 
                                                TenMon as [Tên món ăn],
                                                MaNhom as [Mã nhóm],
                                                DonGia as [Đơn giá],
                                                SoLuongDangCo as [Số lương] from MonAn";

        // Proceduces of NhomMon
        public string PROC_GET_LIST_NHOMMON = "DanhSachNhomMon";
        public string PROC_INSERT_NHOMMON = "ThemNhomMon";
        public string PROC_DELETE_NHOMMON = "XoaNhomMon";
        public string PROC_UPDATE_NHOMMON = "SuaNhomMon";
        // Proceduces of BanAn
        public string PROC_GET_LIST_BANAN = "DanhSachBanAn";
        public string PROC_UPDATE_BAN_AN = "SuaBanAn";
        public string PROC_SET_BAN_AN_TRONG = "SuaBanAnThanhTrong";

        // Procedures of ChiTietHoaDon
        public string PROC_GET_LIST_CHITIET_HOADON = "DanhSachChiTietHoaDon";
        public string PROC_INSET_CHITIET_HOADON = "ThemChiTietHoaDon";
        // Get id
        public string GET_ID_MANHOM = @"select dbo.func_ma_next ((select Top 1 MaNhom from NhomMon order by MaNhom desc),'N','3') as MaNhom";
        public string GET_ID_MAKHACHHANG = @"select dbo.func_ma_next ((select Top 1 MaKH from KhachHang order by MaKH desc),'KH','5') as MaKH";
        public string GET_ID_MANHANVIEN = @"select dbo.func_ma_next ((select Top 1 MaNV from NhanVien order by MaNV desc),'','3') as MaNV";
        // Procedures of HoaDon
        public string PROC_INSERT_HOADON = "ThemHoaDon";
        public string PROC_GET_LAST_HOADON = "GetLastHoaDon";
        public string PROC_HOA_DON_GET_INFO_KHACH_HANG = "ThongTinKhachHangTheoMaHoaDon";
        public string PROC_INFO_HOA_DON = "XemThongTinHoaDonTheoMa";
        public string PROC_EDIT_HOADON = "SuaHoaDon";
        public string PROC_GET_INFO_HOADON = "XemThongTinHoaDon";


        // Tab Name
        public string TAB_NHAN_VIEN = "TabNhanVien";
        public string TAB_KHACH_HANG = "TabKhachHang";
        public string TAB_MON_AN = "TabMonAn";
        public string TAB_NHOM_MON = "TabNhomMon";
        public string TAB_GOI_MON_THEO_BAN = "TabGoiMonTheoBan";

        // Resource Path
        public string NHANVIEN_IMAGE_RESOURCE = @"\Resources\NhanVien\";
        public string BANAN_IMAGE_RESOURCE = @"\Resources\BanAn\";

        public string PRINT_HOA_DON = "printed";
    }
}