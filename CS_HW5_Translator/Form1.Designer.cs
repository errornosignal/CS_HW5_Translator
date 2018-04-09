namespace CS_HW5_Translator
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
            this.ToTranslateRTB = new System.Windows.Forms.RichTextBox();
            this.PigLatinRB = new System.Windows.Forms.RadioButton();
            this.PigGreekRB = new System.Windows.Forms.RadioButton();
            this.TranslatedRTB = new System.Windows.Forms.RichTextBox();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ToTranslateLabel = new System.Windows.Forms.Label();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToTranslateRTB
            // 
            this.ToTranslateRTB.Location = new System.Drawing.Point(15, 34);
            this.ToTranslateRTB.Name = "ToTranslateRTB";
            this.ToTranslateRTB.Size = new System.Drawing.Size(271, 115);
            this.ToTranslateRTB.TabIndex = 0;
            this.ToTranslateRTB.Text = "";
            // 
            // PigLatinRB
            // 
            this.PigLatinRB.AutoSize = true;
            this.PigLatinRB.Location = new System.Drawing.Point(15, 164);
            this.PigLatinRB.Name = "PigLatinRB";
            this.PigLatinRB.Size = new System.Drawing.Size(66, 17);
            this.PigLatinRB.TabIndex = 1;
            this.PigLatinRB.TabStop = true;
            this.PigLatinRB.Text = "Pig Latin";
            this.PigLatinRB.UseVisualStyleBackColor = true;
            // 
            // PigGreekRB
            // 
            this.PigGreekRB.AutoSize = true;
            this.PigGreekRB.Location = new System.Drawing.Point(106, 164);
            this.PigGreekRB.Name = "PigGreekRB";
            this.PigGreekRB.Size = new System.Drawing.Size(72, 17);
            this.PigGreekRB.TabIndex = 2;
            this.PigGreekRB.TabStop = true;
            this.PigGreekRB.Text = "Pig Greek";
            this.PigGreekRB.UseVisualStyleBackColor = true;
            // 
            // TranslatedRTB
            // 
            this.TranslatedRTB.Location = new System.Drawing.Point(15, 211);
            this.TranslatedRTB.Name = "TranslatedRTB";
            this.TranslatedRTB.ReadOnly = true;
            this.TranslatedRTB.Size = new System.Drawing.Size(271, 130);
            this.TranslatedRTB.TabIndex = 3;
            this.TranslatedRTB.Text = "";
            // 
            // TranslateButton
            // 
            this.TranslateButton.Location = new System.Drawing.Point(15, 360);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(75, 23);
            this.TranslateButton.TabIndex = 4;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(96, 360);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(211, 360);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ToTranslateLabel
            // 
            this.ToTranslateLabel.AutoSize = true;
            this.ToTranslateLabel.Location = new System.Drawing.Point(12, 18);
            this.ToTranslateLabel.Name = "ToTranslateLabel";
            this.ToTranslateLabel.Size = new System.Drawing.Size(122, 13);
            this.ToTranslateLabel.TabIndex = 7;
            this.ToTranslateLabel.Text = "Enter English Text Here:";
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.AutoSize = true;
            this.TranslationLabel.Location = new System.Drawing.Point(12, 195);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(62, 13);
            this.TranslationLabel.TabIndex = 8;
            this.TranslationLabel.Text = "Translation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(303, 401);
            this.Controls.Add(this.TranslationLabel);
            this.Controls.Add(this.ToTranslateLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.TranslatedRTB);
            this.Controls.Add(this.PigGreekRB);
            this.Controls.Add(this.PigLatinRB);
            this.Controls.Add(this.ToTranslateRTB);
            this.Name = "Form1";
            this.Text = "Pig Latin & Greek Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ToTranslateRTB;
        private System.Windows.Forms.RadioButton PigLatinRB;
        private System.Windows.Forms.RadioButton PigGreekRB;
        private System.Windows.Forms.RichTextBox TranslatedRTB;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ToTranslateLabel;
        private System.Windows.Forms.Label TranslationLabel;
    }
}

