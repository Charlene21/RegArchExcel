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
    public partial class AlgoResultForm : Form
    {
        public AlgoResultForm(bool theConvergence, int theNIter, double theLLH, double theCritValue, String theReason, double theTime)
        {
            InitializeComponent();
            if (theConvergence)
                this.ConvergenceLabel.Text ="True" ;
            else
                this.ConvergenceLabel.Text = "False";
            this.NIterLabel.Text = theNIter.ToString();
            this.LLHLabel.Text = theLLH.ToString();
            this.CritValueLabel.Text = theCritValue.ToString();
            this.TimeLabel.Text  = theTime.ToString();
            this.ReasonLabel.Text = theReason;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
