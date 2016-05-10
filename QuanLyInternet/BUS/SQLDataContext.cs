using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyInternet.BUS
{
    class SQLDataContext
    {
        static DAO.quanlydangkyinternetDataContext db;

        public SQLDataContext()
        {
            db = new DAO.quanlydangkyinternetDataContext();
        }

        public static DAO.quanlydangkyinternetDataContext SQLData
        {
            get { return db; }
            set { db = value; }
        }

        //public static void CreateDataContext()
        //{
        //    db = new DAO.quanlydangkyinternetDataContext();
        //}
    }
}
