using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class DoiTuongApDungKM_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaCTKM", typeof(string));
            dt.Columns.Add("MaDoiTuong", typeof(string));

            var km = SQLDataContext.SQLData.getDoiTuongApDungKM();
            int stt = 1;
            foreach (var i in km)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaCTKM"] = i.MaCTKM;
                r["MaDoiTuong"] = i.MaDoiTuong;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void add(string mactkm, string madoituong)
        {
            SQLDataContext.SQLData.addDoiTuongApDungKM(mactkm, madoituong);
        }

        public void edit(string mactkm, string madoituong)
        {
            SQLDataContext.SQLData.editDoiTuongApDungKM(mactkm, madoituong);
        }

        public void delete(string mactkm, string madoituong)
        {
            SQLDataContext.SQLData.deleteDoiTuongApDungKM(mactkm, madoituong);
        }
    }
}
