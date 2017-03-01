using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;
using RegArchLibCli;
namespace RegArchExcel
{
    public partial class EstimationForm : Form
    {
        private cExcelStockModel mvExcelGet;
        private Excel.Range mvYtRange;
        private Excel.Range mvXtRange;
        private bool mvChecked = false;
        public EstimationForm()
        {
            InitializeComponent();
            ObsRefEdit._Excel = Globals.ThisAddIn.Application;
            LinRegMatrixRefEdit._Excel = Globals.ThisAddIn.Application;
            DefaultRadioButton.Checked = Globals.ThisAddIn.mDefaultInitPointBool;
            CurrentRadioBouton.Checked = !DefaultRadioButton.Enabled;
            LinRegMatrixRefEdit.Enabled = (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eLinReg] != null);
            if (LinRegMatrixRefEdit.Enabled)
                LinRegMatrixRefEdit.Text = Globals .ThisAddIn .mAddInModel .mCondMean[(int)eCondMeanEnumCli.eLinReg].mParam[1].mCells ;
            mvExcelGet = new cExcelStockModel();
            mvYtRange = Globals.ThisAddIn.mExcelEstimation.mYtRange;
            mvXtRange = Globals.ThisAddIn.mExcelEstimation.mXtRange;
            
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mExcelEstimation.mYtRange = mvYtRange;
            Globals.ThisAddIn.mExcelEstimation.mXtRange = mvXtRange;

            cExcelCompute myCompute = new cExcelCompute();
            Hide();
            ComputingForm myWaitForm = new ComputingForm();
            myWaitForm.Show();
            Globals.ThisAddIn.mDefaultInitPointBool = DefaultRadioButton.Checked;
                myCompute.Estimation(Globals.ThisAddIn.mAddInModel);
            myWaitForm.Close();
           
            Close();
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlgoBouton_Click(object sender, EventArgs e)
        {
        AlgoPreference myAlgoPref = new AlgoPreference() { TopMost = true };
            myAlgoPref.Show();
        }

        private void ObsRefEdit_CellChanged(object sender, EventArgs e)
        {
            string myString = ObsRefEdit.Text;
            mvYtRange = Globals.ThisAddIn.Application.Selection;
            this.SampleSizeLabel.Text = ObsRefEdit._CellsCount.ToString();

        }

        private void EstimationForm_Load(object sender, EventArgs e)
        {
            this.SampleSizeLabel.Text = ObsRefEdit._CellsCount.ToString();
        }

        private void DefaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mvChecked)
            {
                DefaultRadioButton.Checked = true;
                mvChecked = false;
                CurrentRadioBouton.Checked = false;
                mvChecked = true;
            }

        }

        private void CurrentRadioBouton_CheckedChanged(object sender, EventArgs e)
        {
            if (mvChecked)
            {
                CurrentRadioBouton.Checked = true;
                mvChecked = false;
                DefaultRadioButton.Checked = false;
                mvChecked = true;
            }
        }

        private void LinRegMatrixRefEdit_CellChanged(object sender, EventArgs e)
        {
            mvXtRange = Globals.ThisAddIn.Application.Selection;
         }


      }
}
