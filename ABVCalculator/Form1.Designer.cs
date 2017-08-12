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
            this.ogLabel = new System.Windows.Forms.Label();
            this.ogInput = new System.Windows.Forms.TextBox();
            this.fgLabel = new System.Windows.Forms.Label();
            this.fgInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abvOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.ABVInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ogLabel
            // 
            this.ogLabel.AutoSize = true;
            this.ogLabel.Location = new System.Drawing.Point(13, 13);
            this.ogLabel.Name = "ogLabel";
            this.ogLabel.Size = new System.Drawing.Size(78, 13);
            this.ogLabel.TabIndex = 0;
            this.ogLabel.Tag = "Original Gravity";
            this.ogLabel.Text = "Original Gravity";
            // 
            // ogInput
            // 
            this.ogInput.Location = new System.Drawing.Point(16, 30);
            this.ogInput.Name = "ogInput";
            this.ogInput.Size = new System.Drawing.Size(100, 20);
            this.ogInput.TabIndex = 1;
            this.ogInput.Tag = "ogInput";
            // 
            // fgLabel
            // 
            this.fgLabel.AutoSize = true;
            this.fgLabel.Location = new System.Drawing.Point(13, 69);
            this.fgLabel.Name = "fgLabel";
            this.fgLabel.Size = new System.Drawing.Size(65, 13);
            this.fgLabel.TabIndex = 2;
            this.fgLabel.Text = "Final Gravity";
            // 
            // fgInput
            // 
            this.fgInput.Location = new System.Drawing.Point(16, 86);
            this.fgInput.Name = "fgInput";
            this.fgInput.Size = new System.Drawing.Size(100, 20);
            this.fgInput.TabIndex = 3;
            this.fgInput.Tag = "fgInput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results";
            // 
            // abvOutput
            // 
            this.abvOutput.Location = new System.Drawing.Point(13, 169);
            this.abvOutput.Name = "abvOutput";
            this.abvOutput.Size = new System.Drawing.Size(35, 20);
            this.abvOutput.TabIndex = 5;
            this.abvOutput.Tag = "abvOutput";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% ABV";
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.Location = new System.Drawing.Point(16, 113);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(75, 23);
            this.calcTotalButton.TabIndex = 7;
            this.calcTotalButton.Text = "Find ABV";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            this.calcTotalButton.Click += new System.EventHandler(this.calcTotalButton_Click);
            // 
            // ABVInfo
            // 
            this.ABVInfo.Location = new System.Drawing.Point(150, 30);
            this.ABVInfo.Name = "ABVInfo";
            this.ABVInfo.Size = new System.Drawing.Size(141, 162);
            this.ABVInfo.TabIndex = 8;
            this.ABVInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 204);
            this.Controls.Add(this.ABVInfo);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abvOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fgInput);
            this.Controls.Add(this.fgLabel);
            this.Controls.Add(this.ogInput);
            this.Controls.Add(this.ogLabel);
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
        private System.Windows.Forms.Panel ABVInfo;
        private System.Windows.Forms.Label ogLabel;
    }
}

