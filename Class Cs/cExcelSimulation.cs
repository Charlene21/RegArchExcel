using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;
using VectorAndMatrixCli;
using RegArchLibCli;



namespace RegArchExcel
{
    public class cExcelSimulationOutput
    {
        public int mNSimul;
        public Excel.Range mExcelRange;
        public bool mRangeBool;
        public bool mWorksheetBool;
        public bool mWorkbookBool;
        public bool mAllInfoBool;

        public cExcelSimulationOutput()
        {
            mNSimul = 0;
            mExcelRange = null;
            mWorkbookBool = mWorksheetBool = mRangeBool = mAllInfoBool = false;
        }

        public void Fill(rcGSLVector theYt)
        {
            int myNbCol = mExcelRange.Columns.Count;
            int myNbRow = mExcelRange.Rows.Count;
            int myCount = mExcelRange.Count;

            if (myNbCol <= myNbRow)
            {
                for (int t = 0; t < mNSimul; t++)
                    mExcelRange[t + 1, 1].Cells.Value = theYt[t];
            }
            else
                for (int t = 0; t < mNSimul; t++)
                    mExcelRange[1, t + 1].Cells.Value = theYt[t];
        }

        public void Fill(rcRegArchValue theValue, bool theOnlyYt)
        {
            if (theOnlyYt)
            {
                int myNbCol = mExcelRange.Columns.Count;
                int myNbRow = mExcelRange.Rows.Count;
                int myCount = mExcelRange.Count;

                if (myNbCol <= myNbRow)
                {
                    for (int t = 0; t < mNSimul; t++)
                        mExcelRange[t + 1, 1].Cells.Value = theValue[t];
                }
                else
                    for (int t = 0; t < mNSimul; t++)
                        mExcelRange[1, t + 1].Cells.Value = theValue[t];

            }
            else
                Fill(theValue);
        }

        public void Fill(rcRegArchValue theValue)
        {
            int myNbCol = mExcelRange.Columns.Count;
            int myNbRow = mExcelRange.Rows.Count;
            int myCount = mExcelRange.Count;

            if (myNbCol <= myNbRow)
            {
                for (int t = 0; t < mNSimul; t++)
                {
                    mExcelRange[t + 1, 1].Cells.Value = theValue[t];
                    mExcelRange[t + 1, 2].Cells.Value = theValue.get_pMt(t);
                    mExcelRange[t + 1, 3].Cells.Value = theValue.get_pHt(t);
                    mExcelRange[t + 1, 4].Cells.Value = theValue.get_pUt(t);
                    mExcelRange[t + 1, 5].Cells.Value = theValue.get_pEpst(t);
               }
            }
            else
            {
                for (int t = 0; t < mNSimul; t++)
                {
                    mExcelRange[1, t + 1].Cells.Value = theValue[t];
                    mExcelRange[2, t + 1].Cells.Value = theValue.get_pMt(t);
                    mExcelRange[3, t + 1].Cells.Value = theValue.get_pHt(t);
                    mExcelRange[4, t + 1].Cells.Value = theValue.get_pUt(t);
                    mExcelRange[5, t + 1].Cells.Value = theValue.get_pEpst(t);
                }
            }
        }
    }
}