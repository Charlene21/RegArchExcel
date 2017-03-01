using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;

namespace RegArchExcel
{
    public class cExcelStockModel
    {
        public int mModelType;
        public int mNParam;
        public cExcelRangeClass[] mParam;
       
        public cExcelStockModel()
        {
            mModelType = 0;
            mParam = null;
            mNParam = 0;
        }

        public cExcelStockModel(int theNParam, int theModelType)
        {
            mModelType = theModelType;
            if (theNParam > 0)
            {
                mParam = new cExcelRangeClass[theNParam];
                for (int i = 0; i < theNParam; i++)
                    mParam[i] = new cExcelRangeClass();
                mNParam = theNParam;
            }
            else
            {
                mParam = null;
                mNParam = 0;
            }
        }

        public cExcelStockModel(cExcelStockModel theStockModel)
        {
            mModelType = theStockModel.mModelType;
            mNParam = theStockModel.mNParam;
            if (mNParam > 0)
            {
                mParam = new cExcelRangeClass[mNParam];
                for (int i = 0; i < mNParam; i++)
                    mParam[i] = new cExcelRangeClass(theStockModel.mParam[i]);
            }
            else
            {
                mParam = null;
                mNParam = 0;
            }
        }
        
        public void Delete()
        {
            for (int i = 0; i < mNParam; i++)
                mParam[i].Delete();

            mParam = null;
        }

        public void AddParam(cExcelRangeClass theParam, int theNumParam)
        {
            mParam[theNumParam].Delete();
            mParam[theNumParam] = new cExcelRangeClass(theParam);
        }

        public void ToExcelCells()
        {
            for (int i = 0; i < mNParam; i++)
                mParam[i].ToExcelCells();
        }

    };
}