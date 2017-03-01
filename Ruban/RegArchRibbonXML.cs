using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;

// TODO:  suivez ces étapes pour activer l'élément (XML) Ruban :

// 1 : Copiez le bloc de code suivant dans la classe ThisAddin, ThisWorkbook ou ThisDocument.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new RegArchRibbonXML();
//  }

// 2. Créez des méthodes de rappel dans la région "Rappels du ruban" de cette classe pour gérer les actions des utilisateurs,
//    comme les clics sur un bouton. Remarque : si vous avez exporté ce ruban à partir du Concepteur de ruban,
//    vous devrez déplacer votre code des gestionnaires d'événements vers les méthodes de rappel et modifiez le code pour qu'il fonctionne avec
//    le modèle de programmation d'extensibilité du ruban (RibbonX).

// 3. Assignez les attributs aux balises de contrôle dans le fichier XML du ruban pour identifier les méthodes de rappel appropriées dans votre code.  

// Pour plus d'informations, consultez la documentation XML du ruban dans l'aide de Visual Studio Tools pour Office.


namespace RegArchExcel
{
    [ComVisible(true)]
    public class RegArchRibbonXML : Office.IRibbonExtensibility
    {
        public Office.IRibbonUI mvRegArchRibbon;

        public RegArchRibbonXML()
        {
        }

        public void RefreshRegArchRibbon()
        {
            mvRegArchRibbon.Invalidate();
        }

        #region Membres IRibbonExtensibility

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("RegArchExcel.Ruban.RegArchRibbonXML.xml");
        }

        #endregion

        #region Rappels du ruban
        //Créez des méthodes de rappel ici. Pour plus d'informations sur l'ajout de méthodes de rappel, consultez http://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.mvRegArchRibbon = ribbonUI;
        }

        public void setBoutonClick(Office.IRibbonControl control)
        {
            ModelForm myModel = new ModelForm() { TopMost = true };
            myModel.Show();

        }

        public void loadBoutonClick(Office.IRibbonControl control)
        {
            LoadModelForm myLoadForm = new LoadModelForm() { TopMost = true };
            myLoadForm.Show();

        }

        public void saveBoutonClick(Office.IRibbonControl control)
        {
            SaveModelForm mySaveForm = new SaveModelForm() { TopMost = true };
            mySaveForm.Show();

        }

        public void simulationBoutonClick(Office.IRibbonControl control)
        {
            SimulationForm mySimulation = new SimulationForm() { TopMost = true };
            mySimulation.Show();
        }

        public void estimateBoutonClick(Office.IRibbonControl control)
        {
            EstimationForm myEstimation = new EstimationForm() { TopMost = true };
            myEstimation.Show();
        }

        public bool enableDisableButton(Office.IRibbonControl theControl)
        {
            return Globals.ThisAddIn.mAddInModel.mCondDistrDone & Globals.ThisAddIn.mAddInModel.mCondMeanDone & Globals.ThisAddIn.mAddInModel.mCondVarDone;
            
        }

        #endregion

        #region Programmes d'assistance

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
