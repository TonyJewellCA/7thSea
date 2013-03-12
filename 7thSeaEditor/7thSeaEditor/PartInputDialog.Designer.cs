namespace _7thSeaEditor
{
    partial class PartInputDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartInputDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.previewWindow = new System.Windows.Forms.WebBrowser();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.exampleButton = new System.Windows.Forms.Button();
            this.headerButton = new System.Windows.Forms.Button();
            this.linebreakButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.previewButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.previewWindow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 333);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(8, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Name:";
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.Location = new System.Drawing.Point(8, 37);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(390, 20);
            this.titleBox.TabIndex = 2;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(404, 8);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 72);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // previewWindow
            // 
            this.previewWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWindow.Location = new System.Drawing.Point(404, 37);
            this.previewWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWindow.Name = "previewWindow";
            this.tableLayoutPanel1.SetRowSpan(this.previewWindow, 3);
            this.previewWindow.Size = new System.Drawing.Size(199, 250);
            this.previewWindow.TabIndex = 5;
            // 
            // descriptionBox
            // 
            this.descriptionBox.AcceptsReturn = true;
            this.descriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBox.Location = new System.Drawing.Point(8, 93);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(390, 194);
            this.descriptionBox.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(404, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(199, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(121, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(40, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.boldButton);
            this.flowLayoutPanel2.Controls.Add(this.italicButton);
            this.flowLayoutPanel2.Controls.Add(this.exampleButton);
            this.flowLayoutPanel2.Controls.Add(this.headerButton);
            this.flowLayoutPanel2.Controls.Add(this.linebreakButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 293);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(390, 100);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selection:";
            // 
            // boldButton
            // 
            this.boldButton.Location = new System.Drawing.Point(63, 3);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(25, 23);
            this.boldButton.TabIndex = 0;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.Location = new System.Drawing.Point(94, 3);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(29, 23);
            this.italicButton.TabIndex = 3;
            this.italicButton.Text = "I";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // exampleButton
            // 
            this.exampleButton.Location = new System.Drawing.Point(129, 3);
            this.exampleButton.Name = "exampleButton";
            this.exampleButton.Size = new System.Drawing.Size(36, 23);
            this.exampleButton.TabIndex = 1;
            this.exampleButton.Text = "Ex.";
            this.exampleButton.UseVisualStyleBackColor = true;
            this.exampleButton.Click += new System.EventHandler(this.exampleButton_Click);
            // 
            // headerButton
            // 
            this.headerButton.Location = new System.Drawing.Point(171, 3);
            this.headerButton.Name = "headerButton";
            this.headerButton.Size = new System.Drawing.Size(26, 23);
            this.headerButton.TabIndex = 4;
            this.headerButton.Text = "H";
            this.headerButton.UseVisualStyleBackColor = true;
            this.headerButton.Click += new System.EventHandler(this.headerButton_Click);
            // 
            // linebreakButton
            // 
            this.linebreakButton.Location = new System.Drawing.Point(203, 3);
            this.linebreakButton.Name = "linebreakButton";
            this.linebreakButton.Size = new System.Drawing.Size(27, 23);
            this.linebreakButton.TabIndex = 5;
            this.linebreakButton.Text = "br";
            this.linebreakButton.UseVisualStyleBackColor = true;
            this.linebreakButton.Click += new System.EventHandler(this.linebreakButton_Click);
            // 
            // PartInputDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(611, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartInputDialog";
            this.ShowInTaskbar = false;
            this.Text = "PartInputDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.WebBrowser previewWindow;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button exampleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button headerButton;
        private System.Windows.Forms.Button linebreakButton;
    }
}