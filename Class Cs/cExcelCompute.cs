using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;
using VectorAndMatrixCli;
using RegArchLibCli;

namespace RegArchExcel
{
    public class cExcelCompute
    {
        public void Simulation(int theNSimul,  cExcelModelClass theModel)
        {
            // Test si linereg
            rcGSLMatrix myX = null;
            if (theModel.mCondMean[(int)eCondMeanEnumCli.eLinReg] != null)
            {
                cExcelRangeClass myExcelStockModel = theModel.mCondMean[(int)eCondMeanEnumCli.eLinReg].mParam[1]; // matrix X
                myX = new rcGSLMatrix(myExcelStockModel.mNRow, myExcelStockModel.mNColumn);
                for (int i = 0; i < myExcelStockModel.mNRow; i++)
                    for (int j = 0; j < myExcelStockModel.mNColumn; j++)
                        myX[i, j] = myExcelStockModel.mValues[i, j];
            }

            rcRegArchModel myModel = new rcRegArchModel();
            rcRegArchValue myValue = null;
            if (myX == null)
                myValue = new rcRegArchValue((uint)theNSimul);
            else
                myValue = new rcRegArchValue((uint)theNSimul, myX);
            theModel.SetrcRegArchModel(ref myModel);
            rcRegArchCompute myCompute = new rcRegArchCompute();

            if (!Globals.ThisAddIn.mExcelSimulation.mAllInfoBool)
            {
                myCompute.Simul((uint)theNSimul, myModel, myValue);
                Globals.ThisAddIn.mExcelSimulation.Fill(myValue, true);
            }
            else
            {
                myCompute.Simul((uint)theNSimul, myModel, myValue);
                Globals.ThisAddIn.mExcelSimulation.Fill(myValue);
            }
        }

        public void Estimation(cExcelModelClass theModel)
        {
        rcRegArchModel myModel = new rcRegArchModel();
            theModel.SetrcRegArchModel(ref myModel);
        rcRegArchModel myResModel = new rcRegArchModel(myModel);
  //         theModel.SetrcRegArchModel(ref myResModel);

        rcRegArchValue myValue = new rcRegArchValue();
            Globals.ThisAddIn.mExcelEstimation.GetObs(ref myValue);
        rcRegArchCompute myCompute = new rcRegArchCompute();

        rcGSLMultiMinResult myGslResult = new rcGSLMultiMinResult();
        rcNLOPTResult myNLOPTResult = new rcNLOPTResult();
            if (Globals.ThisAddIn.mGslOrNloptBool)
            {
            rcGSLMultiMinAlgoParam myAlgoParam = new rcGSLMultiMinAlgoParam(Globals.ThisAddIn.mGSLAlgoParameter.GetAlgoType(),
                    Globals.ThisAddIn.mGSLAlgoParameter.GetStepSize(), Globals.ThisAddIn.mGSLAlgoParameter.GetTol(), Globals.ThisAddIn.mGSLAlgoParameter.GetStopValue(),
                    Globals.ThisAddIn.mGSLAlgoParameter.GetNMaxIter(), Globals.ThisAddIn.mGSLAlgoParameter.GetNMaxSeconds(), false);

            int myNParam = (int)myModel.GetNParam();
            rcGSLVector myInitPoint = new rcGSLVector(myNParam);
                if (Globals.ThisAddIn.mDefaultInitPointBool)
                    myResModel.DefaultInitPoint(myValue);

                myResModel.RegArchParamToVector(myInitPoint);

                myCompute.RegArchEstim(myModel, myValue, myGslResult, myResModel, myInitPoint, myAlgoParam);
            }
            else
            {
                rcNloptAlgoParam myAlgoParam = new rcNloptAlgoParam(Globals.ThisAddIn.mNLOPTAlgoParameter.GetAlgoType(), true, Globals.ThisAddIn.mNLOPTAlgoParameter.GetStopValue(),
                    Globals.ThisAddIn.mNLOPTAlgoParameter.GetfTol(), Globals.ThisAddIn.mNLOPTAlgoParameter.GetxTol(), Globals.ThisAddIn.mNLOPTAlgoParameter.GetNMaxFuncEval(),
                    Globals.ThisAddIn.mNLOPTAlgoParameter.GetNMaxSeconds(), false);
            
                int myNParam = (int)myModel.GetNParam();
                rcGSLVector myInitPoint = new rcGSLVector(myNParam);
                if (Globals.ThisAddIn.mDefaultInitPointBool)
                    myResModel.DefaultInitPoint(myValue);

                myResModel.RegArchParamToVector(myInitPoint);

                myCompute.RegArchEstim(myModel, myValue, myNLOPTResult, myResModel, myInitPoint, myAlgoParam);
            }
            Globals.ThisAddIn.mAddInModel.GetrcRegArchModel(ref myResModel);
            if (Globals.ThisAddIn.mGslOrNloptBool)
            {
            int myNIter = 0;
            bool myConvergence = false;
            double myCritValue = 0.0, myLLHValue = 0.0, myNSecond = 0.0;
            String myConvergenceComment = null;
                myGslResult.GetValues(ref myNIter, ref myConvergence, ref myCritValue, ref myLLHValue, ref myConvergenceComment, ref myNSecond);
            AlgoResultForm myResultForm = new AlgoResultForm(myConvergence, myNIter, myLLHValue, myCritValue, myConvergenceComment, myNSecond);
                myResultForm.Show();
            }
            else
            {
            bool myConvergence = false;
            String myConvergenceComment = null;
            double myLLHValue = 0.0;
            double myNSecond = 0;

                myNLOPTResult.GetValues(ref myConvergence, ref myLLHValue, ref myConvergenceComment, ref myNSecond);
                NloptAlgoResultForm myResultForm = new NloptAlgoResultForm(myConvergence, myLLHValue,myConvergenceComment, myNSecond);
                myResultForm.Show();
            }

            Globals.ThisAddIn.mAddInModel.ToExcelCells();
        }
         
    };
}
