﻿namespace Camera_Simulator
{
    partial class MainScreenForm
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
            label1 = new Label();
            mainScreen = new RichTextBox();
            takeShot = new Button();
            autoMode = new Button();
            portraitMode = new Button();
            standardMode = new Button();
            modeInfo = new Label();
            offButton = new Button();
            standard = new Button();
            timerMode = new Button();
            pictureBox1 = new PictureBox();
            modeLabel = new TextBox();
            label2 = new Label();
            standardButton = new Button();
            galleryButton = new Button();
            videoRecording = new Button();
            videoMode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 80);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 0;
            label1.Text = "Camera Simulator";
            // 
            // mainScreen
            // 
            mainScreen.Location = new Point(131, 110);
            mainScreen.Name = "mainScreen";
            mainScreen.Size = new Size(709, 312);
            mainScreen.TabIndex = 1;
            mainScreen.Text = "";
            // 
            // takeShot
            // 
            takeShot.BackColor = Color.MediumPurple;
            takeShot.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeShot.Location = new Point(694, 122);
            takeShot.Name = "takeShot";
            takeShot.Size = new Size(134, 34);
            takeShot.TabIndex = 2;
            takeShot.Text = "Take a Shot";
            takeShot.UseVisualStyleBackColor = false;
            takeShot.Click += takeShot_Click;
            // 
            // autoMode
            // 
            autoMode.Location = new Point(145, 374);
            autoMode.Name = "autoMode";
            autoMode.Size = new Size(112, 34);
            autoMode.TabIndex = 3;
            autoMode.Text = "Auto Mode";
            autoMode.UseVisualStyleBackColor = true;
            autoMode.Click += autoMode_Click;
            // 
            // portraitMode
            // 
            portraitMode.Location = new Point(263, 374);
            portraitMode.Name = "portraitMode";
            portraitMode.Size = new Size(134, 34);
            portraitMode.TabIndex = 4;
            portraitMode.Text = "Portrait Mode";
            portraitMode.UseVisualStyleBackColor = true;
            portraitMode.Click += portraitMode_Click;
            // 
            // standardMode
            // 
            standardMode.Location = new Point(0, 0);
            standardMode.Name = "standardMode";
            standardMode.Size = new Size(75, 23);
            standardMode.TabIndex = 11;
            // 
            // modeInfo
            // 
            modeInfo.Location = new Point(0, 0);
            modeInfo.Name = "modeInfo";
            modeInfo.Size = new Size(100, 23);
            modeInfo.TabIndex = 10;
            // 
            // offButton
            // 
            offButton.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            offButton.Location = new Point(738, 70);
            offButton.Name = "offButton";
            offButton.Size = new Size(90, 34);
            offButton.TabIndex = 9;
            offButton.Text = "On/Off";
            offButton.UseVisualStyleBackColor = true;
            offButton.Click += offButton_Click;
            // 
            // standard
            // 
            standard.Location = new Point(0, 0);
            standard.Name = "standard";
            standard.Size = new Size(75, 23);
            standard.TabIndex = 17;
            // 
            // timerMode
            // 
            timerMode.Location = new Point(694, 374);
            timerMode.Name = "timerMode";
            timerMode.Size = new Size(137, 34);
            timerMode.TabIndex = 13;
            timerMode.Text = "TimerMode";
            timerMode.UseVisualStyleBackColor = true;
            timerMode.Click += timerMode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(288, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 206);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // modeLabel
            // 
            modeLabel.Location = new Point(376, 458);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(249, 31);
            modeLabel.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 458);
            label2.Name = "label2";
            label2.Size = new Size(220, 27);
            label2.TabIndex = 16;
            label2.Text = "Curent selected mode:";
            // 
            // standardButton
            // 
            standardButton.Location = new Point(546, 374);
            standardButton.Name = "standardButton";
            standardButton.Size = new Size(145, 34);
            standardButton.TabIndex = 18;
            standardButton.Text = "Standard Mode";
            standardButton.UseVisualStyleBackColor = true;
            standardButton.Click += standardButton_Click;
            // 
            // galleryButton
            // 
            galleryButton.Location = new Point(738, 451);
            galleryButton.Name = "galleryButton";
            galleryButton.Size = new Size(102, 34);
            galleryButton.TabIndex = 19;
            galleryButton.Text = "Gallery";
            galleryButton.UseVisualStyleBackColor = true;
            galleryButton.Click += galleryButton_Click;
            // 
            // videoRecording
            // 
            videoRecording.BackColor = Color.IndianRed;
            videoRecording.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            videoRecording.Location = new Point(515, 122);
            videoRecording.Name = "videoRecording";
            videoRecording.Size = new Size(173, 34);
            videoRecording.TabIndex = 20;
            videoRecording.Text = "Video recording";
            videoRecording.UseVisualStyleBackColor = false;
            videoRecording.Click += videoRecording_Click;
            // 
            // videoMode
            // 
            videoMode.Location = new Point(403, 374);
            videoMode.Name = "videoMode";
            videoMode.Size = new Size(137, 34);
            videoMode.TabIndex = 21;
            videoMode.Text = "Video Mode";
            videoMode.UseVisualStyleBackColor = true;
            videoMode.Click += videoMode_Click;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(978, 544);
            Controls.Add(videoMode);
            Controls.Add(videoRecording);
            Controls.Add(galleryButton);
            Controls.Add(standardButton);
            Controls.Add(label2);
            Controls.Add(modeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(timerMode);
            Controls.Add(standard);
            Controls.Add(offButton);
            Controls.Add(modeInfo);
            Controls.Add(standardMode);
            Controls.Add(portraitMode);
            Controls.Add(autoMode);
            Controls.Add(takeShot);
            Controls.Add(mainScreen);
            Controls.Add(label1);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            Load += MainScreenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox mainScreen;
        private Button takeShot;
        private Button autoMode;
        private Button portraitMode;
        private Button standardMode;
        private Label modeInfo;
        private Button offButton;
        private Button standard;
        private Button timerMode;
        private PictureBox pictureBox1;
        private TextBox modeLabel;
        private Label label2;
        private Button standardButton;
        private Button galleryButton;
        private Button videoRecording;
        private Button videoMode;
    }
}