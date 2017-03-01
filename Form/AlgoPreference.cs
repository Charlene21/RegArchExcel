using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegArchLibCli ;

namespace RegArchExcel
{
    public partial class AlgoPreference : Form
    {
    public string[] mAlgoStr;
        public AlgoPreference()
        {
            InitializeComponent();
            GSLRadioButton.Checked = true;
        int myCount = GSLAlgoBox.Items.Count;
            mAlgoStr = new string[myCount];
            for (int i = 0 ; i < myCount ; i++)
            {    GSLAlgoBox.SelectedIndex = i ;
            Object mySelectedItem = GSLAlgoBox.SelectedItem;
                mAlgoStr[i] = mySelectedItem.ToString();
            }
            GSLStepSizeTextBox.Text = Convert.ToString (Globals.ThisAddIn.mGSLAlgoParameter.GetStepSize());
            GSLStopValueTextBox.Text = Convert.ToString(Globals.ThisAddIn.mGSLAlgoParameter.GetStopValue());
            GSLToleranceTextBox.Text = Convert.ToString(Globals.ThisAddIn.mGSLAlgoParameter.GetTol());
            GSLMaxIterTextBox.Text = Convert.ToString(Globals.ThisAddIn.mGSLAlgoParameter.GetNMaxIter());
            GSLTimeLimitTextBox.Text = Convert.ToString(Globals.ThisAddIn.mGSLAlgoParameter.GetNMaxSeconds());
            int myAux = (int)Globals.ThisAddIn.mGSLAlgoParameter.GetAlgoType();
            GSLAlgoBox.SelectedIndex = myAux;
            GSLAlgoBox.Text = mAlgoStr[myAux];

        }


        private void OKBouton_Click(object sender, EventArgs e)
        {
            if (GSLRadioButton.Checked)
            {
                Globals.ThisAddIn.mGslOrNloptBool = true; 
            int myAux = GSLAlgoBox.FindString(GSLAlgoBox.Text);
            eGSLMultiMinAlgoEnumCli myAlgo = (eGSLMultiMinAlgoEnumCli)myAux;
            double myStepSize = (double)Convert.ToDouble(GSLStepSizeTextBox.Text);
            double myTolerance = (double)Convert.ToDouble(GSLToleranceTextBox.Text);
            double myStopValue = (double)Convert.ToDouble(GSLStopValueTextBox.Text);
            uint myNMaxIter = (uint)Convert.ToInt32(GSLMaxIterTextBox.Text);
            uint myTimeLimit = (uint)Convert.ToInt32(GSLTimeLimitTextBox.Text);
                Globals.ThisAddIn.mGSLAlgoParameter.SetValue(myAlgo, myStepSize, myTolerance,
                myStopValue, myNMaxIter, myTimeLimit, false);
            }
            else
            {
                Globals.ThisAddIn.mGslOrNloptBool = false;
            int myAux = NLOPTAlgoBox.FindString(NLOPTAlgoBox.Text);
            eNloptOptimEnumCli myAlgo = (eNloptOptimEnumCli)myAux;
                double myStopValue = (double)Convert.ToDouble(NLOPTStopValueTextBox.Text);
                double myfTol = (double)Convert.ToDouble(NLOPTfTolTextBox.Text);
                double myxTol = (double)Convert.ToDouble(NLOPTxTolTextBox.Text);
                int myMaxFuncEval = (int)Convert.ToInt32(NLOPTMaxFuncEvalTextBox.Text);
                uint myTimeLimit = (uint)Convert.ToInt32(NLOPTTimeLimitTextBox.Text);
                Globals.ThisAddIn.mNLOPTAlgoParameter.SetValue(myAlgo, true, myStopValue, myfTol, myxTol, (uint)myMaxFuncEval, myTimeLimit, false);
            }
            Close();
        }

  
        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void GSLRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GSLRadioButton.Checked)
            {
                NLOPTRadioButton.Checked = false;
                GSLAlgoBox.Enabled = true;
                GSLStepSizeTextBox.Enabled = true;
                GSLToleranceTextBox.Enabled = true;
                GSLStopValueTextBox.Enabled = true;
                GSLMaxIterTextBox.Enabled = true;
                GSLTimeLimitTextBox.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                NLOPTAlgoBox.Enabled = false;
                NLOPTfTolTextBox.Enabled = false;
                NLOPTxTolTextBox.Enabled = false;
                NLOPTMaxFuncEvalTextBox.Enabled = false;
                NLOPTTimeLimitTextBox.Enabled = false;
                NLOPTStopValueTextBox.Enabled = false;
            }
        }

        private void NLoptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NLOPTRadioButton.Checked)
            {
                GSLRadioButton.Checked = false;
                GSLAlgoBox.Enabled = false;
                GSLStepSizeTextBox.Enabled = false;
                GSLToleranceTextBox.Enabled = false;
                GSLStopValueTextBox.Enabled = false;
                GSLMaxIterTextBox.Enabled = false;
                GSLTimeLimitTextBox.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                NLOPTAlgoBox.Enabled = true;
                NLOPTfTolTextBox.Enabled = true;
                NLOPTxTolTextBox.Enabled = true;
                NLOPTMaxFuncEvalTextBox.Enabled = true;
                NLOPTTimeLimitTextBox.Enabled = true;
                NLOPTStopValueTextBox.Enabled = true;
            }

        }
    }
}
