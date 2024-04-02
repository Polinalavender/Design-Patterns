namespace Camera_Simulator
{
    partial class GalleryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox = new PictureBox();
            nextPhoto = new Button();
            previousPhoto = new Button();
            back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 39);
            label1.TabIndex = 0;
            label1.Text = "Photo Gallery";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(148, 102);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(621, 277);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // nextPhoto
            // 
            nextPhoto.Location = new Point(657, 400);
            nextPhoto.Name = "nextPhoto";
            nextPhoto.Size = new Size(112, 34);
            nextPhoto.TabIndex = 2;
            nextPhoto.Text = "Next photo";
            nextPhoto.UseVisualStyleBackColor = true;
            nextPhoto.Click += nextPhoto_Click;
            // 
            // previousPhoto
            // 
            previousPhoto.Location = new Point(148, 400);
            previousPhoto.Name = "previousPhoto";
            previousPhoto.Size = new Size(141, 34);
            previousPhoto.TabIndex = 3;
            previousPhoto.Text = "Previous photo";
            previousPhoto.UseVisualStyleBackColor = true;
            previousPhoto.Click += previousPhoto_Click;
            // 
            // back
            // 
            back.Location = new Point(12, 12);
            back.Name = "back";
            back.Size = new Size(112, 34);
            back.TabIndex = 4;
            back.Text = "Go Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(978, 544);
            Controls.Add(back);
            Controls.Add(previousPhoto);
            Controls.Add(nextPhoto);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Name = "GalleryForm";
            Text = "GalleryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox;
        private Button nextPhoto;
        private Button previousPhoto;
        private Button back;
    }
}