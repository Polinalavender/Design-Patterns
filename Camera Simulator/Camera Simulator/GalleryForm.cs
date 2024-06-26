﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public partial class GalleryForm : Form
    {
        private List<Image> images;
        private int currentIndex;
        private GaleryTake galleryTake;
        private MainScreenForm mainScreenForm;

        public GalleryForm(List<Image> images, MainScreenForm mainScreenForm = null)
        {
            InitializeComponent();

            this.images = images ?? new List<Image>();
            this.mainScreenForm = mainScreenForm;
            currentIndex = 0;
            galleryTake = new GaleryTake();
            galleryTake.AddMomento(new GalleryMemento(images));
            DisplayCurrentImage();
        }

        private void DisplayCurrentImage()
        {
            pictureBox.Image = null;

            if (images.Count > 0 && currentIndex >= 0 && currentIndex < images.Count)
            {
                Image currentImage = images[currentIndex];

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(400, 300); 
                pictureBox.Image = currentImage;
            }
        }

        private void NavigateTo(int index)
        {
            if (index >= 0 && index < images.Count)
            {
                galleryTake.AddMomento(new GalleryMemento(images));
                currentIndex = index;
                DisplayCurrentImage();
            }
        }

        private void nextPhoto_Click(object sender, EventArgs e)
        {
            NavigateTo(currentIndex + 1);
        }

        private void previousPhoto_Click(object sender, EventArgs e)
        {
            NavigateTo(currentIndex - 1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainScreenForm?.Show();
            this.Close();
        }
    }
}
