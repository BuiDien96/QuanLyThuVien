using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DataAccessLayer;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class Bus
    {
        //thu thu


        //doc gia
        //sach

        public static DataTable GetListSach()
        {
            return Dao.GetListSach();
        }


        public static DataTable GetListTheloai()
        {
            return Dao.GetListTheloai();
        }

        public static int InsertSach(Sach1 sach)
        {
            return Dao.InsertSach(sach);
        }

        public static int UpdateSach(Sach1 sach)
        {
            return Dao.UpdateSach(sach);
        }

        public static int DeleteSach(Sach1 sach)
        {
            return Dao.DeleteSach(sach);
        }

        public static DataTable SearchSach(string ten)
        {
            return Dao.SearchSach(ten);
        }

        //the doc gia
        public static DataTable GetListThedg()
        {
            return Dao.GetListThedg();
        }

        public static int InsertThedg(TheDocGia1 thedg)
        {
            return Dao.InsertThedg(thedg);
        }

        public static int UpdateThedg(TheDocGia1 thedg)
        {
            return Dao.UpdateThedg(thedg);
        }

        public static int DeleteThedg(TheDocGia1 thedg)
        {
            return Dao.DeleteThedg(thedg);
        }

        public static DataTable SearchThedg(string ten)
        {
            return Dao.SearchThedg(ten);
        }


        //ke sach


        //phieu muon tra



    }
}
