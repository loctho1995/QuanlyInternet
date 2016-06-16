using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyInternet.BUS
{
    public class GoiCuoc_BUS
    {
        public DataTable getAllResult()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Tốc Độ", typeof(float));
            dt.Columns.Add("Cước Thuê Bao Tháng", typeof(float));
            dt.Columns.Add("Số MB miễn phí", typeof(float));

            var kh = SQLDataContext.SQLData.getGoiCuoc();
            int stt = 1;
            foreach (var i in kh)
            {
                //if(i.MaGoiCuoc == "")
                    //continue;
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Tốc Độ"] = i.TocDo;
                r["Cước Thuê Bao Tháng"] = i.CuocThueBaoThang;
                r["Số MB miễn phí"] = i.SoMBMienPhi;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public DataTable getGoiCuocWith(string magoicuoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã Gói Cước", typeof(string));
            dt.Columns.Add("Tốc Độ", typeof(float));
            dt.Columns.Add("Cước Thuê Bao Tháng", typeof(float));
            dt.Columns.Add("Số MB miễn phí", typeof(float));

            var kh = SQLDataContext.SQLData.getGoiCuocWith(magoicuoc);
            int stt = 1;
            foreach (var i in kh)
            {
                //if(i.MaGoiCuoc == "")
                //continue;
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["Mã Gói Cước"] = i.MaGoiCuoc;
                r["Tốc Độ"] = i.TocDo;
                r["Cước Thuê Bao Tháng"] = i.CuocThueBaoThang;
                r["Số MB miễn phí"] = i.SoMBMienPhi;
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public void addGoiCuoc(string magoicuoc, float tocdo, float cuocthuebaothang, float soMBmienphi)
        {
            SQLDataContext.SQLData.addGoiCuoc(magoicuoc, tocdo, cuocthuebaothang, soMBmienphi);
        }

        public void editGoiCuoc(string magoicuoc, float tocdo, float cuocthuebaothang, float soMBmienphi)
        {
            SQLDataContext.SQLData.editGoiCuoc(magoicuoc, tocdo, cuocthuebaothang, soMBmienphi);
        }

        public void deleteGoiCuoc(string magoicuoc)
        {
            SQLDataContext.SQLData.deleteGoiCuoc(magoicuoc);
        }
    }
}
