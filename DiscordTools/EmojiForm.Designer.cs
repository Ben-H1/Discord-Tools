namespace DiscordTools
{
    partial class EmojiForm
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
            this.originalLabel = new System.Windows.Forms.Label();
            this.originalBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertedBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(12, 9);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(79, 13);
            this.originalLabel.TabIndex = 0;
            this.originalLabel.Text = "Text to convert";
            // 
            // originalBox
            // 
            this.originalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalBox.Location = new System.Drawing.Point(12, 25);
            this.originalBox.Multiline = true;
            this.originalBox.Name = "originalBox";
            this.originalBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalBox.Size = new System.Drawing.Size(260, 100);
            this.originalBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Location = new System.Drawing.Point(12, 131);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(260, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert to emoji";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertedLabel
            // 
            this.convertedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(12, 157);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(76, 13);
            this.convertedLabel.TabIndex = 3;
            this.convertedLabel.Text = "Converted text";
            // 
            // convertedBox
            // 
            this.convertedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertedBox.Location = new System.Drawing.Point(12, 173);
            this.convertedBox.Multiline = true;
            this.convertedBox.Name = "convertedBox";
            this.convertedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.convertedBox.Size = new System.Drawing.Size(260, 100);
            this.convertedBox.TabIndex = 3;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(12, 279);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(260, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // EmojiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertedBox);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.originalBox);
            this.Controls.Add(this.originalLabel);
            this.Name = "EmojiForm";
            this.Text = "Text to Emoji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.TextBox originalBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.TextBox convertedBox;
        private System.Windows.Forms.Button copyButton;
    }
}