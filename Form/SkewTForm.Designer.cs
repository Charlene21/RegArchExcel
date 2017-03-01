namespace RegArchExcel
{
    partial class SkewTForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.StdevInMeanRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.refedit1 = new VS.NET_RefeditControl.refedit();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.OKBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DoF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StdevInMeanRefEdit
            // 
            this.StdevInMeanRefEdit._CellsCount = 0;
            this.StdevInMeanRefEdit._Excel = null;
            this.StdevInMeanRefEdit.AllowCollapsedFormResize = false;
            this.StdevInMeanRefEdit.Location = new System.Drawing.Point(135, 29);
            this.StdevInMeanRefEdit.Name = "StdevInMeanRefEdit";
            this.StdevInMeanRefEdit.Size = new System.Drawing.Size(172, 20);
            this.StdevInMeanRefEdit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gamma";
            // 
            // refedit1
            // 
            this.refedit1._CellsCount = 0;
            this.refedit1._Excel = null;
            this.refedit1.AllowCollapsedFormResize = false;
            this.refedit1.Location = new System.Drawing.Point(135, 77);
            this.refedit1.Name = "refedit1";
            this.refedit1.Size = new System.Drawing.Size(172, 20);
            this.refedit1.TabIndex = 6;
            // 
            // CancelBouton
            // 
            this.CancelBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBouton.Location = new System.Drawing.Point(15, 147);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(81, 28);
            this.CancelBouton.TabIndex = 7;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(196, 147);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(81, 28);
            this.OKBouton.TabIndex = 8;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            // 
            // SkewTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
            this.Controls.Add(this.OKBouton);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.refedit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StdevInMeanRefEdit);
            this.Controls.Add(this.label1);
            this.Name = "SkewTForm";
            this.Text = "SkewTForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit StdevInMeanRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit refedit1;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button OKBouton;
    }
}