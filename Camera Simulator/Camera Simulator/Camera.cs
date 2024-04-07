using Camera_Simulator;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public class Camera
    {
        private ShootingMode currentMode;

        public ShootingMode CurrentMode
        {
            get { return currentMode; }
        }

        public void SetMode(ShootingMode mode)
        {
            currentMode = mode;
        }

        public Image PressButton(RichTextBox richTextBox, string modeDescription)
        {
            if (currentMode == null)
            {
                throw new InvalidOperationException("No shooting mode selected.");
            }

            if (currentMode is TimerMode)
            {
                ShowCountdownForm();
                return GetPlaceholderImage();
            }
            else
            {
                string photoFilePath = GetPhotoFilePath();
                PhotoBuilder photoBuilder = new ConcretePhotoBuilder();
                photoBuilder.BuildImageSize(currentMode);
                photoBuilder.BuildImage(photoFilePath);
                Photo photo = photoBuilder.GetPhoto();
                richTextBox.AppendText($"Output photo: {photo.Description}, photo of {GetCurrentModeName()}, {GetCurrentModeImageSize()}\n");
                return photo.Image;
            }
        }

        private void ShowCountdownForm()
        {
            CountdownForm countdownForm = new CountdownForm();
            countdownForm.ShowDialog();
        }

        private string GetPhotoFilePath()
        {
            if (currentMode is PortraitMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Portrait.JPG";
            }
            else if (currentMode is AutoMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Amsterdam-autoMode.jpg";
            }
            else if (currentMode is StandardMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Standard.jpg";
            }
            else if (currentMode is TimerMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Timer.jpg";
            }
            else
            {
                return "";
            }
        }
        private string GetCurrentModeName()
        {
            return currentMode.GetType().Name.Replace("Mode", "");
        }

        private string GetCurrentModeImageSize()
        {
            return currentMode.getImageSize();
        }

        private Image GetPlaceholderImage()
        {
            return Image.FromFile("C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Timer.jpg");
        }
    }
}