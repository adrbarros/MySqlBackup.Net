using MySqlConnector;
using System;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class FormOptions : Form
    {
        public ExportInformations ExportInfo { get; private set; }
        public ImportInformations ImportInfo { get; private set; }

        public FormOptions(ExportInformations exportInfo, ImportInformations importInfo)
        {
            InitializeComponent();

            ExportInfo = exportInfo ?? new ExportInformations();
            ImportInfo = importInfo ?? new ImportInformations();

            pgExport.SelectedObject = ExportInfo;
            pgImport.SelectedObject = ImportInfo;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btResetExport_Click(object sender, EventArgs e)
        {
            ExportInfo = new ExportInformations();
            pgExport.SelectedObject = ExportInfo;
        }

        private void btResetImport_Click(object sender, EventArgs e)
        {
            ImportInfo = new ImportInformations();
            pgImport.SelectedObject = ImportInfo;
        }
    }
}
