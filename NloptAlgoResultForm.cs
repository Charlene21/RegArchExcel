using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegArchExcel
{
    public partial class NloptAlgoResultForm : Form
    {
        public NloptAlgoResultForm(bool theConvergence, double theLLH, String theReason, double theTime)
        {
            InitializeComponent();
            if (theConvergence)
                this.ConvergenceLabel.Text = "True";
            else
                this.ConvergenceLabel.Text = "False";
            this.LLHLabel.Text = theLLH.ToString();
            this.TimeLabel.Text = theTime.ToString();
            this.ReasonLabel.Text = theReason;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
