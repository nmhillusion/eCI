using eCI.helper;
using eCI.model.common.office;
using eCI.model.wanted_people;
using eCI.Properties;
using eCI.service.wanted_people;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace eCI
{
    public partial class MainForm : Form
    {
        private readonly IWantedPeopleService wantedPeopleService;

        public MainForm()
        {
            InitializeComponent();

            this.wantedPeopleService = InstanceFactory.GetInstanceOfType<IWantedPeopleService>();

            inpUrlOfWantedPeople.Text = WantedPeopleResource.urlOfWantedPeople;

            Debug.WriteLine(" >> wantedPeopleService : " + wantedPeopleService);

        }

        private void btnCrawlWantedPeople_Click(object sender, System.EventArgs e)
        {
            string urlOfWantedPeople = inpUrlOfWantedPeople.Text;
            string savedFilePath = inpSavedFilePath.Text;

            if (string.IsNullOrWhiteSpace(savedFilePath))
            {
                throw new ArgumentNullException(nameof(savedFilePath));
            }

            if (string.IsNullOrWhiteSpace(urlOfWantedPeople))
            {
                throw new ArgumentNullException(nameof(urlOfWantedPeople));
            }

            List<WantedPeopleEntity> dataList = wantedPeopleService.CrawlWantedPeople(urlOfWantedPeople, UpdateUI);

            ExportExcelWorkbookData exportExcelWorkbookData = ConvertWantedPeopleDataToExportExcelData(dataList);

            ExcelHelper.ExportData(
                filePath: savedFilePath,
                exportExcelData: exportExcelWorkbookData
            );
        }

        private ExportExcelWorkbookData ConvertWantedPeopleDataToExportExcelData(List<WantedPeopleEntity> dataList)
        {
            if (null == dataList)
            {
                throw new ArgumentNullException("dataList is empty");
            }

            List<string> headers = new List<string> {
                "fullName",
                "birthday",
                "livePlace",
                "nameOfParents",
                "crimeName",
                "decisionDate",
                "decisionOffice"
            };

            List<List<string>> data = new List<List<string>>();

            foreach (WantedPeopleEntity personEntry in dataList)
            {
                data.Add(new List<string> {
                    personEntry.fullName,
                    personEntry.birthday,
                    personEntry.livePlace,
                    personEntry.nameOfParents,
                    personEntry.crimeName,
                    personEntry.decisionDate,
                    personEntry.decisionOffice
                });
            }

            ExportExcelSheetData sheet_ = new ExportExcelSheetData
            {
                headers = headers,
                data = data
            };

            return new ExportExcelWorkbookData
            {
                sheets = { sheet_ }
            };
        }

        void UpdateUI(object sender, string eventValue)
        {
            this.lblProgressStatus.Invoke((MethodInvoker)delegate
            {
                lblProgressStatus.Text = eventValue;
                lblProgressStatus.Update();
            });

            Debug.WriteLine("trigger event of " + sender + " : " + eventValue);
        }

        private void btnBrowseSavedFolder_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("choose save folder");
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|.xlsx",
                AddExtension = true,
                Title = "Choose where to export data"
            };
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            Debug.WriteLine("Result: " + dialogResult.ToString() + "; file: " + saveFileDialog.FileName);

            if (dialogResult.Equals(DialogResult.OK))
            {
                inpSavedFilePath.Text = saveFileDialog.FileName;
            }
        }
    }
}
