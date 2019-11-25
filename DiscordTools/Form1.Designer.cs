namespace DiscordTools
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
            this.emojiButton = new System.Windows.Forms.Button();
            this.spoilerButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emojiButton
            // 
            this.emojiButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiButton.Location = new System.Drawing.Point(12, 12);
            this.emojiButton.Name = "emojiButton";
            this.emojiButton.Size = new System.Drawing.Size(221, 23);
            this.emojiButton.TabIndex = 0;
            this.emojiButton.Text = "Convert text to emoji";
            this.emojiButton.UseVisualStyleBackColor = true;
            this.emojiButton.Click += new System.EventHandler(this.emojiButton_Click);
            // 
            // spoilerButton
            // 
            this.spoilerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spoilerButton.Location = new System.Drawing.Point(12, 41);
            this.spoilerButton.Name = "spoilerButton";
            this.spoilerButton.Size = new System.Drawing.Size(221, 23);
            this.spoilerButton.TabIndex = 1;
            this.spoilerButton.Text = "Convert text to spoilers";
            this.spoilerButton.UseVisualStyleBackColor = true;
            this.spoilerButton.Click += new System.EventHandler(this.spoilerButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontButton.Location = new System.Drawing.Point(12, 70);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(221, 23);
            this.fontButton.TabIndex = 2;
            this.fontButton.Text = "Convert text to font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 105);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.spoilerButton);
            this.Controls.Add(this.emojiButton);
            this.MaximumSize = new System.Drawing.Size(261, 144);
            this.MinimumSize = new System.Drawing.Size(261, 144);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Discord Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emojiButton;
        private System.Windows.Forms.Button spoilerButton;
        private System.Windows.Forms.Button fontButton;
    }
}

