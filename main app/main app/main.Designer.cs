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
            btnBreakOut = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(56, 157);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(250, 30);
            btnCalculator.TabIndex = 0;
            btnCalculator.Text = "Kalkulator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnForm2_Click;
            // 
            // btnBreakOut
            // 
            btnBreakOut.Location = new Point(449, 157);
            btnBreakOut.Name = "btnBreakOut";
            btnBreakOut.Size = new Size(250, 30);
            btnBreakOut.TabIndex = 1;
            btnBreakOut.Text = "Break Out";
            btnBreakOut.UseVisualStyleBackColor = true;
            btnBreakOut.Click += btnBreakOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 45);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 2;
            label1.Text = "Dariusz Walda";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 113);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 3;
            label2.Text = "Aplikacje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(548, 113);
            label3.Name = "label3";
            label3.Size = new Size(49, 31);
            label3.TabIndex = 3;
            label3.Text = "Gry";
            label3.Click += label3_Click;
            // 
            // mainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 453);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBreakOut);
            Controls.Add(btnCalculator);
            Name = "mainApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Paint += mainApp_paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculator;
        private Button btnBreakOut;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}