using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using RegArchLibCli;
using VS.NET_RefeditControl;
namespace RegArchExcel
{
    public partial class ThisAddIn
    {
        public int gvMaxNCondMean = 8;
        public int gvMaxNDistrParam = 1;
        public cExcelModelClass mAddInModel;
        public cExcelModelClass mAddInBackupModel;
        public cExcelModelClass mAddInBackupMeanModel;
        public cExcelModelClass mAddInBackupVarModel;
        public cExcelModelClass mAddInBackupDistrModel;
        public cExcelSimulationOutput mExcelSimulation;
        public cExcelEstimation mExcelEstimation;
        public rcGSLMultiMinAlgoParam mGSLAlgoParameter;
        public rcNloptAlgoParam mNLOPTAlgoParameter;
        public bool mDefaultInitPointBool;
        public bool mContinueSaveBool;
        public RegArchRibbonXML mRuban;
        public bool mGslOrNloptBool;
  
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            mRuban = new RegArchRibbonXML();
            return mRuban;
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
 //           mRuban = new RegArchRibbonXML();
 //           mRuban = Globals.Ribbons.RegArchRibbonXML;
            mAddInBackupModel = new cExcelModelClass();
            mAddInBackupMeanModel = new cExcelModelClass();
            mAddInBackupVarModel = new cExcelModelClass();
            mAddInBackupDistrModel = new cExcelModelClass();
            mAddInModel = new cExcelModelClass();
            mExcelSimulation = new cExcelSimulationOutput();
            mExcelEstimation = new cExcelEstimation();
            mGSLAlgoParameter = new rcGSLMultiMinAlgoParam();
            mNLOPTAlgoParameter = new rcNloptAlgoParam();
            mDefaultInitPointBool = true;
            mContinueSaveBool = false;
            mGslOrNloptBool = true;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Code généré par VSTO

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
