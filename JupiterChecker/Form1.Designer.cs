namespace clickerBlum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            stopButton = new Button();
            alignButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 65);
            startButton.Name = "startButton";
            startButton.Size = new Size(182, 51);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(12, 121);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(182, 25);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // alignButton
            // 
            alignButton.Location = new Point(12, 12);
            alignButton.Name = "alignButton";
            alignButton.Size = new Size(182, 23);
            alignButton.TabIndex = 2;
            alignButton.Text = "Align Window";
            alignButton.UseVisualStyleBackColor = true;
            alignButton.Click += alignButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Autoplay";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 158);
            Controls.Add(checkBox1);
            Controls.Add(alignButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Blum Clicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button stopButton;
        private Button alignButton;
        private CheckBox checkBox1;
    }
}
