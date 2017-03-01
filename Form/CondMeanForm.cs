using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegArchLibCli;

namespace RegArchExcel
{
    public partial class CondMeanForm : Form
    {
        public CondMeanForm()
        {   InitializeComponent();
 //           CheckCondMean();
        }

        private void CondMeanForm_Activated(object sender, System.EventArgs e)
        {
           UpdateControl();
        }

        private void EnableDisableButton(ref Button theAddButton, ref Button theRemoveButton, bool theRemoveOK)
        {
            if (theRemoveOK)
            {
                theRemoveButton.Enabled = true;
                theAddButton.Enabled = false;
            }
            else
            {
                theRemoveButton.Enabled = false;
                theAddButton.Enabled = true;
            }
            
        }
 
        private void UpdateControl()
        {
        bool myNoCondMeanBool = Globals.ThisAddIn.mAddInModel.mCondMeanDone & (Globals.ThisAddIn.mAddInModel.mNCondMean == 0) ;
            EnableDisableButton(ref NoCondMeanAddButton, ref NoCondMeanRemoveButton, myNoCondMeanBool) ;
            EnableDisableButton(ref ConstAddButton, ref ConstRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eConst] != null));
            EnableDisableButton(ref ARAddButton, ref ARRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eAr] != null));
            EnableDisableButton(ref MAAddButton, ref MARemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eMa] != null));
            EnableDisableButton(ref LinRegAddButton, ref LinRegRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eLinReg] != null));
            EnableDisableButton(ref VarInMeanAddButton, ref VarInMeanRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eVarInMean] != null));
            EnableDisableButton(ref StdevInMeanAddButton, ref StdevInMeanRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondMean[(int)eCondMeanEnumCli.eStdDevInMean] != null));
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.SetDescription();
            Globals.ThisAddIn.mAddInBackupMeanModel = new cExcelModelClass(Globals.ThisAddIn.mAddInModel) ;
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
   
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupMeanModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
 
        }
       
        private void NoCondMeanAddButton_Click(object sender, EventArgs e)
        {
            NoCondMeanAddButton.Enabled = false;
            NoCondMeanRemoveButton.Enabled = true;
            for (int i = 1  ; i < Globals.ThisAddIn.gvMaxNCondMean ; i++)
            {
                Globals.ThisAddIn.mAddInModel.DeleteCondMean(i) ;
            }
            Globals.ThisAddIn.mAddInModel.mNCondMean = 0;
            Globals.ThisAddIn.mAddInModel.mCondMeanDone = true;
            UpdateControl();
        }

        private void NoCondMeanRemoveButton_Click(object sender, EventArgs e)
        {   NoCondMeanAddButton.Enabled = true;
            NoCondMeanRemoveButton.Enabled = false;
            Globals.ThisAddIn.mAddInModel.mNCondMean = 0;
            Globals.ThisAddIn.mAddInModel.mCondMeanDone = false;
            UpdateControl();
        }

        private void ConstAddButton_Click(object sender, EventArgs e)
        {
            ConstMeanForm myConstForm = new ConstMeanForm() { TopMost = true };
            AddOwnedForm(myConstForm);
            myConstForm.Show();
            Hide();
        }

        private void ConstRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eConst);
            UpdateControl();
        }

        private void ARAddButton_Click(object sender, EventArgs e)
        {
            ARForm myArForm = new ARForm() { TopMost = true };
            AddOwnedForm(myArForm);
            myArForm.Show();
            Hide();
        }

        private void ARRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eAr);
            UpdateControl();
        }

       
        private void MAAddButton_Click(object sender, EventArgs e)
        {
            MAForm myMaForm = new MAForm() { TopMost = true };
            AddOwnedForm(myMaForm);
            myMaForm.Show();
            Hide();
        }

        private void MARemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eMa);
            UpdateControl();
        }

        private void LinRegAddButton_Click(object sender, EventArgs e)
        {
            LinRegForm myLinRegForm = new LinRegForm() { TopMost = true };
            AddOwnedForm(myLinRegForm);
            myLinRegForm.Show();
            Hide();
        }

        private void LinRegRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eLinReg);
            UpdateControl();
        }

        private void VarInMeanAddButton_Click(object sender, EventArgs e)
        {
            VarInMeanForm myVarInMeanForm = new VarInMeanForm() { TopMost = true };
            AddOwnedForm(myVarInMeanForm);
            myVarInMeanForm.Show();
            Hide();
        }

        private void VarInMeanRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eVarInMean);
            UpdateControl();
        }

        private void StdevInMeanAddButton_Click(object sender, EventArgs e)
        {
            StdevInMeanForm myStdevInMeanForm = new StdevInMeanForm() { TopMost = true };
            AddOwnedForm(myStdevInMeanForm);
            myStdevInMeanForm.Show();
            Hide();
        }

        private void StdevInMeanRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eStdDevInMean);
            UpdateControl();
        }

        private void ArfimaAddButton_Click(object sender, EventArgs e)
        {
            ARFIMAForm myArfimaForm = new ARFIMAForm() { TopMost = true };
            AddOwnedForm(myArfimaForm);
            myArfimaForm.Show();
            Hide();

        }

        private void ArfimaRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondMean((int)eCondMeanEnumCli.eArfima);
            UpdateControl();
  
        }

 
        
 

    }
}
