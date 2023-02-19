using eCI.model.common.office;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace eCI.helper
{
    internal class ExcelHelper
    {
        public static void ExportData(string filePath, ExportExcelWorkbookData exportExcelData)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath must be specific");
            }

            if (null == exportExcelData || null == exportExcelData.sheets || 0 == exportExcelData.sheets.Count)
            {
                throw new ArgumentNullException("exportExcelData does not have data");
            }

            Application excel = new Application
            {
                // for making Excel visible  
                Visible = false,
                DisplayAlerts = false
            };

            // Creation a new Workbook  
            Workbook excelworkBook = excel.Workbooks.Add(Type.Missing);

            foreach (ExportExcelSheetData sheet_ in exportExcelData.sheets)
            {
                Debug.WriteLine("add sheet data ");
                AddSheetData(excelworkBook, sheet_);
            }

            Debug.WriteLine("excel save to path: " + filePath);

            excelworkBook.SaveAs(filePath);

            excelworkBook.Close();
            excel.Quit();
        }

        private static void AddSheetData(Workbook excelWorkbook, ExportExcelSheetData sheetData)
        {
            // Workk sheet  
            Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add();
            if (null != sheetData.sheetName)
            {
                excelSheet.Name = sheetData.sheetName;
            }

            AddHeader(excelSheet, sheetData.headers);
            AddBody(excelSheet, sheetData.data);
        }

        private static void AddBody(Worksheet excelSheet, List<List<string>> data)
        {
            if (null != data)
            {
                int startRowIdx_ = 1;
                for (int rowIdx_ = 0; rowIdx_ < data.Count; ++rowIdx_)
                {
                    List<string> row_ = data[rowIdx_];

                    for (int colIdx_ = 0; colIdx_ < row_.Count; ++colIdx_)
                    {
                        string cellData = row_[colIdx_];

                        excelSheet.Cells[rowIdx_ + startRowIdx_ + 1, colIdx_ + 1] = cellData;
                    }
                }
            }
        }

        private static void AddHeader(Worksheet excelSheet, List<string> headerNames)
        {
            if (null != headerNames)
            {
                for (int headerIdx_ = 0; headerIdx_ < headerNames.Count; ++headerIdx_)
                {
                    excelSheet.Cells[1, headerIdx_ + 1] = headerNames[headerIdx_];
                }

                Range excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[1, headerNames.Count]];
                excelCellrange.Font.Bold = true;
            }
        }
    }
}
