namespace RegArchExcel
{
    partial class SaveModelForm
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
            this.ModeleRefEdit = new VS.NET_RefeditControl.refedit();
            this.NRowsLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.LeftUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModeleRefEdit
            // 
            this.ModeleRefEdit._CellsCount = 0;
            this.ModeleRefEdit._Excel = null;
            this.ModeleRefEdit.AllowCollapsedFormResize = false;
            this.ModeleRefEdit.Location = new System.Drawing.Point(138, 67);
            this.ModeleRefEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ModeleRefEdit.Name = "ModeleRefEdit";
            this.ModeleRefEdit.Size = new System.Drawing.Size(237, 22);
            this.ModeleRefEdit.TabIndex = 2;
            this.ModeleRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ModeleRefEdit_CellChanged);
            // 
            // NRowsLabel
            // 
            this.NRowsLabel.AutoSize = true;
            this.NRowsLabel.Location = new System.Drawing.Point(22, 28);
            this.NRowsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NRowsLabel.Name = "NRowsLabel";
            this.NRowsLabel.Size = new System.Drawing.Size(343, 20);
            this.NRowsLabel.TabIndex = 3;
            this.NRowsLabel.Text = "Current model needs 10 rows and 6 columns";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(312, 112);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBouton
            // 
            this.CancelBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBouton.Location = new System.Drawing.Point(26, 112);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // LeftUpLabel
            // 
            this.LeftUpLabel.AutoSize = true;
            this.LeftUpLabel.Location = new System.Drawing.Point(22, 67);
            this.LeftUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftUpLabel.Name = "LeftUpLabel";
            this.LeftUpLabel.Size = new System.Drawing.Size(109, 20);
            this.LeftUpLabel.TabIndex = 4;
            this.LeftUpLabel.Text = "Select Cells: ";
            // 
            // SaveModelForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(429, 160);
            this.ControlBox = false;
            this.Controls.Add(this.LeftUpLabel);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NRowsLabel);
            this.Controls.Add(this.ModeleRefEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaveModelForm";
            this.Text = "Save Model";
            this.Load += new System.EventHandler(this.SaveModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VS.NET_RefeditControl.refedit ModeleRefEdit;
        private System.Windows.Forms.Label NRowsLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label LeftUpLabel;
    }
}