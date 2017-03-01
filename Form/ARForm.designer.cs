namespace RegArchExcel
{
    partial class ARForm
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
            this.CommentLabel = new System.Windows.Forms.Label();
            this.LagsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ARRefedit = new VS.NET_RefeditControl.refedit();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(211, 124);
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
            this.CancelBouton.Location = new System.Drawing.Point(32, 124);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(28, 26);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(51, 20);
            this.CommentLabel.TabIndex = 2;
            this.CommentLabel.Text = "Lags:";
            // 
            // LagsLabel
            // 
            this.LagsLabel.AutoSize = true;
            this.LagsLabel.Location = new System.Drawing.Point(89, 26);
            this.LagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LagsLabel.Name = "LagsLabel";
            this.LagsLabel.Size = new System.Drawing.Size(18, 20);
            this.LagsLabel.TabIndex = 3;
            this.LagsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "AR Cells";
            // 
            // ARRefedit
            // 
            this.ARRefedit._Excel = null;
            this.ARRefedit.AllowCollapsedFormResize = false;
            this.ARRefedit.Location = new System.Drawing.Point(133, 68);
            this.ARRefedit.Name = "ARRefedit";
            this.ARRefedit.Size = new System.Drawing.Size(172, 22);
            this.ARRefedit.TabIndex = 5;
            this.ARRefedit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ARRefedit_CellChanged);
            // 
            // ARForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 174);
            this.Controls.Add(this.ARRefedit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LagsLabel);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ARForm";
            this.Text = "AR(p) Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.Label LagsLabel;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit ARRefedit;
    }
}