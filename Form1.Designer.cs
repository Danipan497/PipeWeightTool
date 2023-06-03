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
            this.button1 = new System.Windows.Forms.Button();
            this.pipeNominalDiameterTextBox = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pipeMassResultLabel = new System.Windows.Forms.Label();
            this.wallThicknessTextComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.pipeLengthTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pipeNominalDiameterTextBox
            // 
            this.pipeNominalDiameterTextBox.AllowDrop = true;
            this.pipeNominalDiameterTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pipeNominalDiameterTextBox.FormattingEnabled = true;
            this.pipeNominalDiameterTextBox.Location = new System.Drawing.Point(49, 203);
            this.pipeNominalDiameterTextBox.Name = "pipeNominalDiameterTextBox";
            this.pipeNominalDiameterTextBox.Size = new System.Drawing.Size(248, 28);
            this.pipeNominalDiameterTextBox.TabIndex = 1;
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
            this.pipeMassResultLabel.Location = new System.Drawing.Point(545, 388);
            this.pipeMassResultLabel.Name = "pipeMassResultLabel";
            this.pipeMassResultLabel.Size = new System.Drawing.Size(454, 47);
            this.pipeMassResultLabel.TabIndex = 3;
            // 
            // wallThicknessTextComboBox
            // 
            this.wallThicknessTextComboBox.AllowDrop = true;
            this.wallThicknessTextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wallThicknessTextComboBox.FormattingEnabled = true;
            this.wallThicknessTextComboBox.Location = new System.Drawing.Point(49, 268);
            this.wallThicknessTextComboBox.Name = "wallThicknessTextComboBox";
            this.wallThicknessTextComboBox.Size = new System.Drawing.Size(248, 28);
            this.wallThicknessTextComboBox.TabIndex = 4;
            // 
            // materialComboBox
            // 
            this.materialComboBox.AllowDrop = true;
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(49, 331);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(248, 28);
            this.materialComboBox.TabIndex = 5;
            // 
            // pipeLengthTextBox
            // 
            this.pipeLengthTextBox.Location = new System.Drawing.Point(49, 401);
            this.pipeLengthTextBox.Name = "pipeLengthTextBox";
            this.pipeLengthTextBox.Size = new System.Drawing.Size(248, 26);
            this.pipeLengthTextBox.TabIndex = 6;
            this.pipeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 617);
            this.Controls.Add(this.pipeLengthTextBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.wallThicknessTextComboBox);
            this.Controls.Add(this.pipeMassResultLabel);
            this.Controls.Add(this.pipeNominalDiameterTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox pipeNominalDiameterTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label pipeMassResultLabel;
        private System.Windows.Forms.ComboBox wallThicknessTextComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.TextBox pipeLengthTextBox;
    }
}

