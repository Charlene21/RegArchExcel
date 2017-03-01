namespace RegArchExcel
{
    partial class TARCHForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKBouton = new System.Windows.Forms.Button();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.ArchLagLabel1 = new System.Windows.Forms.Label();
            this.ArchLagsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchPlusRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.ARCHMoinsRefEdit = new VS.NET_RefeditControl.refedit();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(226, 187);
            this.OKBouton.Margin = new System.Windows.Forms.Padding(4);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(94, 29);
            this.OKBouton.TabIndex = 0;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // CancelBouton
            // 
            this.CancelBouton.Location = new System.Drawing.Point(32, 187);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // ArchLagLabel1
            // 
            this.ArchLagLabel1.AutoSize = true;
            this.ArchLagLabel1.Location = new System.Drawing.Point(28, 26);
            this.ArchLagLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagLabel1.Name = "ArchLagLabel1";
            this.ArchLagLabel1.Size = new System.Drawing.Size(104, 20);
            this.ArchLagLabel1.TabIndex = 2;
            this.ArchLagLabel1.Text = "ARCH Lags:";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Location = new System.Drawing.Point(144, 26);
            this.ArchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.ArchLagsLabel.TabIndex = 3;
            this.ArchLagsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARCH+ Cells";
            // 
            // ArchPlusRefEdit
            // 
            this.ArchPlusRefEdit._Excel = null;
            this.ArchPlusRefEdit.AllowCollapsedFormResize = false;
            this.ArchPlusRefEdit.Location = new System.Drawing.Point(148, 100);
            this.ArchPlusRefEdit.Name = "ArchPlusRefEdit";
            this.ArchPlusRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ArchPlusRefEdit.TabIndex = 3;
            this.ArchPlusRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchPlusRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ARCH- Cells";
            // 
            // ARCHMoinsRefEdit
            // 
            this.ARCHMoinsRefEdit._Excel = null;
            this.ARCHMoinsRefEdit.AllowCollapsedFormResize = false;
            this.ARCHMoinsRefEdit.Location = new System.Drawing.Point(148, 136);
            this.ARCHMoinsRefEdit.Name = "ARCHMoinsRefEdit";
            this.ARCHMoinsRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ARCHMoinsRefEdit.TabIndex = 4;
            this.ARCHMoinsRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ARCHMoinsRefEdit_CellChanged);
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Location = new System.Drawing.Point(148, 62);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ConstRefEdit.TabIndex = 2;
            this.ConstRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ConstRefEdit_CellChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Const. Cell";
            // 
            // TARCHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 245);
            this.Controls.Add(this.ConstRefEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ARCHMoinsRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArchPlusRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArchLagsLabel);
            this.Controls.Add(this.ArchLagLabel1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TARCHForm";
            this.Text = "TARCH(p) Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label ArchLagLabel1;
        private System.Windows.Forms.Label ArchLagsLabel;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit ArchPlusRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit ARCHMoinsRefEdit;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
        private System.Windows.Forms.Label label3;
    }
}