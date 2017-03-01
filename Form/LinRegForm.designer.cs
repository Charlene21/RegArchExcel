namespace RegArchExcel
{
    partial class LinRegForm
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
            this.LinRegBetaRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.LinRegXRefEdit = new VS.NET_RefeditControl.refedit();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(375, 139);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(74, 35);
            this.OKBouton.TabIndex = 0;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // CancelBouton
            // 
            this.CancelBouton.Location = new System.Drawing.Point(16, 139);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(74, 35);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameter (beta) Cells";
            // 
            // LinRegBetaRefEdit
            // 
            this.LinRegBetaRefEdit._CellsCount = 0;
            this.LinRegBetaRefEdit._Excel = null;
            this.LinRegBetaRefEdit.AllowCollapsedFormResize = false;
            this.LinRegBetaRefEdit.Location = new System.Drawing.Point(254, 38);
            this.LinRegBetaRefEdit.Name = "LinRegBetaRefEdit";
            this.LinRegBetaRefEdit.Size = new System.Drawing.Size(195, 22);
            this.LinRegBetaRefEdit.TabIndex = 3;
            this.LinRegBetaRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.LinRegBetaRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regressors (X) Matrix Cells";
            // 
            // LinRegXRefEdit
            // 
            this.LinRegXRefEdit._CellsCount = 0;
            this.LinRegXRefEdit._Excel = null;
            this.LinRegXRefEdit.AllowCollapsedFormResize = false;
            this.LinRegXRefEdit.Location = new System.Drawing.Point(254, 85);
            this.LinRegXRefEdit.Name = "LinRegXRefEdit";
            this.LinRegXRefEdit.Size = new System.Drawing.Size(195, 22);
            this.LinRegXRefEdit.TabIndex = 5;
            this.LinRegXRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.LinRegXRefEdit_CellChanged);
            // 
            // LinRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 188);
            this.Controls.Add(this.LinRegXRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinRegBetaRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LinRegForm";
            this.Text = "Linear Regression Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label label1;
        private VS.NET_RefeditControl.refedit LinRegBetaRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit LinRegXRefEdit;
    }
}