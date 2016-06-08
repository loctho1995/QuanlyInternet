﻿using System;
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
            dt.Columns.Add("MaGoiCuoc", typeof(string));
            dt.Columns.Add("TocDo", typeof(float));
            dt.Columns.Add("CuocThueBaoThang", typeof(float));
            dt.Columns.Add("SoMBMienPhi", typeof(float));

            var kh = SQLDataContext.SQLData.getGoiCuoc();
            int stt = 1;
            foreach (var i in kh)
            {
                //if(i.MaGoiCuoc == "")
                    //continue;
                DataRow r = dt.NewRow();
                r["STT"] = stt++;
                r["MaGoiCuoc"] = i.MaGoiCuoc;
                r["TocDo"] = i.TocDo;
                r["CuocThueBaoThang"] = i.CuocThueBaoThang;
                r["SoMBMienPhi"] = i.SoMBMienPhi;
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
