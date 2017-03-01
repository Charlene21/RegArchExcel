namespace RegArchExcel
{
    partial class LoadModelForm
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
            this.OKBoutton = new System.Windows.Forms.Button();
            this.CancelBoutton = new System.Windows.Forms.Button();
            this.CellsLabel = new System.Windows.Forms.Label();
            this.ModeleRefEdit = new VS.NET_RefeditControl.refedit();
            this.SuspendLayout();
            // 
            // OKBoutton
            // 
            this.OKBoutton.Location = new System.Drawing.Point(305, 95);
            this.OKBoutton.Name = "OKBoutton";
            this.OKBoutton.Size = new System.Drawing.Size(95, 32);
            this.OKBoutton.TabIndex = 0;
            this.OKBoutton.Text = "OK";
            this.OKBoutton.UseVisualStyleBackColor = true;
            this.OKBoutton.Click += new System.EventHandler(this.OKBoutton_Click);
            // 
            // CancelBoutton
            // 
            this.CancelBoutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBoutton.Location = new System.Drawing.Point(34, 95);
            this.CancelBoutton.Name = "CancelBoutton";
            this.CancelBoutton.Size = new System.Drawing.Size(95, 32);
            this.CancelBoutton.TabIndex = 1;
            this.CancelBoutton.Text = "Cancel";
            this.CancelBoutton.UseVisualStyleBackColor = true;
            this.CancelBoutton.Click += new System.EventHandler(this.CancelBoutton_Click);
            // 
            // CellsLabel
            // 
            this.CellsLabel.AutoSize = true;
            this.CellsLabel.Location = new System.Drawing.Point(30, 40);
            this.CellsLabel.Name = "CellsLabel";
            this.CellsLabel.Size = new System.Drawing.Size(106, 20);
            this.CellsLabel.TabIndex = 2;
            this.CellsLabel.Text = "Select cells: ";
            // 
            // ModeleRefEdit
            // 
            this.ModeleRefEdit._CellsCount = 0;
            this.ModeleRefEdit._Excel = null;
            this.ModeleRefEdit.AllowCollapsedFormResize = false;
            this.ModeleRefEdit.Location = new System.Drawing.Point(131, 40);
            this.ModeleRefEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ModeleRefEdit.Name = "ModeleRefEdit";
            this.ModeleRefEdit.Size = new System.Drawing.Size(269, 27);
            this.ModeleRefEdit.TabIndex = 3;
            // 
            // LoadModelForm
            // 
            this.AcceptButton = this.OKBoutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBoutton;
            this.ClientSize = new System.Drawing.Size(436, 144);
            this.Controls.Add(this.ModeleRefEdit);
            this.Controls.Add(this.CellsLabel);
            this.Controls.Add(this.CancelBoutton);
            this.Controls.Add(this.OKBoutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoadModelForm";
            this.Text = "Load Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBoutton;
        private System.Windows.Forms.Button CancelBoutton;
        private System.Windows.Forms.Label CellsLabel;
        private VS.NET_RefeditControl.refedit ModeleRefEdit;
    }
}