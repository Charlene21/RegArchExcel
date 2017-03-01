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

namespace RegArchExcel
{
    public partial class SimulationForm : Form
    {
        private Excel.Range mvRange;
        private Boolean mvRangeBool;
        private Boolean mvWorksheetBool;
        private Boolean mvWorkbookBool;
        private Boolean mvAllInfoBool;
        private int mvSheetNum;

        public SimulationForm()
        {
            InitializeComponent();
            RangeRefEdit._Excel = Globals.ThisAddIn.Application;
            mvRange = Globals.ThisAddIn.mExcelSimulation.mExcelRange;
            mvRangeBool = Globals.ThisAddIn.mExcelSimulation.mRangeBool;
            mvWorksheetBool = Globals.ThisAddIn.mExcelSimulation.mWorksheetBool;
            mvWorkbookBool =  Globals.ThisAddIn.mExcelSimulation.mWorkbookBool ;
            mvAllInfoBool = Globals.ThisAddIn.mExcelSimulation.mAllInfoBool;
            RangeRefEdit.Enabled = mvRangeBool ;
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {   int myInt = Convert.ToInt16( SampleSizeTextBox.Text) ;

            Globals.ThisAddIn.mExcelSimulation.mNSimul = myInt;
            if (mvRangeBool)
            {
                Globals.ThisAddIn.mExcelSimulation.mExcelRange = mvRange;
            }

            Globals.ThisAddIn.mExcelSimulation.mAllInfoBool = mvAllInfoBool; ;
            if (mvWorksheetBool)
            {
                Globals.ThisAddIn.Application.Worksheets.Add();
                mvSheetNum = Globals.ThisAddIn.Application.Sheets.Count;
                Excel.Worksheet myWorksheet = Globals.ThisAddIn.Application.ActiveSheet ;
                if (myWorksheet != null)
                {
                string myString ;
                    if (!mvAllInfoBool)
                        myString = "A" + Convert.ToString(myInt + 1);
                    else
                        myString = "E" + Convert.ToString(myInt + 1);
                    
                    Globals.ThisAddIn.mExcelSimulation.mExcelRange = mvRange = myWorksheet.Range["A2", myString];
                }
            }
            if (mvWorkbookBool)
            {
                Globals.ThisAddIn.Application.Workbooks.Add();               
                Excel.Worksheet myWorksheet = Globals.ThisAddIn.Application.ActiveSheet ;
                if (myWorksheet != null)
                {
                    mvSheetNum = 1;
                    string myString;
                    if (!mvAllInfoBool)
                        myString = "A" + Convert.ToString(myInt + 1);
                    else
                        myString = "E" + Convert.ToString(myInt + 1);
                    Globals.ThisAddIn.mExcelSimulation.mExcelRange = mvRange = myWorksheet.Range["A2", myString];
                }
            }
            Globals.ThisAddIn.mExcelSimulation.mRangeBool = mvRangeBool;
            Globals.ThisAddIn.mExcelSimulation.mWorksheetBool = mvWorksheetBool;
            Globals.ThisAddIn.mExcelSimulation.mWorkbookBool = mvWorkbookBool;
            cExcelCompute myCompute = new cExcelCompute();

            myCompute.Simulation(myInt, Globals.ThisAddIn.mAddInModel) ;
            Close();
        }

        private void RangeRefEdit_CellChanged(object sender, EventArgs e)
        {
            mvRange = Globals.ThisAddIn.Application.Selection;
            int mySize = mvRange.Count;
            if (mvAllInfoBool)
                mySize = (int)(mySize/5);
            SampleSizeTextBox.Text  = Convert.ToString (mySize);
        }

        private void RangeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!mvRangeBool)
            {
                mvRangeBool = true;
                mvWorksheetBool = mvWorkbookBool  = false;
                RangeRefEdit.Enabled = true;
                RangeRefEdit._Excel = Globals.ThisAddIn.Application;
            }
        }

        private void WorksheetRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!mvWorksheetBool)
            {
                mvWorksheetBool = true;
                mvRangeBool  = mvWorkbookBool = false;
                RangeRefEdit.Enabled = false;
 
            }
  
        }

        private void WorkbookRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!mvWorkbookBool)
            {
                mvWorkbookBool = true;
                mvRangeBool = mvWorksheetBool = false;
                RangeRefEdit.Enabled = false;
            }

        }

        private void AllInfoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mvAllInfoBool = AllInfoCheckBox.Checked;
        }

      }
}
