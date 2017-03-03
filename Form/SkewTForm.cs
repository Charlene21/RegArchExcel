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
    public partial class SkewTForm : Form
    {
        private cExcelStockModel mvExcelGet;
        public SkewTForm()
        {
            InitializeComponent();
            SkewTRefEdit._Excel = Globals.ThisAddIn.Application;
            GammaRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelGet = new cExcelStockModel(2, (int)eDistrTypeEnumCli.eSkewT);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                Tools.Workbook myWorkbook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
                Tools.Worksheet myWorksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveSheet);
                mvExcelGet.mParam[0].SetValuesWithCells(SkewTRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                mvExcelGet.mParam[1].SetValuesWithCells(GammaRefEdit.Text, myWorksheet.Name, myWorkbook.Name);
                Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
                Globals.ThisAddIn.mAddInModel.AddCondDistr(mvExcelGet);
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
    }
}
