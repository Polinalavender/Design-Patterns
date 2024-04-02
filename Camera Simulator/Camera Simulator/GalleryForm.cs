using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public partial class GalleryForm : Form
    {
        private List<Image> images;
        private int currentIndex;
        private GaleryTaker galleryTaker;
        private MainScreenForm mainScreenForm; 

        // Inside GalleryForm class
        public GalleryForm(List<Image> images, MainScreenForm mainScreenForm = null)
        {
            InitializeComponent();
            this.images = images;
            this.mainScreenForm = mainScreenForm; // Store reference to MainScreenForm
            currentIndex = 0;
            galleryTaker = new GaleryTaker();
            galleryTaker.AddMemento(new GalleryMemento(images));
            DisplayCurrentImage();
        }


        private void DisplayCurrentImage()
        {
            // Clear existing image
            pictureBox.Image = null;

            if (images != null && images.Count > 0 && currentIndex >= 0 && currentIndex < images.Count)
            {
                // Display the current image
                pictureBox.Image = images[currentIndex];
            }
        }

        private void nextPhoto_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                galleryTaker.AddMemento(new GalleryMemento(images));
                currentIndex++;
                DisplayCurrentImage();
            }
        }

        private void previousPhoto_Click(object sender, EventArgs e)
        {

            if (currentIndex > 0)
            {
                galleryTaker.AddMemento(new GalleryMemento(images));
                currentIndex--;
                DisplayCurrentImage();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Check if the mainScreenForm reference is not null
            if (mainScreenForm != null)
            {
                // Show the already opened mainScreenForm
                mainScreenForm.Show();
            }
            // Close the current GalleryForm
            this.Close();
        }
    }
}
