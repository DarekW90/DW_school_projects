﻿namespace main_app
{
    partial class photoGalery
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
            animationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // animationTimer
            // 
            animationTimer.Enabled = true;
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimeEvent;
            // 
            // photoGalery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            Name = "photoGalery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "photoGalery";
            Paint += FormPaintEvent;
            KeyUp += KeyIsUp;
            MouseDown += FormMouseDown;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer animationTimer;
    }
}