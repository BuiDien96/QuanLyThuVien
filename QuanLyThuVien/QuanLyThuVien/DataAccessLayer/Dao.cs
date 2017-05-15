using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.DataAccessLayer
{
     class Dao
    {
        //thu thu


        //doc gia

        //sach

        public static DataTable GetListSach()
        {
            return DataProvider.GetData("select * from sach ");
        }


        public static DataTable GetListTheloai()
        {
            return DataProvider.GetData("select * from theloai ");
        }

        public static int InsertSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@vitri", sach.vitri),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("themsach", para);
        }

        public static int UpdateSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@vitri", sach.vitri),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("susach", para);
        }

        public static int DeleteSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach)

            };
            return DataProvider.ExecuteNonQuery("xoasach", para);
        }

        public static DataTable SearchSach(string ten)
        {
            return DataProvider.GetData("select * from sach " + ten);
        }


        //the doc gia

        public static DataTable GetListThedg()
        {
            return DataProvider.GetData(" select * from thedocgia ");
        }

        public static int InsertThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe),
                new SqlParameter("@ngaylam", thedg.ngaylam),
                new SqlParameter("@ngayhethan", thedg.ngayhethan),
                new SqlParameter("@matt", thedg.matt),
                new SqlParameter("@madg", thedg.madg)

            };
            return DataProvider.ExecuteNonQuery("themthedocgia", para);
        }

        public static int UpdateThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe),
                new SqlParameter("@ngaylam", thedg.ngaylam),
                new SqlParameter("@ngayhethan", thedg.ngayhethan),
                new SqlParameter("@matt", thedg.matt),
                new SqlParameter("@madg", thedg.madg)

            };
            return DataProvider.ExecuteNonQuery("suathedocgia", para);
        }

        public static int DeleteThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe)

            };
            return DataProvider.ExecuteNonQuery("xoathedocgia", para);
        }

        public static DataTable SearchThedg(string ten)
        {
            return DataProvider.GetData("select * from thedocgia " + ten);
        }



        //ke sach


        //phieu muon tra



        //the loai


        //chi tiet phieu muon

    }
}
