namespace PipeWeightTool
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.pipeNominalDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pipeMassResultLabel = new System.Windows.Forms.Label();
            this.wallThicknessTextComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.pipeLengthTextBox = new System.Windows.Forms.TextBox();
            this.nominalDiameterLabel = new System.Windows.Forms.Label();
            this.wallThicknessLabel1 = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.lengthLabel1 = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(125, 560);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(250, 85);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pipeNominalDiameterComboBox
            // 
            this.pipeNominalDiameterComboBox.AllowDrop = true;
            this.pipeNominalDiameterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pipeNominalDiameterComboBox.FormattingEnabled = true;
            this.pipeNominalDiameterComboBox.Location = new System.Drawing.Point(125, 80);
            this.pipeNominalDiameterComboBox.Name = "pipeNominalDiameterComboBox";
            this.pipeNominalDiameterComboBox.Size = new System.Drawing.Size(250, 28);
            this.pipeNominalDiameterComboBox.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pipeMassResultLabel
            // 
            this.pipeMassResultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pipeMassResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel.Location = new System.Drawing.Point(125, 480);
            this.pipeMassResultLabel.Name = "pipeMassResultLabel";
            this.pipeMassResultLabel.Size = new System.Drawing.Size(250, 28);
            this.pipeMassResultLabel.TabIndex = 3;
            // 
            // wallThicknessTextComboBox
            // 
            this.wallThicknessTextComboBox.AllowDrop = true;
            this.wallThicknessTextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wallThicknessTextComboBox.FormattingEnabled = true;
            this.wallThicknessTextComboBox.Location = new System.Drawing.Point(125, 180);
            this.wallThicknessTextComboBox.Name = "wallThicknessTextComboBox";
            this.wallThicknessTextComboBox.Size = new System.Drawing.Size(250, 28);
            this.wallThicknessTextComboBox.TabIndex = 4;
            // 
            // materialComboBox
            // 
            this.materialComboBox.AllowDrop = true;
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(125, 280);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(250, 28);
            this.materialComboBox.TabIndex = 5;
            // 
            // pipeLengthTextBox
            // 
            this.pipeLengthTextBox.Location = new System.Drawing.Point(125, 380);
            this.pipeLengthTextBox.Name = "pipeLengthTextBox";
            this.pipeLengthTextBox.Size = new System.Drawing.Size(250, 26);
            this.pipeLengthTextBox.TabIndex = 6;
            this.pipeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox_KeyPress);
            // 
            // nominalDiameterLabel
            // 
            this.nominalDiameterLabel.AutoSize = true;
            this.nominalDiameterLabel.Location = new System.Drawing.Point(125, 40);
            this.nominalDiameterLabel.Name = "nominalDiameterLabel";
            this.nominalDiameterLabel.Size = new System.Drawing.Size(167, 20);
            this.nominalDiameterLabel.TabIndex = 7;
            this.nominalDiameterLabel.Text = "Nominal pipe size [DN]";
            // 
            // wallThicknessLabel1
            // 
            this.wallThicknessLabel1.AutoSize = true;
            this.wallThicknessLabel1.Location = new System.Drawing.Point(125, 140);
            this.wallThicknessLabel1.Name = "wallThicknessLabel1";
            this.wallThicknessLabel1.Size = new System.Drawing.Size(148, 20);
            this.wallThicknessLabel1.TabIndex = 8;
            this.wallThicknessLabel1.Text = "Wall thickness [mm]";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(125, 240);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(65, 20);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material";
            // 
            // lengthLabel1
            // 
            this.lengthLabel1.AutoSize = true;
            this.lengthLabel1.Location = new System.Drawing.Point(125, 340);
            this.lengthLabel1.Name = "lengthLabel1";
            this.lengthLabel1.Size = new System.Drawing.Size(59, 20);
            this.lengthLabel1.TabIndex = 10;
            this.lengthLabel1.Text = "Length";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(125, 440);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 20);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Weight [kg]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 744);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.lengthLabel1);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.wallThicknessLabel1);
            this.Controls.Add(this.nominalDiameterLabel);
            this.Controls.Add(this.pipeLengthTextBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.wallThicknessTextComboBox);
            this.Controls.Add(this.pipeMassResultLabel);
            this.Controls.Add(this.pipeNominalDiameterComboBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Pipe weight tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox pipeNominalDiameterComboBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label pipeMassResultLabel;
        private System.Windows.Forms.ComboBox wallThicknessTextComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.TextBox pipeLengthTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label lengthLabel1;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label wallThicknessLabel1;
        private System.Windows.Forms.Label nominalDiameterLabel;
    }
}

