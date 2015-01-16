namespace Disabler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enableList = new System.Windows.Forms.ListBox();
            this.disableList = new System.Windows.Forms.ListBox();
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.lastEnabledList = new System.Windows.Forms.ListBox();
            this.lastDisabledList = new System.Windows.Forms.ListBox();
            this.lastEnabledLabel = new System.Windows.Forms.Label();
            this.lastDisabledLabel = new System.Windows.Forms.Label();
            this.enSelectAll = new System.Windows.Forms.Button();
            this.enDeselectAll = new System.Windows.Forms.Button();
            this.diSelectAll = new System.Windows.Forms.Button();
            this.diDeselectAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshViewToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshViewToolStripMenuItem
            // 
            this.refreshViewToolStripMenuItem.Name = "refreshViewToolStripMenuItem";
            this.refreshViewToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshViewToolStripMenuItem.Text = "Refresh";
            this.refreshViewToolStripMenuItem.Click += new System.EventHandler(this.refreshViewToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click_1);
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(112, 27);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(328, 20);
            this.filePathTxtBox.TabIndex = 1;
            this.filePathTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filePathTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Folder: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enabled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disabled";
            // 
            // enableList
            // 
            this.enableList.FormattingEnabled = true;
            this.enableList.HorizontalScrollbar = true;
            this.enableList.Location = new System.Drawing.Point(40, 87);
            this.enableList.Name = "enableList";
            this.enableList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.enableList.Size = new System.Drawing.Size(330, 420);
            this.enableList.TabIndex = 7;
            this.enableList.SelectedIndexChanged += new System.EventHandler(this.enableList_SelectedIndexChanged);
            this.enableList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enableList_KeyDown);
            // 
            // disableList
            // 
            this.disableList.FormattingEnabled = true;
            this.disableList.HorizontalScrollbar = true;
            this.disableList.Location = new System.Drawing.Point(401, 87);
            this.disableList.Name = "disableList";
            this.disableList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.disableList.Size = new System.Drawing.Size(330, 420);
            this.disableList.TabIndex = 8;
            this.disableList.SelectedIndexChanged += new System.EventHandler(this.disableList_SelectedIndexChanged);
            this.disableList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableList_KeyDown);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(266, 542);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(244, 40);
            this.enableButton.TabIndex = 9;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(538, 542);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(244, 40);
            this.disableButton.TabIndex = 10;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(446, 24);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 11;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // lastEnabledList
            // 
            this.lastEnabledList.FormattingEnabled = true;
            this.lastEnabledList.Location = new System.Drawing.Point(764, 87);
            this.lastEnabledList.Name = "lastEnabledList";
            this.lastEnabledList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lastEnabledList.Size = new System.Drawing.Size(244, 186);
            this.lastEnabledList.TabIndex = 15;
            this.lastEnabledList.Click += new System.EventHandler(this.lastEnabledList_Click);
            this.lastEnabledList.SelectedIndexChanged += new System.EventHandler(this.lastEnabledList_SelectedIndexChanged);
            // 
            // lastDisabledList
            // 
            this.lastDisabledList.FormattingEnabled = true;
            this.lastDisabledList.Location = new System.Drawing.Point(764, 321);
            this.lastDisabledList.Name = "lastDisabledList";
            this.lastDisabledList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lastDisabledList.Size = new System.Drawing.Size(244, 186);
            this.lastDisabledList.TabIndex = 16;
            this.lastDisabledList.SelectedIndexChanged += new System.EventHandler(this.lastDisabledList_SelectedIndexChanged);
            // 
            // lastEnabledLabel
            // 
            this.lastEnabledLabel.AutoSize = true;
            this.lastEnabledLabel.Location = new System.Drawing.Point(852, 71);
            this.lastEnabledLabel.Name = "lastEnabledLabel";
            this.lastEnabledLabel.Size = new System.Drawing.Size(69, 13);
            this.lastEnabledLabel.TabIndex = 17;
            this.lastEnabledLabel.Text = "Last Enabled";
            // 
            // lastDisabledLabel
            // 
            this.lastDisabledLabel.AutoSize = true;
            this.lastDisabledLabel.Location = new System.Drawing.Point(850, 305);
            this.lastDisabledLabel.Name = "lastDisabledLabel";
            this.lastDisabledLabel.Size = new System.Drawing.Size(71, 13);
            this.lastDisabledLabel.TabIndex = 18;
            this.lastDisabledLabel.Text = "Last Disabled";
            this.lastDisabledLabel.Click += new System.EventHandler(this.lastDisabledLabel_Click);
            // 
            // enSelectAll
            // 
            this.enSelectAll.Location = new System.Drawing.Point(112, 513);
            this.enSelectAll.Name = "enSelectAll";
            this.enSelectAll.Size = new System.Drawing.Size(75, 23);
            this.enSelectAll.TabIndex = 19;
            this.enSelectAll.Text = "Select All";
            this.enSelectAll.UseVisualStyleBackColor = true;
            this.enSelectAll.Click += new System.EventHandler(this.enSelectAll_Click);
            // 
            // enDeselectAll
            // 
            this.enDeselectAll.Location = new System.Drawing.Point(228, 513);
            this.enDeselectAll.Name = "enDeselectAll";
            this.enDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.enDeselectAll.TabIndex = 20;
            this.enDeselectAll.Text = "Deselect All";
            this.enDeselectAll.UseVisualStyleBackColor = true;
            this.enDeselectAll.Click += new System.EventHandler(this.enDeselectAll_Click);
            // 
            // diSelectAll
            // 
            this.diSelectAll.Location = new System.Drawing.Point(472, 513);
            this.diSelectAll.Name = "diSelectAll";
            this.diSelectAll.Size = new System.Drawing.Size(75, 23);
            this.diSelectAll.TabIndex = 21;
            this.diSelectAll.Text = "Select All";
            this.diSelectAll.UseVisualStyleBackColor = true;
            this.diSelectAll.Click += new System.EventHandler(this.diSelectAll_Click);
            // 
            // diDeselectAll
            // 
            this.diDeselectAll.Location = new System.Drawing.Point(587, 513);
            this.diDeselectAll.Name = "diDeselectAll";
            this.diDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.diDeselectAll.TabIndex = 22;
            this.diDeselectAll.Text = "Deselect All";
            this.diDeselectAll.UseVisualStyleBackColor = true;
            this.diDeselectAll.Click += new System.EventHandler(this.diDeselectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1046, 593);
            this.Controls.Add(this.diDeselectAll);
            this.Controls.Add(this.diSelectAll);
            this.Controls.Add(this.enDeselectAll);
            this.Controls.Add(this.enSelectAll);
            this.Controls.Add(this.lastDisabledLabel);
            this.Controls.Add(this.lastEnabledLabel);
            this.Controls.Add(this.lastDisabledList);
            this.Controls.Add(this.lastEnabledList);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.disableList);
            this.Controls.Add(this.enableList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1062, 632);
            this.MinimumSize = new System.Drawing.Size(1062, 632);
            this.Name = "Form1";
            this.Text = "Disabler 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox enableList;
        private System.Windows.Forms.ListBox disableList;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListBox lastEnabledList;
        private System.Windows.Forms.ListBox lastDisabledList;
        private System.Windows.Forms.Label lastEnabledLabel;
        private System.Windows.Forms.Label lastDisabledLabel;
        private System.Windows.Forms.Button enSelectAll;
        private System.Windows.Forms.Button enDeselectAll;
        private System.Windows.Forms.Button diSelectAll;
        private System.Windows.Forms.Button diDeselectAll;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

