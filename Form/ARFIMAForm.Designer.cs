namespace RegArchExcel
{
    partial class ARFIMAForm
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
            this.FracDRefEdit = new VS.NET_RefeditControl.refedit();
            this.label4 = new System.Windows.Forms.Label();
            this.MaLagsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaRefEdit = new VS.NET_RefeditControl.refedit();
            this.label2 = new System.Windows.Forms.Label();
            this.ArRefEdit = new VS.NET_RefeditControl.refedit();
            this.label1 = new System.Windows.Forms.Label();
            this.ArLagsLabel = new System.Windows.Forms.Label();
            this.ArLagLabel1 = new System.Windows.Forms.Label();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.OKBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FracDRefEdit
            // 
            this.FracDRefEdit._CellsCount = 0;
            this.FracDRefEdit._Excel = null;
            this.FracDRefEdit.AllowCollapsedFormResize = false;
            this.FracDRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FracDRefEdit.Location = new System.Drawing.Point(160, 157);
            this.FracDRefEdit.Name = "FracDRefEdit";
            this.FracDRefEdit.Size = new System.Drawing.Size(172, 22);
            this.FracDRefEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fractal d Cell";
            // 
            // MaLagsLabel
            // 
            this.MaLagsLabel.AutoSize = true;
            this.MaLagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLagsLabel.Location = new System.Drawing.Point(271, 24);
            this.MaLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaLagsLabel.Name = "MaLagsLabel";
            this.MaLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.MaLagsLabel.TabIndex = 21;
            this.MaLagsLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "MA Lags:";
            // 
            // MaRefEdit
            // 
            this.MaRefEdit._CellsCount = 0;
            this.MaRefEdit._Excel = null;
            this.MaRefEdit.AllowCollapsedFormResize = false;
            this.MaRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaRefEdit.Location = new System.Drawing.Point(160, 111);
            this.MaRefEdit.Name = "MaRefEdit";
            this.MaRefEdit.Size = new System.Drawing.Size(172, 22);
            this.MaRefEdit.TabIndex = 4;
            this.MaRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.MaRefEdit_CellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "MA Cells";
            // 
            // ArRefEdit
            // 
            this.ArRefEdit._CellsCount = 0;
            this.ArRefEdit._Excel = null;
            this.ArRefEdit.AllowCollapsedFormResize = false;
            this.ArRefEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArRefEdit.Location = new System.Drawing.Point(160, 68);
            this.ArRefEdit.Name = "ArRefEdit";
            this.ArRefEdit.Size = new System.Drawing.Size(172, 22);
            this.ArRefEdit.TabIndex = 3;
            this.ArRefEdit.CellChanged += new VS.NET_RefeditControl.refeditCellChangeEventHandler(this.ArRefEdit_CellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "AR Cells";
            // 
            // ArLagsLabel
            // 
            this.ArLagsLabel.AutoSize = true;
            this.ArLagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArLagsLabel.Location = new System.Drawing.Point(127, 24);
            this.ArLagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArLagsLabel.Name = "ArLagsLabel";
            this.ArLagsLabel.Size = new System.Drawing.Size(18, 20);
            this.ArLagsLabel.TabIndex = 16;
            this.ArLagsLabel.Text = "0";
            // 
            // ArLagLabel1
            // 
            this.ArLagLabel1.AutoSize = true;
            this.ArLagLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArLagLabel1.Location = new System.Drawing.Point(40, 24);
            this.ArLagLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArLagLabel1.Name = "ArLagLabel1";
            this.ArLagLabel1.Size = new System.Drawing.Size(79, 20);
            this.ArLagLabel1.TabIndex = 14;
            this.ArLagLabel1.Text = "AR Lags:";
            // 
            // CancelBouton
            // 
            this.CancelBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBouton.Location = new System.Drawing.Point(44, 210);
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
            this.OKBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBouton.Location = new System.Drawing.Point(238, 210);
            this.OKBouton.Margin = new System.Windows.Forms.Padding(4);
            this.OKBouton.Name = "OKBouton";
            this.OKBouton.Size = new System.Drawing.Size(94, 29);
            this.OKBouton.TabIndex = 1;
            this.OKBouton.Text = "OK";
            this.OKBouton.UseVisualStyleBackColor = true;
            this.OKBouton.Click += new System.EventHandler(this.OKBouton_Click);
            // 
            // ARFIMAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 260);
            this.Controls.Add(this.FracDRefEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaLagsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaRefEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArRefEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArLagsLabel);
            this.Controls.Add(this.ArLagLabel1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Name = "ARFIMAForm";
            this.Text = "ARFIMA(p, d, q) model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VS.NET_RefeditControl.refedit FracDRefEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MaLagsLabel;
        private System.Windows.Forms.Label label3;
        private VS.NET_RefeditControl.refedit MaRefEdit;
        private System.Windows.Forms.Label label2;
        private VS.NET_RefeditControl.refedit ArRefEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArLagsLabel;
        private System.Windows.Forms.Label ArLagLabel1;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button OKBouton;
    }
}