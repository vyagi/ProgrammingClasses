﻿namespace BasicApp
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
            this.startButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessNumberLabel = new System.Windows.Forms.Label();
            this.guessHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "New game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(13, 42);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(35, 13);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "label1";
            // 
            // guessInput
            // 
            this.guessInput.Enabled = false;
            this.guessInput.Location = new System.Drawing.Point(16, 71);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(100, 20);
            this.guessInput.TabIndex = 2;
            this.guessInput.TextChanged += new System.EventHandler(this.guessInput_TextChanged);
            // 
            // guessButton
            // 
            this.guessButton.Enabled = false;
            this.guessButton.Location = new System.Drawing.Point(133, 69);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // guessNumberLabel
            // 
            this.guessNumberLabel.AutoSize = true;
            this.guessNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessNumberLabel.Location = new System.Drawing.Point(221, 13);
            this.guessNumberLabel.Name = "guessNumberLabel";
            this.guessNumberLabel.Size = new System.Drawing.Size(70, 76);
            this.guessNumberLabel.TabIndex = 4;
            this.guessNumberLabel.Text = "0";
            // 
            // guessHistory
            // 
            this.guessHistory.FormattingEnabled = true;
            this.guessHistory.Location = new System.Drawing.Point(16, 110);
            this.guessHistory.Name = "guessHistory";
            this.guessHistory.Size = new System.Drawing.Size(275, 173);
            this.guessHistory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 294);
            this.Controls.Add(this.guessHistory);
            this.Controls.Add(this.guessNumberLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Guess a number game !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label guessNumberLabel;
        private System.Windows.Forms.ListBox guessHistory;
    }
}

