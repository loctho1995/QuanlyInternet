using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    class DoiTuong_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaDoiTuong", typeof(int));
            dt.Columns.Add("MoTa", typeof(string));
            dt.Columns.Add("SoThangCanTren", typeof(int));
            dt.Columns.Add("SoThangCanDuoi", typeof(int));

            var kh = SQLDataContext.SQLData.getDoiTuong();
            int stt = 1;
            foreach (var i in kh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaDoiTuong"] = i.MaDoiTuong;
                r["MoTa"] = i.MoTa;
                r["SoThangCanTren"] = i.SoThangCanTren;
                r["SoThangCanDuoi"] = i.SoThangCanDuoi;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
