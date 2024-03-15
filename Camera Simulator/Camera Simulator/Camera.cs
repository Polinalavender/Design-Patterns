using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void PressButton(RichTextBox richTextBox)
        {
            currentMode.takePhoto(richTextBox);
            richTextBox.AppendText($"Output photo: {GetOutputDescription()}\n");
        }

        public string GetOutputDescription()
        {
            return $"photo of {GetCurrentModeName()}, {GetCurrentModeImageSize()}";
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
