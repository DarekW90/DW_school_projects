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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
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
            player.Location = new Point(463, 546);
            player.Name = "player";
            player.Size = new Size(100, 31);
            player.TabIndex = 1;
            player.TabStop = false;
            player.Tag = "player";
            // 
            // ball
            // 
            ball.BackColor = Color.Coral;
            ball.Location = new Point(508, 442);
            ball.Name = "ball";
            ball.Size = new Size(20, 20);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.Location = new Point(162, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 31);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "blocks";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightGray;
            pictureBox4.Location = new Point(313, 64);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 31);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "blocks";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightGray;
            pictureBox5.Location = new Point(463, 64);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 31);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "blocks";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.LightGray;
            pictureBox6.Location = new Point(610, 64);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 31);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "blocks";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.LightGray;
            pictureBox7.Location = new Point(757, 64);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 31);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "blocks";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.LightGray;
            pictureBox8.Location = new Point(162, 113);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 31);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "blocks";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.LightGray;
            pictureBox9.Location = new Point(313, 113);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 31);
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "blocks";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.LightGray;
            pictureBox10.Location = new Point(463, 113);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 31);
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "blocks";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.LightGray;
            pictureBox11.Location = new Point(610, 113);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 31);
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "blocks";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.LightGray;
            pictureBox12.Location = new Point(757, 113);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 31);
            pictureBox12.TabIndex = 1;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "blocks";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.LightGray;
            pictureBox13.Location = new Point(162, 161);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 31);
            pictureBox13.TabIndex = 1;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "blocks";
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.LightGray;
            pictureBox14.Location = new Point(313, 161);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 31);
            pictureBox14.TabIndex = 1;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "blocks";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.LightGray;
            pictureBox15.Location = new Point(463, 161);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(100, 31);
            pictureBox15.TabIndex = 1;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "blocks";
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.LightGray;
            pictureBox16.Location = new Point(610, 161);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(100, 31);
            pictureBox16.TabIndex = 1;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "blocks";
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.LightGray;
            pictureBox17.Location = new Point(757, 161);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(100, 31);
            pictureBox17.TabIndex = 1;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "blocks";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 25;
            gameTimer.Tick += gameTimerEvent;
            // 
            // BreakOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1012, 589);
            Controls.Add(ball);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox player;
        private PictureBox ball;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private System.Windows.Forms.Timer gameTimer;
    }
}