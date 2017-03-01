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
    public partial class ARForm : Form
    {
        private cExcelStockModel mvExcelGet;
 
        public ARForm()
        {
            InitializeComponent();
            ARRefedit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(1, (int)eCondMeanEnumCli.eAr);
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(ARRefedit.Text, myWorksheet.Name, myWorkbook.Name);
                
                Globals.ThisAddIn.mAddInModel.AddOneCondMean(mvExcelGet);
            }
            else
                Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

  
        private void ARRefedit_CellChanged(object sender, EventArgs e)
        {
  //          mvExcelGet.GetRefEditValue(ref ARRefedit, 0);

            LagsLabel.Text = ARRefedit._CellsCount.ToString();
  
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

     }
}
