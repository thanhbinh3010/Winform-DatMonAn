using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoAn
{
    class clsSuatAn
    {
        Database db;
        public clsSuatAn()
        {
            db = new Database();
        }
        public DataTable LayDsSuatAn()
        {
            string strSQL = "SELECT MSSA , TENSA,THANHPHAN,DONGIA,NGAYAD FROM SuatAn ";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void XoaSuatAn(string index_sa)
        {
            string sql = string.Format("Delete from SuatAn where MSSA ='{0}' ", index_sa);
            db.Thuchien(sql);
        }
        //Thêm 
        public void ThemSuatAn( string TENSA,string NGAYAD ,string THANHPHAN ,  string MSSA,string DONGIA)
        {
            string sql = string.Format("Insert Into SuatAn    Values('{0}', N'{1}', N'{2}','{3}','{4}')", MSSA,TENSA,THANHPHAN,DONGIA,NGAYAD);
            db.Thuchien(sql);
        }
        //Cập nhật
        public void CapNhapSuatAn(string index_a,  string TENSA, string NGAYAD,string THANHPHAN,string MSSA,string DONGIA )
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update SuatAn set MSSA = '{0}', TENSA = N'{1}',THANHPHAN = N'{2}' , DONGIA='{3}' ,NGAYAD='{4}' where MSSA = '{5}'", MSSA,TENSA,THANHPHAN,DONGIA,NGAYAD, index_a);
            db.Thuchien(str);
        }
    }
}



