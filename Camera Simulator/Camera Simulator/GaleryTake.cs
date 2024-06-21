using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{

    public class GaleryTake
    {
        public Stack<GalleryMemento> History { get; private set; }

        public GaleryTake()
        {
            History = new Stack<GalleryMemento>();
        }

        public void AddMomento(GalleryMemento momento)
        {
            History.Push(momento);
        }

        public GalleryMemento GetMomento()
        {
            if (History.Count > 0)
                return History.Pop();
            else
                return null;
        }
    }
}
