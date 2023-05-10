namespace kalkulator
{
    partial class calculator
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
            txtTotal = new TextBox();
            btnClear = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnMinus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(394, 85);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(12, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 64);
            btnClear.TabIndex = 1;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(112, 103);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 64);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMulti.Location = new Point(212, 103);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(94, 64);
            btnMulti.TabIndex = 3;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(312, 103);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 64);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(12, 173);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 64);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(112, 173);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 64);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(212, 173);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 64);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(312, 173);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 64);
            btnPlus.TabIndex = 8;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 243);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 64);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(112, 243);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 64);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(212, 243);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 64);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(312, 243);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(94, 204);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 313);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 64);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button13_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(112, 313);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 64);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(212, 313);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 64);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(12, 383);
            btn0.Name = "btn0";
            btn0.Size = new Size(294, 64);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(413, 454);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMinus);
            Controls.Add(btnMulti);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(txtTotal);
            Name = "calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnMinus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
    }
}