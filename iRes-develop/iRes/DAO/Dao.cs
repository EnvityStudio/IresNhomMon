﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.Config;
using Title.VO;

namespace Title.DAO {
    public class Dao {
        public static Configuration config = new Configuration();

        public static DataTable GetListNhanVien() {
            return DataProvider.GetData(config.PROC_GET_LIST_NHANVIEN);
        }

        public static int InsertNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.DiaChi),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@Luong", nv.Luong),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@HinhAnh", nv.HinhAnh),
                new SqlParameter("@TrangThai", nv.TinhTrangLamViec)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHANVIEN, para);
        }
        public static int InsertNhomMon(NhomMon nm) 
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNhom",nm.MaNhom),
                new SqlParameter("@TenNhom",nm.TenNhom),
                new SqlParameter("@TongSoMon",nm.TongSoMon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHOMMON, para);
        }
        public static int UpdateNhomMon(NhomMon nm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNhom",nm.MaNhom),
                new SqlParameter("@TenNhom",nm.TenNhom),
                new SqlParameter("@TongSoMon",nm.TongSoMon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHOMMON, para);
        }
        public static int DeleteNhomMon(NhomMon nm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@"+config.NHOMMON_MANHOM, nm.MaNhom)
               
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHOMMON,para);
        }
        public static int UpdateNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@Luong", nv.Luong),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@HinhAnh", nv.HinhAnh),
                new SqlParameter("@TrangThai", nv.TinhTrangLamViec)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHANVIEN, para);
        }

        public static int DeleteNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@MaNV", nv.MaNV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHANVIEN, para);
        }

        public static DataTable GetListKhachHang() {
            return DataProvider.GetData(config.PROC_GET_LIST_KHACHHANG);
        }

        public static int InsertKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),
                new SqlParameter("@"+config.KHACHHANG_TENKH, kh.TenKH),
                new SqlParameter("@"+config.KHACHHANG_DIACHI, kh.DiaChi),
                new SqlParameter("@"+config.KHACHHANG_SDT, kh.SDT),
                new SqlParameter("@"+config.KHACHHANG_EMAIL, kh.Email),
                new SqlParameter("@"+config.KHACHHANG_SOLANAN, kh.SoLanAn),
                new SqlParameter("@"+config.KHACHHANG_TONGTIEN, kh.TongTien),
                new SqlParameter("@"+config.KHACHHANG_PHANLOAI, kh.PhanLoai)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_KHACHHANG, para);
        }

        public static int UpdateKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),
                new SqlParameter("@"+config.KHACHHANG_TENKH, kh.TenKH),
                new SqlParameter("@"+config.KHACHHANG_DIACHI, kh.DiaChi),
                new SqlParameter("@"+config.KHACHHANG_SDT, kh.SDT),
                new SqlParameter("@"+config.KHACHHANG_EMAIL, kh.Email),
                new SqlParameter("@"+config.KHACHHANG_SOLANAN, kh.SoLanAn),
                new SqlParameter("@"+config.KHACHHANG_TONGTIEN, kh.TongTien),
                new SqlParameter("@"+config.KHACHHANG_PHANLOAI, kh.PhanLoai)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_KHACHHANG, para);
        }

        public static int DeleteKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_KHACHHANG, para);
        }

        public static DataTable GetListMonAn() {
            return DataProvider.GetData(config.PROC_GET_LIST_MONAN);
        }

        public static DataTable GetListMonAnByNhomMon(string maNhom) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.MONAN_MANHOM, maNhom),            
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_LIST_MONAN_BY_NHOM_MON, para);
        }

        public static DataTable GetListNhomMon() {
            return DataProvider.GetData(config.PROC_GET_LIST_NHOMMON);
        }

        public static DataTable GetListBanAn() {
            return DataProvider.GetData(config.PROC_GET_LIST_BANAN);
        }

        public static int UpdateBanAn(BanAn banAn) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MABAN, banAn.MaBan),            
                new SqlParameter("@"+config.BANAN_TRANGTHAI, banAn.TrangThai),            
                new SqlParameter("@"+config.BANAN_MAHOADON, banAn.MaHoaDon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_BAN_AN, para);
        }

        public static int SetBanAnTrong(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MABAN, banAn.MaBan),                    
            };
            return DataProvider.ExecuteNonQuery(config.PROC_SET_BAN_AN_TRONG, para);
        }

        public static DataTable GetListChiTietHoaDon(BanAn banAn) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MAHOADON, banAn.MaHoaDon),            
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_LIST_CHITIET_HOADON, para);
        }

        public static int InsertChiTietHoaDon(ChiTietHoaDon chiTietHoaDon) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_HOA_DON, chiTietHoaDon.MaHoaDon),            
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_MON, chiTietHoaDon.MaMon),            
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_SO_LUONG, chiTietHoaDon.SoLuong)            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSET_CHITIET_HOADON, para);
        }

        public static int InsertHoaDon(HoaDon hoaDon) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_THOI_GIAN, hoaDon.ThoiGian),            
                new SqlParameter("@"+config.HOA_DON_MA_KHACH_HANG, hoaDon.MaKH),            
                new SqlParameter("@"+config.HOA_DON_MA_NHAN_VIEN, hoaDon.MaNV),            
                new SqlParameter("@"+config.HOA_DON_CHIET_KHAU, hoaDon.ChietKhau),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_HOADON, para);
        }

        public static DataTable GetInfoKhachHangQuaMaHoaDon(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON, banAn.MaHoaDon),                       
            };
            return DataProvider.GetDataByParameter(config.PROC_HOA_DON_GET_INFO_KHACH_HANG, para);
        }

        public static DataTable GetLastHoaDon() {
            return DataProvider.GetData(config.PROC_GET_LAST_HOADON);
        }
        public static DataTable GetIDNhomMon()
        {
            return DataProvider.GetData(config.GET_ID_MANHOM);
        }
        public static DataTable GetIDKhachHang()
        {
            return DataProvider.GetData(config.GET_ID_MAKHACHHANG);
        }
        public static DataTable GetIDNhanVien()
        {
            return DataProvider.GetData(config.GET_ID_MANHANVIEN);
        }
        public static DataTable GetInfoHoaDon(string maHoaDon)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON,maHoaDon),
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_INFO_HOADON, para);
        }

        public static int EditHoaDon(HoaDon hoaDon)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON,hoaDon.MaHD),
                new SqlParameter("@"+config.HOA_DON_THOI_GIAN, hoaDon.ThoiGian),            
                new SqlParameter("@"+config.HOA_DON_MA_KHACH_HANG, hoaDon.MaKH),            
                new SqlParameter("@"+config.HOA_DON_MA_NHAN_VIEN, hoaDon.MaNV),            
                new SqlParameter("@"+config.HOA_DON_CHIET_KHAU, hoaDon.ChietKhau),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_EDIT_HOADON,para);
        }

        public static DataTable GetInfoHoaDonTheoBanAn(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON, banAn.MaHoaDon),                       
            };
            return DataProvider.GetDataByParameter(config.PROC_INFO_HOA_DON, para);
        }
    }
}