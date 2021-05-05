
namespace AmIPositive
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.Location = new System.Drawing.Point(45, 59);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(100, 23);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an Integer";
            this.integerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(151, 62);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 20);
            this.integerInput.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Black;
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(109, 134);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(89, 26);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.Location = new System.Drawing.Point(63, 190);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(188, 26);
            this.outputLabel1.TabIndex = 3;
            // 
            // outputLabel2
            // 
            this.outputLabel2.Location = new System.Drawing.Point(63, 239);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(188, 26);
            this.outputLabel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 292);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "Am I Positive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
    }
}

