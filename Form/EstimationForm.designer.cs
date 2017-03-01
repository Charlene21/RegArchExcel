namespace RegArchExcel
{
    partial class EstimationForm
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
//            Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
//            Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
//            Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
            this.OKBouton = new System.Windows.Forms.Button();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SampleSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
//            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.AlgoBouton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputBouton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LinRegMatrixRefEdit = new VS.NET_RefeditControl.refedit();
            this.ObsRefEdit = new VS.NET_RefeditControl.refedit();
            this.DefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentRadioBouton = new System.Windows.Forms.RadioButton();
//            lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
//            lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
//            lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
 /*
            lineShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            lineShape1.BorderWidth = 10;
            lineShape1.Name = "lineShape1";
            lineShape1.SelectionColor = System.Drawing.Color.Transparent;
            lineShape1.X1 = 1;
            lineShape1.X2 = 446;
            lineShape1.Y1 = 240;
            lineShape1.Y2 = 240;
            // 
            // lineShape2
            // 
            lineShape2.BorderColor = System.Drawing.Color.WhiteSmoke;
            lineShape2.BorderWidth = 10;
            lineShape2.Name = "lineShape2";
            lineShape2.SelectionColor = System.Drawing.Color.Transparent;
            lineShape2.X1 = 0;
            lineShape2.X2 = 444;
            lineShape2.Y1 = 141;
            lineShape2.Y2 = 140;
            // 
            // lineShape3
            // 
            lineShape3.BorderColor = System.Drawing.Color.WhiteSmoke;
            lineShape3.BorderWidth = 10;
            lineShape3.Name = "lineShape3";
            lineShape3.SelectionColor = System.Drawing.Color.Transparent;
            lineShape3.X1 = -2;
            lineShape3.X2 = 446;
            lineShape3.Y1 = 304;
            lineShape3.Y2 = 303;
*/
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(342, 327);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(87, 34);
            this.OKBouton.TabIndex = 0;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // CancelBouton
            // 
            this.CancelBouton.Location = new System.Drawing.Point(25, 327);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(87, 34);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sample size:";
            // 
            // SampleSizeLabel
            // 
            this.SampleSizeLabel.AutoSize = true;
            this.SampleSizeLabel.Location = new System.Drawing.Point(138, 25);
            this.SampleSizeLabel.Name = "SampleSizeLabel";
            this.SampleSizeLabel.Size = new System.Drawing.Size(45, 20);
            this.SampleSizeLabel.TabIndex = 4;
            this.SampleSizeLabel.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observations Cells (Y(t)): ";
 /*
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            lineShape3,
            lineShape2,
            lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(450, 380);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
 */
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Algorithm preferences:";
            // 
            // AlgoBouton
            // 
            this.AlgoBouton.Location = new System.Drawing.Point(209, 158);
            this.AlgoBouton.Name = "AlgoBouton";
            this.AlgoBouton.Size = new System.Drawing.Size(75, 31);
            this.AlgoBouton.TabIndex = 4;
            this.AlgoBouton.Text = "Change";
            this.AlgoBouton.UseVisualStyleBackColor = true;
            this.AlgoBouton.Click += new System.EventHandler(this.AlgoBouton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output options:";
            // 
            // OutputBouton
            // 
            this.OutputBouton.Location = new System.Drawing.Point(150, 255);
            this.OutputBouton.Name = "OutputBouton";
            this.OutputBouton.Size = new System.Drawing.Size(75, 31);
            this.OutputBouton.TabIndex = 6;
            this.OutputBouton.Text = "Change";
            this.OutputBouton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Regressor Matrix Cells (X(t)): ";
            // 
            // LinRegMatrixRefEdit
            // 
            this.LinRegMatrixRefEdit._CellsCount = 0;
            this.LinRegMatrixRefEdit._Excel = null;
            this.LinRegMatrixRefEdit.AllowCollapsedFormResize = false;
            this.LinRegMatrixRefEdit.Enabled = false;
            this.LinRegMatrixRefEdit.Location = new System.Drawing.Point(257, 98);
            this.LinRegMatrixRefEdit.Name = "LinRegMatrixRefEdit";
            this.LinRegMatrixRefEdit.Size = new System.Drawing.Size(172, 22);
            this.LinRegMatrixRefEdit.TabIndex = 3;
            this.LinRegMatrixRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.LinRegMatrixRefEdit_CellChanged);
            // 
            // ObsRefEdit
            // 
            this.ObsRefEdit._CellsCount = 0;
            this.ObsRefEdit._Excel = null;
            this.ObsRefEdit.AllowCollapsedFormResize = false;
            this.ObsRefEdit.Location = new System.Drawing.Point(257, 55);
            this.ObsRefEdit.Name = "ObsRefEdit";
            this.ObsRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ObsRefEdit.TabIndex = 2;
            this.ObsRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ObsRefEdit_CellChanged);
            // 
            // DefaultRadioButton
            // 
            this.DefaultRadioButton.AutoSize = true;
            this.DefaultRadioButton.Checked = true;
            this.DefaultRadioButton.Location = new System.Drawing.Point(24, 202);
            this.DefaultRadioButton.Name = "DefaultRadioButton";
            this.DefaultRadioButton.Size = new System.Drawing.Size(154, 24);
            this.DefaultRadioButton.TabIndex = 5;
            this.DefaultRadioButton.TabStop = true;
            this.DefaultRadioButton.Text = "Default Init Point";
            this.DefaultRadioButton.UseVisualStyleBackColor = true;
            this.DefaultRadioButton.CheckedChanged += new System.EventHandler(this.DefaultRadioButton_CheckedChanged);
            // 
            // CurrentRadioBouton
            // 
            this.CurrentRadioBouton.AutoSize = true;
            this.CurrentRadioBouton.Location = new System.Drawing.Point(209, 202);
            this.CurrentRadioBouton.Name = "CurrentRadioBouton";
            this.CurrentRadioBouton.Size = new System.Drawing.Size(142, 24);
            this.CurrentRadioBouton.TabIndex = 6;
            this.CurrentRadioBouton.Text = "Current Values";
            this.CurrentRadioBouton.UseVisualStyleBackColor = true;
            this.CurrentRadioBouton.CheckedChanged += new System.EventHandler(this.CurrentRadioBouton_CheckedChanged);
            // 
            // EstimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.CurrentRadioBouton);
            this.Controls.Add(this.DefaultRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LinRegMatrixRefEdit);
            this.Controls.Add(this.OutputBouton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlgoBouton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SampleSizeLabel);
            this.Controls.Add(this.ObsRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
 //           this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EstimationForm";
            this.Text = "Estimation";
            this.Load += new System.EventHandler(this.EstimationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit ObsRefEdit;
        private System.Windows.Forms.Label SampleSizeLabel;
        private System.Windows.Forms.Label label2;
 //       private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AlgoBouton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OutputBouton;
        private System.Windows.Forms.Label label5;
        private VS.NET_RefeditControl.refedit LinRegMatrixRefEdit;
        private System.Windows.Forms.RadioButton DefaultRadioButton;
        private System.Windows.Forms.RadioButton CurrentRadioBouton;
    }
}