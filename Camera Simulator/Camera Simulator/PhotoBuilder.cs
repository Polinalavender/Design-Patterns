using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{

    public interface PhotoBuilder
    {
        void BuildImageSize(ShotingMode mode);
        void BuildImage(string photoFilePath);
        Photo GetPhoto();
    }
}
