using System;
using System.Drawing;
using System.IO;

namespace Camera_Simulator
{
    public class ConcretePhotoBuilder : PhotoBuilder
    {
        private Photo photo;
        public ConcretePhotoBuilder()
        {
            photo = new Photo();
        }

        public void BuildImageSize(ShootingMode mode)
        {
            // image size based on the shooting mode
            photo.ImageSize = mode.getImageSize();
        }

        public void BuildImage(string photoFilePath)
        {
            // Loading the image 
            if (!File.Exists(photoFilePath))
            {
                throw new FileNotFoundException($"Photo file not found at: {photoFilePath}");
            }
            photo.Image = Image.FromFile(photoFilePath);
        }

        public Photo GetPhoto()
        {
            return photo;
        }
    }
}
