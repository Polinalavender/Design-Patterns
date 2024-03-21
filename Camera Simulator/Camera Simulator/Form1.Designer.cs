namespace Camera_Simulator
{
    partial class Form1
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
            label1 = new Label();
            buttonStart = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 195);
            label1.Name = "label1";
            label1.Size = new Size(481, 44);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Camera Simulator ";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.MediumSlateBlue;
            buttonStart.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(387, 330);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(200, 50);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 248);
            label2.Name = "label2";
            label2.Size = new Size(540, 25);
            label2.TabIndex = 2;
            label2.Text = "Tap the button to start your experience with Camera Simulator XX6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(978, 544);
            Controls.Add(label2);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Camera Simulator ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonStart;
        private Label label2;
    }
}
