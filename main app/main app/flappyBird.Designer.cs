namespace main_app
{
    partial class flappyBird
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
            ground = new PictureBox();
            fBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pipeSpeedtxt = new Label();
            gameOverInfo = new Label();
            sumMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-1, 735);
            ground.Name = "ground";
            ground.Size = new Size(837, 62);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            ground.Click += ground_Click;
            // 
            // fBird
            // 
            fBird.Image = Properties.Resources.bird;
            fBird.Location = new Point(76, 292);
            fBird.Name = "fBird";
            fBird.Size = new Size(79, 64);
            fBird.SizeMode = PictureBoxSizeMode.StretchImage;
            fBird.TabIndex = 1;
            fBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(436, 12);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(125, 238);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 2;
            pipeTop.TabStop = false;
            pipeTop.Click += pipeTop_Click;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(502, 530);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(125, 208);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 3;
            pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Pink;
            scoreText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            scoreText.Location = new Point(-1, 751);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(156, 46);
            scoreText.TabIndex = 4;
            scoreText.Text = "Punkty: 0";
            scoreText.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // pipeSpeedtxt
            // 
            pipeSpeedtxt.AutoSize = true;
            pipeSpeedtxt.BackColor = Color.Pink;
            pipeSpeedtxt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pipeSpeedtxt.Location = new Point(436, 751);
            pipeSpeedtxt.Name = "pipeSpeedtxt";
            pipeSpeedtxt.Size = new Size(148, 46);
            pipeSpeedtxt.TabIndex = 6;
            pipeSpeedtxt.Text = "Speed: 0";
            pipeSpeedtxt.Click += pipeSpeedtxt_Click;
            // 
            // gameOverInfo
            // 
            gameOverInfo.AutoSize = true;
            gameOverInfo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gameOverInfo.Location = new Point(176, 318);
            gameOverInfo.Name = "gameOverInfo";
            gameOverInfo.Size = new Size(0, 29);
            gameOverInfo.TabIndex = 7;
            // 
            // sumMsg
            // 
            sumMsg.AutoSize = true;
            sumMsg.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sumMsg.Location = new Point(176, 368);
            sumMsg.Name = "sumMsg";
            sumMsg.Size = new Size(0, 29);
            sumMsg.TabIndex = 8;
            // 
            // flappyBird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(698, 795);
            Controls.Add(sumMsg);
            Controls.Add(gameOverInfo);
            Controls.Add(scoreText);
            Controls.Add(fBird);
            Controls.Add(pipeSpeedtxt);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Name = "flappyBird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "flappyBird";
            Load += flappyBird_Load;
            KeyDown += gameKeyIsDown;
            KeyUp += gameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)fBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox fBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label pipeSpeedtxt;
        private Label gameOverInfo;
        private Label sumMsg;
    }
}