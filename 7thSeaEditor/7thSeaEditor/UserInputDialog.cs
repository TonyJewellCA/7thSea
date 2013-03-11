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
    public partial class UserInputDialog : Form
    {
        public UserInputDialog()
        {
            InitializeComponent();
        }

        public string CaptionText
        {
            get { return captionLabel.Text; }
            set { captionLabel.Text = value; }
        }

        public string InputText
        {
            get { return inputBox.Text; }
            set { inputBox.Text = value; }
        }
    }
}
