using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace _7thSeaEditor
{
    class SeventhSeaUtils
    {
        public static void SetListItems(ListBox listBox, ListItemWithId[] items)
        {
            listBox.Text = "";
            listBox.Items.Clear();

            listBox.BeginUpdate();

            for (int i = 0; i < items.Length; i++)
                listBox.Items.Add(items[i]);

            listBox.EndUpdate();
        }

        public static void SetListItems(ComboBox comboBox, ListItemWithId[] items)
        {
            comboBox.Text = "";
            comboBox.Items.Clear();

            comboBox.BeginUpdate();

            for (int i = 0; i < items.Length; i++)
                comboBox.Items.Add(items[i]);

            comboBox.EndUpdate();
        }

        public static string MakeHtmlDoc(string body)
        {
            return "<html><head><style>body{background-color:black;color:white;}.example{border: 1px solid gray;}</style></head><body>" + body + "</body></html>";
        }
    }
}
