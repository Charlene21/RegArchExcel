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
    public partial class LoadModelForm : Form
    {
        public LoadModelForm()
        {
            InitializeComponent();
            this.ModeleRefEdit._Excel = Globals.ThisAddIn.Application;
        }

        static int GetSheetNumber(Tools.Workbook theWorkbook, string theWorksheetName)
        {
        int myNMax = theWorkbook.Worksheets.Count ;
        int i = 1 ;
            while (i <= myNMax )
            {
            string myName = theWorkbook.Worksheets[i].Name ;
                if (theWorksheetName == myName)
                    return i;
                i++;
            }
            return 0;
        }

        private void OKBoutton_Click(object sender, EventArgs e)
        {
            Tools.Workbook myWorkBook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook);
            string myModelStr = this.ModeleRefEdit.Text;
            int myLength = myModelStr.Length;
            int myWorksheetNameIndex = myModelStr.IndexOf("!");
            string myWorkSheetName;
            Tools.Worksheet myWorkSheet;
            if (myWorksheetNameIndex >= 0)
            {
                myWorkSheetName = myModelStr.Substring(0, myWorksheetNameIndex);
                myModelStr = myModelStr.Substring(myWorksheetNameIndex + 1, myLength - myWorksheetNameIndex - 1);
                myWorkSheet = myWorkBook.Worksheets[myWorkSheetName];
            }
            else
                myWorkSheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet);

            myWorkSheet.Range[myModelStr].Select();
            Excel.Range myExcelRange = Globals.ThisAddIn.Application.Selection.Cells;
            int myNCol = myExcelRange.Columns.Count;
            int myNRow = myExcelRange.Rows.Count;
            int i = 1;
            if (((int)myExcelRange[i, 3].Cells.Value == 0) && ((int)myExcelRange[i, 4].Cells.Value == -1) )
            {
                Globals.ThisAddIn.mAddInModel.mNCondMean = 0;
                for (int j = 0; j < Globals.ThisAddIn.gvMaxNCondMean; j++)
                    Globals.ThisAddIn.mAddInModel.DeleteCondMean(j);
                Globals.ThisAddIn.mAddInModel.mCondMeanDone = true ;
                i++;

            }
            while (i <= myNRow)
            {
                if ((int)myExcelRange[i, 3].Cells.Value == 0) // CondMean
                {
                    int myCondMeanType = (int)myExcelRange[i, 4].Cells.Value;
                    Globals.ThisAddIn.mAddInModel.DeleteCondMean(myCondMeanType);
                    int j = 1;
                    while (((int)myExcelRange[i + j, 3].Cells.Value == 0) && ((int)myExcelRange[i + j, 4].Cells.Value == myCondMeanType))
                        j++;
                    cExcelStockModel myAuxStockModel = new cExcelStockModel(j, myCondMeanType);
                    for (int k = 0; k < j; k++)
                    {
                        cExcelRangeClass myExcelRangeClass = new cExcelRangeClass();
                        myExcelRangeClass.mWorkbook = myExcelRange[i + k, 1].Cells.Value;
                        myExcelRangeClass.mWorksheet = myExcelRange[i + k, 2].Cells.Value;
                        myExcelRangeClass.mLeftUpCell = myExcelRange[i + k, 5].Cells.Value;
                        myExcelRangeClass.mRightDownCell = myExcelRange[i + k, 6].Cells.Value;
                        myExcelRangeClass.mCells = myExcelRangeClass.mLeftUpCell + ":" + myExcelRangeClass.mRightDownCell;
                        Tools.Workbook myTempWorkBook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.Workbooks[myExcelRangeClass.mWorkbook]);
                        int myNumber = GetSheetNumber(myTempWorkBook, myExcelRangeClass.mWorksheet) ;
                        Tools.Worksheet myTempWorkSheet = Globals.Factory.GetVstoObject(myTempWorkBook.Worksheets[myNumber]);
                        myTempWorkBook.Activate();
                        myTempWorkSheet.Activate();
                        myTempWorkSheet.Range[myExcelRangeClass.mLeftUpCell, myExcelRangeClass.mRightDownCell].Select();
                        Excel.Range myTempExcelRange = Globals.ThisAddIn.Application.Selection.Cells;
                        myExcelRangeClass.mNColumn = myTempExcelRange.Columns.Count;
                        myExcelRangeClass.mNRow = myTempExcelRange.Rows.Count;
                        myExcelRangeClass.mNSize = myTempExcelRange.Count;
                        myAuxStockModel.AddParam(myExcelRangeClass, k);
                        myWorkBook.Activate();
                        myWorkSheet.Activate();
                    }
                    Globals.ThisAddIn.mAddInModel.AddOneCondMean(myAuxStockModel);
                    myAuxStockModel.Delete();
                    i += j;
                }
                else
                {
                    if ((int)myExcelRange[i, 3].Cells.Value == 1) // CondVar
                    {
                        int myCondVarType = (int)myExcelRange[i, 4].Cells.Value;
                        Globals.ThisAddIn.mAddInModel.DeleteCondVar();
                        int j = 1;
                        while (((int)myExcelRange[i + j, 3].Cells.Value == 1) && ((int)myExcelRange[i + j, 4].Cells.Value == myCondVarType))
                            j++;
                        cExcelStockModel myAuxStockModel = new cExcelStockModel(j, myCondVarType);
                        for (int k = 0; k < j; k++)
                        {
                            cExcelRangeClass myExcelRangeClass = new cExcelRangeClass();
                            myExcelRangeClass.mWorkbook = myExcelRange[i + k, 1].Cells.Value;
                            myExcelRangeClass.mWorksheet = myExcelRange[i + k, 2].Cells.Value;
                            myExcelRangeClass.mLeftUpCell = myExcelRange[i + k, 5].Cells.Value;
                            myExcelRangeClass.mRightDownCell = myExcelRange[i + k, 6].Cells.Value;
                            myExcelRangeClass.mCells = myExcelRangeClass.mLeftUpCell + ":" + myExcelRangeClass.mRightDownCell;
                            Tools.Workbook myTempWorkBook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.Workbooks[myExcelRangeClass.mWorkbook]);
                            int myNumber = GetSheetNumber(myTempWorkBook, myExcelRangeClass.mWorksheet);
                            Tools.Worksheet myTempWorkSheet = Globals.Factory.GetVstoObject(myTempWorkBook.Worksheets[myNumber]);
                            myTempWorkBook.Activate();
                            myTempWorkSheet.Activate();
                            Excel.Range myTempExcelRange = Globals.ThisAddIn.Application.Selection.Cells;
                            myExcelRangeClass.mNColumn = myTempExcelRange.Columns.Count;
                            myExcelRangeClass.mNRow = myTempExcelRange.Rows.Count;
                            myExcelRangeClass.mNSize = myTempExcelRange.Count;
                            myAuxStockModel.AddParam(myExcelRangeClass, k);
                            myWorkBook.Activate();
                            myWorkSheet.Activate();
                        }
                        Globals.ThisAddIn.mAddInModel.AddCondVar(myAuxStockModel);
                        myAuxStockModel.Delete();
                        i += j;
                    }
                    else
                    {
                        int myCondDistrType = (int)myExcelRange[i, 4].Cells.Value;
                        Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
                        if (myCondDistrType == (int)(eDistrTypeEnumCli.eNormal))
                        {   
                        cExcelStockModel myAuxStockModel = new cExcelStockModel(0, myCondDistrType);
                            Globals.ThisAddIn.mAddInModel.AddCondDistr(myAuxStockModel) ;
                            i++;
                        }
                        else
                        {
                        int j = 1;
                            if (i + j <= myNRow)
                                while (((int)myExcelRange[i + j, 3].Cells.Value == 2) && ((int)myExcelRange[i + j, 4].Cells.Value == myCondDistrType))
                                    j++;
                        cExcelStockModel myAuxStockModel = new cExcelStockModel(j, myCondDistrType);
                            for (int k = 0; k < j; k++)
                            {
                                cExcelRangeClass myExcelRangeClass = new cExcelRangeClass();
                                myExcelRangeClass.mWorkbook = myExcelRange[i + k, 1].Cells.Value;
                                myExcelRangeClass.mWorksheet = myExcelRange[i + k, 2].Cells.Value;
                                myExcelRangeClass.mLeftUpCell = myExcelRange[i + k, 5].Cells.Value;
                                myExcelRangeClass.mRightDownCell = myExcelRange[i + k, 6].Cells.Value;
                                myExcelRangeClass.mCells = myExcelRangeClass.mLeftUpCell + ":" + myExcelRangeClass.mRightDownCell;
                            Tools.Workbook myTempWorkBook = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.Workbooks[myExcelRangeClass.mWorkbook]);
                            int myNumber = GetSheetNumber(myTempWorkBook, myExcelRangeClass.mWorksheet);
                            Tools.Worksheet myTempWorkSheet = Globals.Factory.GetVstoObject(myTempWorkBook.Worksheets[myNumber]);
                                myTempWorkBook.Activate();
                                myTempWorkSheet.Activate();
                            Excel.Range myTempExcelRange = Globals.ThisAddIn.Application.Selection.Cells;
                                myExcelRangeClass.mNColumn = myTempExcelRange.Columns.Count;
                                myExcelRangeClass.mNRow = myTempExcelRange.Rows.Count;
                                myExcelRangeClass.mNSize = myTempExcelRange.Count;
                                myAuxStockModel.AddParam(myExcelRangeClass, k);
                                myWorkBook.Activate();
                                myWorkSheet.Activate();
                            }
                            Globals.ThisAddIn.mAddInModel.AddCondDistr(myAuxStockModel);
                            myAuxStockModel.Delete();
                            i += j;
                        }
                    }
                }
            }
            Globals.ThisAddIn.mAddInModel.SetDescription();
            Globals.ThisAddIn.mAddInBackupModel = new cExcelModelClass(Globals.ThisAddIn.mAddInModel);
//            bool myModelDone = Globals.ThisAddIn.mAddInModel.mCondDistrDone & Globals.ThisAddIn.mAddInModel.mCondMeanDone & Globals.ThisAddIn.mAddInModel.mCondVarDone;
            
            Globals.ThisAddIn.mRuban.RefreshRegArchRibbon();
            Close();
        }

        private void CancelBoutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
