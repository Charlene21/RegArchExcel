namespace RegArchExcel
{
    partial class AlgoPreference
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
            this.GSLAlgoBox = new System.Windows.Forms.ComboBox();
            this.OKBouton = new System.Windows.Forms.Button();
            this.CancelBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GSLStepSizeTextBox = new System.Windows.Forms.TextBox();
            this.GSLToleranceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GSLStopValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GSLMaxIterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GSLTimeLimitTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GSLRadioButton = new System.Windows.Forms.RadioButton();
            this.NLOPTRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.NLOPTAlgoBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NLOPTStopValueTextBox = new System.Windows.Forms.TextBox();
            this.NLOPTfTolTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NLOPTxTolTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NLOPTTimeLimitTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NLOPTMaxFuncEvalTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GSLAlgoBox
            // 
            this.GSLAlgoBox.FormattingEnabled = true;
            this.GSLAlgoBox.Items.AddRange(new object[] {
            "Fletcher-Reeves conjugate gradient algorithm",
            "Polak-Ribiere conjugate gradient algorithm",
            "Broyden-Fletcher-Goldfarb-Shanno (BFGS) algorithm",
            "The most efficient Broyden-Fletcher-Goldfarb-Shanno BFGS algorithm",
            "The steepest descent algorithm ",
            "Simplex algorithm of Nelder and Mead"});
            this.GSLAlgoBox.Location = new System.Drawing.Point(168, 70);
            this.GSLAlgoBox.Margin = new System.Windows.Forms.Padding(4);
            this.GSLAlgoBox.Name = "GSLAlgoBox";
            this.GSLAlgoBox.Size = new System.Drawing.Size(559, 28);
            this.GSLAlgoBox.TabIndex = 4;
            // 
            // OKBouton
            // 
            this.OKBouton.Location = new System.Drawing.Point(633, 385);
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
            this.CancelBouton.Location = new System.Drawing.Point(25, 385);
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
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "GSL Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Step size:";
            // 
            // GSLStepSizeTextBox
            // 
            this.GSLStepSizeTextBox.Location = new System.Drawing.Point(101, 130);
            this.GSLStepSizeTextBox.Name = "GSLStepSizeTextBox";
            this.GSLStepSizeTextBox.Size = new System.Drawing.Size(67, 27);
            this.GSLStepSizeTextBox.TabIndex = 5;
            this.GSLStepSizeTextBox.Text = "0.01";
            this.GSLStepSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GSLToleranceTextBox
            // 
            this.GSLToleranceTextBox.Location = new System.Drawing.Point(257, 130);
            this.GSLToleranceTextBox.Name = "GSLToleranceTextBox";
            this.GSLToleranceTextBox.Size = new System.Drawing.Size(67, 27);
            this.GSLToleranceTextBox.TabIndex = 6;
            this.GSLToleranceTextBox.Text = "0.1";
            this.GSLToleranceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tolerance:";
            // 
            // GSLStopValueTextBox
            // 
            this.GSLStopValueTextBox.Location = new System.Drawing.Point(419, 130);
            this.GSLStopValueTextBox.Name = "GSLStopValueTextBox";
            this.GSLStopValueTextBox.Size = new System.Drawing.Size(67, 27);
            this.GSLStopValueTextBox.TabIndex = 7;
            this.GSLStopValueTextBox.Text = "1e-2";
            this.GSLStopValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop value:";
            // 
            // GSLMaxIterTextBox
            // 
            this.GSLMaxIterTextBox.Location = new System.Drawing.Point(146, 176);
            this.GSLMaxIterTextBox.Name = "GSLMaxIterTextBox";
            this.GSLMaxIterTextBox.Size = new System.Drawing.Size(67, 27);
            this.GSLMaxIterTextBox.TabIndex = 8;
            this.GSLMaxIterTextBox.Text = "10000";
            this.GSLMaxIterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max iterations:";
            // 
            // GSLTimeLimitTextBox
            // 
            this.GSLTimeLimitTextBox.Location = new System.Drawing.Point(425, 176);
            this.GSLTimeLimitTextBox.Name = "GSLTimeLimitTextBox";
            this.GSLTimeLimitTextBox.Size = new System.Drawing.Size(67, 27);
            this.GSLTimeLimitTextBox.TabIndex = 9;
            this.GSLTimeLimitTextBox.Text = "30";
            this.GSLTimeLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time limit (seconds): ";
            // 
            // GSLRadioButton
            // 
            this.GSLRadioButton.AutoSize = true;
            this.GSLRadioButton.Location = new System.Drawing.Point(25, 23);
            this.GSLRadioButton.Name = "GSLRadioButton";
            this.GSLRadioButton.Size = new System.Drawing.Size(149, 24);
            this.GSLRadioButton.TabIndex = 2;
            this.GSLRadioButton.TabStop = true;
            this.GSLRadioButton.Text = "GSL Algorithms";
            this.GSLRadioButton.UseVisualStyleBackColor = true;
            this.GSLRadioButton.CheckedChanged += new System.EventHandler(this.GSLRadioButton_CheckedChanged);
            // 
            // NLOPTRadioButton
            // 
            this.NLOPTRadioButton.AutoSize = true;
            this.NLOPTRadioButton.Location = new System.Drawing.Point(253, 23);
            this.NLOPTRadioButton.Name = "NLOPTRadioButton";
            this.NLOPTRadioButton.Size = new System.Drawing.Size(176, 24);
            this.NLOPTRadioButton.TabIndex = 3;
            this.NLOPTRadioButton.TabStop = true;
            this.NLOPTRadioButton.Text = "NLOPT Algoritthms";
            this.NLOPTRadioButton.UseVisualStyleBackColor = true;
            this.NLOPTRadioButton.CheckedChanged += new System.EventHandler(this.NLoptRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "NLOPT Algorithm:";
            // 
            // NLOPTAlgoBox
            // 
            this.NLOPTAlgoBox.FormattingEnabled = true;
            this.NLOPTAlgoBox.Items.AddRange(new object[] {
            "NLOPT_GN_DIRECT",
            "NLOPT_GN_DIRECT_L",
            "NLOPT_GN_DIRECT_L_RAND",
            "NLOPT_GN_DIRECT_NOSCAL",
            "NLOPT_GN_DIRECT_L_NOSCAL",
            "NLOPT_GN_DIRECT_L_RAND_NOSCAL",
            "NLOPT_GN_ORIG_DIRECT",
            "NLOPT_GN_ORIG_DIRECT_L",
            "NLOPT_GD_STOGO",
            "NLOPT_GD_STOGO_RAND",
            "NLOPT_LD_LBFGS_NOCEDAL",
            "NLOPT_LD_LBFGS",
            "NLOPT_LN_PRAXIS",
            "NLOPT_LD_VAR1",
            "NLOPT_LD_VAR2",
            "NLOPT_LD_TNEWTON",
            "NLOPT_LD_TNEWTON_RESTART",
            "NLOPT_LD_TNEWTON_PRECOND",
            "NLOPT_LD_TNEWTON_PRECOND_RESTART",
            "NLOPT_GN_CRS2_LM",
            "NLOPT_GN_MLSL",
            "NLOPT_GD_MLSL",
            "NLOPT_GN_MLSL_LDS",
            "NLOPT_GD_MLSL_LDS",
            "NLOPT_LD_MMA",
            "NLOPT_LN_COBYLA",
            " NLOPT_LN_NEWUOA",
            "NLOPT_LN_NEWUOA_BOUND",
            "NLOPT_LN_NELDERMEAD",
            "NLOPT_LN_SBPLX",
            "NLOPT_LN_AUGLAG",
            "NLOPT_LD_AUGLAG,",
            "NLOPT_LN_AUGLAG_EQ",
            " NLOPT_LD_AUGLAG_EQ",
            "NLOPT_LN_BOBYQA",
            "NLOPT_GN_ISRES",
            "NLOPT_AUGLAG",
            "NLOPT_AUGLAG_EQ",
            "NLOPT_G_MLSL",
            "NLOPT_G_MLSL_LDS",
            " NLOPT_LD_SLSQP",
            "NLOPT_LD_CCSAQ",
            "NLOPT_GN_ESCH"});
            this.NLOPTAlgoBox.Location = new System.Drawing.Point(168, 228);
            this.NLOPTAlgoBox.Margin = new System.Windows.Forms.Padding(4);
            this.NLOPTAlgoBox.Name = "NLOPTAlgoBox";
            this.NLOPTAlgoBox.Size = new System.Drawing.Size(559, 28);
            this.NLOPTAlgoBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stop Value:";
            // 
            // NLOPTStopValueTextBox
            // 
            this.NLOPTStopValueTextBox.Location = new System.Drawing.Point(127, 284);
            this.NLOPTStopValueTextBox.Name = "NLOPTStopValueTextBox";
            this.NLOPTStopValueTextBox.Size = new System.Drawing.Size(91, 27);
            this.NLOPTStopValueTextBox.TabIndex = 16;
            this.NLOPTStopValueTextBox.Text = "1e200";
            this.NLOPTStopValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NLOPTfTolTextBox
            // 
            this.NLOPTfTolTextBox.Location = new System.Drawing.Point(280, 281);
            this.NLOPTfTolTextBox.Name = "NLOPTfTolTextBox";
            this.NLOPTfTolTextBox.Size = new System.Drawing.Size(67, 27);
            this.NLOPTfTolTextBox.TabIndex = 17;
            this.NLOPTfTolTextBox.Text = "0.001";
            this.NLOPTfTolTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "fTol:";
            // 
            // NLOPTxTolTextBox
            // 
            this.NLOPTxTolTextBox.Location = new System.Drawing.Point(425, 281);
            this.NLOPTxTolTextBox.Name = "NLOPTxTolTextBox";
            this.NLOPTxTolTextBox.Size = new System.Drawing.Size(67, 27);
            this.NLOPTxTolTextBox.TabIndex = 19;
            this.NLOPTxTolTextBox.Text = "0.001";
            this.NLOPTxTolTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "xTol:";
            // 
            // NLOPTTimeLimitTextBox
            // 
            this.NLOPTTimeLimitTextBox.Location = new System.Drawing.Point(426, 328);
            this.NLOPTTimeLimitTextBox.Name = "NLOPTTimeLimitTextBox";
            this.NLOPTTimeLimitTextBox.Size = new System.Drawing.Size(67, 27);
            this.NLOPTTimeLimitTextBox.TabIndex = 22;
            this.NLOPTTimeLimitTextBox.Text = "30";
            this.NLOPTTimeLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Time limit (seconds): ";
            // 
            // NLOPTMaxFuncEvalTextBox
            // 
            this.NLOPTMaxFuncEvalTextBox.Location = new System.Drawing.Point(175, 328);
            this.NLOPTMaxFuncEvalTextBox.Name = "NLOPTMaxFuncEvalTextBox";
            this.NLOPTMaxFuncEvalTextBox.Size = new System.Drawing.Size(67, 27);
            this.NLOPTMaxFuncEvalTextBox.TabIndex = 21;
            this.NLOPTMaxFuncEvalTextBox.Text = "10000";
            this.NLOPTMaxFuncEvalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Max function eval. :";
            // 
            // AlgoPreference
            // 
            this.AcceptButton = this.OKBouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(745, 441);
            this.Controls.Add(this.NLOPTTimeLimitTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NLOPTMaxFuncEvalTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NLOPTxTolTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NLOPTfTolTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NLOPTStopValueTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NLOPTAlgoBox);
            this.Controls.Add(this.NLOPTRadioButton);
            this.Controls.Add(this.GSLRadioButton);
            this.Controls.Add(this.GSLTimeLimitTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GSLMaxIterTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GSLStopValueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GSLToleranceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GSLStepSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Controls.Add(this.GSLAlgoBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlgoPreference";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GSLAlgoBox;
        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GSLStepSizeTextBox;
        private System.Windows.Forms.TextBox GSLToleranceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GSLStopValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GSLMaxIterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GSLTimeLimitTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton GSLRadioButton;
        private System.Windows.Forms.RadioButton NLOPTRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox NLOPTAlgoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NLOPTStopValueTextBox;
        private System.Windows.Forms.TextBox NLOPTfTolTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NLOPTxTolTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NLOPTTimeLimitTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NLOPTMaxFuncEvalTextBox;
        private System.Windows.Forms.Label label12;
    }
}