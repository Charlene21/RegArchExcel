namespace RegArchExcel
{
    partial class EGARCHForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.TetaRefEdit = new VS.NET_RefeditControl.refedit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GammaRefEdit = new VS.NET_RefeditControl.refedit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(367, 324);
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
            this.CancelBouton.Location = new System.Drawing.Point(32, 324);
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
            this.ArchLagLabel1.Location = new System.Drawing.Point(28, 76);
            this.ArchLagLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagLabel1.Name = "ArchLagLabel1";
            this.ArchLagLabel1.Size = new System.Drawing.Size(104, 20);
            this.ArchLagLabel1.TabIndex = 2;
            this.ArchLagLabel1.Text = "ARCH Lags:";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Location = new System.Drawing.Point(144, 76);
            this.ArchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.ArchLagsLabel.TabIndex = 3;
            this.ArchLagsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARCH Cells";
            // 
            // ArchRefEdit
            // 
            this.ArchRefEdit._CellsCount = 0;
            this.ArchRefEdit._Excel = null;
            this.ArchRefEdit.AllowCollapsedFormResize = false;
            this.ArchRefEdit.Location = new System.Drawing.Point(145, 156);
            this.ArchRefEdit.Name = "ArchRefEdit";
            this.ArchRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ArchRefEdit.TabIndex = 5;
            this.ArchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "GARCH Cells";
            // 
            // GarchRefEdit
            // 
            this.GarchRefEdit._CellsCount = 0;
            this.GarchRefEdit._Excel = null;
            this.GarchRefEdit.AllowCollapsedFormResize = false;
            this.GarchRefEdit.Location = new System.Drawing.Point(148, 196);
            this.GarchRefEdit.Name = "GarchRefEdit";
            this.GarchRefEdit.Size = new System.Drawing.Size(172, 22);
            this.GarchRefEdit.TabIndex = 7;
            this.GarchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.GarchRefEdit_CellChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "GARCH Lags:";
            // 
            // GarchLagsLabel
            // 
            this.GarchLagsLabel.AutoSize = true;
            this.GarchLagsLabel.Location = new System.Drawing.Point(295, 76);
            this.GarchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GarchLagsLabel.Name = "GarchLagsLabel";
            this.GarchLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.GarchLagsLabel.TabIndex = 9;
            this.GarchLagsLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Constant Cell";
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._CellsCount = 0;
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Location = new System.Drawing.Point(145, 116);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ConstRefEdit.TabIndex = 11;
            this.ConstRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ConstRefEdit_CellChanged);
            // 
            // TetaRefEdit
            // 
            this.TetaRefEdit._CellsCount = 0;
            this.TetaRefEdit._Excel = null;
            this.TetaRefEdit.AllowCollapsedFormResize = false;
            this.TetaRefEdit.Location = new System.Drawing.Point(148, 236);
            this.TetaRefEdit.Name = "TetaRefEdit";
            this.TetaRefEdit.Size = new System.Drawing.Size(172, 22);
            this.TetaRefEdit.TabIndex = 13;
            this.TetaRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.TetaRefEdit_CellChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Theta Cell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gamma Cell";
            // 
            // GammaRefEdit
            // 
            this.GammaRefEdit._CellsCount = 0;
            this.GammaRefEdit._Excel = null;
            this.GammaRefEdit.AllowCollapsedFormResize = false;
            this.GammaRefEdit.Location = new System.Drawing.Point(148, 276);
            this.GammaRefEdit.Name = "GammaRefEdit";
            this.GammaRefEdit.Size = new System.Drawing.Size(172, 22);
            this.GammaRefEdit.TabIndex = 15;
            this.GammaRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.GammaRefEdit_CellChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegArchExcel.Properties.Resources.Egarch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // EGARCHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GammaRefEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TetaRefEdit);
            this.Controls.Add(this.label5);
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
            this.Name = "EGARCHForm";
            this.Text = "EGARCH(p, q) Model";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
        private VS.NET_RefeditControl.refedit TetaRefEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private VS.NET_RefeditControl.refedit GammaRefEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}