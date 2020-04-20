using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMyPhotos
{
    partial class MyPhotos 
    {
    
        private System.ComponentModel.IContainer components = null;



        public MyPhotos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(65, 0);
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            FormManageImage addImageForm = new FormManageImage();
            addImageForm.Show();
        }


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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddImage = new System.Windows.Forms.Button();
            this.SelectImage = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddImage);
            this.groupBox1.Controls.Add(this.SelectImage);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(47, 143);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(145, 43);
            this.AddImage.TabIndex = 2;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(47, 88);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(145, 39);
            this.SelectImage.TabIndex = 1;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox.Location = new System.Drawing.Point(3, 18);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(243, 203);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "My Photos";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 550);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyPhotos";
            this.Text = "MyPhotos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button AddImage;
        private Button SelectImage;
        private TextBox textBox;
    }
}

