using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    public class HybridMode : ShotingMode
    {
        public string getImageSize()
        {
            return "1080p HD at 60fps";
        }

        public void takePhoto(RichTextBox richTextBox)
        {
            richTextBox.Text = "Video HD in Hybrid mode.";
        }
    }
}
