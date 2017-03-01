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
    public partial class ARFIMAForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public ARFIMAForm()
        {
            InitializeComponent();
            FracDRefEdit._Excel = Globals.ThisAddIn.Application;
            ArRefEdit._Excel = Globals.ThisAddIn.Application;
            MaRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(3, (int)eCondMeanEnumCli.eArfima);
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(ArRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(MaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[2].SetValuesWithCells(FracDRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.AddOneCondMean(mvExcelGet);
            }
            else
                Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void ArRefEdit_CellChanged(object sender, EventArgs e)
        {
            ArLagsLabel.Text = ArRefEdit._CellsCount.ToString();

        }

        private void MaRefEdit_CellChanged(object sender, EventArgs e)
        {
            MaLagsLabel.Text = MaRefEdit._CellsCount.ToString();

        }


    }
}
