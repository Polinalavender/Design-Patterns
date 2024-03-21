namespace Camera_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Hide the start screen form
            this.Hide();

            MainScreenForm mainScreen = new MainScreenForm();
            mainScreen.ShowDialog();

            // Close the application when the main screen is closed
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 600);
        }
    }
}
