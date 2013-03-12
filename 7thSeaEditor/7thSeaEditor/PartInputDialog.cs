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
            previewWindow.DocumentText = SeventhSeaUtils.MakeHtmlDoc("");
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
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            previewWindow.DocumentText = SeventhSeaUtils.MakeHtmlDoc(descriptionBox.Text);
        }

        private void TagSelection(string tagStart, string tagEnd)
        {
            if (descriptionBox.SelectionLength == 0)
                return;

            string text = descriptionBox.Text;

            string result = text.Substring(0, descriptionBox.SelectionStart) +
                tagStart + text.Substring(descriptionBox.SelectionStart, descriptionBox.SelectionLength) + tagEnd +
                text.Substring(descriptionBox.SelectionStart + descriptionBox.SelectionLength);

            descriptionBox.Text = result;
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            TagSelection("<strong>", "</strong>");
            UpdatePreview();
        }

        private void exampleButton_Click(object sender, EventArgs e)
        {
            TagSelection("<p class='example'>", "</p>");
            UpdatePreview();
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            TagSelection("<em>", "</em>");
            UpdatePreview();
        }

        private void headerButton_Click(object sender, EventArgs e)
        {
            TagSelection("<h3>", "</h3>");
            UpdatePreview();
        }

        private void linebreakButton_Click(object sender, EventArgs e)
        {
            descriptionBox.Text = descriptionBox.Text.Insert(descriptionBox.SelectionStart, "<br/>");
            UpdatePreview();
        }
    }
}
