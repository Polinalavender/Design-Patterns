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

    public class GaleryTaker
    {
        public Stack<GalleryMemento> History { get; private set; }

        public GaleryTaker()
        {
            History = new Stack<GalleryMemento>();
        }

        public void AddMemento(GalleryMemento memento)
        {
            History.Push(memento);
        }

        public GalleryMemento GetMemento()
        {
            if (History.Count > 0)
                return History.Pop();
            else
                return null;
        }
    }
}

