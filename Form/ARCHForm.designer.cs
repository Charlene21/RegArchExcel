namespace RegArchExcel
{
    partial class ARCHForm
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
            this.ArchLagsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArchRefEdit = new VS.NET_RefeditControl.refedit();
            this.ConstRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(223, 124);
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
            this.CommentLabel.Location = new System.Drawing.Point(29, 9);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(51, 20);
            this.CommentLabel.TabIndex = 2;
            this.CommentLabel.Text = "Lags:";
            // 
            // ArchLagsLabel
            // 
            this.ArchLagsLabel.AutoSize = true;
            this.ArchLagsLabel.Location = new System.Drawing.Point(90, 9);
            this.ArchLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchLagsLabel.Name = "ArchLagsLabel";
            this.ArchLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.ArchLagsLabel.TabIndex = 3;
            this.ArchLagsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARCH Cells";
            // 
            // ArchRefEdit
            // 
            this.ArchRefEdit._Excel = null;
            this.ArchRefEdit.AllowCollapsedFormResize = false;
            this.ArchRefEdit.Location = new System.Drawing.Point(145, 80);
            this.ArchRefEdit.Name = "ArchRefEdit";
            this.ArchRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ArchRefEdit.TabIndex = 3;
            this.ArchRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArchRefEdit_CellChanged);
            // 
            // ConstRefEdit
            // 
            this.ConstRefEdit._Excel = null;
            this.ConstRefEdit.AllowCollapsedFormResize = false;
            this.ConstRefEdit.Location = new System.Drawing.Point(145, 40);
            this.ConstRefEdit.Name = "ConstRefEdit";
            this.ConstRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ConstRefEdit.TabIndex = 2;
            this.ConstRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ConstRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Const. Cell";
            // 
            // ARCHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 174);
            this.Controls.Add(this.ConstRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArchRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArchLagsLabel);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ARCHForm";
            this.Text = "ARCH(p) Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.Label ArchLagsLabel;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit ArchRefEdit;
        private VS.NET_RefeditControl.refedit ConstRefEdit;
        private System.Windows.Forms.Label label2;
    }
}