using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    public interface ShootingMode
    {
        string getImageSize();
        void takePhoto(RichTextBox richTextBox);
    }
}