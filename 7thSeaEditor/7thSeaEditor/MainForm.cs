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
    public partial class MainForm : Form
    {
        SeventhSeaDatabase database = new SeventhSeaDatabase();

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewItem(int categoryId, string name, string description)
        {
            int id = database.CreateItem(categoryId, name, description);

            itemSelector.Items.Add(new ListItemWithId(name, id));
            EnableItemEditingControlsIfNecessary();
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            PartInputDialog dialog = new PartInputDialog();
            dialog.Text = "New Item";

            dialog.TitleCaptionText = "Name:";
            dialog.DescriptionCaptionText = "Description:";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ListItemWithId category = (ListItemWithId)categorySelector.Items[categorySelector.SelectedIndex];
                CreateNewItem(category.Id, dialog.TitleInputText, dialog.DescriptionInputText);
            }
        }

        private void partListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partListBox.SelectedIndex != -1)
            {
                ListItemWithId item = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];

                SeventhSeaPart part = database.GetPart(item.Id);
                previewWindow.DocumentText = part.Description;
            }
            else
            {
                previewWindow.DocumentText = "";
            }

            EnableAddPartButtonIfNecessary();
        }

        private void CreateNewPart(string name, string description)
        {
            int id = database.CreatePart(name, description);
            partListBox.Items.Add(new ListItemWithId(name, id));
            EnableItemEditingControlsIfNecessary();
        }

        private void EditPart(int id, string name, string description)
        {
            database.UpdatePart(id, name, description);
            partListBox.Items[partListBox.SelectedIndex] = new ListItemWithId(name, id);

            previewWindow.DocumentText = description;
        }

        private void DeletePart(int id)
        {
            database.DeletePart(id);

            partListBox.Items.RemoveAt(partListBox.SelectedIndex);
            EnableItemEditingControlsIfNecessary();
        }

        private void CreateNewCategory(string categoryName)
        {
            int id = database.CreateCategory(categoryName);
            categorySelector.Items.Add(new ListItemWithId(categoryName, id));

            categorySelector.SelectedIndex = categorySelector.Items.IndexOf(categoryName);
            EnableItemEditingControlsIfNecessary();
        }

        private void RemoveCategory(int id)
        {
            database.DeleteCategory(id);

            categorySelector.Items.RemoveAt(categorySelector.SelectedIndex);
            EnableItemEditingControlsIfNecessary();
        }

        void EnableItemCreationControlsIfNecessary()
        {
            bool enable = (categorySelector.SelectedIndex != -1);
            newItemButton.Enabled = enable;
            editItemButton.Enabled = enable;
            deleteItemButton.Enabled = enable;
        }

        private void SetActiveCategory(int id)
        {
            itemSelector.Text = "";
            itemSelector.Items.Clear();

            if (id != -1)
            {
                ListItemWithId[] items = database.GetItemListForCategory(id);
                itemSelector.BeginUpdate();

                for (int i = 0; i < items.Length; i++)
                    itemSelector.Items.Add(items[i]);

                itemSelector.EndUpdate();

            }

            EnableAddPartButtonIfNecessary();
            EnableItemCreationControlsIfNecessary();
            EnableItemEditingControlsIfNecessary();
        }

        private void newCategoryButton_Click(object sender, EventArgs e)
        {
            UserInputDialog dialog = new UserInputDialog();
            dialog.Text = "New Category";
            dialog.CaptionText = "Enter name for new category";

            if (dialog.ShowDialog() == DialogResult.OK)
                CreateNewCategory(dialog.InputText);
        }

        private void categorySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = categorySelector.SelectedIndex;
            if (index != -1)
            {
                ListItemWithId category = (ListItemWithId)categorySelector.Items[index];
                SetActiveCategory(category.Id);
            }
            else
                SetActiveCategory(index);
        }

        private void renameCategoryButton_Click(object sender, EventArgs e)
        {
            ListItemWithId category = (ListItemWithId)categorySelector.Items[categorySelector.SelectedIndex];

            UserInputDialog dialog = new UserInputDialog();
            dialog.Text = "Rename " + category.Text;
            dialog.CaptionText = "Enter new name for " + category.Text;
            dialog.InputText = category.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newCategoryName = dialog.InputText;

                database.RenameCategory(category.Id, newCategoryName);
                categorySelector.Items[categorySelector.SelectedIndex] = new ListItemWithId(newCategoryName, category.Id);
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            ListItemWithId category = (ListItemWithId)categorySelector.Items[categorySelector.SelectedIndex];

            DialogResult result = MessageBox.Show("Do you really want to delete " + category.Text + '?', "Delete " + category.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK)
                RemoveCategory(category.Id);
        }

        private void newPartButton_Click(object sender, EventArgs e)
        {
            PartInputDialog dialog = new PartInputDialog();
            dialog.Text = "New Part";

            if (dialog.ShowDialog() == DialogResult.OK)
                CreateNewPart(dialog.TitleInputText, dialog.DescriptionInputText);
        }

        private void editPartButton_Click(object sender, EventArgs e)
        {
            ListItemWithId partItem = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];
            SeventhSeaPart part = database.GetPart(partItem.Id);

            PartInputDialog dialog = new PartInputDialog();
            dialog.Text = "Edit " +part.Name;

            dialog.TitleInputText = part.Name;
            dialog.DescriptionInputText = part.Description;

            if (dialog.ShowDialog() == DialogResult.OK)
                EditPart(part.Id, dialog.TitleInputText, dialog.DescriptionInputText);
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            ListItemWithId part = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];

            DeletePart(part.Id);
        }

        private void AddPartToItem(int partId, int itemId)
        {
            database.AddPartToItem(partId, itemId);
            SeventhSeaPart part = database.GetPart(partId);
            SeventhSeaItem item = database.GetItem(itemId);
            currentItemPartsBox.Items.Add(new ListItemWithId(part.Name, part.Id));

            previewWindow.DocumentText = item.GetMarkdown();
        }

        private void RemovePartFromitem(int partId, int itemId)
        {
            database.RemovePartFromItem(partId, itemId);
            SeventhSeaPart part = database.GetPart(partId);
            SeventhSeaItem item = database.GetItem(itemId);

            currentItemPartsBox.Items.RemoveAt(currentItemPartsBox.SelectedIndex);

            previewWindow.DocumentText = item.GetMarkdown();
        }

        private void EnableItemEditingControlsIfNecessary()
        {
            bool enable = currentItemPartsBox.SelectedIndex != -1;

            partUpButton.Enabled = enable;
            partDownButton.Enabled = enable;
            removePartButton.Enabled = enable;

        }

        private void EnableAddPartButtonIfNecessary()
        {
            addPartButton.Enabled = (partListBox.SelectedIndex != -1 && itemSelector.SelectedIndex != -1 && categorySelector.SelectedIndex != -1);
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            ListItemWithId part = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];
            ListItemWithId item = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];

            AddPartToItem(part.Id, item.Id);
        }

        private void itemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemSelector.SelectedIndex != -1)
            {
                ListItemWithId itemItem = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];
                SeventhSeaItem item = database.GetItem(itemItem.Id);
                previewWindow.DocumentText = item.GetMarkdown();
            }

            EnableAddPartButtonIfNecessary();
            EnableItemEditingControlsIfNecessary();
        }

        private void currentItemPartsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableItemEditingControlsIfNecessary();

        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            ListItemWithId part = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];
            ListItemWithId item = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];

            RemovePartFromitem(part.Id, item.Id);
        }

        private void SwapCurrentPartsItems(int a, int b)
        {
            ListItemWithId temp = (ListItemWithId)currentItemPartsBox.Items[a];

            currentItemPartsBox.BeginUpdate();
            currentItemPartsBox.Items[a] = currentItemPartsBox.Items[b];
            currentItemPartsBox.Items[b] = temp;
            currentItemPartsBox.SelectedIndex = b;
            currentItemPartsBox.EndUpdate();
        }

        private void partUpButton_Click(object sender, EventArgs e)
        {
            ListItemWithId partItem = (ListItemWithId)currentItemPartsBox.Items[currentItemPartsBox.SelectedIndex];
            ListItemWithId itemItem = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];

            SeventhSeaPart part = database.GetPart(partItem.Id);
            SeventhSeaItem item = database.GetItem(itemItem.Id);

            if (item.MovePartUp(part))
                SwapCurrentPartsItems(currentItemPartsBox.SelectedIndex, currentItemPartsBox.SelectedIndex - 1);

            previewWindow.DocumentText = item.GetMarkdown();
        }

        private void partDownButton_Click(object sender, EventArgs e)
        {
            ListItemWithId partItem = (ListItemWithId)currentItemPartsBox.Items[currentItemPartsBox.SelectedIndex];
            ListItemWithId itemItem = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];

            SeventhSeaPart part = database.GetPart(partItem.Id);
            SeventhSeaItem item = database.GetItem(itemItem.Id);

            if (item.MovePartDown(part))
                SwapCurrentPartsItems(currentItemPartsBox.SelectedIndex, currentItemPartsBox.SelectedIndex + 1);

            previewWindow.DocumentText = item.GetMarkdown();
        }
    }
}
