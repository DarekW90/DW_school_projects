namespace main_app
{
    partial class mainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculator = new Button();
            SuspendLayout();
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(118, 81);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(498, 29);
            btnCalculator.TabIndex = 0;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnForm2_Click;
            // 
            // mainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculator);
            Name = "mainApp";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculator;
    }
}