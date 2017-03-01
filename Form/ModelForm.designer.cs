namespace RegArchExcel
{
    partial class ModelForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CondMeanLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CondVarLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CondDistrLabel = new System.Windows.Forms.Label();
            this.CondMeanButton = new System.Windows.Forms.Button();
            this.CondVarButton = new System.Windows.Forms.Button();
            this.CondDistrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(288, 476);
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
            this.CancelBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBouton.Location = new System.Drawing.Point(38, 470);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conditional Mean Model";
            // 
            // CondMeanLabel
            // 
            this.CondMeanLabel.AutoSize = true;
            this.CondMeanLabel.Location = new System.Drawing.Point(58, 285);
            this.CondMeanLabel.Name = "CondMeanLabel";
            this.CondMeanLabel.Size = new System.Drawing.Size(97, 20);
            this.CondMeanLabel.TabIndex = 7;
            this.CondMeanLabel.Text = "Pure ARCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conditional Variance Model";
            // 
            // CondVarLabel
            // 
            this.CondVarLabel.AutoSize = true;
            this.CondVarLabel.Location = new System.Drawing.Point(58, 357);
            this.CondVarLabel.Name = "CondVarLabel";
            this.CondVarLabel.Size = new System.Drawing.Size(38, 20);
            this.CondVarLabel.TabIndex = 9;
            this.CondVarLabel.Text = "i.i.d.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Conditional Distribution";
            // 
            // CondDistrLabel
            // 
            this.CondDistrLabel.AutoSize = true;
            this.CondDistrLabel.Location = new System.Drawing.Point(58, 427);
            this.CondDistrLabel.Name = "CondDistrLabel";
            this.CondDistrLabel.Size = new System.Drawing.Size(80, 20);
            this.CondDistrLabel.TabIndex = 11;
            this.CondDistrLabel.Text = "Gaussian";
            // 
            // CondMeanButton
            // 
            this.CondMeanButton.Location = new System.Drawing.Point(124, 24);
            this.CondMeanButton.Name = "CondMeanButton";
            this.CondMeanButton.Size = new System.Drawing.Size(198, 36);
            this.CondMeanButton.TabIndex = 12;
            this.CondMeanButton.Text = "Conditional Mean";
            this.CondMeanButton.UseVisualStyleBackColor = true;
            this.CondMeanButton.Click += new System.EventHandler(this.CondMeanButton_Click);
            // 
            // CondVarButton
            // 
            this.CondVarButton.Location = new System.Drawing.Point(124, 80);
            this.CondVarButton.Name = "CondVarButton";
            this.CondVarButton.Size = new System.Drawing.Size(196, 36);
            this.CondVarButton.TabIndex = 13;
            this.CondVarButton.Text = "Conditional Variance";
            this.CondVarButton.UseVisualStyleBackColor = true;
            this.CondVarButton.Click += new System.EventHandler(this.CondVarButton_Click);
            // 
            // CondDistrButton
            // 
            this.CondDistrButton.Location = new System.Drawing.Point(124, 134);
            this.CondDistrButton.Name = "CondDistrButton";
            this.CondDistrButton.Size = new System.Drawing.Size(196, 36);
            this.CondDistrButton.TabIndex = 14;
            this.CondDistrButton.Text = "Conditional Distribution";
            this.CondDistrButton.UseVisualStyleBackColor = true;
            this.CondDistrButton.Click += new System.EventHandler(this.CondDistrButton_Click);
            // 
            // ModelForm
            // 
            this.AcceptButton = this.OKBouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(424, 518);
            this.ControlBox = false;
            this.Controls.Add(this.CondDistrButton);
            this.Controls.Add(this.CondVarButton);
            this.Controls.Add(this.CondMeanButton);
            this.Controls.Add(this.CondDistrLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CondVarLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CondMeanLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModelForm";
            this.Text = "Model";
            this.Activated += new System.EventHandler(this.ModelForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CondMeanLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CondVarLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CondDistrLabel;
        private System.Windows.Forms.Button CondMeanButton;
        private System.Windows.Forms.Button CondVarButton;
        private System.Windows.Forms.Button CondDistrButton;
    }
}