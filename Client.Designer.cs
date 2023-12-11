namespace Client
{
    partial class Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thirdRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.PanelCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thirdRadioButton);
            this.groupBox1.Controls.Add(this.secondRadioButton);
            this.groupBox1.Controls.Add(this.firstRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Height";
            // 
            // YellowRadioButton
            // 
            this.thirdRadioButton.AutoSize = true;
            this.thirdRadioButton.Location = new System.Drawing.Point(6, 74);
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Size = new System.Drawing.Size(68, 20);
            this.thirdRadioButton.TabIndex = 3;
            this.thirdRadioButton.Text = "83";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            this.thirdRadioButton.CheckedChanged += new System.EventHandler(this.thirdRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.Location = new System.Drawing.Point(6, 47);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(54, 20);
            this.secondRadioButton.TabIndex = 2;
            this.secondRadioButton.Text = "62";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.secondRadioButton_CheckedChanged);
            // 
            // WhiteRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Checked = true;
            this.firstRadioButton.Location = new System.Drawing.Point(6, 21);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(78, 20);
            this.firstRadioButton.TabIndex = 1;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "41";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // PanelCheckBox
            // 
            this.PanelCheckBox.AutoSize = true;
            this.PanelCheckBox.Checked = true;
            this.PanelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PanelCheckBox.Location = new System.Drawing.Point(244, 48);
            this.PanelCheckBox.Name = "PanelCheckBox";
            this.PanelCheckBox.Size = new System.Drawing.Size(113, 20);
            this.PanelCheckBox.TabIndex = 5;
            this.PanelCheckBox.Text = "Panel - visible";
            this.PanelCheckBox.UseVisualStyleBackColor = true;
            this.PanelCheckBox.CheckedChanged += new System.EventHandler(this.PanelCheckBox_CheckedChanged);
            // 
            // ButtonCheckBox
            // 
            this.ButtonCheckBox.AutoSize = true;
            this.ButtonCheckBox.Location = new System.Drawing.Point(244, 22);
            this.ButtonCheckBox.Name = "ButtonCheckBox";
            this.ButtonCheckBox.Size = new System.Drawing.Size(153, 20);
            this.ButtonCheckBox.TabIndex = 4;
            this.ButtonCheckBox.Text = "Button - not available";
            this.ButtonCheckBox.UseVisualStyleBackColor = true;
            this.ButtonCheckBox.CheckedChanged += new System.EventHandler(this.ButtonCheckBox_CheckedChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelCheckBox);
            this.Controls.Add(this.ButtonCheckBox);
            this.Name = "Client";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton thirdRadioButton;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.CheckBox PanelCheckBox;
        private System.Windows.Forms.CheckBox ButtonCheckBox;
    }
}

