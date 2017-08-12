namespace ABVCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ogLabel = new System.Windows.Forms.Label();
            this.ogInput = new System.Windows.Forms.TextBox();
            this.fgLabel = new System.Windows.Forms.Label();
            this.fgInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abvOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ogLabel
            // 
            this.ogLabel.AutoSize = true;
            this.ogLabel.Location = new System.Drawing.Point(26, 25);
            this.ogLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ogLabel.Name = "ogLabel";
            this.ogLabel.Size = new System.Drawing.Size(160, 25);
            this.ogLabel.TabIndex = 0;
            this.ogLabel.Tag = "Original Gravity";
            this.ogLabel.Text = "Original Gravity";
            // 
            // ogInput
            // 
            this.ogInput.Location = new System.Drawing.Point(32, 58);
            this.ogInput.Margin = new System.Windows.Forms.Padding(6);
            this.ogInput.Name = "ogInput";
            this.ogInput.Size = new System.Drawing.Size(154, 31);
            this.ogInput.TabIndex = 1;
            this.ogInput.Tag = "ogInput";
            // 
            // fgLabel
            // 
            this.fgLabel.AutoSize = true;
            this.fgLabel.Location = new System.Drawing.Point(26, 133);
            this.fgLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fgLabel.Name = "fgLabel";
            this.fgLabel.Size = new System.Drawing.Size(133, 25);
            this.fgLabel.TabIndex = 2;
            this.fgLabel.Text = "Final Gravity";
            // 
            // fgInput
            // 
            this.fgInput.Location = new System.Drawing.Point(32, 165);
            this.fgInput.Margin = new System.Windows.Forms.Padding(6);
            this.fgInput.Name = "fgInput";
            this.fgInput.Size = new System.Drawing.Size(154, 31);
            this.fgInput.TabIndex = 3;
            this.fgInput.Tag = "fgInput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results";
            // 
            // abvOutput
            // 
            this.abvOutput.Location = new System.Drawing.Point(32, 312);
            this.abvOutput.Margin = new System.Windows.Forms.Padding(6);
            this.abvOutput.Name = "abvOutput";
            this.abvOutput.ReadOnly = true;
            this.abvOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.abvOutput.Size = new System.Drawing.Size(63, 31);
            this.abvOutput.TabIndex = 5;
            this.abvOutput.Tag = "abvOutput";
            this.abvOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "% ABV";
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.Location = new System.Drawing.Point(31, 217);
            this.calcTotalButton.Margin = new System.Windows.Forms.Padding(6);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(155, 44);
            this.calcTotalButton.TabIndex = 7;
            this.calcTotalButton.Text = "Find ABV";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            this.calcTotalButton.Click += new System.EventHandler(this.calcTotalButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionBox.Location = new System.Drawing.Point(208, 25);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(355, 315);
            this.descriptionBox.TabIndex = 8;
            this.descriptionBox.Tag = "descriptionBox";
            this.descriptionBox.Text = resources.GetString("descriptionBox.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 359);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abvOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fgInput);
            this.Controls.Add(this.fgLabel);
            this.Controls.Add(this.ogInput);
            this.Controls.Add(this.ogLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "ABV Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ogInput;
        private System.Windows.Forms.Label fgLabel;
        private System.Windows.Forms.TextBox fgInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abvOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.Label ogLabel;
        private System.Windows.Forms.RichTextBox descriptionBox;
    }
}

