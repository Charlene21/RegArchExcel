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
    public partial class LinRegForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public LinRegForm()
        {
            InitializeComponent();
            LinRegBetaRefEdit._Excel = Globals.ThisAddIn.Application;
            LinRegXRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(2, (int)eCondMeanEnumCli.eLinReg);
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(LinRegBetaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(LinRegXRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.AddOneCondMean(mvExcelGet);
            }
            else
                Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void LinRegXRefEdit_CellChanged(object sender, EventArgs e)
        {
 //           mvExcelGet.GetRefEditValue(ref LinRegXRefEdit, 1);
        }

        private void LinRegBetaRefEdit_CellChanged(object sender, EventArgs e)
        {
//            mvExcelGet.GetRefEditValue(ref LinRegBetaRefEdit, 0); 
 
        }
    }
}
