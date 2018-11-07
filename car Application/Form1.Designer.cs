namespace car_Application
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
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.makeDescriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.yearResultLabel = new System.Windows.Forms.Label();
            this.speedResultLabel = new System.Windows.Forms.Label();
            this.makeResultLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.speedResultDescriptionLabel = new System.Windows.Forms.Label();
            this.makeResultDescriptionLabel = new System.Windows.Forms.Label();
            this.yearResultDescriptionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(112, 37);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 0;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(112, 76);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 2;
            // 
            // makeDescriptionLabel
            // 
            this.makeDescriptionLabel.AutoSize = true;
            this.makeDescriptionLabel.Location = new System.Drawing.Point(13, 37);
            this.makeDescriptionLabel.Name = "makeDescriptionLabel";
            this.makeDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.makeDescriptionLabel.TabIndex = 3;
            this.makeDescriptionLabel.Text = "Enter Car Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Car Year:";
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(218, 102);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 5;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(310, 102);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 23);
            this.brakeButton.TabIndex = 6;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // yearResultLabel
            // 
            this.yearResultLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yearResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearResultLabel.Location = new System.Drawing.Point(152, 16);
            this.yearResultLabel.Name = "yearResultLabel";
            this.yearResultLabel.Size = new System.Drawing.Size(123, 23);
            this.yearResultLabel.TabIndex = 7;
            this.yearResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedResultLabel
            // 
            this.speedResultLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.speedResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedResultLabel.Location = new System.Drawing.Point(152, 123);
            this.speedResultLabel.Name = "speedResultLabel";
            this.speedResultLabel.Size = new System.Drawing.Size(123, 23);
            this.speedResultLabel.TabIndex = 8;
            this.speedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeResultLabel
            // 
            this.makeResultLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.makeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.makeResultLabel.Location = new System.Drawing.Point(152, 65);
            this.makeResultLabel.Name = "makeResultLabel";
            this.makeResultLabel.Size = new System.Drawing.Size(123, 23);
            this.makeResultLabel.TabIndex = 9;
            this.makeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speedResultDescriptionLabel);
            this.groupBox1.Controls.Add(this.makeResultDescriptionLabel);
            this.groupBox1.Controls.Add(this.yearResultDescriptionLabel);
            this.groupBox1.Controls.Add(this.yearResultLabel);
            this.groupBox1.Controls.Add(this.speedResultLabel);
            this.groupBox1.Controls.Add(this.makeResultLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results:";
            // 
            // speedResultDescriptionLabel
            // 
            this.speedResultDescriptionLabel.AutoSize = true;
            this.speedResultDescriptionLabel.Location = new System.Drawing.Point(67, 123);
            this.speedResultDescriptionLabel.Name = "speedResultDescriptionLabel";
            this.speedResultDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.speedResultDescriptionLabel.TabIndex = 12;
            this.speedResultDescriptionLabel.Text = "Car Speed:";
            // 
            // makeResultDescriptionLabel
            // 
            this.makeResultDescriptionLabel.AutoSize = true;
            this.makeResultDescriptionLabel.Location = new System.Drawing.Point(71, 75);
            this.makeResultDescriptionLabel.Name = "makeResultDescriptionLabel";
            this.makeResultDescriptionLabel.Size = new System.Drawing.Size(56, 13);
            this.makeResultDescriptionLabel.TabIndex = 11;
            this.makeResultDescriptionLabel.Text = "Car Make:";
            // 
            // yearResultDescriptionLabel
            // 
            this.yearResultDescriptionLabel.AutoSize = true;
            this.yearResultDescriptionLabel.Location = new System.Drawing.Point(76, 21);
            this.yearResultDescriptionLabel.Name = "yearResultDescriptionLabel";
            this.yearResultDescriptionLabel.Size = new System.Drawing.Size(51, 13);
            this.yearResultDescriptionLabel.TabIndex = 11;
            this.yearResultDescriptionLabel.Text = "Car Year:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 32);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(258, 37);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(127, 42);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 367);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.makeDescriptionLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Name = "Form1";
            this.Text = "Cars";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label makeDescriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Label yearResultLabel;
        private System.Windows.Forms.Label speedResultLabel;
        private System.Windows.Forms.Label makeResultLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label speedResultDescriptionLabel;
        private System.Windows.Forms.Label makeResultDescriptionLabel;
        private System.Windows.Forms.Label yearResultDescriptionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterButton;
    }
}

