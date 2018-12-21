namespace Text_Replacer
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
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.labelOldText = new System.Windows.Forms.Label();
            this.textBoxOldText = new System.Windows.Forms.TextBox();
            this.labelNewText = new System.Windows.Forms.Label();
            this.textBoxNewText = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxDrop = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.AutoSize = true;
            this.labelOutputDir.Location = new System.Drawing.Point(13, 13);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(84, 13);
            this.labelOutputDir.TabIndex = 0;
            this.labelOutputDir.Text = "Output Directory";
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Location = new System.Drawing.Point(13, 30);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.Size = new System.Drawing.Size(775, 20);
            this.textBoxOutputDir.TabIndex = 1;
            // 
            // labelOldText
            // 
            this.labelOldText.AutoSize = true;
            this.labelOldText.Location = new System.Drawing.Point(13, 57);
            this.labelOldText.Name = "labelOldText";
            this.labelOldText.Size = new System.Drawing.Size(47, 13);
            this.labelOldText.TabIndex = 2;
            this.labelOldText.Text = "Old Text";
            // 
            // textBoxOldText
            // 
            this.textBoxOldText.Location = new System.Drawing.Point(13, 74);
            this.textBoxOldText.Multiline = true;
            this.textBoxOldText.Name = "textBoxOldText";
            this.textBoxOldText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOldText.Size = new System.Drawing.Size(775, 20);
            this.textBoxOldText.TabIndex = 3;
            // 
            // labelNewText
            // 
            this.labelNewText.AutoSize = true;
            this.labelNewText.Location = new System.Drawing.Point(13, 101);
            this.labelNewText.Name = "labelNewText";
            this.labelNewText.Size = new System.Drawing.Size(53, 13);
            this.labelNewText.TabIndex = 4;
            this.labelNewText.Text = "New Text";
            // 
            // textBoxNewText
            // 
            this.textBoxNewText.Location = new System.Drawing.Point(13, 118);
            this.textBoxNewText.Multiline = true;
            this.textBoxNewText.Name = "textBoxNewText";
            this.textBoxNewText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNewText.Size = new System.Drawing.Size(775, 20);
            this.textBoxNewText.TabIndex = 5;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(13, 145);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Input";
            // 
            // textBoxDrop
            // 
            this.textBoxDrop.AllowDrop = true;
            this.textBoxDrop.Location = new System.Drawing.Point(13, 162);
            this.textBoxDrop.Multiline = true;
            this.textBoxDrop.Name = "textBoxDrop";
            this.textBoxDrop.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDrop.Size = new System.Drawing.Size(775, 247);
            this.textBoxDrop.TabIndex = 7;
            this.textBoxDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxDrop_DragDrop);
            this.textBoxDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxDrop_DragEnter);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(772, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 8;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Location = new System.Drawing.Point(336, 421);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(13, 13);
            this.labelProgressBar.TabIndex = 9;
            this.labelProgressBar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxDrop);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxNewText);
            this.Controls.Add(this.labelNewText);
            this.Controls.Add(this.textBoxOldText);
            this.Controls.Add(this.labelOldText);
            this.Controls.Add(this.textBoxOutputDir);
            this.Controls.Add(this.labelOutputDir);
            this.Name = "Form1";
            this.Text = "Text Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutputDir;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.Label labelOldText;
        private System.Windows.Forms.TextBox textBoxOldText;
        private System.Windows.Forms.Label labelNewText;
        private System.Windows.Forms.TextBox textBoxNewText;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxDrop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgressBar;
    }
}

