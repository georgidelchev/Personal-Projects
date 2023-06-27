using System.Data;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace DemoProblem
{
    public class ExcelData
    {
        private readonly string path;

        public ExcelData(string path)
        {
            this.path = path;
        }

        public DataView Data
        {
            get
            {
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Open(this.path);
                var worksheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
                var range = worksheet.UsedRange;

                var dataTable = new DataTable();

                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Surname");
                dataTable.Columns.Add("Location");
                dataTable.Columns.Add("Email");

                for (var row = 2; row <= range.Rows.Count; row++)
                {
                    var dataRow = dataTable.NewRow();

                    for (var column = 1; column <= range.Columns.Count; column++)
                    {
                        dataRow[column - 1] = (range.Cells[row, column] as Excel.Range)?.Value2.ToString();
                    }

                    dataTable.Rows.Add(dataRow);
                    dataTable.AcceptChanges();
                }

                workbook.Close(true, Missing.Value, Missing.Value);

                excelApp.Quit();

                return dataTable.DefaultView;
            }
        }
    }
}