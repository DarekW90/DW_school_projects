namespace main_app
{
    partial class BreakOut
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
            components = new System.ComponentModel.Container();
            txtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(18, 17);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(101, 31);
            txtScore.TabIndex = 0;
            txtScore.Text = "Pnkty: 0";
            // 
            // player
            // 
            player.BackColor = Color.LightGray;
            player.Location = new Point(350, 546);
            player.Name = "player";
            player.Size = new Size(100, 31);
            player.TabIndex = 1;
            player.TabStop = false;
            player.Tag = "player";
            // 
            // ball
            // 
            ball.BackColor = Color.Coral;
            ball.Location = new Point(380, 335);
            ball.Name = "ball";
            ball.Size = new Size(20, 20);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 25;
            gameTimer.Tick += gameTimerEvent;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Lime;
            buttonStart.Cursor = Cursors.Hand;
            buttonStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(317, 235);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(148, 70);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click_1;
            // 
            // BreakOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(811, 589);
            Controls.Add(buttonStart);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtScore);
            Name = "BreakOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BreakOut";
            Load += BreakOut_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox player;
        private PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private Button buttonStart;
    }
}