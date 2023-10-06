using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanDoAn
{
    class clsHoaDon
    {
        Database db;
        public clsHoaDon()
        {
            db = new Database();
        }
        public DataTable LayDSHoaDon()
        {
            string strSQL = "Select  SOHD,SODONDAT,MANV,NGAYLHD,THANHTIEN,THUEVAT From HoaDonThanhToan";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);

            return dt;
        }
            
        public void XoaHoaDon(string index_hd)
        {
            string sql = string.Format("Delete from HoaDonThanhToan where SOHD = '{0}'" , index_hd);
            db.Thuchien(sql);
        }
        public void ThemHoaDon(string SOHD, string SODONDAT,string MANV, string NGAYLHD, string THANHTIEN , string THUEVAT)
        {

                string sql = string.Format("Insert Into HoaDonThanhToan Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')", SOHD, SODONDAT,MANV, NGAYLHD, THANHTIEN, THUEVAT);
                db.Thuchien(sql);
      
            
        }

        public void CapNhatHoaDon( string SOHD ,string SODONDAT, string MANV,string NGAYLHD, string THANHTIEN,string THUEVAT ,string index   )
        {

            string str = string.Format("Update HoaDonThanhToan set SOHD = '{0}',SODONDAT='{1}',MANV='{2}', NGAYLHD = '{3}',THANHTIEN ='{4}',THUEVAT='{5}' where SOHD = '{0}'", SOHD,SODONDAT,MANV, NGAYLHD, THANHTIEN,THUEVAT,index);
            db.Thuchien(str);
        }
    }
}
