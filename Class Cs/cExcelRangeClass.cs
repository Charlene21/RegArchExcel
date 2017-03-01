using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;


namespace RegArchExcel
{
    public class cExcelRangeClass
    {
        public string mCells;
        public string mWorkbook;
        public string mWorksheet;
        public string mLeftUpCell;
        public string mRightDownCell;
        public int mNSize;
        public int mNColumn;
        public int mNRow;
        public double[,] mValues;
       
        public cExcelRangeClass()
        {
            mCells = mWorkbook = mWorksheet = mLeftUpCell = mRightDownCell = "";
            mNSize = mNColumn = mNRow = 0;
            mValues = null;
        }

        public cExcelRangeClass(cExcelRangeClass theExcelRangeClass)
        {
            mCells = theExcelRangeClass.mCells;
            mWorkbook = theExcelRangeClass.mWorkbook;
            mWorksheet = theExcelRangeClass.mWorksheet;
            mLeftUpCell = theExcelRangeClass.mLeftUpCell;
            mRightDownCell = theExcelRangeClass.mRightDownCell;
            mNSize = theExcelRangeClass.mNSize;
            mNColumn = theExcelRangeClass.mNColumn;
            mNRow = theExcelRangeClass.mNRow;
            GetCellsValues();
        }
       
        public void Delete()
        {
            mValues = null;
            mCells = mWorkbook = mWorksheet = mLeftUpCell = mRightDownCell = null;
            mNSize = mNColumn = mNRow = 0;
        }

        private void GetCellsValues()
        {
            Excel.Workbook myWorkbook = null;
            Excel.Worksheet myWorksheet = null;
            if (Globals.ThisAddIn.Application.Workbooks[mWorkbook] != null)

            //if (Globals.ThisAddIn.Application.ActiveWorkbook != null)
            {
                myWorkbook = Globals.ThisAddIn.Application.Workbooks[mWorkbook];
                myWorksheet = myWorkbook.Worksheets[mWorksheet];

                if (myWorksheet != null)
                {
                    Excel.Range myExcelRange = myWorksheet.Range[mLeftUpCell, mRightDownCell];

                    int myNbCol = myExcelRange.Columns.Count;
                    int myNbRow = myExcelRange.Rows.Count;
                    int myCount = myExcelRange.Count;
                    if (myNbRow >= myNbCol)
                    {
                        mNRow = myNbRow;
                        mNColumn = myNbCol;
                    }
                    else
                    {
                        mNRow = myNbCol;
                        mNColumn = myNbRow;
                    }
                    mNSize = myCount;

                    if ((myNbRow > 0) && (myNbCol > 0))
                    {
                        if (myNbRow < myNbCol)
                            mValues = new double[myNbCol, myNbRow];
                        else
                            mValues = new double[myNbRow, myNbCol];

                        for (int i = 0; i < myNbRow; i++)
                        {
                            for (int j = 0; j < myNbCol; j++)
                            {
                                try
                                {
                                    if (myNbRow >= myNbCol)
                                        mValues[i, j] = myExcelRange[i + 1, j + 1].Cells.Value;
                                    else
                                        mValues[j, i] = myExcelRange[i + 1, j + 1].Cells.Value;
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SetCellsValues()
        {
            Excel.Workbook myWorkbook = null;
            Excel.Worksheet myWorksheet = null;
            if (Globals.ThisAddIn.Application.Workbooks[mWorkbook] != null)
            {
                myWorkbook = Globals.ThisAddIn.Application.Workbooks[mWorkbook];
                myWorksheet = myWorkbook.Worksheets[mWorksheet];

                if (myWorksheet != null)
                {
                    Excel.Range myExcelRange = myWorksheet.Range[mLeftUpCell, mRightDownCell];

                    int myNbCol = myExcelRange.Columns.Count;
                    int myNbRow = myExcelRange.Rows.Count;
                    int myCount = myExcelRange.Count;
                    if (myNbRow >= myNbCol)
                    {
                        mNRow = myNbRow;
                        mNColumn = myNbCol;
                    }
                    else
                    {
                        mNRow = myNbCol;
                        mNColumn = myNbRow;
                    }
                    mNSize = myCount;

                    if ((myNbRow > 0) && (myNbCol > 0))
                    {
                        for (int i = 0; i < myNbRow; i++)
                        {
                            for (int j = 0; j < myNbCol; j++)
                            {
                                try
                                {
                                    if (myNbRow >= myNbCol)
                                        myExcelRange[i + 1, j + 1].Cells.Value = mValues[i, j];
                                    else
                                        myExcelRange[i + 1, j + 1].Cells.Value = mValues[j, i];
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
            }
        }

        public void GetRange()
        {
            int myLength = mCells.Length;
            int myWorksheetNameIndex = mCells.IndexOf("!");
            if (myWorksheetNameIndex >= 0)
            {
                mWorksheet = mCells.Substring(0, myWorksheetNameIndex);
                mCells = mCells.Substring(myWorksheetNameIndex + 1, myLength - myWorksheetNameIndex - 1);
                myLength = myLength - myWorksheetNameIndex - 1;
            }
            int mySemiColumn = mCells.IndexOf(":");
            if (mySemiColumn >= 0)
            {
                mLeftUpCell = mCells.Substring(0, mySemiColumn);
                mRightDownCell = mCells.Substring(mySemiColumn + 1, myLength - mySemiColumn - 1);
            }
            else
            {
                mLeftUpCell = mRightDownCell = mCells;
            }
        }

        public void SetValues(string theCellString, string theWorksheetString, string theWorkbookString)
        {
            mWorkbook = theWorkbookString;
            mWorksheet = theWorksheetString;
            mCells = theCellString;
            GetRange();
        }
 
        public void SetValuesWithCells(string theCellString, string theWorksheetString, string theWorkbookString)
        {
            mWorkbook = theWorkbookString;
            mWorksheet = theWorksheetString;
            mCells = theCellString;
            GetRange();
            GetCellsValues();
        }

        public void SetCellsWithValues(string theCellString, string theWorksheetString, string theWorkbookString)
        {
            mWorkbook = theWorkbookString;
            mWorksheet = theWorksheetString;
            mCells = theCellString;
            GetRange();
            SetCellsValues();
        }

        public void ToExcelCells()
        {
            SetCellsValues();
        }

    };

}