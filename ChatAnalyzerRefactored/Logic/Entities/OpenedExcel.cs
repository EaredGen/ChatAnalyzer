using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ChatAnalyzer.Logic
{
    class OpenedExcel
    {
        public _Application excel;
        public Workbook wb;
        public Worksheet ws;
        public Range lastCell;
        public string[,] list;

        //public OpenedExcel(_Application excel, Workbook wb, Worksheet ws, Range lastCell, string[,] list)
        //{
        //    this.excel = excel;
        //    this.wb = wb;
        //    this.ws = ws;
        //    this.lastCell = lastCell;
        //    this.list = list;
        //}
    }
}
