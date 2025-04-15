using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhi_Nguyen_PictureBox
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        int originalWidth;
        int originalHeight;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Reset form size to original
            picAutoSize.Width = picNormal.Width;
            picAutoSize.Height = picNormal.Height;
            Width = originalWidth; 
            Height = originalHeight;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(dlgOpen.FileName);
                picNormal.Image = selectedImage;
                picCenter.Image = selectedImage;
                picAutoSize.Image = selectedImage;
                picStretch.Image = selectedImage;
                picZoom.Image = selectedImage;
                txtSize.Text = picAutoSize.Width.ToString() + "x" + picAutoSize.Height.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            Width = originalWidth;
            Height = originalHeight;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
