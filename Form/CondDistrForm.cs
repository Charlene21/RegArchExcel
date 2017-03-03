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
    public partial class CondDistrForm : Form
    {
        public CondDistrForm()
        {   InitializeComponent();
        }

        private void CondDistrForm_Activated(object sender, System.EventArgs e)
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
            if (Globals.ThisAddIn.mAddInModel.mCondDistr == null)
            {
                EnableDisableButton(ref NormAddButton, ref NormRemoveButton, false);
                EnableDisableButton(ref StudentAddButton, ref StudentRemoveButton, false);
                EnableDisableButton(ref GedAddButton, ref GedRemoveButton, false);
                EnableDisableButton(ref SkewTAddButton, ref SkewTRemoveButton, false);
            }
            else
            {
                EnableDisableButton(ref NormAddButton, ref NormRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType == (int)eDistrTypeEnumCli.eNormal));
                EnableDisableButton(ref StudentAddButton, ref StudentRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType == (int)eDistrTypeEnumCli.eStudent));
                EnableDisableButton(ref GedAddButton, ref GedRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType == (int)eDistrTypeEnumCli.eGed));
                EnableDisableButton(ref SkewTAddButton, ref SkewTRemoveButton, (Globals.ThisAddIn.mAddInModel.mCondDistr.mModelType == (int)eDistrTypeEnumCli.eSkewT));
            }
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.SetDescription();
            Globals.ThisAddIn.mAddInBackupDistrModel = new cExcelModelClass(Globals.ThisAddIn.mAddInModel) ;
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
   
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupDistrModel);
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
 
        }
       
        private void NormAddButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
        cExcelStockModel myDistr = new cExcelStockModel(0, (int)eDistrTypeEnumCli.eNormal);
            Globals.ThisAddIn.mAddInModel.AddCondDistr(myDistr);
            UpdateControl();
        }

        private void NormRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
            UpdateControl();
        }

        private void StudentAddButton_Click(object sender, EventArgs e)
        {
            StudentForm myStudentForm = new StudentForm() { TopMost = true };
            AddOwnedForm(myStudentForm);
            myStudentForm.Show();
            Hide();
        }

        private void StudentRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
            UpdateControl();
 
        }

        private void GedAddButton_Click(object sender, EventArgs e)
        {
            GedForm myGedForm = new GedForm() { TopMost = true };
            AddOwnedForm(myGedForm);
            myGedForm.Show();
            Hide();

        }

        private void GedRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
            UpdateControl();

        }

        private void CondDistrForm_Load(object sender, EventArgs e)
        {

        }

        private void SkewTRemoveButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.DeleteCondDistr();
            UpdateControl();
        }

        private void SkewTAddButton_Click(object sender, EventArgs e)
        {
            SkewTForm mySkewTForm = new SkewTForm() { TopMost = true };
            AddOwnedForm(mySkewTForm);
            mySkewTForm.Show();
            Hide();
        }


    }
}
