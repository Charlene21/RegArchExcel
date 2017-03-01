using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace RegArchExcel
{
    public partial class RibbonRegArch
    {
        private void SetBouton_Click(object sender, RibbonControlEventArgs e)
        {
            ModelForm myModel = new ModelForm() { TopMost = true };
            myModel.Show();

        }

        private void LoadBouton_Click(object sender, RibbonControlEventArgs e)
        {
            LoadModelForm myLoadForm = new LoadModelForm() { TopMost = true };
            myLoadForm.Show();

        }

        private void SaveBouton_Click(object sender, RibbonControlEventArgs e)
        {
            SaveModelForm mySaveForm = new SaveModelForm() { TopMost = true };
            mySaveForm.Show();

        }

        private void SimulationBouton_Click(object sender, RibbonControlEventArgs e)
        {
            SimulationForm mySimulation = new SimulationForm() { TopMost = true };
            mySimulation.Show();
        }

        private void EstimationBouton_Click(object sender, RibbonControlEventArgs e)
        {
            EstimationForm myEstimation = new EstimationForm() { TopMost = true };
            myEstimation.Show();
        }
    }
}