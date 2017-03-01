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
    public partial class Alerte2Form : Form
    {
        public Alerte2Form()
        {
            InitializeComponent();
            Globals.ThisAddIn.mContinueSaveBool = false;
        }

        private void ContinueBouton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.mContinueSaveBool = true;
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();

        }

        private void CancelBouton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.Activate();
            Owner.RemoveOwnedForm(this);
            Close();
        }
    }
}
