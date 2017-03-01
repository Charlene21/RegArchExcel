using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools = Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using RegArchLibCli;

namespace RegArchExcel
{
    public partial class ConstMeanForm : Form
    {
        private cExcelStockModel mvExcelGet;
        
        public ConstMeanForm()
        {
            InitializeComponent();
            ConstRefedit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(1, (int)eCondMeanEnumCli.eConst);
         }

  
        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(ConstRefedit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.AddOneCondMean(mvExcelGet);
    //            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.None);
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

        private void ConstRefedit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref ConstRefedit, 0);
 
        }

     }
}
