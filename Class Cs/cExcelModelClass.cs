using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;
using VectorAndMatrixCli;
using RegArchLibCli;

namespace RegArchExcel
{

    public class cExcelModelClass
    {
        public bool     mCondMeanDone;
        public bool     mCondVarDone;
        public bool     mCondDistrDone;
        public int      mNCondMean;
        public string   mCondMeanDescr;
        public string   mCondVarDescr;
        public string   mCondDistrDescr;

        public cExcelStockModel[] mCondMean;
        public cExcelStockModel mCondVar;
        public cExcelStockModel mCondDistr;

        public cExcelModelClass()
        {
            mCondMeanDone = mCondVarDone = mCondDistrDone = false;
            SetDescription();
            mNCondMean = 0;
            mCondMean = new cExcelStockModel[Globals.ThisAddIn.gvMaxNCondMean];
        }

        public cExcelModelClass(cExcelModelClass theModelClass)
        {
            Delete();
            mCondMeanDone = theModelClass.mCondMeanDone;
            mCondVarDone = theModelClass.mCondVarDone;
            mCondDistrDone = theModelClass.mCondDistrDone;
            mNCondMean = theModelClass.mNCondMean;
            mCondMeanDescr = theModelClass.mCondMeanDescr;
            mCondVarDescr = theModelClass.mCondVarDescr;
            mCondDistrDescr = theModelClass.mCondDistrDescr;
            mCondMean = new cExcelStockModel[Globals.ThisAddIn.gvMaxNCondMean];
            for (int i = 0; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
            {
                if (theModelClass.mCondMean[i] != null)
                    mCondMean[i] = new cExcelStockModel(theModelClass.mCondMean[i]);
                else
                    mCondMean[i] = null;
            }
            if (theModelClass.mCondVar != null)
                mCondVar = new cExcelStockModel(theModelClass.mCondVar);
            if (theModelClass.mCondDistr != null)
                mCondDistr = new cExcelStockModel(theModelClass.mCondDistr);
        }

        public void AddOneCondMean(cExcelStockModel theCondMean)
        {
            DeleteCondMean(theCondMean.mModelType);
            mCondMean[theCondMean.mModelType] = new cExcelStockModel(theCondMean);
            mNCondMean++;
            mCondMeanDone = true;
        }

        public void DeleteCondMean(int theType)
        {
            if (mCondMean[theType] != null)
            {
                mCondMean[theType].Delete();
                mCondMean[theType] = null;
                mNCondMean--;
            }
            mCondMeanDone = (mNCondMean > 0);
        }

        public void AddCondVar(cExcelStockModel theCondVar)
        {
            DeleteCondVar();
            mCondVar = new cExcelStockModel(theCondVar);
            mCondVarDone = true;
        }

        public void DeleteCondVar()
        {
            if (mCondVar != null)
                mCondVar.Delete() ;
            mCondVar = null;
            mCondVarDone = false;
        }

        public void AddCondDistr(cExcelStockModel theCondDistr)
        {
            DeleteCondDistr() ;
            mCondDistr = new cExcelStockModel(theCondDistr);
            mCondDistrDone = true;
        }

        public void DeleteCondDistr()
        {
            if (mCondDistr != null)
                mCondDistr.Delete();
            mCondDistr = null;
            mCondDistrDone = false;
        }

        public void Delete()
        {
            if (mCondMean != null)
                for (int i = 0; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
                    mCondMean[i].Delete();
            mCondMean = null;
            if (mCondVar != null)
                mCondVar.Delete();
            if (mCondDistr != null)
                mCondDistr.Delete();
        }

        private string MeanEnumToString(eCondMeanEnumCli theType)
        {
            switch (theType)
            {   case eCondMeanEnumCli.eConst:
                    return ("Const");
                case eCondMeanEnumCli.eAr:
                    return ("AR(p)");
                case eCondMeanEnumCli.eMa:
                    return ("MA(q)");
                case eCondMeanEnumCli.eLinReg:
                    return ("Lin. Reg.");
                case eCondMeanEnumCli.eVarInMean:
                    return ("Var in Mean");
                case eCondMeanEnumCli.eStdDevInMean:
                    return ("Stdev in Mean");
                case eCondMeanEnumCli.eArfima:
                    return ("ARFIMA(p, d, q)");
                case eCondMeanEnumCli.eUnknown:
                default:
                    return "Undefined";
            }
        }

        private string VarEnumToString(eCondVarEnumCli theType)
        {
            switch (theType)
            {
                case eCondVarEnumCli.eCste:
                    return ("Constant Var");
                case eCondVarEnumCli.eArch:
                    return ("ARCH(p)");
                case eCondVarEnumCli.eGarch:
                    return ("GARCH(p, q)");
                case eCondVarEnumCli.eTarch:
                    return ("TARCH(p)");
                case eCondVarEnumCli.eEgarch:
                    return ("EGARCH(p, q)");
                case eCondVarEnumCli.eAparch:
                    return ("APARCH(p,q)");
                case eCondVarEnumCli.eFigarch:
                    return ("FIGARCH(p, d, q)");
                case eCondVarEnumCli.eNotKnown:
                default:
                    return "Undefined";
            }
        }

        private string DistrEnumToString(eDistrTypeEnumCli theType)
        {
            switch (theType)
            {
                case eDistrTypeEnumCli.eNormal:
                    return ("Gaussian");
                case eDistrTypeEnumCli.eStudent:
                    return ("Student");
                case eDistrTypeEnumCli.eGed:
                    return ("Ged");
                case eDistrTypeEnumCli.eUndefined:
                default:
                    return "Undefined";
            }
        }

        public void SetDescription()
        {
            if ((mNCondMean == 0) && (!mCondMeanDone))
                mCondMeanDescr = "Undefined";
            else
            {   if (mNCondMean == 0)
                    mCondMeanDescr = "No conditional mean (pure ARCH model)";
                else
                {
                int i = 0;
                    while (mCondMean[i] == null)
                        i++;
                    mCondMeanDescr = MeanEnumToString((eCondMeanEnumCli)i);

                    for (int j = i + 1; j < Globals.ThisAddIn.gvMaxNCondMean; j++)
                        if (mCondMean[j] != null)
                            mCondMeanDescr = mCondMeanDescr + " + " + MeanEnumToString((eCondMeanEnumCli)j);
                }
            }
            if (mCondVar == null)
                mCondVarDescr = "Undefined";
            else
                mCondVarDescr = VarEnumToString((eCondVarEnumCli)mCondVar.mModelType);
            if (mCondDistr == null)
                mCondDistrDescr = "Undefined";
            else
                mCondDistrDescr = DistrEnumToString((eDistrTypeEnumCli)mCondDistr.mModelType);
        }

        public void SetrcRegArchModel(ref rcRegArchModel theRegArchModel)
        {
            for (int i = 1; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
            {
                if (mCondMean[i] != null)
                {
                rcAbstCondMean myCondMean = new rcAbstCondMean((eCondMeanEnumCli)i);
                int myNParam = mCondMean[i].mNParam ;
                    if ( (eCondMeanEnumCli)i == eCondMeanEnumCli.eLinReg )
                        myNParam = 1 ;

                    for (int j = 0; j < myNParam ; j++)
                    {
                    int myNCol = mCondMean[i].mParam[j].mNColumn;
                    int myNRow = mCondMean[i].mParam[j].mNRow;
                    int myNSize = mCondMean[i].mParam[j].mNSize;
                        if ((myNCol == 1) || (myNRow == 1))
                        {   myCondMean.ReAlloc((uint)myNSize, (uint)j);
                            for (int n = 0; n < myNSize; n++)
                            {   if (myNCol == 1)
                                    myCondMean.Set(mCondMean[i].mParam[j].mValues[n, 0], (uint)n, (uint)j);
                                else
                                    myCondMean.Set(mCondMean[i].mParam[j].mValues[0, n], (uint)n, (uint)j);
                            }
                        }
                    }
                    theRegArchModel.AddOneMean(myCondMean);
                }
            }

            rcAbstCondVar myCondVar = new rcAbstCondVar((eCondVarEnumCli)mCondVar.mModelType);
            for (int j = 0; j < mCondVar.mNParam; j++)
            {
            int myNCol = mCondVar.mParam[j].mNColumn;
            int myNRow = mCondVar.mParam[j].mNRow;
            int myNSize = mCondVar.mParam[j].mNSize;
                if ((myNCol == 1) || (myNRow == 1))
                {   myCondVar.ReAlloc((uint)myNSize, (uint)j);
                    for (int n = 0; n < myNSize; n++)
                    {   if (myNCol == 1)
                            myCondVar.Set(mCondVar.mParam[j].mValues[n, 0], (uint)n, (uint)j);
                        else
                            myCondVar.Set(mCondVar.mParam[j].mValues[0, n], (uint)n, (uint)j);
                    }
                }
            }
            theRegArchModel.SetVar(myCondVar);

            if (mCondDistr.mNParam > 0)
            {   rcGSLVector myVector = new rcGSLVector();
                for (int j = 0; j < mCondDistr.mNParam; j++)
                {
                int myNCol = mCondDistr.mParam[j].mNColumn;
                int myNRow = mCondDistr.mParam[j].mNRow;
                int myNSize = mCondDistr.mParam[j].mNSize;
                    if ((myNCol == 1) || (myNRow == 1))
                    {   myVector.ReAlloc(myNSize);
                        for (int n = 0; n < myNSize; n++)
                        {   if (myNCol == 1)
                                myVector[n] = mCondDistr.mParam[j].mValues[n, 0];
                            else
                                myVector[n] = mCondDistr.mParam[j].mValues[0, n];
                        }
                    }
                }
                rcAbstCondResiduals myCondResid = new rcAbstCondResiduals((eDistrTypeEnumCli)mCondDistr.mModelType, myVector, true);
                theRegArchModel.SetResid(myCondResid);
            }
            else
            {   rcAbstCondResiduals myCondResid = new rcAbstCondResiduals((eDistrTypeEnumCli)mCondDistr.mModelType, true);
                theRegArchModel.SetResid(myCondResid);
            }

        }

        public void GetrcRegArchModel(ref rcRegArchModel theRegArchModel)
        {
            for (int i = 1; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
            {
                if (mCondMean[i] != null)
                {
                    rcAbstCondMean myCondMean = new rcAbstCondMean();
                    int k = theRegArchModel.GetIndexMeanType(i);
                    if (k >= 0)
                    {
                        theRegArchModel.GetOneMean(k, myCondMean);
                    int myNParam = mCondMean[i].mNParam;
                        if ((eCondMeanEnumCli)i == eCondMeanEnumCli.eLinReg)
                            myNParam = 1;
                        for (int j = 0; j < myNParam; j++)
                        {
                            int myNCol = mCondMean[i].mParam[j].mNColumn;
                            int myNRow = mCondMean[i].mParam[j].mNRow;
                            int myNSize = mCondMean[i].mParam[j].mNSize;
                            if ((myNCol == 1) || (myNRow == 1))
                            {
                                for (int n = 0; n < myNSize; n++)
                                {
                                    if (myNCol == 1)
                                        mCondMean[i].mParam[j].mValues[n, 0] = myCondMean.Get((uint)n, (uint)j);
                                    else
                                        mCondMean[i].mParam[j].mValues[0, n] = myCondMean.Get((uint)n, (uint)j);
                                }
                            }
                        }
                    }
                }
            }
            rcAbstCondVar myCondVar = new rcAbstCondVar();
            theRegArchModel.GetVar(myCondVar);
            for (int j = 0; j < mCondVar.mNParam; j++)
            {
                int myNCol = mCondVar.mParam[j].mNColumn;
                int myNRow = mCondVar.mParam[j].mNRow;
                int myNSize = mCondVar.mParam[j].mNSize;
                if ((myNCol == 1) || (myNRow == 1))
                {
                    for (int n = 0; n < myNSize; n++)
                    {
                        if (myNCol == 1)
                            mCondVar.mParam[j].mValues[n, 0] = myCondVar.Get((uint)n, (uint)j);
                        else
                            mCondVar.mParam[j].mValues[0, n] = myCondVar.Get((uint)n, (uint)j);
                    }
                }
            }

            rcAbstCondResiduals myCondResid = new rcAbstCondResiduals();
            theRegArchModel.GetResiduals(myCondResid);
            if (mCondDistr.mNParam > 0)
            {
                rcGSLVector myVector = new rcGSLVector();
                for (int j = 0; j < mCondDistr.mNParam; j++)
                {
                    int myNCol = mCondDistr.mParam[j].mNColumn;
                    int myNRow = mCondDistr.mParam[j].mNRow;
                    int myNSize = mCondDistr.mParam[j].mNSize;
                    if ((myNCol == 1) || (myNRow == 1))
                    {
                        for (int n = 0; n < myNSize; n++)
                        {
                            if (myNCol == 1)
                                mCondDistr.mParam[j].mValues[n, 0] = myCondResid.Get((uint)n);
                            else
                                mCondDistr.mParam[j].mValues[0, n] = myCondResid.Get((uint)n);
                        }
                    }
                }
            }

        }

        public void ToExcelCells()
        {
            for (int i = 0; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
            {
                if (mCondMean[i] != null)
                    mCondMean[i].ToExcelCells();
            }
            mCondVar.ToExcelCells();
            mCondDistr.ToExcelCells();
        }

        public int GetParamRangeNumber()
        {
            int myNParamRangeNumber = 0;
            for (int i = 0; i < Globals.ThisAddIn.gvMaxNCondMean; i++)
            {
                if (mCondMean[i] != null)
                    myNParamRangeNumber += mCondMean[i].mNParam;
            }
            myNParamRangeNumber += mCondVar.mNParam;
            if (mCondDistr.mNParam < 1) // Loi normale
                myNParamRangeNumber++;
            else
                myNParamRangeNumber += mCondDistr.mNParam;
            return myNParamRangeNumber;
        }
    };
}