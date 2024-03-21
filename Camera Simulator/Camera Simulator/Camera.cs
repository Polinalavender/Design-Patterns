using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public class Camera
    {
        private ShotingMode currentMode;

        public Camera()
        {
            SetMode(new AutoMode()); // Default mode 
        }

        public void SetMode(ShotingMode mode)
        {
            currentMode = mode;
        }

        public Image PressButton(RichTextBox richTextBox, string modeDescription)
        {

            string photoFilePath = GetPhotoFilePath();
            PhotoBuilder photoBuilder = new ConcretePhotoBuilder();
            photoBuilder.BuildImageSize(currentMode);
            photoBuilder.BuildImage(photoFilePath);

            Photo photo = photoBuilder.GetPhoto();

            // Display information 
            richTextBox.AppendText($"Output photo: {photo.Description}, photo of {GetCurrentModeName()}, {GetCurrentModeImageSize()}\n");

            return photo.Image;
        }


        private string GetPhotoFilePath()
        {
            if (currentMode is PortraitMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Portrait.JPG"; // Replace with the actual file path of the portrait image
            }
            else if (currentMode is AutoMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Amsterdam-autoMode.jpg"; // Replace with the actual file path of the auto image
            }
            else if (currentMode is StandardMode)
            {
                return "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Standard.jpg"; // Replace with the actual file path of the auto image
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
    }
}
