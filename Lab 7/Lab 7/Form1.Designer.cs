namespace Lab_7
{
    partial class Lab7
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
            this.calcButton = new System.Windows.Forms.Button();
            this.futureValueLabel = new System.Windows.Forms.Label();
            this.futureValueTextBox = new System.Windows.Forms.TextBox();
            this.annualLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.annualTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.presentValueTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(153, 257);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // futureValueLabel
            // 
            this.futureValueLabel.AutoSize = true;
            this.futureValueLabel.Location = new System.Drawing.Point(94, 49);
            this.futureValueLabel.Name = "futureValueLabel";
            this.futureValueLabel.Size = new System.Drawing.Size(73, 13);
            this.futureValueLabel.TabIndex = 1;
            this.futureValueLabel.Text = "Future Value: ";
            // 
            // futureValueTextBox
            // 
            this.futureValueTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.futureValueTextBox.Location = new System.Drawing.Point(194, 46);
            this.futureValueTextBox.Name = "futureValueTextBox";
            this.futureValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.futureValueTextBox.TabIndex = 2;
            // 
            // annualLabel
            // 
            this.annualLabel.AutoSize = true;
            this.annualLabel.Location = new System.Drawing.Point(78, 94);
            this.annualLabel.Name = "annualLabel";
            this.annualLabel.Size = new System.Drawing.Size(110, 13);
            this.annualLabel.TabIndex = 3;
            this.annualLabel.Text = "Annual Interest Rate: ";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(94, 140);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(67, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "No. of Year: ";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueLabel.Location = new System.Drawing.Point(94, 194);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(79, 13);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Present Value: ";
            // 
            // annualTextBox
            // 
            this.annualTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.annualTextBox.Location = new System.Drawing.Point(194, 91);
            this.annualTextBox.Name = "annualTextBox";
            this.annualTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yearTextBox.Location = new System.Drawing.Point(194, 137);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // presentValueTextBox
            // 
            this.presentValueTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.presentValueTextBox.Location = new System.Drawing.Point(194, 193);
            this.presentValueTextBox.Name = "presentValueTextBox";
            this.presentValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.presentValueTextBox.TabIndex = 8;
            this.presentValueTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab7
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.presentValueTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.annualTextBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.annualLabel);
            this.Controls.Add(this.futureValueTextBox);
            this.Controls.Add(this.futureValueLabel);
            this.Controls.Add(this.calcButton);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label futureValueLabel;
        private System.Windows.Forms.TextBox futureValueTextBox;
        private System.Windows.Forms.Label annualLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox annualTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label presentValueTextBox;
    }
}

