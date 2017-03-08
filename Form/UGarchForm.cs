using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools = Microsoft.Office.Tools.Excel;
using RegArchLibCli;

namespace RegArchExcel
{
    public partial class UGarchForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public UGarchForm()
        {
            InitializeComponent();
            ArchRefEdit._Excel = Globals.ThisAddIn.Application;
            ConstRefEdit._Excel = Globals.ThisAddIn.Application;
            GarchRefEdit._Excel = Globals.ThisAddIn.Application;
            BetaRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(4, (int)eCondVarEnumCli.eUgarch);
        }

        private void GarchRefEdit_CellChanged(object sender, EventArgs e)
        {
            GarchLagsLabel.Text = GarchRefEdit._CellsCount.ToString();
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                //if (constBoolBox.Checked)
                mvExcelGet.mParam[0].SetValuesWithCells(ConstRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(ArchRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[2].SetValuesWithCells(GarchRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[3].SetValuesWithCells(BetaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.AddCondVar(mvExcelGet);
            }
            else
                Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

        private void constBoolBox_CheckedChanged(object sender, EventArgs e)
        {
            ConstRefEdit.Enabled = constBoolBox.Checked;
        }

        private void UGarchForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

        private void BetaRefEdit_CellChanged(object sender, EventArgs e)
        {
            betaSizeLabel.Text = BetaRefEdit._CellsCount.ToString();
        }

        private void ArchRefEdit_CellChanged(object sender, EventArgs e)
        {
            ArchLagsLabel.Text = ArchRefEdit._CellsCount.ToString();
        }

    }
}
