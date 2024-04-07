using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public class GalleryMemento
    {
        public List<Image> Images { get; private set; }

        public GalleryMemento(List<Image> images)
        {
            Images = new List<Image>(images);
        }
    }
}

