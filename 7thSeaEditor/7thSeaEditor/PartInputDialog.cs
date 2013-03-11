using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7thSeaEditor
{
    public partial class PartInputDialog : Form
    {
        public PartInputDialog()
        {
            InitializeComponent();
        }

        public string TitleCaptionText
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        public string TitleInputText
        {
            get { return titleBox.Text; }
            set { titleBox.Text = value; }
        }

        public string DescriptionCaptionText
        {
            get { return descriptionLabel.Text; }
            set {descriptionLabel.Text = value;}
        }

        public string DescriptionInputText
        {
            get { return descriptionBox.Text; }
            set { descriptionBox.Text = value; }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            previewWindow.DocumentText = descriptionBox.Text;
        }
    }
}
