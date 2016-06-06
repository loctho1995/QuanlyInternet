using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class LoaiGioTruyCap_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaLoaiGioTruyCap", typeof(string));
            dt.Columns.Add("KhoangThoiGian", typeof(string));

            var tt = SQLDataContext.SQLData.getLoaiGioTruyCap();
            int stt = 1;
            foreach (var i in tt)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaLoaiGioTruyCap"] = i.MaLoaiGioTruyCap;
                r["KhoangThoiGian"] = i.KhoangThoiGian;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
