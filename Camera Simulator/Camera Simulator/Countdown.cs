using System;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public class CountdownForm : Form
    {
        private Label countdownLabel;
        private System.Windows.Forms.Timer timer;
        private int countdownSeconds = 5;

        public CountdownForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeComponent()
        {
            countdownLabel = new Label();
            SuspendLayout();
            // 
            // countdownLabel
            //
            countdownLabel.Dock = DockStyle.Fill;
            countdownLabel.Font = new Font("Microsoft Sans Serif", 20F);
            countdownLabel.Location = new Point(0, 0);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(255, 145);
            countdownLabel.TabIndex = 0;
            countdownLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountdownForm
            // 
            ClientSize = new Size(255, 145);
            Controls.Add(countdownLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CountdownForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countdown";
            ResumeLayout(false);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;
            countdownLabel.Text = countdownSeconds.ToString();

            if (countdownSeconds == 0)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
