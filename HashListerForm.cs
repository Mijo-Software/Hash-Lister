using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HashLister
{
	public partial class HasListerForm : Form
	{
		private string statusBarBackup = "";

		public HasListerForm()
		{
			InitializeComponent();
		}

		private void HasListerForm_Load(object sender, EventArgs e)
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripProgressBar.Visible = false;
			toolStripStatusLabelCancel.Visible = false;
		}

		private string Satusbar
		{
			get
			{
				return toolStripStatusLabelInformation.Text;
			}
			set
			{
				statusBarBackup = toolStripStatusLabelInformation.Text;
				toolStripStatusLabelInformation.Text = value;
			}
		}

		private void AddFiles()
		{
		}

		private void AddFolder()
		{

			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				toolStripStatusLabelInformation.Visible = true;
				Satusbar = "Scanning...";
				toolStripProgressBar.Visible = true;
				toolStripProgressBar.Style = ProgressBarStyle.Marquee;
				string path = folderBrowserDialog.SelectedPath;

				List<string> files = new List<string>();
				getFilesRecursive(path);

				void getFilesRecursive(string sDir)
				{
					try
					{
						foreach (string d in Directory.GetDirectories(sDir))
						{
							getFilesRecursive(d);
						}
						foreach (var file in Directory.GetFiles(sDir))
						{
							//This is where you would manipulate each file found, e.g.:
							DoAction(file);
						}
					}
					catch (System.Exception e)
					{
						MessageBox.Show(e.Message);
					}
				}

				void DoAction(string filepath)
				{
					files.Add(filepath);
					Satusbar = files.Capacity.ToString() + " files found.";
				}


				//string path = folderBrowserDialog.SelectedPath;
				//string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);


				toolStripProgressBar.Visible = false;
				Satusbar = files.Capacity.ToString() + " files found.";
			}
		}

		private void ClearList()
		{
		}

		private void DoRefresh()
		{
		}

		private void SaveItemAsText()
		{
		}

		private void SaveItemAsCsv()
		{
		}

		private void SaveItemAsHtml()
		{
		}

		private void ShowProperties()
		{
		}

		private void Exit()
		{
			Close();
		}

		private void ShowAbout()
		{
			new AboutBox().ShowDialog();
		}

		private void ToolStripButtonAddFiles_Click(object sender, EventArgs e)
		{
			AddFiles();
		}

		private void ToolStripButtonAddFolder_Click(object sender, EventArgs e)
		{
			AddFolder();
		}

		private void ToolStripButtonClearAll_Click(object sender, EventArgs e)
		{
			ClearList();
		}

		private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			DoRefresh();
		}

		private void ToolStripButtonProperties_Click(object sender, EventArgs e)
		{
			ShowProperties();
		}

		private void ToolStripButtonExit_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void ToolStripStatusLabelCancel_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemAddFiles_Click(object sender, EventArgs e)
		{
			AddFiles();
		}

		private void ToolStripMenuItemAddFolder_Click(object sender, EventArgs e)
		{
			AddFolder();
		}

		private void ToolStripSplitButtonSaveItem_ButtonClick(object sender, EventArgs e)
		{
			SaveItemAsText();
		}

		private void ToolStripMenuItemSaveItemAsText_Click(object sender, EventArgs e)
		{
			SaveItemAsText();
		}

		private void ToolStripMenuItemSaveItemAsCsv_Click(object sender, EventArgs e)
		{
			SaveItemAsCsv();
		}

		private void ToolStripMenuItemSaveItemAsHtml_Click(object sender, EventArgs e)
		{
			SaveItemAsHtml();
		}

		private void ToolStripMenuItemSaveAsText_Click(object sender, EventArgs e)
		{
			SaveItemAsText();
		}

		private void ToolStripMenuItemSaveAsCsv_Click(object sender, EventArgs e)
		{
			SaveItemAsCsv();
		}

		private void ToolStripMenuItemSaveAsHtml_Click(object sender, EventArgs e)
		{
			SaveItemAsHtml();
		}

		private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowProperties();
		}

		private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void ToolStripMenuItemRefresh_Click(object sender, EventArgs e)
		{
			DoRefresh();
		}

		private void ToolStripMenuItemClearList_Click(object sender, EventArgs e)
		{
			ClearList();
		}

		private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
		{
			ShowAbout();
		}
	}
}
