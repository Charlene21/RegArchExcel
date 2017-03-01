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
     public partial class TARCHForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public TARCHForm()
        {
            InitializeComponent();
            ConstRefEdit._Excel = Globals.ThisAddIn.Application;
            ArchPlusRefEdit._Excel = Globals.ThisAddIn.Application;
            ARCHMoinsRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(3, (int)eCondVarEnumCli.eTarch);
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(ConstRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(ArchPlusRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[2].SetValuesWithCells(ARCHMoinsRefEdit.Text, myWorksheet.Name, myWorkbook.Name); 
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


        private void ArchPlusRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref ArchPlusRefEdit, 1);
            ArchLagsLabel.Text = ArchPlusRefEdit._CellsCount.ToString();

        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void ARCHMoinsRefEdit_CellChanged(object sender, EventArgs e)
        {
   //         mvExcelGet.GetRefEditValue(ref ARCHMoinsRefEdit, 2);
            ArchLagsLabel.Text = ARCHMoinsRefEdit._CellsCount.ToString();
 
        }

        private void ConstRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref ConstRefEdit, 0);
 
        }

     }
}
