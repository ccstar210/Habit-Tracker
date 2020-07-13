using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class FileHandler
    {
        public List<Entry> entryList = new List<Entry>();
        Excel.Application excel = new Excel.Application(); //create excel object
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range range;
        object misValue = System.Reflection.Missing.Value;


        public void openFile(string fileName)
        {
            if (!File.Exists(fileName))
            { //file doesn't exist, create the file
                //MessageBox.Show("file doesn't exist");
                createFile(fileName);

            }
            else
            {
                //MessageBox.Show("file exists");
                /*Excel has different current working directory (CWD) than File.Exists() and this program's .exe file 
                so need to set the same path as .exe file, see https://stackoverflow.com/questions/16394842/excel-can-only-open-file-if-using-absolute-path-why */
                string excelPath = System.IO.Path.GetFullPath(fileName);
                workbook = excel.Workbooks.Open(excelPath);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            }
            
            

        }

        public void createFile(string fileName)
        {
            
            if (excel == null)
            {
                MessageBox.Show("Excel not properly installed");
                return;
            }
            workbook = excel.Workbooks.Add(misValue);
            worksheet = (Excel.Worksheet) workbook.Worksheets.get_Item(1); //create worksheet 1
            worksheet.Name = "Habit Tracker";

            //column titles
            worksheet.Cells[1, 1] = "Date";
            worksheet.Cells[1, 2] = "Overall Mood";
            worksheet.Cells[1, 3] = "Water Intake";
            worksheet.Cells[1, 4] = "Wake Time";
            worksheet.Cells[1, 5] = "Sleep Time";
            worksheet.Cells[1, 6] = "Money Spent";
            worksheet.Cells[1, 7] = "Exercise";
            worksheet.Cells[1, 8] = "Breakfast";
            worksheet.Cells[1, 9] = "Lunch";
            worksheet.Cells[1, 10] = "Dinner";
            worksheet.Cells[1, 11] = "Notes";

            /*Excel has different current working directory (CWD) than this program's .exe file 
              so need to set the same path as .exe file*/
            string excelPath = System.IO.Path.GetFullPath(fileName);

            workbook.SaveAs(excelPath);
            //file stays open

        }

        public void saveFile(string fileName)
        {
            /*Excel has different current working directory (CWD) than this program's .exe file 
              so need to set the same path as .exe file*/
            string excelPath = System.IO.Path.GetFullPath(fileName);
            workbook.Save();
            //workbook.SaveAs(excelPath); //will have popup message, file exists, do you want to overwrite
            
        }

        public void closeFile()
        {
            workbook.Close();
            excel.Quit();
            //Cleans up the Excel interop objects
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(excel);
        }




        public void writeToFile( Entry entry, string fileName )
        {
            openFile(fileName);

            range = worksheet.UsedRange;
            int rowCount = range.Rows.Count;

            //add entry to next available row in the excel file
            worksheet.Cells[rowCount + 1, 1] = entry.Date;
            worksheet.Cells[rowCount + 1, 2] = entry.Mood;
            worksheet.Cells[rowCount + 1, 3] = entry.Water;
            worksheet.Cells[rowCount + 1, 4] = entry.Wake;
            worksheet.Cells[rowCount + 1, 5] = entry.Sleep;
            worksheet.Cells[rowCount + 1, 6] = entry.Money;
            worksheet.Cells[rowCount + 1, 7] = entry.Exercise;
            worksheet.Cells[rowCount + 1, 8] = entry.Breakfast;
            worksheet.Cells[rowCount + 1, 9] = entry.Lunch;
            worksheet.Cells[rowCount + 1, 10] = entry.Dinner;
            worksheet.Cells[rowCount + 1, 11] = entry.Notes;

            saveFile(fileName);
            closeFile();


        }


        /*public List<Entry> readFile(string fileName)
        {
            //http://csharp.net-informations.com/excel/csharp-read-excel.htm


            if (File.Exists(fileName))
            {

                openFile(fileName);
                range = worksheet.UsedRange;
                for (int row = 1; row <= range.Rows.Count; row++)
                {
                    List<string> listItem = new List<string>();
                    for (int col = 1; col <= range.Columns.Count; col++)
                    {
                        string str = (string)(range.Cells[row, col] as Excel.Range).Value2;
                        listItem.Add(str);
                    }

                    Entry entryItem = new Entry(listItem[0], listItem[6], listItem[2], listItem[1], listItem[3], listItem[4], listItem[5], listItem[6], listItem[7], listItem[8], listItem[9]);
                    //listItem.Clear;
                    entryList.Add(entryItem);
                }

                saveFile(fileName);
            }

            return entryList;

        }*/

    }
}
