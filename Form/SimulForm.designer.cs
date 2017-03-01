namespace RegArchExcel
{
    partial class SimulationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SampleSizeTextBox = new System.Windows.Forms.TextBox();
            this.RangeRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RangeRefEdit = new VS.NET_RefeditControl.refedit();
            this.WorksheetRadio = new System.Windows.Forms.RadioButton();
            this.WorkbookRadio = new System.Windows.Forms.RadioButton();
            this.AllInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(244, 318);
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
            this.CancelBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBouton.Location = new System.Drawing.Point(15, 318);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sample size:";
            // 
            // SampleSizeTextBox
            // 
            this.SampleSizeTextBox.Location = new System.Drawing.Point(134, 29);
            this.SampleSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SampleSizeTextBox.Name = "SampleSizeTextBox";
            this.SampleSizeTextBox.Size = new System.Drawing.Size(71, 27);
            this.SampleSizeTextBox.TabIndex = 2;
            this.SampleSizeTextBox.Text = "10000";
            this.SampleSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RangeRadio
            // 
            this.RangeRadio.AutoSize = true;
            this.RangeRadio.Location = new System.Drawing.Point(19, 131);
            this.RangeRadio.Name = "RangeRadio";
            this.RangeRadio.Size = new System.Drawing.Size(130, 24);
            this.RangeRadio.TabIndex = 3;
            this.RangeRadio.TabStop = true;
            this.RangeRadio.Text = "Select Range";
            this.RangeRadio.UseVisualStyleBackColor = true;
            this.RangeRadio.CheckedChanged += new System.EventHandler(this.RangeRadio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output options";
            // 
            // RangeRefEdit
            // 
            this.RangeRefEdit._CellsCount = 0;
            this.RangeRefEdit._Excel = null;
            this.RangeRefEdit.AllowCollapsedFormResize = false;
            this.RangeRefEdit.Location = new System.Drawing.Point(168, 131);
            this.RangeRefEdit.Name = "RangeRefEdit";
            this.RangeRefEdit.Size = new System.Drawing.Size(172, 22);
            this.RangeRefEdit.TabIndex = 4;
            this.RangeRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.RangeRefEdit_CellChanged);
            // 
            // WorksheetRadio
            // 
            this.WorksheetRadio.AutoSize = true;
            this.WorksheetRadio.Location = new System.Drawing.Point(19, 173);
            this.WorksheetRadio.Name = "WorksheetRadio";
            this.WorksheetRadio.Size = new System.Drawing.Size(148, 24);
            this.WorksheetRadio.TabIndex = 5;
            this.WorksheetRadio.TabStop = true;
            this.WorksheetRadio.Text = "New Worksheet";
            this.WorksheetRadio.UseVisualStyleBackColor = true;
            this.WorksheetRadio.CheckedChanged += new System.EventHandler(this.WorksheetRadio_CheckedChanged);
            // 
            // WorkbookRadio
            // 
            this.WorkbookRadio.AutoSize = true;
            this.WorkbookRadio.Location = new System.Drawing.Point(19, 213);
            this.WorkbookRadio.Name = "WorkbookRadio";
            this.WorkbookRadio.Size = new System.Drawing.Size(142, 24);
            this.WorkbookRadio.TabIndex = 6;
            this.WorkbookRadio.TabStop = true;
            this.WorkbookRadio.Text = "New Workbook";
            this.WorkbookRadio.UseVisualStyleBackColor = true;
            this.WorkbookRadio.CheckedChanged += new System.EventHandler(this.WorkbookRadio_CheckedChanged);
            // 
            // AllInfoCheckBox
            // 
            this.AllInfoCheckBox.AutoSize = true;
            this.AllInfoCheckBox.Location = new System.Drawing.Point(19, 268);
            this.AllInfoCheckBox.Name = "AllInfoCheckBox";
            this.AllInfoCheckBox.Size = new System.Drawing.Size(292, 24);
            this.AllInfoCheckBox.TabIndex = 7;
            this.AllInfoCheckBox.Text = "All informations output (5 columns)";
            this.AllInfoCheckBox.UseVisualStyleBackColor = true;
            this.AllInfoCheckBox.CheckedChanged += new System.EventHandler(this.AllInfoCheckBox_CheckedChanged);
            // 
            // SimulationForm
            // 
            this.AcceptButton = this.OKBouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(360, 369);
            this.Controls.Add(this.AllInfoCheckBox);
            this.Controls.Add(this.WorkbookRadio);
            this.Controls.Add(this.WorksheetRadio);
            this.Controls.Add(this.RangeRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RangeRadio);
            this.Controls.Add(this.SampleSizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimulationForm";
            this.Text = "Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SampleSizeTextBox;
//        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
//        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.RadioButton RangeRadio;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit RangeRefEdit;
        private System.Windows.Forms.RadioButton WorksheetRadio;
        private System.Windows.Forms.RadioButton WorkbookRadio;
        private System.Windows.Forms.CheckBox AllInfoCheckBox;
    }
}