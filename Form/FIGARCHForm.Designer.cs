namespace RegArchExcel
{
    partial class FIGARCHForm
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
            this.FracDRefEdit = new VS.NET_RefeditControl.refedit();
            this.label4 = new System.Windows.Forms.Label();
            this.GarchLagsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GarchRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.ArchRefEdit = new VS.NET_RefeditControl.refedit();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchLagsLabel = new System.Windows.Forms.Label();
            this.ArchLagLabel1 = new System.Windows.Forms.Label();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.OKBouton = new System.Windows.Forms.Button();
            this.ConstCellLabel = new System.Windows.Forms.Label();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.SuspendLayout();
            // 
            // FracDRefEdit
            // 
            this.FracDRefEdit._CellsCount = 0;
            this.FracDRefEdit._Excel = null;
            this.FracDRefEdit.AllowCollapsedFormResize = false;
            this.FracDRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FracDRefEdit.Location = new System.Drawing.Point(110, 146);
            this.FracDRefEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FracDRefEdit.Name = "FracDRefEdit";
            this.FracDRefEdit.Size = new System.Drawing.Size(129, 23);
            this.FracDRefEdit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fractal d Cell";
            // 
            // GarchLagsLabel
            // 
            this.GarchLagsLabel.AutoSize = true;
            this.GarchLagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarchLagsLabel.Location = new System.Drawing.Point(219, 19);
            this.GarchLagsLabel.Name = "GarchLagsLabel";
            this.GarchLagsLabel.Size = new System.Drawing.Size(16, 17);
            this.GarchLagsLabel.TabIndex = 33;
            this.GarchLagsLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "GARCH Lags:";
            // 
            // GarchRefEdit
            // 
            this.GarchRefEdit._CellsCount = 0;
            this.GarchRefEdit._Excel = null;
            this.GarchRefEdit.AllowCollapsedFormResize = false;
            this.GarchRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarchRefEdit.Location = new System.Drawing.Point(110, 114);
            this.GarchRefEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GarchRefEdit.Name = "GarchRefEdit";
            this.GarchRefEdit.Size = new System.Drawing.Size(129, 23);
            this.GarchRefEdit.TabIndex = 5;
            this.GarchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.GarchRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "GARCH Cells";
            // 
            // ArchRefEdit
            // 
            this.ArchRefEdit._CellsCount = 0;
            this.ArchRefEdit._Excel = null;
            this.ArchRefEdit.AllowCollapsedFormResize = false;
            this.ArchRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchRefEdit.Location = new System.Drawing.Point(110, 81);
            this.ArchRefEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArchRefEdit.Name = "ArchRefEdit";
            this.ArchRefEdit.Size = new System.Drawing.Size(129, 23);
            this.ArchRefEdit.TabIndex = 4;
            this.ArchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchRefEdit_CellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "ARCH Cells";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchLagsLabel.Location = new System.Drawing.Point(98, 19);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(16, 17);
            this.ArchLagsLabel.TabIndex = 29;
            this.ArchLagsLabel.Text = "0";
            // 
            // ArchLagLabel1
            // 
            this.ArchLagLabel1.AutoSize = true;
            this.ArchLagLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchLagLabel1.Location = new System.Drawing.Point(20, 19);
            this.ArchLagLabel1.Name = "ArchLagLabel1";
            this.ArchLagLabel1.Size = new System.Drawing.Size(85, 17);
            this.ArchLagLabel1.TabIndex = 28;
            this.ArchLagLabel1.Text = "ARCH Lags:";
            // 
            // CancelBouton
            // 
            this.CancelBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBouton.Location = new System.Drawing.Point(22, 184);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(70, 24);
            this.CancelBouton.TabIndex = 2;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // OKBouton
            // 
            this.OKBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBouton.Location = new System.Drawing.Point(168, 184);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(70, 24);
            this.OKBouton.TabIndex = 1;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // ConstCellLabel
            // 
            this.ConstCellLabel.AutoSize = true;
            this.ConstCellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstCellLabel.Location = new System.Drawing.Point(20, 49);
            this.ConstCellLabel.Name = "ConstCellLabel";
            this.ConstCellLabel.Size = new System.Drawing.Size(75, 17);
            this.ConstCellLabel.TabIndex = 35;
            this.ConstCellLabel.Text = "Const. Cell";
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._CellsCount = 0;
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstRefEdit.Location = new System.Drawing.Point(110, 49);
            this.ConstRefEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(129, 23);
            this.ConstRefEdit.TabIndex = 3;
            this.ConstRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ConstRefEdit_CellChanged);
            // 
            // FIGARCHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 231);
            this.Controls.Add(this.ConstRefEdit);
            this.Controls.Add(this.ConstCellLabel);
            this.Controls.Add(this.FracDRefEdit);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FIGARCHForm";
            this.Text = "FIGARCH(p, d, q) model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VS.NET_RefeditControl.refedit FracDRefEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GarchLagsLabel;
        private System.Windows.Forms.Label label3;
        private VS.NET_RefeditControl.refedit GarchRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit ArchRefEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArchLagsLabel;
        private System.Windows.Forms.Label ArchLagLabel1;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Label ConstCellLabel;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
    }
}