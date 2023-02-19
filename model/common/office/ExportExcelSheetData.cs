using System.Collections.Generic;

namespace eCI.model.common.office
{
    internal class ExportExcelSheetData
    {
        public string sheetName;
        public List<string> headers = new List<string>();
        public List<List<string>> data = new List<List<string>>();
    }
}
