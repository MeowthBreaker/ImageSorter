﻿namespace ImageSorter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ImageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ColapseFoldersButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.CollapseOptionsButton = new System.Windows.Forms.Button();
            this.FolderListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SkipButton = new System.Windows.Forms.Button();
            this.NewImageFolderButton = new System.Windows.Forms.Button();
            this.ImagePropertiesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HotKeyLabel = new System.Windows.Forms.Label();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.NameFolderLabel = new System.Windows.Forms.Label();
            this.NameFolderTextBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.HotKeyButton = new System.Windows.Forms.Button();
            this.ClearFolderListViewButton = new System.Windows.Forms.Button();
            this.DeleteFolderButton = new System.Windows.Forms.Button();
            this.UpdateFolderButton = new System.Windows.Forms.Button();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProfileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.LoadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).BeginInit();
            this.ImageSplitContainer.Panel1.SuspendLayout();
            this.ImageSplitContainer.Panel2.SuspendLayout();
            this.ImageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsSplitContainer)).BeginInit();
            this.OptionsSplitContainer.Panel1.SuspendLayout();
            this.OptionsSplitContainer.Panel2.SuspendLayout();
            this.OptionsSplitContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ProfileMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            resources.ApplyResources(this.MainSplitContainer, "MainSplitContainer");
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ImageSplitContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.OptionsSplitContainer);
            this.MainSplitContainer.TabStop = false;
            // 
            // ImageSplitContainer
            // 
            resources.ApplyResources(this.ImageSplitContainer, "ImageSplitContainer");
            this.ImageSplitContainer.Name = "ImageSplitContainer";
            // 
            // ImageSplitContainer.Panel1
            // 
            this.ImageSplitContainer.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.ImageSplitContainer.Panel1.Controls.Add(this.ColapseFoldersButton);
            this.ImageSplitContainer.Panel1.Controls.Add(this.ImagePictureBox);
            this.ImageSplitContainer.Panel1.Controls.Add(this.CollapseOptionsButton);
            // 
            // ImageSplitContainer.Panel2
            // 
            this.ImageSplitContainer.Panel2.BackColor = System.Drawing.Color.Silver;
            this.ImageSplitContainer.Panel2.Controls.Add(this.FolderListView);
            this.ImageSplitContainer.TabStop = false;
            // 
            // ColapseFoldersButton
            // 
            resources.ApplyResources(this.ColapseFoldersButton, "ColapseFoldersButton");
            this.ColapseFoldersButton.BackColor = System.Drawing.Color.White;
            this.ColapseFoldersButton.FlatAppearance.BorderSize = 0;
            this.ColapseFoldersButton.Name = "ColapseFoldersButton";
            this.ColapseFoldersButton.TabStop = false;
            this.ColapseFoldersButton.UseVisualStyleBackColor = false;
            this.ColapseFoldersButton.Click += new System.EventHandler(this.ColapseFoldersButton_Click);
            // 
            // ImagePictureBox
            // 
            resources.ApplyResources(this.ImagePictureBox, "ImagePictureBox");
            this.ImagePictureBox.BackColor = System.Drawing.Color.Black;
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // CollapseOptionsButton
            // 
            resources.ApplyResources(this.CollapseOptionsButton, "CollapseOptionsButton");
            this.CollapseOptionsButton.BackColor = System.Drawing.Color.White;
            this.CollapseOptionsButton.FlatAppearance.BorderSize = 0;
            this.CollapseOptionsButton.Name = "CollapseOptionsButton";
            this.CollapseOptionsButton.TabStop = false;
            this.CollapseOptionsButton.UseVisualStyleBackColor = false;
            this.CollapseOptionsButton.Click += new System.EventHandler(this.CollapseOptionsButton_Click);
            // 
            // FolderListView
            // 
            this.FolderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            resources.ApplyResources(this.FolderListView, "FolderListView");
            this.FolderListView.FullRowSelect = true;
            this.FolderListView.HideSelection = false;
            this.FolderListView.Name = "FolderListView";
            this.FolderListView.TabStop = false;
            this.FolderListView.UseCompatibleStateImageBehavior = false;
            this.FolderListView.View = System.Windows.Forms.View.Details;
            this.FolderListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderListView_MouseClick);
            this.FolderListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderListView_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // OptionsSplitContainer
            // 
            resources.ApplyResources(this.OptionsSplitContainer, "OptionsSplitContainer");
            this.OptionsSplitContainer.Name = "OptionsSplitContainer";
            // 
            // OptionsSplitContainer.Panel1
            // 
            this.OptionsSplitContainer.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.OptionsSplitContainer.Panel1.Controls.Add(this.SkipButton);
            this.OptionsSplitContainer.Panel1.Controls.Add(this.NewImageFolderButton);
            this.OptionsSplitContainer.Panel1.Controls.Add(this.ImagePropertiesListView);
            // 
            // OptionsSplitContainer.Panel2
            // 
            this.OptionsSplitContainer.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.OptionsSplitContainer.Panel2.Controls.Add(this.HotKeyLabel);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.FolderPathLabel);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.NameFolderLabel);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.NameFolderTextBox);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.PathButton);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.HotKeyButton);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.ClearFolderListViewButton);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.DeleteFolderButton);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.UpdateFolderButton);
            this.OptionsSplitContainer.Panel2.Controls.Add(this.AddFolderButton);
            this.OptionsSplitContainer.TabStop = false;
            // 
            // SkipButton
            // 
            resources.ApplyResources(this.SkipButton, "SkipButton");
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.TabStop = false;
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // NewImageFolderButton
            // 
            resources.ApplyResources(this.NewImageFolderButton, "NewImageFolderButton");
            this.NewImageFolderButton.Name = "NewImageFolderButton";
            this.NewImageFolderButton.TabStop = false;
            this.NewImageFolderButton.UseVisualStyleBackColor = true;
            this.NewImageFolderButton.Click += new System.EventHandler(this.NewImageFolderButton_Click);
            // 
            // ImagePropertiesListView
            // 
            resources.ApplyResources(this.ImagePropertiesListView, "ImagePropertiesListView");
            this.ImagePropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ImagePropertiesListView.FullRowSelect = true;
            this.ImagePropertiesListView.HideSelection = false;
            this.ImagePropertiesListView.Name = "ImagePropertiesListView";
            this.ImagePropertiesListView.TabStop = false;
            this.ImagePropertiesListView.UseCompatibleStateImageBehavior = false;
            this.ImagePropertiesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // HotKeyLabel
            // 
            resources.ApplyResources(this.HotKeyLabel, "HotKeyLabel");
            this.HotKeyLabel.Name = "HotKeyLabel";
            // 
            // FolderPathLabel
            // 
            resources.ApplyResources(this.FolderPathLabel, "FolderPathLabel");
            this.FolderPathLabel.Name = "FolderPathLabel";
            // 
            // NameFolderLabel
            // 
            resources.ApplyResources(this.NameFolderLabel, "NameFolderLabel");
            this.NameFolderLabel.Name = "NameFolderLabel";
            // 
            // NameFolderTextBox
            // 
            this.NameFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.NameFolderTextBox, "NameFolderTextBox");
            this.NameFolderTextBox.Name = "NameFolderTextBox";
            this.NameFolderTextBox.TabStop = false;
            this.NameFolderTextBox.Enter += new System.EventHandler(this.NameFolderTextBox_Enter);
            this.NameFolderTextBox.Leave += new System.EventHandler(this.NameFolderTextBox_Leave);
            // 
            // PathButton
            // 
            resources.ApplyResources(this.PathButton, "PathButton");
            this.PathButton.Name = "PathButton";
            this.PathButton.TabStop = false;
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // HotKeyButton
            // 
            resources.ApplyResources(this.HotKeyButton, "HotKeyButton");
            this.HotKeyButton.Name = "HotKeyButton";
            this.HotKeyButton.TabStop = false;
            this.HotKeyButton.UseVisualStyleBackColor = true;
            this.HotKeyButton.Click += new System.EventHandler(this.HotKeyButton_Click);
            // 
            // ClearFolderListViewButton
            // 
            resources.ApplyResources(this.ClearFolderListViewButton, "ClearFolderListViewButton");
            this.ClearFolderListViewButton.Name = "ClearFolderListViewButton";
            this.ClearFolderListViewButton.TabStop = false;
            this.ClearFolderListViewButton.UseVisualStyleBackColor = true;
            this.ClearFolderListViewButton.Click += new System.EventHandler(this.ClearFolderListViewButton_Click);
            // 
            // DeleteFolderButton
            // 
            resources.ApplyResources(this.DeleteFolderButton, "DeleteFolderButton");
            this.DeleteFolderButton.Name = "DeleteFolderButton";
            this.DeleteFolderButton.TabStop = false;
            this.DeleteFolderButton.UseVisualStyleBackColor = true;
            this.DeleteFolderButton.Click += new System.EventHandler(this.DeleteFolderButton_Click);
            // 
            // UpdateFolderButton
            // 
            resources.ApplyResources(this.UpdateFolderButton, "UpdateFolderButton");
            this.UpdateFolderButton.Name = "UpdateFolderButton";
            this.UpdateFolderButton.TabStop = false;
            this.UpdateFolderButton.UseVisualStyleBackColor = true;
            this.UpdateFolderButton.Click += new System.EventHandler(this.UpdateFolderButton_Click);
            // 
            // AddFolderButton
            // 
            resources.ApplyResources(this.AddFolderButton, "AddFolderButton");
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.TabStop = false;
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MainSplitContainer);
            this.tabPage1.Controls.Add(this.ProfileMenuStrip);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProfileMenuStrip
            // 
            this.ProfileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadProfileToolStripMenuItem,
            this.SaveProfileToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            resources.ApplyResources(this.ProfileMenuStrip, "ProfileMenuStrip");
            this.ProfileMenuStrip.Name = "ProfileMenuStrip";
            // 
            // LoadProfileToolStripMenuItem
            // 
            this.LoadProfileToolStripMenuItem.Name = "LoadProfileToolStripMenuItem";
            resources.ApplyResources(this.LoadProfileToolStripMenuItem, "LoadProfileToolStripMenuItem");
            this.LoadProfileToolStripMenuItem.Click += new System.EventHandler(this.LoadProfileToolStripMenuItem_Click);
            // 
            // SaveProfileToolStripMenuItem
            // 
            this.SaveProfileToolStripMenuItem.Name = "SaveProfileToolStripMenuItem";
            resources.ApplyResources(this.SaveProfileToolStripMenuItem, "SaveProfileToolStripMenuItem");
            this.SaveProfileToolStripMenuItem.Click += new System.EventHandler(this.SaveProfileToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.ProfileMenuStrip;
            this.Name = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ImageSplitContainer.Panel1.ResumeLayout(false);
            this.ImageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).EndInit();
            this.ImageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.OptionsSplitContainer.Panel1.ResumeLayout(false);
            this.OptionsSplitContainer.Panel2.ResumeLayout(false);
            this.OptionsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsSplitContainer)).EndInit();
            this.OptionsSplitContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ProfileMenuStrip.ResumeLayout(false);
            this.ProfileMenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.SplitContainer ImageSplitContainer;
        private System.Windows.Forms.Button ColapseFoldersButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button CollapseOptionsButton;
        private System.Windows.Forms.ListView FolderListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.SplitContainer OptionsSplitContainer;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Button NewImageFolderButton;
        private System.Windows.Forms.ListView ImagePropertiesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label HotKeyLabel;
        private System.Windows.Forms.Label FolderPathLabel;
        private System.Windows.Forms.Label NameFolderLabel;
        private System.Windows.Forms.TextBox NameFolderTextBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Button HotKeyButton;
        private System.Windows.Forms.Button ClearFolderListViewButton;
        private System.Windows.Forms.Button DeleteFolderButton;
        private System.Windows.Forms.Button UpdateFolderButton;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.MenuStrip ProfileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LoadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

