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
            this.SkewTRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.GammaRefEdit = new VS.NET_RefeditControl.refedit();
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
            // SkewTRefEdit
            // 
            this.SkewTRefEdit._CellsCount = 0;
            this.SkewTRefEdit._Excel = null;
            this.SkewTRefEdit.AllowCollapsedFormResize = false;
            this.SkewTRefEdit.Location = new System.Drawing.Point(135, 29);
            this.SkewTRefEdit.Name = "SkewTRefEdit";
            this.SkewTRefEdit.Size = new System.Drawing.Size(172, 20);
            this.SkewTRefEdit.TabIndex = 4;
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
            // GammaRefEdit
            // 
            this.GammaRefEdit._CellsCount = 0;
            this.GammaRefEdit._Excel = null;
            this.GammaRefEdit.AllowCollapsedFormResize = false;
            this.GammaRefEdit.Location = new System.Drawing.Point(135, 77);
            this.GammaRefEdit.Name = "GammaRefEdit";
            this.GammaRefEdit.Size = new System.Drawing.Size(172, 20);
            this.GammaRefEdit.TabIndex = 6;
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
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(196, 147);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(81, 28);
            this.OKBouton.TabIndex = 8;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // SkewTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
            this.Controls.Add(this.OKBouton);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.GammaRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SkewTRefEdit);
            this.Controls.Add(this.label1);
            this.Name = "SkewTForm";
            this.Text = "SkewTForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit SkewTRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit GammaRefEdit;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button OKBouton;
    }
}