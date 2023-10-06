using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoAn
{
    class clsKhachHang
    {
        Database db;
        public clsKhachHang()
        {
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "SELECT MAKH,TENKH,DIACHI,EMAIL,SODT FROM KhachHang";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void XoaKhachHang(string index_kh)
        {
            string sql = string.Format("Delete from KhachHang where MAKH = '{0}'", index_kh);
            db.Thuchien(sql);
        }
        //Thêm 1 KH mới
        public void ThemKhachHang(string TENKH, string EMAIL, string DIACHI, string MAKH, string SODT )
        {
            string sql = string.Format("Insert Into KhachHang Values('{0}', N'{1}', N'{2}', '{3}','{4}')", MAKH, TENKH, DIACHI,EMAIL,SODT);
            db.Thuchien(sql);
        }   
        //Cập nhật KH
        public void CapNhapKhachHang(string index_khg,string TENKH ,string EMAIL,string DIACHI,string MAKH , string SODT)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update KhachHang set MAKH = '{0}', TENKH = N'{1}', DIACHI = N'{2}',  EMAIL='{3}' ,SODT='{4}'where MAKH = '{5}'", MAKH ,TENKH, DIACHI, EMAIL, SODT,index_khg);
            db.Thuchien(str);
        }
    }
}

    

        