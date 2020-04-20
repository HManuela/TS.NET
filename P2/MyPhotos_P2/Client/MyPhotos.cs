using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMyPhotos
{
    public partial class MyPhotos : Form
    {
        public MyPhotos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(65, 0);
        }



        private void SelectImage_Click(object sender, EventArgs e)
        {
         
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            FormManageImage addImageForm = new FormManageImage();
            addImageForm.Show();
        }
    }
}



