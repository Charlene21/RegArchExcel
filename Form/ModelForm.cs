using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegArchExcel
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
            CondDistrLabel.Text = Globals.ThisAddIn.mAddInModel.mCondDistrDescr;
            CondMeanLabel.Text  = Globals.ThisAddIn.mAddInModel.mCondMeanDescr;
            CondVarLabel.Text = Globals.ThisAddIn.mAddInModel.mCondVarDescr;
        }

        private void OKBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.SetDescription();
            Globals.ThisAddIn.mAddInBackupModel = new cExcelModelClass(Globals.ThisAddIn.mAddInModel);
            Close();
            Globals.ThisAddIn.mRuban.RefreshRegArchRibbon();
        }

        private void ModelForm_Activated(object sender, System.EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel.SetDescription();
            CondDistrLabel.Text = Globals.ThisAddIn.mAddInModel.mCondDistrDescr;
            CondMeanLabel.Text = Globals.ThisAddIn.mAddInModel.mCondMeanDescr;
            CondVarLabel.Text = Globals.ThisAddIn.mAddInModel.mCondVarDescr;
        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mAddInModel = new cExcelModelClass(Globals.ThisAddIn.mAddInBackupModel);
            Close();
        }
 
        private void CondMeanButton_Click(object sender, EventArgs e)
       {
            CondMeanForm myCondMeanForm = new CondMeanForm() { TopMost = true };
            AddOwnedForm(myCondMeanForm);
            myCondMeanForm.Show();
            Hide();
        }

        private void CondVarButton_Click(object sender, EventArgs e)
        {
            CondVarForm myCondVarForm = new CondVarForm() { TopMost = true };
            AddOwnedForm(myCondVarForm);
            myCondVarForm.Show();
            Hide();

        }

        private void CondDistrButton_Click(object sender, EventArgs e)
        {
            CondDistrForm myCondDistrForm = new CondDistrForm() { TopMost = true };
            AddOwnedForm(myCondDistrForm);
            myCondDistrForm.Show();
            Hide();

        }

        private void CondDistrLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
