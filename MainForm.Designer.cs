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
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OptionBTN2 = new System.Windows.Forms.Button();
            this.OptionBTN4 = new System.Windows.Forms.Button();
            this.OptionsTopRow = new System.Windows.Forms.Panel();
            this.OptionBTN3 = new System.Windows.Forms.Button();
            this.OptionBTN1 = new System.Windows.Forms.Button();
            this.DialogueLabel = new System.Windows.Forms.Label();
            this.TextBoxGroup.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.OptionsTopRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGroup
            // 
            this.TextBoxGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextBoxGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxGroup.Controls.Add(this.ButtonContainer);
            this.TextBoxGroup.Controls.Add(this.DialogueLabel);
            this.TextBoxGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxGroup.Location = new System.Drawing.Point(0, 638);
            this.TextBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxGroup.Name = "TextBoxGroup";
            this.TextBoxGroup.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.TextBoxGroup.Size = new System.Drawing.Size(1516, 294);
            this.TextBoxGroup.TabIndex = 0;
            this.TextBoxGroup.TabStop = false;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.panel3);
            this.ButtonContainer.Controls.Add(this.OptionsTopRow);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainer.Location = new System.Drawing.Point(8, 158);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(1500, 128);
            this.ButtonContainer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OptionBTN2);
            this.panel3.Controls.Add(this.OptionBTN4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel3.Size = new System.Drawing.Size(1500, 64);
            this.panel3.TabIndex = 5;
            // 
            // OptionBTN2
            // 
            this.OptionBTN2.AutoSize = true;
            this.OptionBTN2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionBTN2.BackColor = System.Drawing.Color.Black;
            this.OptionBTN2.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionBTN2.Font = new System.Drawing.Font("Bauhaus 93", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBTN2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN2.Location = new System.Drawing.Point(8, 0);
            this.OptionBTN2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionBTN2.MinimumSize = new System.Drawing.Size(490, 0);
            this.OptionBTN2.Name = "OptionBTN2";
            this.OptionBTN2.Size = new System.Drawing.Size(490, 64);
            this.OptionBTN2.TabIndex = 0;
            this.OptionBTN2.Text = " Option 2";
            this.OptionBTN2.UseVisualStyleBackColor = false;
            this.OptionBTN2.Click += new System.EventHandler(this.OptionBTN2_Click);
            // 
            // OptionBTN4
            // 
            this.OptionBTN4.AutoSize = true;
            this.OptionBTN4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionBTN4.BackColor = System.Drawing.Color.Black;
            this.OptionBTN4.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionBTN4.Font = new System.Drawing.Font("Bauhaus 93", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBTN4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN4.Location = new System.Drawing.Point(1002, 0);
            this.OptionBTN4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionBTN4.MinimumSize = new System.Drawing.Size(490, 0);
            this.OptionBTN4.Name = "OptionBTN4";
            this.OptionBTN4.Size = new System.Drawing.Size(490, 64);
            this.OptionBTN4.TabIndex = 1;
            this.OptionBTN4.Text = "Option 4";
            this.OptionBTN4.UseVisualStyleBackColor = false;
            this.OptionBTN4.Click += new System.EventHandler(this.OptionBTN4_Click);
            // 
            // OptionsTopRow
            // 
            this.OptionsTopRow.Controls.Add(this.OptionBTN3);
            this.OptionsTopRow.Controls.Add(this.OptionBTN1);
            this.OptionsTopRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsTopRow.Location = new System.Drawing.Point(0, 0);
            this.OptionsTopRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsTopRow.Name = "OptionsTopRow";
            this.OptionsTopRow.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OptionsTopRow.Size = new System.Drawing.Size(1500, 61);
            this.OptionsTopRow.TabIndex = 4;
            // 
            // OptionBTN3
            // 
            this.OptionBTN3.AutoSize = true;
            this.OptionBTN3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionBTN3.BackColor = System.Drawing.Color.Black;
            this.OptionBTN3.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionBTN3.Font = new System.Drawing.Font("Bauhaus 93", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBTN3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN3.Location = new System.Drawing.Point(1002, 0);
            this.OptionBTN3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionBTN3.MinimumSize = new System.Drawing.Size(490, 0);
            this.OptionBTN3.Name = "OptionBTN3";
            this.OptionBTN3.Size = new System.Drawing.Size(490, 61);
            this.OptionBTN3.TabIndex = 3;
            this.OptionBTN3.Text = "Option 3";
            this.OptionBTN3.UseVisualStyleBackColor = false;
            this.OptionBTN3.Click += new System.EventHandler(this.OptionBTN3_Click);
            // 
            // OptionBTN1
            // 
            this.OptionBTN1.AutoSize = true;
            this.OptionBTN1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionBTN1.BackColor = System.Drawing.Color.Black;
            this.OptionBTN1.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionBTN1.Font = new System.Drawing.Font("Bauhaus 93", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionBTN1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionBTN1.Location = new System.Drawing.Point(8, 0);
            this.OptionBTN1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionBTN1.MinimumSize = new System.Drawing.Size(490, 0);
            this.OptionBTN1.Name = "OptionBTN1";
            this.OptionBTN1.Size = new System.Drawing.Size(490, 61);
            this.OptionBTN1.TabIndex = 2;
            this.OptionBTN1.Text = " Option 1";
            this.OptionBTN1.UseVisualStyleBackColor = false;
            this.OptionBTN1.Click += new System.EventHandler(this.OptionBTN1_Click);
            // 
            // DialogueLabel
            // 
            this.DialogueLabel.AutoEllipsis = true;
            this.DialogueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DialogueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DialogueLabel.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogueLabel.Location = new System.Drawing.Point(8, 27);
            this.DialogueLabel.MinimumSize = new System.Drawing.Size(1024, 130);
            this.DialogueLabel.Name = "DialogueLabel";
            this.DialogueLabel.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.DialogueLabel.Size = new System.Drawing.Size(1500, 130);
            this.DialogueLabel.TabIndex = 4;
            this.DialogueLabel.Text = "DIALOGUE GOES HERE";
            this.DialogueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NIM_Game.Properties.Resources.hallwaylvl2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1516, 932);
            this.Controls.Add(this.TextBoxGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1059, 977);
            this.Name = "MainForm";
            this.Text = "NIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TextBoxGroup.ResumeLayout(false);
            this.ButtonContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.OptionsTopRow.ResumeLayout(false);
            this.OptionsTopRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TextBoxGroup;
        private System.Windows.Forms.Button OptionBTN2;
        private System.Windows.Forms.Button OptionBTN3;
        private System.Windows.Forms.Button OptionBTN1;
        private System.Windows.Forms.Button OptionBTN4;
        private System.Windows.Forms.Label DialogueLabel;
        private System.Windows.Forms.Panel ButtonContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel OptionsTopRow;
    }
}

