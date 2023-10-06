using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoAn
{
    class clsDatSuatAn
    {
        Database db;
        public clsDatSuatAn()
        {
            db = new Database();
        }
        public DataTable LayDsDatSuatAn()
        {
            string strSQL = "SELECT *FROM DatSuatAn ";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void XoaDatSuatAn(string index_dsa)
        {
            string sql = string.Format("Delete from DatSuatAn where SODONDAT ='{0}' ", index_dsa);
            db.Thuchien(sql);
        }
        //Thêm mới
        public void ThemDatSuatAn(string SODONDAT ,string NGAYGIODAT, string NGAYGIOGIAO, string DIACHIGIAO, string XACNHAN, string TINHTRANG, string MAKH,string MANV)
        {
            string sql = string.Format("Insert Into DatSuatAn    Values('{0}', '{1}', '{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')", SODONDAT, NGAYGIODAT, NGAYGIOGIAO, DIACHIGIAO, XACNHAN, TINHTRANG, MAKH,MANV);
            db.Thuchien(sql);
        }
        //Cập nhật
        public void CapNhapDatSuatAn(string SODONDAT, string NGAYGIODAT, string NGAYGIOGIAO, string DIACHIGIAO, string XACNHAN, string TINHTRANG,  string MAKH,string MANV , string index)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update DatSuatAn set SODONDAT = '{0}' NGAYGIODAT = '{1}',NGAYGIOGIAO = '{2}' , DIACHIGIAO=N'{3}' ,XACNHAN='{4}',TINHTRANG='{5}',MAKH='{6}',MANV='{7}' where SODONDAT = '{0}'", SODONDAT, NGAYGIODAT, NGAYGIOGIAO, DIACHIGIAO, XACNHAN, TINHTRANG, MAKH, MANV, index);
            db.Thuchien(str); 
        }
    }
}



