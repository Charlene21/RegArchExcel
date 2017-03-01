namespace RegArchExcel
{
    partial class GedForm
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
            this.BetaRefedit = new VS.NET_RefeditControl.refedit();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.OKBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BetaRefedit
            // 
            this.BetaRefedit._CellsCount = 0;
            this.BetaRefedit._Excel = null;
            this.BetaRefedit.AllowCollapsedFormResize = false;
            this.BetaRefedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetaRefedit.Location = new System.Drawing.Point(129, 25);
            this.BetaRefedit.Name = "BetaRefedit";
            this.BetaRefedit.Size = new System.Drawing.Size(172, 22);
            this.BetaRefedit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "beta Cell";
            // 
            // CancelBouton
            // 
            this.CancelBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBouton.Location = new System.Drawing.Point(16, 81);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 2;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // OKBouton
            // 
            this.OKBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBouton.Location = new System.Drawing.Point(207, 81);
            this.OKBouton.Margin = new System.Windows.Forms.Padding(4);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(94, 29);
            this.OKBouton.TabIndex = 1;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // GedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 137);
            this.Controls.Add(this.BetaRefedit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Name = "GedForm";
            this.Text = "GedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VS.NET_RefeditControl.refedit BetaRefedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button OKBouton;
    }
}