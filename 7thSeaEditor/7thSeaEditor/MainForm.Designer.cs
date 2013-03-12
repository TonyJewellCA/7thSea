namespace _7thSeaEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.categorySelector = new System.Windows.Forms.ComboBox();
            this.newCategoryButton = new System.Windows.Forms.Button();
            this.renameCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.GroupBox();
            this.previewWindow = new System.Windows.Forms.WebBrowser();
            this.partsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.newPartButton = new System.Windows.Forms.Button();
            this.editPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.partListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemSelector = new System.Windows.Forms.ComboBox();
            this.newItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partUpButton = new System.Windows.Forms.Button();
            this.partDownButton = new System.Windows.Forms.Button();
            this.removePartButton = new System.Windows.Forms.Button();
            this.currentItemPartsBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.categoryBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.previewBox.SuspendLayout();
            this.partsBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.60044F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.45664F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.86813F));
            this.tableLayoutPanel1.Controls.Add(this.categoryBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.previewBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.partsBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.categoryBox, 2);
            this.categoryBox.Controls.Add(this.flowLayoutPanel1);
            this.categoryBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryBox.Location = new System.Drawing.Point(3, 3);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(385, 53);
            this.categoryBox.TabIndex = 0;
            this.categoryBox.TabStop = false;
            this.categoryBox.Text = "Category";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.categorySelector);
            this.flowLayoutPanel1.Controls.Add(this.newCategoryButton);
            this.flowLayoutPanel1.Controls.Add(this.renameCategoryButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteCategoryButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(379, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // categorySelector
            // 
            this.categorySelector.FormattingEnabled = true;
            this.categorySelector.Location = new System.Drawing.Point(3, 3);
            this.categorySelector.Name = "categorySelector";
            this.categorySelector.Size = new System.Drawing.Size(121, 21);
            this.categorySelector.Sorted = true;
            this.categorySelector.TabIndex = 1;
            this.categorySelector.SelectedIndexChanged += new System.EventHandler(this.categorySelector_SelectedIndexChanged);
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.Location = new System.Drawing.Point(130, 3);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.newCategoryButton.TabIndex = 3;
            this.newCategoryButton.Text = "New";
            this.newCategoryButton.UseVisualStyleBackColor = true;
            this.newCategoryButton.Click += new System.EventHandler(this.newCategoryButton_Click);
            // 
            // renameCategoryButton
            // 
            this.renameCategoryButton.Location = new System.Drawing.Point(211, 3);
            this.renameCategoryButton.Name = "renameCategoryButton";
            this.renameCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.renameCategoryButton.TabIndex = 2;
            this.renameCategoryButton.Text = "Rename";
            this.renameCategoryButton.UseVisualStyleBackColor = true;
            this.renameCategoryButton.Click += new System.EventHandler(this.renameCategoryButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(292, 3);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCategoryButton.TabIndex = 1;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // previewBox
            // 
            this.previewBox.Controls.Add(this.previewWindow);
            this.previewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBox.Location = new System.Drawing.Point(623, 62);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(285, 359);
            this.previewBox.TabIndex = 1;
            this.previewBox.TabStop = false;
            this.previewBox.Text = "Preview";
            // 
            // previewWindow
            // 
            this.previewWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWindow.Location = new System.Drawing.Point(3, 16);
            this.previewWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWindow.Name = "previewWindow";
            this.previewWindow.Size = new System.Drawing.Size(279, 340);
            this.previewWindow.TabIndex = 0;
            // 
            // partsBox
            // 
            this.partsBox.Controls.Add(this.tableLayoutPanel2);
            this.partsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsBox.Location = new System.Drawing.Point(3, 62);
            this.partsBox.Name = "partsBox";
            this.partsBox.Size = new System.Drawing.Size(209, 359);
            this.partsBox.TabIndex = 2;
            this.partsBox.TabStop = false;
            this.partsBox.Text = "Parts";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.partListBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(203, 340);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.newPartButton);
            this.flowLayoutPanel2.Controls.Add(this.editPartButton);
            this.flowLayoutPanel2.Controls.Add(this.deletePartButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(197, 39);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // newPartButton
            // 
            this.newPartButton.Location = new System.Drawing.Point(3, 3);
            this.newPartButton.Name = "newPartButton";
            this.newPartButton.Size = new System.Drawing.Size(50, 23);
            this.newPartButton.TabIndex = 0;
            this.newPartButton.Text = "New";
            this.newPartButton.UseVisualStyleBackColor = true;
            this.newPartButton.Click += new System.EventHandler(this.newPartButton_Click);
            // 
            // editPartButton
            // 
            this.editPartButton.Location = new System.Drawing.Point(59, 3);
            this.editPartButton.Name = "editPartButton";
            this.editPartButton.Size = new System.Drawing.Size(50, 23);
            this.editPartButton.TabIndex = 1;
            this.editPartButton.Text = "Edit";
            this.editPartButton.UseVisualStyleBackColor = true;
            this.editPartButton.Click += new System.EventHandler(this.editPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(115, 3);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(50, 23);
            this.deletePartButton.TabIndex = 2;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // partListBox
            // 
            this.partListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partListBox.FormattingEnabled = true;
            this.partListBox.Location = new System.Drawing.Point(3, 48);
            this.partListBox.Name = "partListBox";
            this.partListBox.Size = new System.Drawing.Size(197, 289);
            this.partListBox.Sorted = true;
            this.partListBox.TabIndex = 1;
            this.partListBox.SelectedIndexChanged += new System.EventHandler(this.partListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(218, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.currentItemPartsBox, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(393, 340);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.itemSelector);
            this.flowLayoutPanel3.Controls.Add(this.newItemButton);
            this.flowLayoutPanel3.Controls.Add(this.editItemButton);
            this.flowLayoutPanel3.Controls.Add(this.deleteItemButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 39);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // itemSelector
            // 
            this.itemSelector.FormattingEnabled = true;
            this.itemSelector.Location = new System.Drawing.Point(3, 3);
            this.itemSelector.Name = "itemSelector";
            this.itemSelector.Size = new System.Drawing.Size(121, 21);
            this.itemSelector.Sorted = true;
            this.itemSelector.TabIndex = 0;
            this.itemSelector.SelectedIndexChanged += new System.EventHandler(this.itemSelector_SelectedIndexChanged);
            // 
            // newItemButton
            // 
            this.newItemButton.Enabled = false;
            this.newItemButton.Location = new System.Drawing.Point(130, 3);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(50, 23);
            this.newItemButton.TabIndex = 1;
            this.newItemButton.Text = "New";
            this.newItemButton.UseVisualStyleBackColor = true;
            this.newItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Enabled = false;
            this.editItemButton.Location = new System.Drawing.Point(186, 3);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(50, 23);
            this.editItemButton.TabIndex = 2;
            this.editItemButton.Text = "Edit";
            this.editItemButton.UseVisualStyleBackColor = true;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.Location = new System.Drawing.Point(242, 3);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(50, 23);
            this.deleteItemButton.TabIndex = 3;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.addPartButton);
            this.flowLayoutPanel4.Controls.Add(this.partUpButton);
            this.flowLayoutPanel4.Controls.Add(this.partDownButton);
            this.flowLayoutPanel4.Controls.Add(this.removePartButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(387, 47);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // addPartButton
            // 
            this.addPartButton.Enabled = false;
            this.addPartButton.Location = new System.Drawing.Point(3, 3);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 0;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // partUpButton
            // 
            this.partUpButton.Enabled = false;
            this.partUpButton.Location = new System.Drawing.Point(84, 3);
            this.partUpButton.Name = "partUpButton";
            this.partUpButton.Size = new System.Drawing.Size(75, 23);
            this.partUpButton.TabIndex = 1;
            this.partUpButton.Text = "Up";
            this.partUpButton.UseVisualStyleBackColor = true;
            this.partUpButton.Click += new System.EventHandler(this.partUpButton_Click);
            // 
            // partDownButton
            // 
            this.partDownButton.Enabled = false;
            this.partDownButton.Location = new System.Drawing.Point(165, 3);
            this.partDownButton.Name = "partDownButton";
            this.partDownButton.Size = new System.Drawing.Size(75, 23);
            this.partDownButton.TabIndex = 2;
            this.partDownButton.Text = "Down";
            this.partDownButton.UseVisualStyleBackColor = true;
            this.partDownButton.Click += new System.EventHandler(this.partDownButton_Click);
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(246, 3);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(96, 23);
            this.removePartButton.TabIndex = 3;
            this.removePartButton.Text = "Remove Part";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // currentItemPartsBox
            // 
            this.currentItemPartsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentItemPartsBox.FormattingEnabled = true;
            this.currentItemPartsBox.Location = new System.Drawing.Point(3, 101);
            this.currentItemPartsBox.Name = "currentItemPartsBox";
            this.currentItemPartsBox.Size = new System.Drawing.Size(387, 236);
            this.currentItemPartsBox.TabIndex = 2;
            this.currentItemPartsBox.SelectedIndexChanged += new System.EventHandler(this.currentItemPartsBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "7th Sea Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.categoryBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.previewBox.ResumeLayout(false);
            this.partsBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox categoryBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox categorySelector;
        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Button renameCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.GroupBox previewBox;
        private System.Windows.Forms.WebBrowser previewWindow;
        private System.Windows.Forms.GroupBox partsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button newPartButton;
        private System.Windows.Forms.Button editPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.ListBox partListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox itemSelector;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button partUpButton;
        private System.Windows.Forms.Button partDownButton;
        private System.Windows.Forms.ListBox currentItemPartsBox;
        private System.Windows.Forms.Button removePartButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

