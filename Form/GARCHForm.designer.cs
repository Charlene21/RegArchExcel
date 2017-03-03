namespace RegArchExcel
{
    partial class GARCHForm
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
            this.ArchRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.GarchRefEdit = new VS.NET_RefeditControl.refedit();
            this.label3 = new System.Windows.Forms.Label();
            this.GarchLagsLabel = new System.Windows.Forms.Label();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(226, 191);
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
            this.CancelBouton.Location = new System.Drawing.Point(32, 191);
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
            this.ArchLagLabel1.Size = new System.Drawing.Size(85, 17);
            this.ArchLagLabel1.TabIndex = 2;
            this.ArchLagLabel1.Text = "ARCH Lags:";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Location = new System.Drawing.Point(144, 26);
            this.ArchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(16, 17);
            this.ArchLagsLabel.TabIndex = 3;
            this.ArchLagsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARCH Cells";
            // 
            // ArchRefEdit
            // 
            this.ArchRefEdit._CellsCount = 0;
            this.ArchRefEdit._Excel = null;
            this.ArchRefEdit.AllowCollapsedFormResize = false;
            this.ArchRefEdit.Location = new System.Drawing.Point(148, 104);
            this.ArchRefEdit.Name = "ArchRefEdit";
            this.ArchRefEdit.Size = new System.Drawing.Size(172, 20);
            this.ArchRefEdit.TabIndex = 3;
            this.ArchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "GARCH Cells";
            // 
            // GarchRefEdit
            // 
            this.GarchRefEdit._CellsCount = 0;
            this.GarchRefEdit._Excel = null;
            this.GarchRefEdit.AllowCollapsedFormResize = false;
            this.GarchRefEdit.Location = new System.Drawing.Point(148, 140);
            this.GarchRefEdit.Name = "GarchRefEdit";
            this.GarchRefEdit.Size = new System.Drawing.Size(172, 20);
            this.GarchRefEdit.TabIndex = 4;
            this.GarchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.GarchRefEdit_CellChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "GARCH Lags:";
            // 
            // GarchLagsLabel
            // 
            this.GarchLagsLabel.AutoSize = true;
            this.GarchLagsLabel.Location = new System.Drawing.Point(295, 26);
            this.GarchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GarchLagsLabel.Name = "GarchLagsLabel";
            this.GarchLagsLabel.Size = new System.Drawing.Size(16, 17);
            this.GarchLagsLabel.TabIndex = 9;
            this.GarchLagsLabel.Text = "0";
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._CellsCount = 0;
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Location = new System.Drawing.Point(148, 68);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(172, 20);
            this.ConstRefEdit.TabIndex = 2;
            this.ConstRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ConstRefEdit_CellChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Const. Cell";
            // 
            // GARCHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.ConstRefEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GarchLagsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GarchRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArchRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArchLagsLabel);
            this.Controls.Add(this.ArchLagLabel1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GARCHForm";
            this.Text = "GARCH(p, q) Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label ArchLagLabel1;
        private System.Windows.Forms.Label ArchLagsLabel;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit ArchRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit GarchRefEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GarchLagsLabel;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
        private System.Windows.Forms.Label label4;
    }
}