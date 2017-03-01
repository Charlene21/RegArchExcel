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
    public partial class CondVarForm : Form
    {
        public CondVarForm()
        {   InitializeComponent();
        }

        private void CondVarForm_Activated(object sender, System.EventArgs e)
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
            if (Globals.ThisAddIn.mAddInModel.mCondVar == null)
            {   EnableDisableButton(ref ConstAddButton, ref ConstRemoveButton, false);
                EnableDisableButton(ref ArchAddButton, ref ArchRemoveButton, false);
                EnableDisableButton(ref GarchAddButton, ref GarchRemoveButton, false);
                EnableDisableButton(ref TarchAddButton, ref TarchRemoveButton, false);
                EnableDisableButton(ref EgarchAddButton, ref EgarchRemoveButton, false);
                EnableDisableButton(ref AparchAddButton, ref AparchRemoveButton, false);
            }
            else
            {
                EnableDisableButton(ref ConstAddButton, ref ConstRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eCste));
                EnableDisableButton(ref ArchAddButton, ref ArchRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eArch));
                EnableDisableButton(ref GarchAddButton, ref GarchRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eGarch));
                EnableDisableButton(ref TarchAddButton, ref TarchRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eTarch));
                EnableDisableButton(ref EgarchAddButton, ref EgarchRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eEgarch));
                EnableDisableButton(ref AparchAddButton, ref AparchRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondVar.mModelType == (int)eCondVarEnumCli.eAparch));
            }
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.SetDescription();
            Globals.ThisAddIn.mAddInBackupVarModel = new cExcelModelClass(Globals.ThisAddIn.mAddInModel) ;
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupVarModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }
       
        private void CondVarForm_Load(object sender, EventArgs e)
        {

        }

        private void ConstAddButton_Click(object sender, EventArgs e)
        {
            ConstVarForm myConstForm = new ConstVarForm() { TopMost = true };
            AddOwnedForm(myConstForm);
            myConstForm.Show();
            Hide();
        }

        private void ConstRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void ArchAddButton_Click(object sender, EventArgs e)
        {
            ARCHForm myArchForm = new ARCHForm() { TopMost = true };
            AddOwnedForm(myArchForm);
            myArchForm.Show();
            Hide();
        }

        private void ArchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void GarchAddButton_Click(object sender, EventArgs e)
        {
            GARCHForm myGarchForm = new GARCHForm() { TopMost = true };
            AddOwnedForm(myGarchForm);
            myGarchForm.Show();
            Hide();
        }

        private void GarchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void TarchAddButton_Click(object sender, EventArgs e)
        {
            TARCHForm myTarchForm = new TARCHForm() { TopMost = true };
            AddOwnedForm(myTarchForm);
            myTarchForm.Show();
            Hide();
        }

        private void TarchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void EgarchAddButton_Click(object sender, EventArgs e)
        {
            EGARCHForm myEgarchForm = new EGARCHForm() { TopMost = true };
            AddOwnedForm(myEgarchForm);
            myEgarchForm.Show();
            Hide();
        }

        private void EgarchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void AparchAddButton_Click(object sender, EventArgs e)
        {
            APARCHForm myAparchForm = new APARCHForm() { TopMost = true };
            AddOwnedForm(myAparchForm);
            myAparchForm.Show();
            Hide();
        }

        private void AparchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();
        }

        private void FigarchAddButton_Click(object sender, EventArgs e)
        {
            FIGARCHForm myFigarchForm = new FIGARCHForm() { TopMost = true };
            AddOwnedForm(myFigarchForm);
            myFigarchForm.Show();
            Hide();

        }

        private void FigarchRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondVar();
            UpdateControl();

        }

    
  
    }
}
