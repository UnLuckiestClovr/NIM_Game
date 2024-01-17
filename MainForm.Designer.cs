namespace NIM_Game
{
    partial class MainForm
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
            this.TextBoxGroup = new System.Windows.Forms.GroupBox();
            this.DialogueLabel = new System.Windows.Forms.Label();
            this.OptionBTN3 = new System.Windows.Forms.Button();
            this.OptionBTN1 = new System.Windows.Forms.Button();
            this.OptionBTN4 = new System.Windows.Forms.Button();
            this.OptionBTN2 = new System.Windows.Forms.Button();
            this.TextBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGroup
            // 
            this.TextBoxGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxGroup.Controls.Add(this.DialogueLabel);
            this.TextBoxGroup.Controls.Add(this.OptionBTN3);
            this.TextBoxGroup.Controls.Add(this.OptionBTN1);
            this.TextBoxGroup.Controls.Add(this.OptionBTN4);
            this.TextBoxGroup.Controls.Add(this.OptionBTN2);
            this.TextBoxGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxGroup.Location = new System.Drawing.Point(12, 712);
            this.TextBoxGroup.Name = "TextBoxGroup";
            this.TextBoxGroup.Size = new System.Drawing.Size(1644, 294);
            this.TextBoxGroup.TabIndex = 0;
            this.TextBoxGroup.TabStop = false;
            // 
            // DialogueLabel
            // 
            this.DialogueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogueLabel.AutoSize = true;
            this.DialogueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DialogueLabel.Location = new System.Drawing.Point(45, 18);
            this.DialogueLabel.MinimumSize = new System.Drawing.Size(1550, 130);
            this.DialogueLabel.Name = "DialogueLabel";
            this.DialogueLabel.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.DialogueLabel.Size = new System.Drawing.Size(1550, 130);
            this.DialogueLabel.TabIndex = 4;
            this.DialogueLabel.Text = "DIALOGUE GOES HERE";
            // 
            // OptionBTN3
            // 
            this.OptionBTN3.BackColor = System.Drawing.Color.Black;
            this.OptionBTN3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN3.Location = new System.Drawing.Point(849, 171);
            this.OptionBTN3.Name = "OptionBTN3";
            this.OptionBTN3.Size = new System.Drawing.Size(746, 49);
            this.OptionBTN3.TabIndex = 3;
            this.OptionBTN3.Text = "Option 3";
            this.OptionBTN3.UseVisualStyleBackColor = false;
            this.OptionBTN3.Click += new System.EventHandler(this.OptionBTN2_Click);
            // 
            // OptionBTN1
            // 
            this.OptionBTN1.BackColor = System.Drawing.Color.Black;
            this.OptionBTN1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN1.Location = new System.Drawing.Point(48, 171);
            this.OptionBTN1.Name = "OptionBTN1";
            this.OptionBTN1.Size = new System.Drawing.Size(767, 49);
            this.OptionBTN1.TabIndex = 2;
            this.OptionBTN1.Text = " Option 1";
            this.OptionBTN1.UseVisualStyleBackColor = false;
            this.OptionBTN1.Click += new System.EventHandler(this.OptionBTN1_Click);
            // 
            // OptionBTN4
            // 
            this.OptionBTN4.BackColor = System.Drawing.Color.Black;
            this.OptionBTN4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN4.Location = new System.Drawing.Point(849, 226);
            this.OptionBTN4.Name = "OptionBTN4";
            this.OptionBTN4.Size = new System.Drawing.Size(746, 49);
            this.OptionBTN4.TabIndex = 1;
            this.OptionBTN4.Text = "Option 4";
            this.OptionBTN4.UseVisualStyleBackColor = false;
            // 
            // OptionBTN2
            // 
            this.OptionBTN2.BackColor = System.Drawing.Color.Black;
            this.OptionBTN2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN2.Location = new System.Drawing.Point(48, 226);
            this.OptionBTN2.Name = "OptionBTN2";
            this.OptionBTN2.Size = new System.Drawing.Size(767, 49);
            this.OptionBTN2.TabIndex = 0;
            this.OptionBTN2.Text = " Option 2";
            this.OptionBTN2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1668, 1018);
            this.Controls.Add(this.TextBoxGroup);
            this.Name = "MainForm";
            this.Text = "NIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextBoxGroup.ResumeLayout(false);
            this.TextBoxGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TextBoxGroup;
        private System.Windows.Forms.Button OptionBTN2;
        private System.Windows.Forms.Button OptionBTN3;
        private System.Windows.Forms.Button OptionBTN1;
        private System.Windows.Forms.Button OptionBTN4;
        private System.Windows.Forms.Label DialogueLabel;
    }
}

