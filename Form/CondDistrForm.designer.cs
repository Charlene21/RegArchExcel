namespace RegArchExcel
{
    partial class CondDistrForm
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
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.NoCondMeanLabel = new System.Windows.Forms.Label();
            this.ConstLabel = new System.Windows.Forms.Label();
            this.StudentRemoveButton = new System.Windows.Forms.Button();
            this.NormRemoveButton = new System.Windows.Forms.Button();
            this.NormAddButton = new System.Windows.Forms.Button();
            this.GedRemoveButton = new System.Windows.Forms.Button();
            this.GedLabel = new System.Windows.Forms.Label();
            this.GedAddButton = new System.Windows.Forms.Button();
            this.SkewTLabel = new System.Windows.Forms.Label();
            this.SkewTAddButton = new System.Windows.Forms.Button();
            this.SkewTRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKBouton
            // 
            this.OKBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKBouton.Location = new System.Drawing.Point(270, 207);
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
            this.CancelBouton.Location = new System.Drawing.Point(27, 207);
            this.CancelBouton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBouton.Name = "CancelBouton";
            this.CancelBouton.Size = new System.Drawing.Size(94, 29);
            this.CancelBouton.TabIndex = 1;
            this.CancelBouton.Text = "Cancel";
            this.CancelBouton.UseVisualStyleBackColor = true;
            this.CancelBouton.Click += new System.EventHandler(this.CancelBouton_Click);
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Location = new System.Drawing.Point(157, 57);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(86, 31);
            this.StudentAddButton.TabIndex = 4;
            this.StudentAddButton.Text = "Add";
            this.StudentAddButton.UseVisualStyleBackColor = true;
            this.StudentAddButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // NoCondMeanLabel
            // 
            this.NoCondMeanLabel.AutoSize = true;
            this.NoCondMeanLabel.Enabled = false;
            this.NoCondMeanLabel.Location = new System.Drawing.Point(24, 22);
            this.NoCondMeanLabel.Name = "NoCondMeanLabel";
            this.NoCondMeanLabel.Size = new System.Drawing.Size(68, 17);
            this.NoCondMeanLabel.TabIndex = 16;
            this.NoCondMeanLabel.Text = "Gaussian";
            // 
            // ConstLabel
            // 
            this.ConstLabel.AutoSize = true;
            this.ConstLabel.Location = new System.Drawing.Point(24, 62);
            this.ConstLabel.Name = "ConstLabel";
            this.ConstLabel.Size = new System.Drawing.Size(57, 17);
            this.ConstLabel.TabIndex = 17;
            this.ConstLabel.Text = "Student";
            // 
            // StudentRemoveButton
            // 
            this.StudentRemoveButton.Enabled = false;
            this.StudentRemoveButton.Location = new System.Drawing.Point(278, 57);
            this.StudentRemoveButton.Name = "StudentRemoveButton";
            this.StudentRemoveButton.Size = new System.Drawing.Size(86, 31);
            this.StudentRemoveButton.TabIndex = 5;
            this.StudentRemoveButton.Text = "Remove";
            this.StudentRemoveButton.UseVisualStyleBackColor = true;
            this.StudentRemoveButton.Click += new System.EventHandler(this.StudentRemoveButton_Click);
            // 
            // NormRemoveButton
            // 
            this.NormRemoveButton.Enabled = false;
            this.NormRemoveButton.Location = new System.Drawing.Point(278, 17);
            this.NormRemoveButton.Name = "NormRemoveButton";
            this.NormRemoveButton.Size = new System.Drawing.Size(86, 31);
            this.NormRemoveButton.TabIndex = 3;
            this.NormRemoveButton.Text = "Remove";
            this.NormRemoveButton.UseVisualStyleBackColor = true;
            this.NormRemoveButton.Click += new System.EventHandler(this.NormRemoveButton_Click);
            // 
            // NormAddButton
            // 
            this.NormAddButton.Location = new System.Drawing.Point(157, 17);
            this.NormAddButton.Name = "NormAddButton";
            this.NormAddButton.Size = new System.Drawing.Size(86, 31);
            this.NormAddButton.TabIndex = 2;
            this.NormAddButton.Text = "Add";
            this.NormAddButton.UseVisualStyleBackColor = true;
            this.NormAddButton.Click += new System.EventHandler(this.NormAddButton_Click);
            // 
            // GedRemoveButton
            // 
            this.GedRemoveButton.Enabled = false;
            this.GedRemoveButton.Location = new System.Drawing.Point(278, 100);
            this.GedRemoveButton.Name = "GedRemoveButton";
            this.GedRemoveButton.Size = new System.Drawing.Size(86, 31);
            this.GedRemoveButton.TabIndex = 19;
            this.GedRemoveButton.Text = "Remove";
            this.GedRemoveButton.UseVisualStyleBackColor = true;
            this.GedRemoveButton.Click += new System.EventHandler(this.GedRemoveButton_Click);
            // 
            // GedLabel
            // 
            this.GedLabel.AutoSize = true;
            this.GedLabel.Location = new System.Drawing.Point(24, 105);
            this.GedLabel.Name = "GedLabel";
            this.GedLabel.Size = new System.Drawing.Size(38, 17);
            this.GedLabel.TabIndex = 20;
            this.GedLabel.Text = "GED";
            // 
            // GedAddButton
            // 
            this.GedAddButton.Location = new System.Drawing.Point(157, 100);
            this.GedAddButton.Name = "GedAddButton";
            this.GedAddButton.Size = new System.Drawing.Size(86, 31);
            this.GedAddButton.TabIndex = 18;
            this.GedAddButton.Text = "Add";
            this.GedAddButton.UseVisualStyleBackColor = true;
            this.GedAddButton.Click += new System.EventHandler(this.GedAddButton_Click);
            // 
            // SkewTLabel
            // 
            this.SkewTLabel.AutoSize = true;
            this.SkewTLabel.Location = new System.Drawing.Point(24, 148);
            this.SkewTLabel.Name = "SkewTLabel";
            this.SkewTLabel.Size = new System.Drawing.Size(50, 17);
            this.SkewTLabel.TabIndex = 21;
            this.SkewTLabel.Text = "SkewT";
            // 
            // SkewTAddButton
            // 
            this.SkewTAddButton.Location = new System.Drawing.Point(157, 148);
            this.SkewTAddButton.Name = "SkewTAddButton";
            this.SkewTAddButton.Size = new System.Drawing.Size(86, 31);
            this.SkewTAddButton.TabIndex = 22;
            this.SkewTAddButton.Text = "Add";
            this.SkewTAddButton.UseVisualStyleBackColor = true;
            this.SkewTAddButton.Click += new System.EventHandler(this.SkewTAddButton_Click);
            // 
            // SkewTRemoveButton
            // 
            this.SkewTRemoveButton.Enabled = false;
            this.SkewTRemoveButton.Location = new System.Drawing.Point(278, 148);
            this.SkewTRemoveButton.Name = "SkewTRemoveButton";
            this.SkewTRemoveButton.Size = new System.Drawing.Size(86, 31);
            this.SkewTRemoveButton.TabIndex = 23;
            this.SkewTRemoveButton.Text = "Remove";
            this.SkewTRemoveButton.UseVisualStyleBackColor = true;
            this.SkewTRemoveButton.Click += new System.EventHandler(this.SkewTRemoveButton_Click);
            // 
            // CondDistrForm
            // 
            this.AcceptButton = this.OKBouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBouton;
            this.ClientSize = new System.Drawing.Size(378, 266);
            this.Controls.Add(this.SkewTRemoveButton);
            this.Controls.Add(this.SkewTAddButton);
            this.Controls.Add(this.SkewTLabel);
            this.Controls.Add(this.GedRemoveButton);
            this.Controls.Add(this.GedLabel);
            this.Controls.Add(this.GedAddButton);
            this.Controls.Add(this.NormRemoveButton);
            this.Controls.Add(this.NormAddButton);
            this.Controls.Add(this.StudentRemoveButton);
            this.Controls.Add(this.ConstLabel);
            this.Controls.Add(this.NoCondMeanLabel);
            this.Controls.Add(this.StudentAddButton);
            this.Controls.Add(this.CancelBouton);
            this.Controls.Add(this.OKBouton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CondDistrForm";
            this.Text = "Conditional Distribution Model";
            this.Activated += new System.EventHandler(this.CondDistrForm_Activated);
            this.Load += new System.EventHandler(this.CondDistrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBouton;
        private System.Windows.Forms.Button CancelBouton;
        private System.Windows.Forms.Button StudentAddButton;
        private System.Windows.Forms.Label NoCondMeanLabel;
        private System.Windows.Forms.Label ConstLabel;
        private System.Windows.Forms.Button StudentRemoveButton;
        private System.Windows.Forms.Button NormRemoveButton;
        private System.Windows.Forms.Button NormAddButton;
        private System.Windows.Forms.Button GedRemoveButton;
        private System.Windows.Forms.Label GedLabel;
        private System.Windows.Forms.Button GedAddButton;
        private System.Windows.Forms.Label SkewTLabel;
        private System.Windows.Forms.Button SkewTAddButton;
        private System.Windows.Forms.Button SkewTRemoveButton;
    }
}