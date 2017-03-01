namespace RegArchExcel
{
    partial class RibbonRegArch : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonRegArch()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = this.Factory.CreateRibbonTab();
            this.RegArchGroup = this.Factory.CreateRibbonGroup();
            this.modelMenu = this.Factory.CreateRibbonMenu();
            this.SetBouton = this.Factory.CreateRibbonButton();
            this.LoadBouton = this.Factory.CreateRibbonButton();
            this.SaveBouton = this.Factory.CreateRibbonButton();
            this.SimulationBouton = this.Factory.CreateRibbonButton();
            this.EstimationBouton = this.Factory.CreateRibbonButton();
            this.Tab.SuspendLayout();
            this.RegArchGroup.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Tab.ControlId.OfficeId = "TabFormulas";
            this.Tab.Groups.Add(this.RegArchGroup);
            this.Tab.Label = "TabFormulas";
            this.Tab.Name = "Tab";
            // 
            // RegArchGroup
            // 
            this.RegArchGroup.Items.Add(this.modelMenu);
            this.RegArchGroup.Items.Add(this.SimulationBouton);
            this.RegArchGroup.Items.Add(this.EstimationBouton);
            this.RegArchGroup.Label = "RegArch";
            this.RegArchGroup.Name = "RegArchGroup";
            // 
            // modelMenu
            // 
            this.modelMenu.Items.Add(this.SetBouton);
            this.modelMenu.Items.Add(this.LoadBouton);
            this.modelMenu.Items.Add(this.SaveBouton);
            this.modelMenu.Label = "Model";
            this.modelMenu.Name = "modelMenu";
            // 
            // SetBouton
            // 
            this.SetBouton.Label = "Set";
            this.SetBouton.Name = "SetBouton";
            this.SetBouton.ShowImage = true;
            this.SetBouton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetBouton_Click);
            // 
            // LoadBouton
            // 
            this.LoadBouton.Label = "Load ...";
            this.LoadBouton.Name = "LoadBouton";
            this.LoadBouton.ShowImage = true;
            this.LoadBouton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LoadBouton_Click);
            // 
            // SaveBouton
            // 
            this.SaveBouton.Enabled = false;
            this.SaveBouton.Label = "Save ...";
            this.SaveBouton.Name = "SaveBouton";
            this.SaveBouton.ShowImage = true;
            this.SaveBouton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SaveBouton_Click);
            // 
            // SimulationBouton
            // 
            this.SimulationBouton.Enabled = false;
            this.SimulationBouton.Label = "Simulation";
            this.SimulationBouton.Name = "SimulationBouton";
            this.SimulationBouton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SimulationBouton_Click);
            // 
            // EstimationBouton
            // 
            this.EstimationBouton.Enabled = false;
            this.EstimationBouton.Label = "Estimation";
            this.EstimationBouton.Name = "EstimationBouton";
            this.EstimationBouton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EstimationBouton_Click);
            // 
            // RibbonRegArch
            // 
            this.Name = "RibbonRegArch";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Tab);
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            this.RegArchGroup.ResumeLayout(false);
            this.RegArchGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RegArchGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu modelMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetBouton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LoadBouton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EstimationBouton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SaveBouton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SimulationBouton;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonRegArch RegArchExcel
        {
            get { return this.GetRibbon<RibbonRegArch>(); }
        }
    }
}
