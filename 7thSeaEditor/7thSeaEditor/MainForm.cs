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

            PreviewCurrentItem();
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
                previewWindow.DocumentText = part.GetMarkdown();
            }
            else
            {
                previewWindow.DocumentText = "";
            }

            EnableAddPartButtonIfNecessary();
        }

        private void CreateNewPart(string name, string description)
        {
            ListItemWithId categoryItem = (ListItemWithId)categorySelector.Items[categorySelector.SelectedIndex];
            int id = database.CreatePart(name, description, categoryItem.Id);
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

            SeventhSeaUtils.SetListItems(itemSelector, database.GetItemListForCategory(id));

            FilterPartListForCategoryIfNecessary();

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

        private void PreviewCurrentItem()
        {
            if (itemSelector.SelectedIndex == -1)
                previewWindow.DocumentText = "";
            else
            {
                ListItemWithId itemItem = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];
                SeventhSeaItem item = database.GetItem(itemItem.Id);

                previewWindow.DocumentText = item.GetMarkdown();
            }
        }

        private void AddPartToItem(int partId, int itemId)
        {
            int itemPartId = database.AddPartToItem(partId, itemId);
            ListItemWithId partItem = (ListItemWithId)partListBox.Items[partListBox.SelectedIndex];
            currentItemPartsBox.Items.Add(new ListItemWithId(partItem.Text, itemPartId));

            PreviewCurrentItem();
        }

        private void RemovePartFromItem(int itemPartId)
        {
            database.RemovePartFromItem(itemPartId);
            currentItemPartsBox.Items.RemoveAt(currentItemPartsBox.SelectedIndex);

            PreviewCurrentItem();
        }

        private void EnableItemEditingControlsIfNecessary()
        {
            bool enable = currentItemPartsBox.SelectedIndex != -1;

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
                SeventhSeaUtils.SetListItems(currentItemPartsBox, database.GetItemPartsList(itemItem.Id));
            }

            PreviewCurrentItem();

            EnableAddPartButtonIfNecessary();
            EnableItemEditingControlsIfNecessary();
        }

        private void currentItemPartsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewCurrentItem();

            EnableItemEditingControlsIfNecessary();

        }

        private void removePartButton_Click(object sender, EventArgs e)
        {

            ListItemWithId itemPart = (ListItemWithId)currentItemPartsBox.Items[currentItemPartsBox.SelectedIndex];

            RemovePartFromItem(itemPart.Id);
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

        private void LoadDatabase(string path)
        {
            database.Open(path);
            SeventhSeaUtils.SetListItems(categorySelector, database.GetCategoryListInfo());
            SeventhSeaUtils.SetListItems(partListBox, database.GetPartListInfo());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.Multiselect = false;
            dialog.Title = "Open Database";

            if (dialog.ShowDialog() == DialogResult.OK)
                LoadDatabase(dialog.FileName);
        }

        private void DeleteItem(int id)
        {
            database.DeleteItem(id);
            itemSelector.Items.RemoveAt(itemSelector.SelectedIndex);

            previewWindow.DocumentText = "";
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            ListItemWithId item = (ListItemWithId)itemSelector.Items[itemSelector.SelectedIndex];

            DialogResult result = MessageBox.Show("Do you really want to delete " + item.Text + '?', "Delete " + item.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK)
                DeleteItem(item.Id);
        }

        private void FilterPartListForCategoryIfNecessary()
        {
            if (partFilterBox.Text != "All Parts" && categorySelector.SelectedIndex != -1)
            {
                ListItemWithId categoryItem = (ListItemWithId)categorySelector.Items[categorySelector.SelectedIndex];
                SeventhSeaUtils.SetListItems(partListBox, database.GetPartListInfoForCategory(categoryItem.Id));
            }
        }

        private void partFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partFilterBox.Text == "All Parts")
                SeventhSeaUtils.SetListItems(partListBox, database.GetPartListInfo());
            else
                FilterPartListForCategoryIfNecessary();
        }
    }
}
