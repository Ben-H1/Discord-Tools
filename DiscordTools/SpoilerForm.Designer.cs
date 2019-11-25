﻿namespace DiscordTools
{
    partial class SpoilerForm
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
            this.copyButton = new System.Windows.Forms.Button();
            this.convertedBox = new System.Windows.Forms.TextBox();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.originalBox = new System.Windows.Forms.TextBox();
            this.originalLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(12, 306);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(260, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // convertedBox
            // 
            this.convertedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertedBox.Location = new System.Drawing.Point(12, 200);
            this.convertedBox.Multiline = true;
            this.convertedBox.Name = "convertedBox";
            this.convertedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.convertedBox.Size = new System.Drawing.Size(260, 100);
            this.convertedBox.TabIndex = 4;
            // 
            // convertedLabel
            // 
            this.convertedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(12, 184);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(76, 13);
            this.convertedLabel.TabIndex = 9;
            this.convertedLabel.Text = "Converted text";
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Location = new System.Drawing.Point(12, 158);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(260, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert to spoilers";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // originalBox
            // 
            this.originalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalBox.Location = new System.Drawing.Point(12, 52);
            this.originalBox.Multiline = true;
            this.originalBox.Name = "originalBox";
            this.originalBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalBox.Size = new System.Drawing.Size(260, 100);
            this.originalBox.TabIndex = 2;
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(12, 36);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(79, 13);
            this.originalLabel.TabIndex = 6;
            this.originalLabel.Text = "Text to convert";
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(12, 15);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(44, 13);
            this.choiceLabel.TabIndex = 12;
            this.choiceLabel.Text = "Convert";
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "each letter",
            "each word"});
            this.choiceComboBox.Location = new System.Drawing.Point(62, 12);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(210, 21);
            this.choiceComboBox.TabIndex = 1;
            this.choiceComboBox.Text = "each letter";
            // 
            // SpoilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.choiceComboBox);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertedBox);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.originalBox);
            this.Controls.Add(this.originalLabel);
            this.Name = "SpoilerForm";
            this.Text = "Text to Spoilers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox convertedBox;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox originalBox;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.ComboBox choiceComboBox;
    }
}