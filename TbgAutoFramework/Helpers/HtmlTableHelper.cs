using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BuyPlan.Automation.Framework.Helpers
{
    public class HtmlTableHelper
    {

        public static List<HtmlTableCollection> ReadTable(IWebElement table)
        {
            //Initialize the table
            var htmlTableCollections = new List<HtmlTableCollection>();

            //Get all the columns from the table
            var columns = table.FindElements(By.TagName("th"));

            //Get all the rows
            var rows = table.FindElements(By.TagName("tr"));

            //Create row index
            int rowIndex = 0;
            foreach (var row in rows)
            {
                int colIndex = 0;

                var colDatas = row.FindElements(By.TagName("td"));
                //Store data only if it has value in row
                if (colDatas.Count != 0)
                    foreach (var colValue in colDatas)
                    {
                        htmlTableCollections.Add(new HtmlTableCollection
                        {
                            RowNumber = rowIndex,
                            ColumnName = columns[colIndex].Text != "" ?
                                         columns[colIndex].Text : colIndex.ToString(),
                            Value = colValue.Text,
                            Controls = GetControls(colValue)
                        });

                        //Move to next column
                        colIndex++;
                    }
                rowIndex++;
            }
            return htmlTableCollections;
        }

        private static IEnumerable<KeyValuePair<HtmlControl, IWebElement>> GetControls(IWebElement columnValue)
        {

            List<KeyValuePair<HtmlControl, IWebElement>> controls = new List<KeyValuePair<HtmlControl, IWebElement>>();

            //Check if the control has specfic tags like input/hyperlink etc
            if (columnValue.FindElements(By.TagName("a")).Count > 0)
            {
                foreach (var control in columnValue.FindElements(By.TagName("a")))
                {
                    controls.Add(new KeyValuePair<HtmlControl,IWebElement>(HtmlControl.Hyperlink, control));
                }
            }

            if (columnValue.FindElements(By.TagName("input")).Count > 0)
            {
                foreach (var control in columnValue.FindElements(By.TagName("input")))
                {
                    controls.Add(new KeyValuePair<HtmlControl, IWebElement>(HtmlControl.Input, control));
                }
            }

            //Add any more types of controls as per requirement in the project

            return controls;
        }


        public static KeyValuePair<HtmlControl, IWebElement> GetCellControl(List<HtmlTableCollection> htmlTableCollections, int rowNumber, string columnName, int controlIndex)
        {

            var htmlTableCollection = htmlTableCollections
                 .SingleOrDefault(t => t.ColumnName == columnName && t.RowNumber == rowNumber);

            if (htmlTableCollection != null)
            {
                return htmlTableCollection.Controls.ElementAt(controlIndex);
            }
            else
            {
                throw new NullReferenceException("The control is not found or the index out of range");
            }
        }

        public static string GetCellValue(List<HtmlTableCollection> htmlTableCollections, int rowNumber, string columnName)
        {
            var htmlTableCollection = htmlTableCollections
                .SingleOrDefault(t => t.ColumnName == columnName && t.RowNumber == rowNumber);

            if (htmlTableCollection != null)
            {
                return htmlTableCollection.Value;
            }
            else
            {
                throw new NullReferenceException("The control is not found or the index out of range");
            }

        }

        public static int[] GetRowIndexes(List<HtmlTableCollection> htmlTableCollections, string columnName, string value)
        {
            return htmlTableCollections
                .Where(t => t.ColumnName == columnName && t.Value == value)
                .Select(e => e.RowNumber).ToArray();
        }


    }


    public class HtmlTableCollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string Value { get; set; }
        public IEnumerable<KeyValuePair<HtmlControl, IWebElement>> Controls { get; set; }
    }

    public enum HtmlControl
    {
        Hyperlink,
        Input,

    }
}

