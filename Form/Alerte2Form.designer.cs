namespace RegArchExcel
{
    partial class Alerte2Form
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
            this.ContinueBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContinueBouton
            // 
            this.ContinueBouton.Location = new System.Drawing.Point(205, 112);
            this.ContinueBouton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContinueBouton.Name = "ContinueBouton";
            this.ContinueBouton.Size = new System.Drawing.Size(94, 29);
            this.ContinueBouton.TabIndex = 0;
            this.ContinueBouton.Text = "Continue";
            this.ContinueBouton.UseVisualStyleBackColor = true;
            this.ContinueBouton.Click += new System.EventHandler(this.ContinueBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cells are not empty !";
            // 
            // CancelBouton
            // 
            this.CancelBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBouton.Location = new System.Drawing.Point(28, 112);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 2;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // Alerte2Form
            // 
            this.AcceptButton = this.ContinueBouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(327, 173);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContinueBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alerte2Form";
            this.Text = "Problem !!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBouton;
    }
}