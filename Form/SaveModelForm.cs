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
    public partial class SaveModelForm : Form
    {
        private int mvNRows;
        private cExcelRangeClass mvExcelRange;
  
        public SaveModelForm()
        {
            InitializeComponent();
            this.ModeleRefEdit._Excel = Globals.ThisAddIn.Application;
            mvExcelRange = new cExcelRangeClass() ;
            mvNRows = Globals.ThisAddIn.mAddInModel.GetParamRangeNumber();
            if (Globals.ThisAddIn.mAddInModel.mNCondMean == 0)
                mvNRows++;
            this.NRowsLabel.Text = "Current model needs " + mvNRows.ToString() + " rows and 6 columns";
        }

        private void SaveModelForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Excel.Range myExcelRange = Globals.ThisAddIn.Application.Selection.Cells;
        bool myVide = true ;    
            // Test si vide
            for (int i = 1; i <= mvNRows; i++)
            {
                for (int j = 1; j <= 6; j++)
                    myVide = myVide & (myExcelRange[i, j].Cells.Value == null);
            }
            if (!myVide)
            {   Globals.ThisAddIn.mContinueSaveBool = false ;
            Alerte2Form myAlerte2 = new Alerte2Form() { TopMost = true };
                AddOwnedForm(myAlerte2);
                Hide();
                myAlerte2.ShowDialog(this);
            }
            else
                Globals.ThisAddIn.mContinueSaveBool = true ;

        int myLigne = 1;
            if (Globals.ThisAddIn.mContinueSaveBool)
            {
                if (Globals.ThisAddIn.mAddInModel.mNCondMean == 0)
                {
                    myExcelRange[1, 1].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[0].mWorkbook; ;
                    myExcelRange[1, 2].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[0].mWorksheet; ;
                    myExcelRange[1, 3].value = 0; // Mean Parameter
                    myExcelRange[1, 4].value = -1;
                    myExcelRange[1, 5].value = "";
                    myExcelRange[1, 6].value = "";
                    myLigne++;
                }
                else
                {   for (int i = 0; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
                    {
                        if (Globals.ThisAddIn.mAddInModel.mCondMean[i] != null)
                        {   for (int j = 0; j < Globals.ThisAddIn.mAddInModel.mCondMean[i].mNParam; j++)
                            {
                                myExcelRange[myLigne, 1].value = Globals.ThisAddIn.mAddInModel.mCondMean[i].mParam[j].mWorkbook;
                                myExcelRange[myLigne, 2].value = Globals.ThisAddIn.mAddInModel.mCondMean[i].mParam[j].mWorksheet;
                                myExcelRange[myLigne, 3].value = 0; // Mean Parameter
                                myExcelRange[myLigne, 4].value = Globals.ThisAddIn.mAddInModel.mCondMean[i].mModelType;
                                myExcelRange[myLigne, 5].value = Globals.ThisAddIn.mAddInModel.mCondMean[i].mParam[j].mLeftUpCell;
                                myExcelRange[myLigne, 6].value = Globals.ThisAddIn.mAddInModel.mCondMean[i].mParam[j].mRightDownCell;
                                myLigne++;
                            }
                       }
                    }
                }
                for (int j = 0; j < Globals.ThisAddIn.mAddInModel.mCondVar.mNParam; j++)
                {   myExcelRange[myLigne, 1].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[j].mWorkbook;
                    myExcelRange[myLigne, 2].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[j].mWorksheet;
                    myExcelRange[myLigne, 3].value = 1; // Var Parameter
                    myExcelRange[myLigne, 4].value = Globals.ThisAddIn.mAddInModel.mCondVar.mModelType;
                    myExcelRange[myLigne, 5].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[j].mLeftUpCell;
                    myExcelRange[myLigne, 6].value = Globals.ThisAddIn.mAddInModel.mCondVar.mParam[j].mRightDownCell;
                    myLigne++;
                }
                if (Globals.ThisAddIn.mAddInModel.mCondDistr.mNParam == 0)
                {
                    myExcelRange[myLigne, 1].value = "";
                    myExcelRange[myLigne, 2].value = "";
                    myExcelRange[myLigne, 3].value = 2; // Distr Parameter
                    myExcelRange[myLigne, 4].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType;
                    myExcelRange[myLigne, 5].value = "";
                    myExcelRange[myLigne, 6].value = "";
                    myLigne++;
                }
                else
                {
                    for (int j = 0; j < Globals.ThisAddIn.mAddInModel.mCondDistr.mNParam; j++)
                    {
                        myExcelRange[myLigne, 1].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mParam[j].mWorkbook;
                        myExcelRange[myLigne, 2].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mParam[j].mWorksheet;
                        myExcelRange[myLigne, 3].value = 2; // Distr Parameter
                        myExcelRange[myLigne, 4].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType;
                        myExcelRange[myLigne, 5].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mParam[j].mLeftUpCell;
                        myExcelRange[myLigne, 6].value = Globals.ThisAddIn.mAddInModel.mCondDistr.mParam[j].mRightDownCell;
                        myLigne++;
                    }
                }
            }
            Close();
            Globals.ThisAddIn.mRuban.RefreshRegArchRibbon();

        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModeleRefEdit_CellChanged(object sender, EventArgs e)
        {
        
        }
    }
}
