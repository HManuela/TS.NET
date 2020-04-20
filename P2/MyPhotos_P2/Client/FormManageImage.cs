using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MyPhotos;
using MyPhotos.Api;

namespace WindowsFormsMyPhotos
{
    public partial class FormManageImage : Form
    {
        private readonly MyPhotsApi _myPhotos;
        private string _imageLocation = "";
        private string TitlePattern = @"^[a-z0-9]{1,11}.[a-z]{3}$";
        private string DescriptionPattern = @"^(\w)|(\s){5,256}$";

        public FormManageImage()
        {
            InitializeComponent();
            _myPhotos = new MyPhotosApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewImage.Enabled = false;
        }

        private void buttonAddImagePhotoUpload_Click(object sender, EventArgs e)
        {
           
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = @"jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _imageLocation = dialog.FileName;
                    pictureBoxImage.ImageLocation = _imageLocation;
                }
         
         
        }

        private void buttonAddNewImage_Click(object sender, EventArgs e)
        {
            string title = textBoxAddImageTitle.Text;
            string description = textBoxAddImageDescription.Text;
            DateTime date = Convert.ToDateTime(dateTimePickerAddImageDate.Text);

            Image currentImage = Image.FromFile(_imageLocation);
            byte[] photo = ImageToByteArray(currentImage);

            if (!FieldsCompleted(title, description))
            {
                labelAddImage.Text = @"You must complete all fields.";
            }
            else
            {
                buttonAddNewImage.Enabled = true;
                Imagine image = new Imagine()
                {
                    Data = date,
                    Descriere = description,
                    Titlu = title,
                    Foto = photo
                };

                _myPhotos.AddImage(image);

                labelAddImage.Text = @"Image added.";
                labelAddImage.Visible = true;
            }
        }

        private bool FieldsCompleted(string title, string description)
        {
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
                return true;
            else return false;
        }

   
        private byte[] ImageToByteArray(Image image)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] xByte = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            return xByte;
        }

        private void buttonNewImage_Click(object sender, EventArgs e)
        {
            labelAddImage.Visible = false;
            textBoxAddImageDescription.Text = "";
            textBoxAddImageTitle.Text = "";
            pictureBoxImage.Image = null;
        }

        private void textBoxAddImageTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateField(TitlePattern, textBoxAddImageTitle);
        }

        private void textBoxAddImageDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateField(DescriptionPattern, textBoxAddImageDescription);
        }

        private void ValidateField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddNewImage.Enabled = isValidExpression;
            labelAddImage.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(732, 373);
            this.Name = "Images";
            this.Load += new System.EventHandler(this.FormAddImage_Load);
            this.ResumeLayout(false);

        }

        private void FormAddImage_Load(object sender, EventArgs e)
        {

        }
    }
}
