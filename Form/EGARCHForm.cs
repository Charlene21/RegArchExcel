using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools = Microsoft.Office.Tools.Excel;
using RegArchLibCli;

namespace RegArchExcel
{
    public partial class EGARCHForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public EGARCHForm()
        {
            InitializeComponent();
            ArchRefEdit._Excel = Globals.ThisAddIn.Application;
            GarchRefEdit._Excel = Globals.ThisAddIn.Application;
            ConstRefEdit._Excel = Globals.ThisAddIn.Application;
            GammaRefEdit._Excel = Globals.ThisAddIn.Application;
            TetaRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(5, (int)eCondVarEnumCli.eEgarch);
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(ConstRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(ArchRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[2].SetValuesWithCells(GarchRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[3].SetValuesWithCells(TetaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[4].SetValuesWithCells(GammaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.DeleteCondVar();
                Globals.ThisAddIn.mAddInModel.AddCondVar(mvExcelGet);
            }
            else
                Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

  
        private void ArchRefEdit_CellChanged(object sender, EventArgs e)
        {
//            mvExcelGet.GetRefEditValue(ref ArchRefEdit, 1);
            ArchLagsLabel.Text = ArchRefEdit._CellsCount.ToString ();
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void GarchRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref GarchRefEdit, 2);
            GarchLagsLabel.Text = GarchRefEdit._CellsCount .ToString ();
        }

        private void ConstRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref ConstRefEdit, 0);
        }

        private void TetaRefEdit_CellChanged(object sender, EventArgs e)
        {
  //          mvExcelGet.GetRefEditValue(ref TetaRefEdit, 3);
 
        }

        private void GammaRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref TetaRefEdit, 4);
        }

 
     }
}
