using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;

namespace Tbg.Automation.Framework.Helpers
{
    public class ExcelHelpers
    {
        private static readonly List<ExcelDataCollection> _dataCol = new List<ExcelDataCollection>();


     
        public static void PopulateInCollection(string fileName, string worksheetName = "Sheet1")
        {
            DataTable table = ExcelToDataTable(fileName, worksheetName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    ExcelDataCollection dtTable = new ExcelDataCollection()
                    {
                        RowNumber = row,
                        ColumnName = table.Columns[col].ColumnName,
                        ColumnValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    _dataCol.Add(dtTable);
                }
            }
        }

        private static DataTable ExcelToDataTable(string fileName, string worksheetName)
        {
            //Before using the reader from a .NET Core application,
            //you need to add a dependency on the "System.Text.Encoding.CodePages" Nuget package,
            //and then register the codepage provider 

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            //open file and returns as Stream
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }

                    });
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table[worksheetName];
                    //return
                    return resultTable;

                }

            }

        }

        public static string GetCellValue(int rowNumber, string columnName)
        {
            try
            {
              string data = (from colData in _dataCol
                               where colData.ColumnName == columnName && colData.RowNumber == rowNumber
                               select colData.ColumnValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

    public class ExcelDataCollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
    }



}
