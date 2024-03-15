namespace Camera_Simulator
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
            hydridMode = new Button();
            standardMode = new Button();
            modeInfo = new Label();
            button7 = new Button();
            timerMode = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 0;
            label1.Text = "Camera Simulator";
            // 
            // mainScreen
            // 
            mainScreen.Location = new Point(47, 76);
            mainScreen.Name = "mainScreen";
            mainScreen.Size = new Size(697, 312);
            mainScreen.TabIndex = 1;
            mainScreen.Text = "";
            // 
            // takeShot
            // 
            takeShot.BackColor = Color.MediumPurple;
            takeShot.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeShot.Location = new Point(596, 118);
            takeShot.Name = "takeShot";
            takeShot.Size = new Size(134, 34);
            takeShot.TabIndex = 2;
            takeShot.Text = "Take a Shot";
            takeShot.UseVisualStyleBackColor = false;
            takeShot.Click += takeShot_Click;
            // 
            // autoMode
            // 
            autoMode.Location = new Point(59, 334);
            autoMode.Name = "autoMode";
            autoMode.Size = new Size(112, 34);
            autoMode.TabIndex = 3;
            autoMode.Text = "Auto Mode";
            autoMode.UseVisualStyleBackColor = true;
            // 
            // portraitMode
            // 
            portraitMode.Location = new Point(177, 334);
            portraitMode.Name = "portraitMode";
            portraitMode.Size = new Size(134, 34);
            portraitMode.TabIndex = 4;
            portraitMode.Text = "Portrait Mode";
            portraitMode.UseVisualStyleBackColor = true;
            // 
            // hydridMode
            // 
            hydridMode.Location = new Point(317, 334);
            hydridMode.Name = "hydridMode";
            hydridMode.Size = new Size(137, 34);
            hydridMode.TabIndex = 5;
            hydridMode.Text = "Hydrid Mode";
            hydridMode.UseVisualStyleBackColor = true;
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
            // button7
            // 
            button7.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(654, 36);
            button7.Name = "button7";
            button7.Size = new Size(90, 34);
            button7.TabIndex = 9;
            button7.Text = "On/Off";
            button7.UseVisualStyleBackColor = true;
            // 
            // timerMode
            // 
            timerMode.Location = new Point(0, 0);
            timerMode.Name = "timerMode";
            timerMode.Size = new Size(75, 23);
            timerMode.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(460, 334);
            button1.Name = "button1";
            button1.Size = new Size(145, 34);
            button1.TabIndex = 12;
            button1.Text = "Standard Mode";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(611, 334);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "TimerMode";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(timerMode);
            Controls.Add(button7);
            Controls.Add(modeInfo);
            Controls.Add(standardMode);
            Controls.Add(hydridMode);
            Controls.Add(portraitMode);
            Controls.Add(autoMode);
            Controls.Add(takeShot);
            Controls.Add(mainScreen);
            Controls.Add(label1);
            Name = "MainScreenForm";
            Text = "MainScreenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox mainScreen;
        private Button takeShot;
        private Button autoMode;
        private Button portraitMode;
        private Button hydridMode;
        private Button standardMode;
        private Label modeInfo;
        private Button button7;
        private Button timerMode;
        private Button button1;
        private Button button2;
    }
}