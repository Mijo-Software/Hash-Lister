namespace HashLister
{
	partial class HasListerForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasListerForm));
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.listView = new System.Windows.Forms.ListView();
			this.toolStripStatusLabelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabelCancel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripButtonAddFiles = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonClearAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonProperties = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
			this.toolStripMenuItemAddFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAddFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemClearList = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSaveItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveItemAsText = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveItemAsCsv = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveItemAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButtonSaveItem = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemSaveAsText = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveAsCsv = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveAsHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.listView);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(624, 371);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(624, 442);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInformation,
            this.toolStripProgressBar,
            this.toolStripStatusLabelCancel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(624, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFiles,
            this.toolStripButtonAddFolder,
            this.toolStripSeparator1,
            this.toolStripButtonClearAll,
            this.toolStripButtonRefresh,
            this.toolStripSplitButtonSaveItem,
            this.toolStripButtonProperties,
            this.toolStripSeparator2,
            this.toolStripButtonExit});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip.Size = new System.Drawing.Size(624, 25);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TabStop = true;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// listView
			// 
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(0, 0);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(624, 371);
			this.listView.TabIndex = 1;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// toolStripStatusLabelInformation
			// 
			this.toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			this.toolStripStatusLabelInformation.Size = new System.Drawing.Size(70, 17);
			this.toolStripStatusLabelInformation.Text = "Information";
			this.toolStripStatusLabelInformation.ToolTipText = "Information";
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolStripProgressBar.ToolTipText = "Progress";
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemView,
            this.toolStripMenuItemHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip.Size = new System.Drawing.Size(624, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menu";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddFiles,
            this.toolStripMenuItemAddFolder,
            this.toolStripSeparator3,
            this.toolStripMenuItemSaveItem,
            this.toolStripSeparator5,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItemFile.Text = "File";
			this.toolStripMenuItemFile.ToolTipText = "File";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItemHelp
			// 
			this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
			this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
			this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuItemHelp.Text = "Help";
			this.toolStripMenuItemHelp.ToolTipText = "Help";
			// 
			// toolStripStatusLabelCancel
			// 
			this.toolStripStatusLabelCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStatusLabelCancel.Image = global::HashLister.Properties.Resources.fugue_cross_circle_16_shadowless;
			this.toolStripStatusLabelCancel.Name = "toolStripStatusLabelCancel";
			this.toolStripStatusLabelCancel.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabelCancel.ToolTipText = "Cancel";
			this.toolStripStatusLabelCancel.Click += new System.EventHandler(this.ToolStripStatusLabelCancel_Click);
			// 
			// toolStripButtonAddFiles
			// 
			this.toolStripButtonAddFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddFiles.Image = global::HashLister.Properties.Resources.fugue_folder_open_document_16_shadowless;
			this.toolStripButtonAddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddFiles.Name = "toolStripButtonAddFiles";
			this.toolStripButtonAddFiles.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddFiles.Text = "Add files";
			this.toolStripButtonAddFiles.ToolTipText = "Add files";
			this.toolStripButtonAddFiles.Click += new System.EventHandler(this.ToolStripButtonAddFiles_Click);
			// 
			// toolStripButtonAddFolder
			// 
			this.toolStripButtonAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddFolder.Enabled = false;
			this.toolStripButtonAddFolder.Image = global::HashLister.Properties.Resources.fugue_folder_open_16_shadowless;
			this.toolStripButtonAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddFolder.Name = "toolStripButtonAddFolder";
			this.toolStripButtonAddFolder.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddFolder.Text = "Add folder";
			this.toolStripButtonAddFolder.Click += new System.EventHandler(this.ToolStripButtonAddFolder_Click);
			// 
			// toolStripButtonClearAll
			// 
			this.toolStripButtonClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonClearAll.Enabled = false;
			this.toolStripButtonClearAll.Image = global::HashLister.Properties.Resources.fugue_cross_script_16_shadowless;
			this.toolStripButtonClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonClearAll.Name = "toolStripButtonClearAll";
			this.toolStripButtonClearAll.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonClearAll.Text = "Clear all";
			this.toolStripButtonClearAll.ToolTipText = "Clear all";
			this.toolStripButtonClearAll.Click += new System.EventHandler(this.ToolStripButtonClearAll_Click);
			// 
			// toolStripButtonRefresh
			// 
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Enabled = false;
			this.toolStripButtonRefresh.Image = global::HashLister.Properties.Resources.fugue_arrow_circle_16_shadowless;
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRefresh.Text = "Refresh";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.ToolStripButtonRefresh_Click);
			// 
			// toolStripButtonProperties
			// 
			this.toolStripButtonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonProperties.Enabled = false;
			this.toolStripButtonProperties.Image = global::HashLister.Properties.Resources.fugue_property_16_shadowless;
			this.toolStripButtonProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonProperties.Name = "toolStripButtonProperties";
			this.toolStripButtonProperties.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonProperties.Text = "Properties";
			this.toolStripButtonProperties.Click += new System.EventHandler(this.ToolStripButtonProperties_Click);
			// 
			// toolStripButtonExit
			// 
			this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExit.Image = global::HashLister.Properties.Resources.fugue_door_open_in_16_shadowless;
			this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExit.Name = "toolStripButtonExit";
			this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExit.Text = "Exit";
			this.toolStripButtonExit.ToolTipText = "Exit";
			this.toolStripButtonExit.Click += new System.EventHandler(this.ToolStripButtonExit_Click);
			// 
			// toolStripMenuItemAddFiles
			// 
			this.toolStripMenuItemAddFiles.Image = global::HashLister.Properties.Resources.fugue_folder_open_document_16_shadowless;
			this.toolStripMenuItemAddFiles.Name = "toolStripMenuItemAddFiles";
			this.toolStripMenuItemAddFiles.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemAddFiles.Text = "Add files";
			this.toolStripMenuItemAddFiles.ToolTipText = "Add files";
			this.toolStripMenuItemAddFiles.Click += new System.EventHandler(this.ToolStripMenuItemAddFiles_Click);
			// 
			// toolStripMenuItemAddFolder
			// 
			this.toolStripMenuItemAddFolder.Image = global::HashLister.Properties.Resources.fugue_folder_open_16_shadowless;
			this.toolStripMenuItemAddFolder.Name = "toolStripMenuItemAddFolder";
			this.toolStripMenuItemAddFolder.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemAddFolder.Text = "Add folder";
			this.toolStripMenuItemAddFolder.ToolTipText = "Add folder";
			this.toolStripMenuItemAddFolder.Click += new System.EventHandler(this.ToolStripMenuItemAddFolder_Click);
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Image = global::HashLister.Properties.Resources.fugue_property_16_shadowless;
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.propertiesToolStripMenuItem.Text = "Properties";
			this.propertiesToolStripMenuItem.ToolTipText = "Properties";
			this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Image = global::HashLister.Properties.Resources.fugue_door_open_in_16_shadowless;
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.ToolTipText = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemAbout
			// 
			this.toolStripMenuItemAbout.Image = global::HashLister.Properties.Resources.fugue_application_16_shadowless;
			this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			this.toolStripMenuItemAbout.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemAbout.Text = "About";
			this.toolStripMenuItemAbout.ToolTipText = "About";
			this.toolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
			// 
			// toolStripMenuItemView
			// 
			this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRefresh,
            this.toolStripMenuItemClearList});
			this.toolStripMenuItemView.Name = "toolStripMenuItemView";
			this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuItemView.Text = "View";
			this.toolStripMenuItemView.ToolTipText = "View";
			// 
			// toolStripMenuItemRefresh
			// 
			this.toolStripMenuItemRefresh.Image = global::HashLister.Properties.Resources.fugue_arrow_circle_16_shadowless;
			this.toolStripMenuItemRefresh.Name = "toolStripMenuItemRefresh";
			this.toolStripMenuItemRefresh.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemRefresh.Text = "Refresh";
			this.toolStripMenuItemRefresh.ToolTipText = "Refresh";
			this.toolStripMenuItemRefresh.Click += new System.EventHandler(this.ToolStripMenuItemRefresh_Click);
			// 
			// toolStripMenuItemClearList
			// 
			this.toolStripMenuItemClearList.Image = global::HashLister.Properties.Resources.fugue_cross_script_16_shadowless;
			this.toolStripMenuItemClearList.Name = "toolStripMenuItemClearList";
			this.toolStripMenuItemClearList.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemClearList.Text = "Clear list";
			this.toolStripMenuItemClearList.ToolTipText = "Clear list";
			this.toolStripMenuItemClearList.Click += new System.EventHandler(this.ToolStripMenuItemClearList_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
			// 
			// toolStripMenuItemSaveItem
			// 
			this.toolStripMenuItemSaveItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveItemAsText,
            this.toolStripMenuItemSaveItemAsCsv,
            this.toolStripMenuItemSaveItemAsHtml});
			this.toolStripMenuItemSaveItem.Image = global::HashLister.Properties.Resources.fugue_disk_16_shadowless;
			this.toolStripMenuItemSaveItem.Name = "toolStripMenuItemSaveItem";
			this.toolStripMenuItemSaveItem.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveItem.Text = "Save selected item";
			this.toolStripMenuItemSaveItem.ToolTipText = "Save selected item";
			// 
			// toolStripMenuItemSaveItemAsText
			// 
			this.toolStripMenuItemSaveItemAsText.Name = "toolStripMenuItemSaveItemAsText";
			this.toolStripMenuItemSaveItemAsText.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveItemAsText.Text = "As text";
			this.toolStripMenuItemSaveItemAsText.ToolTipText = "As text";
			this.toolStripMenuItemSaveItemAsText.Click += new System.EventHandler(this.ToolStripMenuItemSaveItemAsText_Click);
			// 
			// toolStripMenuItemSaveItemAsCsv
			// 
			this.toolStripMenuItemSaveItemAsCsv.Name = "toolStripMenuItemSaveItemAsCsv";
			this.toolStripMenuItemSaveItemAsCsv.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveItemAsCsv.Text = "As CSV";
			this.toolStripMenuItemSaveItemAsCsv.ToolTipText = "As CSV";
			this.toolStripMenuItemSaveItemAsCsv.Click += new System.EventHandler(this.ToolStripMenuItemSaveItemAsCsv_Click);
			// 
			// toolStripMenuItemSaveItemAsHtml
			// 
			this.toolStripMenuItemSaveItemAsHtml.Name = "toolStripMenuItemSaveItemAsHtml";
			this.toolStripMenuItemSaveItemAsHtml.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveItemAsHtml.Text = "As HTML";
			this.toolStripMenuItemSaveItemAsHtml.ToolTipText = "As HTML";
			this.toolStripMenuItemSaveItemAsHtml.Click += new System.EventHandler(this.ToolStripMenuItemSaveItemAsHtml_Click);
			// 
			// toolStripSplitButtonSaveItem
			// 
			this.toolStripSplitButtonSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonSaveItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveAsText,
            this.toolStripMenuItemSaveAsCsv,
            this.toolStripMenuItemSaveAsHtml});
			this.toolStripSplitButtonSaveItem.Image = global::HashLister.Properties.Resources.fugue_disk_16_shadowless;
			this.toolStripSplitButtonSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonSaveItem.Name = "toolStripSplitButtonSaveItem";
			this.toolStripSplitButtonSaveItem.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButtonSaveItem.Text = "Save selected item";
			this.toolStripSplitButtonSaveItem.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonSaveItem_ButtonClick);
			// 
			// toolStripMenuItemSaveAsText
			// 
			this.toolStripMenuItemSaveAsText.Name = "toolStripMenuItemSaveAsText";
			this.toolStripMenuItemSaveAsText.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveAsText.Text = "Save as text";
			this.toolStripMenuItemSaveAsText.ToolTipText = "Save as text";
			this.toolStripMenuItemSaveAsText.Click += new System.EventHandler(this.ToolStripMenuItemSaveAsText_Click);
			// 
			// toolStripMenuItemSaveAsCsv
			// 
			this.toolStripMenuItemSaveAsCsv.Name = "toolStripMenuItemSaveAsCsv";
			this.toolStripMenuItemSaveAsCsv.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveAsCsv.Text = "Save as CSV";
			this.toolStripMenuItemSaveAsCsv.ToolTipText = "Save as CSV";
			this.toolStripMenuItemSaveAsCsv.Click += new System.EventHandler(this.ToolStripMenuItemSaveAsCsv_Click);
			// 
			// toolStripMenuItemSaveAsHtml
			// 
			this.toolStripMenuItemSaveAsHtml.Name = "toolStripMenuItemSaveAsHtml";
			this.toolStripMenuItemSaveAsHtml.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemSaveAsHtml.Text = "Save as HTML";
			this.toolStripMenuItemSaveAsHtml.ToolTipText = "Save as HTML";
			this.toolStripMenuItemSaveAsHtml.Click += new System.EventHandler(this.ToolStripMenuItemSaveAsHtml_Click);
			// 
			// HasListerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "HasListerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hash Lister";
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddFiles;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddFolder;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
		private System.Windows.Forms.ToolStripButton toolStripButtonClearAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonExit;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInformation;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCancel;
		private System.Windows.Forms.ToolStripButton toolStripButtonProperties;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFiles;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFolder;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveItemAsText;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveItemAsCsv;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveItemAsHtml;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefresh;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearList;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSaveItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAsText;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAsCsv;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAsHtml;
	}
}

