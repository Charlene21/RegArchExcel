namespace RegArchExcel
{
    partial class UGarchForm
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
            this.ArchRefEdit = new VS.NET_RefeditControl.refedit();
            this.GarchRefEdit = new VS.NET_RefeditControl.refedit();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.BetaRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKBouton = new System.Windows.Forms.Button();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.constBoolBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ArchLagsLabel = new System.Windows.Forms.Label();
            this.GarchLagsLabel = new System.Windows.Forms.Label();
            this.betaSizeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArchRefEdit
            // 
            this.ArchRefEdit._CellsCount = 0;
            this.ArchRefEdit._Excel = null;
            this.ArchRefEdit.AllowCollapsedFormResize = false;
            this.ArchRefEdit.Location = new System.Drawing.Point(115, 93);
            this.ArchRefEdit.Name = "ArchRefEdit";
            this.ArchRefEdit.Size = new System.Drawing.Size(172, 20);
            this.ArchRefEdit.TabIndex = 12;
            this.ArchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchRefEdit_CellChanged);
            // 
            // GarchRefEdit
            // 
            this.GarchRefEdit._CellsCount = 0;
            this.GarchRefEdit._Excel = null;
            this.GarchRefEdit.AllowCollapsedFormResize = false;
            this.GarchRefEdit.Location = new System.Drawing.Point(115, 128);
            this.GarchRefEdit.Name = "GarchRefEdit";
            this.GarchRefEdit.Size = new System.Drawing.Size(172, 20);
            this.GarchRefEdit.TabIndex = 13;
            this.GarchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.GarchRefEdit_CellChanged);
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._CellsCount = 0;
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Enabled = false;
            this.ConstRefEdit.Location = new System.Drawing.Point(115, 23);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(172, 20);
            this.ConstRefEdit.TabIndex = 15;
            this.ConstRefEdit.Tag = "";
            // 
            // BetaRefEdit
            // 
            this.BetaRefEdit._CellsCount = 0;
            this.BetaRefEdit._Excel = null;
            this.BetaRefEdit.AllowCollapsedFormResize = false;
            this.BetaRefEdit.Location = new System.Drawing.Point(115, 58);
            this.BetaRefEdit.Name = "BetaRefEdit";
            this.BetaRefEdit.Size = new System.Drawing.Size(172, 20);
            this.BetaRefEdit.TabIndex = 16;
            this.BetaRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.BetaRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Beta Cells";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ARCH Cells";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "GARCH Cells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Const. Cell";
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(297, 179);
            this.OKBouton.Margin = new System.Windows.Forms.Padding(4);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(94, 29);
            this.OKBouton.TabIndex = 22;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // CancelBouton
            // 
            this.CancelBouton.Location = new System.Drawing.Point(43, 179);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 23;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // constBoolBox
            // 
            this.constBoolBox.AutoSize = true;
            this.constBoolBox.Location = new System.Drawing.Point(17, 28);
            this.constBoolBox.Name = "constBoolBox";
            this.constBoolBox.Size = new System.Drawing.Size(15, 14);
            this.constBoolBox.TabIndex = 24;
            this.constBoolBox.UseVisualStyleBackColor = true;
            this.constBoolBox.CheckedChanged += new System.EventHandler(this.constBoolBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ARCH Lags:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "GARCH Lags:";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Location = new System.Drawing.Point(379, 98);
            this.ArchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(13, 13);
            this.ArchLagsLabel.TabIndex = 27;
            this.ArchLagsLabel.Text = "0";
            // 
            // GarchLagsLabel
            // 
            this.GarchLagsLabel.AutoSize = true;
            this.GarchLagsLabel.Location = new System.Drawing.Point(379, 132);
            this.GarchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GarchLagsLabel.Name = "GarchLagsLabel";
            this.GarchLagsLabel.Size = new System.Drawing.Size(13, 13);
            this.GarchLagsLabel.TabIndex = 28;
            this.GarchLagsLabel.Text = "0";
            // 
            // betaSizeLabel
            // 
            this.betaSizeLabel.AutoSize = true;
            this.betaSizeLabel.Location = new System.Drawing.Point(378, 65);
            this.betaSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betaSizeLabel.Name = "betaSizeLabel";
            this.betaSizeLabel.Size = new System.Drawing.Size(13, 13);
            this.betaSizeLabel.TabIndex = 30;
            this.betaSizeLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Beta size:";
            // 
            // UGarchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 225);
            this.Controls.Add(this.betaSizeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GarchLagsLabel);
            this.Controls.Add(this.ArchLagsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.constBoolBox);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BetaRefEdit);
            this.Controls.Add(this.ConstRefEdit);
            this.Controls.Add(this.GarchRefEdit);
            this.Controls.Add(this.ArchRefEdit);
            this.Name = "UGarchForm";
            this.Text = "UGarchForm";
            this.Load += new System.EventHandler(this.UGarchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VS.NET_RefeditControl.refedit ArchRefEdit;
        private VS.NET_RefeditControl.refedit GarchRefEdit;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
        private VS.NET_RefeditControl.refedit BetaRefEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.CheckBox constBoolBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ArchLagsLabel;
        private System.Windows.Forms.Label GarchLagsLabel;
        private System.Windows.Forms.Label betaSizeLabel;
        private System.Windows.Forms.Label label8;
    }
}