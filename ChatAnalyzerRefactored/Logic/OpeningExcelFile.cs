using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ChatAnalyzer.Logic
{
    class OpeningExcelFile
    {
        private OpenedExcel openedExcel = new OpenedExcel();
        private TextBoxBase direction;

        public OpeningExcelFile(TextBoxBase direction)
        {
            this.openedExcel.excel = new _Excel.Application();
            this.direction = direction;
        }

        public OpenedExcel OpenFile()
        {
            try
            {
                openedExcel.wb = openedExcel.excel.Workbooks.Open(direction.Text);
                openedExcel.ws = openedExcel.wb.Worksheets[1];
                openedExcel.lastCell = openedExcel.excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                openedExcel.list = new string[openedExcel.lastCell.Column, openedExcel.lastCell.Row];

                return openedExcel;
            }
            catch (Exception ex)
            {
                openedExcel.excel.Quit();
                return null;
            }
        }
    }
}
