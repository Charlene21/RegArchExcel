using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;
using VectorAndMatrixCli;
using RegArchLibCli;
namespace RegArchExcel
{

    public class cExcelEstimation
    {
        public Excel.Range mYtRange;
        public Excel.Range mXtRange;

        public cExcelEstimation()
        {
            mYtRange = null;
            mXtRange = null;
        }

        public void GetObs(ref rcGSLVector theYt)
        {
            int myNCol = mYtRange.Columns.Count;
            int myNRow = mYtRange.Rows.Count;
            int myCount = mYtRange.Count;
            theYt.ReAlloc(myCount);
            if (myNCol <= myNRow)
            {
                for (int t = 0; t < myCount; t++)
                    theYt[t] = mYtRange[t + 1, 1].Cells.Value;
            }
            else
                for (int t = 0; t < myCount; t++)
                    theYt[t] = mYtRange[1, t + 1].Cells.Value;
        }

        public void GetObs(ref rcRegArchValue theValue)
        {
        int myNCol = mYtRange.Columns.Count;
        int myNRow = mYtRange.Rows.Count;
        int myCount = Math.Max(myNCol, myNRow);
            
            theValue.ReAlloc((uint)myCount);

            if (myNCol <= myNRow)
            {
                for (int t = 0; t < myCount; t++)
                {
                    theValue[t] = mYtRange[t + 1, 1].Cells.Value;
                }
            }
            else
            {
                for (int t = 0; t < myCount; t++)
                {
                    theValue[t] = mYtRange[1, t + 1].Cells.Value;
                }
            }
        
            if (mXtRange != null)
            {   
                int myNColX = mXtRange.Columns.Count;
                int myNRowX = mXtRange.Rows.Count;
               
                if ((myNRowX == myNRow) || (myNColX == myNCol))
                {
                    if (myNColX <= myNRowX)
                    {
                        theValue.ReAllocXt((uint)myNRowX, (uint)myNColX);
                        for (int t = 0; t < myNRowX; t++)
                            for (int s = 0; s < myNColX; s++)
                            {
                                theValue.set_pXt(t, s, mXtRange[t + 1, s + 1].Cells.Value);
                            }
                    }
                    else
                    {
                        theValue.ReAllocXt((uint)myNColX, (uint)myNRowX);
                        for (int t = 0; t < myNColX; t++)
                            for (int s = 0; s < myNRowX; s++)
                            {
                                theValue.set_pXt(t, s, mXtRange[s + 1, t + 1].Cells.Value);
                            }
                    }
                }
            }
        }


    } ;
}