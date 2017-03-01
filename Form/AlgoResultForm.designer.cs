namespace RegArchExcel
{
    partial class AlgoResultForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConvergenceLabel = new System.Windows.Forms.Label();
            this.NIterLabel = new System.Windows.Forms.Label();
            this.LLHLabel = new System.Windows.Forms.Label();
            this.CritValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(448, 163);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(103, 39);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convergence: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Iterations: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "LLH: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Critical value: ";
            // 
            // ConvergenceLabel
            // 
            this.ConvergenceLabel.AutoSize = true;
            this.ConvergenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvergenceLabel.Location = new System.Drawing.Point(173, 34);
            this.ConvergenceLabel.Name = "ConvergenceLabel";
            this.ConvergenceLabel.Size = new System.Drawing.Size(71, 20);
            this.ConvergenceLabel.TabIndex = 6;
            this.ConvergenceLabel.Text = "Groumf";
            // 
            // NIterLabel
            // 
            this.NIterLabel.AutoSize = true;
            this.NIterLabel.Location = new System.Drawing.Point(174, 92);
            this.NIterLabel.Name = "NIterLabel";
            this.NIterLabel.Size = new System.Drawing.Size(45, 20);
            this.NIterLabel.TabIndex = 7;
            this.NIterLabel.Text = "1000";
            // 
            // LLHLabel
            // 
            this.LLHLabel.AutoSize = true;
            this.LLHLabel.Location = new System.Drawing.Point(173, 122);
            this.LLHLabel.Name = "LLHLabel";
            this.LLHLabel.Size = new System.Drawing.Size(91, 20);
            this.LLHLabel.TabIndex = 8;
            this.LLHLabel.Text = "-1000.2578";
            // 
            // CritValueLabel
            // 
            this.CritValueLabel.AutoSize = true;
            this.CritValueLabel.Location = new System.Drawing.Point(173, 152);
            this.CritValueLabel.Name = "CritValueLabel";
            this.CritValueLabel.Size = new System.Drawing.Size(49, 20);
            this.CritValueLabel.TabIndex = 10;
            this.CritValueLabel.Text = "0.002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reason: ";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonLabel.Location = new System.Drawing.Point(173, 62);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(88, 20);
            this.ReasonLabel.TabIndex = 12;
            this.ReasonLabel.Text = "Time Limit";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(174, 182);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 20);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "0.002";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Computation time: ";
            // 
            // AlgoResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 218);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CritValueLabel);
            this.Controls.Add(this.LLHLabel);
            this.Controls.Add(this.NIterLabel);
            this.Controls.Add(this.ConvergenceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlgoResultForm";
            this.Text = "GSL Algorithm Results summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ConvergenceLabel;
        private System.Windows.Forms.Label NIterLabel;
        private System.Windows.Forms.Label LLHLabel;
        private System.Windows.Forms.Label CritValueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label7;
    }
}