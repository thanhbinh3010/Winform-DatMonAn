using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoAn
{
    class clsNhanVien
    {
        Database db;
        public clsNhanVien()
        {
            db = new Database();
        }
        public DataTable LayDsNhanVien()
        {
            string strSQL = "SELECT MANV,TENNV,CHUCVU,NGAYSINH,DIACHI FROM NHANVIEN ";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void XoaNV(string index_nv)
        {
            string sql = string.Format("Delete from NHANVIEN where MANV ='{0}' ", index_nv);
            db.Thuchien(sql);
        }
        //Thêm 
        public void ThemNV(string MANV,string TENNV,string CHUCVU , string NGAYSINH,  string DIACHI  )
        {
            string sql = string.Format("Insert Into NHANVIEN   Values('{0}', N'{1}', N'{2}','{3}','{4}')", MANV,TENNV,CHUCVU,NGAYSINH,DIACHI);
            db.Thuchien(sql);
        }
        //Cập nhật
        public void CapNhapSuatAn( string MANV, string TENNV, string CHUCVU, string NGAYSINH, string DIACHI,string index_a)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update NHANVIEN set MANV = '{0}', TENNV = N'{1}',CHUCVU = N'{2}' , NGAYSINH='{3}' ,DIACHI=N'{4}' where MANV = '{0}'", MANV,TENNV,CHUCVU,NGAYSINH,DIACHI, index_a);
            db.Thuchien(str);
        }
    }
}



