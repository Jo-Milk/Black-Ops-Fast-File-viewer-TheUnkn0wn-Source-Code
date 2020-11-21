namespace Black_Ops_FF_Viewer
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0004A750 File Offset: 0x00048B50
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0004A790 File Offset: 0x00048B90
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Black_Ops_FF_Viewer.Form1));
			this.OD = new global::System.Windows.Forms.OpenFileDialog();
			this.FileList = new global::System.Windows.Forms.ListBox();
			this.ListMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InjectToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RenameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExtractToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu = new global::System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExportAsBlockFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Edit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.KeyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Xbox360ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PS3ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SD = new global::System.Windows.Forms.SaveFileDialog();
			this.CodeMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Code = new global::ICSharpCode.TextEditor.TextEditorControl();
			this.FastFileNameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FastFileName = new global::System.Windows.Forms.ToolStripTextBox();
			this.ListMenu.SuspendLayout();
			this.MainMenu.SuspendLayout();
			this.CodeMenu.SuspendLayout();
			this.SuspendLayout();
			this.FileList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.FileList.ContextMenuStrip = this.ListMenu;
			this.FileList.Enabled = false;
			this.FileList.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FileList.FormattingEnabled = true;
			this.FileList.HorizontalScrollbar = true;
			this.FileList.ItemHeight = 15;
			global::System.Windows.Forms.Control fileList = this.FileList;
			global::System.Drawing.Point location = new global::System.Drawing.Point(1, 24);
			fileList.Location = location;
			this.FileList.Name = "FileList";
			global::System.Windows.Forms.Control fileList2 = this.FileList;
			global::System.Drawing.Size size = new global::System.Drawing.Size(315, 454);
			fileList2.Size = size;
			this.FileList.TabIndex = 4;
			this.ListMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CopyToolStripMenuItem,
				this.InjectToolStripMenuItem,
				this.ExtractToolStripMenuItem
			});
			this.ListMenu.Name = "ListMenu";
			global::System.Windows.Forms.Control listMenu = this.ListMenu;
			size = new global::System.Drawing.Size(159, 70);
			listMenu.Size = size;
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new global::System.Drawing.Size(158, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copy File Name";
			this.InjectToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SaveToolStripMenuItem1,
				this.RenameToolStripMenuItem
			});
			this.InjectToolStripMenuItem.Name = "InjectToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem injectToolStripMenuItem = this.InjectToolStripMenuItem;
			size = new global::System.Drawing.Size(158, 22);
			injectToolStripMenuItem.Size = size;
			this.InjectToolStripMenuItem.Text = "Inject";
			this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem saveToolStripMenuItem = this.SaveToolStripMenuItem1;
			size = new global::System.Drawing.Size(117, 22);
			saveToolStripMenuItem.Size = size;
			this.SaveToolStripMenuItem1.Text = "Save";
			this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem renameToolStripMenuItem = this.RenameToolStripMenuItem;
			size = new global::System.Drawing.Size(117, 22);
			renameToolStripMenuItem.Size = size;
			this.RenameToolStripMenuItem.Text = "Rename";
			this.ExtractToolStripMenuItem.Name = "ExtractToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem extractToolStripMenuItem = this.ExtractToolStripMenuItem;
			size = new global::System.Drawing.Size(158, 22);
			extractToolStripMenuItem.Size = size;
			this.ExtractToolStripMenuItem.Text = "Extract";
			this.MainMenu.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.MainMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.FileToolStripMenuItem,
				this.Edit,
				this.KeyToolStripMenuItem,
				this.AboutToolStripMenuItem
			});
			global::System.Windows.Forms.Control mainMenu = this.MainMenu;
			location = new global::System.Drawing.Point(0, 0);
			mainMenu.Location = location;
			this.MainMenu.Name = "MainMenu";
			global::System.Windows.Forms.Control mainMenu2 = this.MainMenu;
			size = new global::System.Drawing.Size(953, 24);
			mainMenu2.Size = size;
			this.MainMenu.TabIndex = 5;
			this.MainMenu.Text = "MainMenu";
			this.FileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.OpenToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.ToolStripSeparator1,
				this.ToolStripMenuItem1,
				this.ExportAsBlockFileToolStripMenuItem,
				this.ToolStripSeparator2,
				this.ExitToolStripMenuItem
			});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem fileToolStripMenuItem = this.FileToolStripMenuItem;
			size = new global::System.Drawing.Size(37, 20);
			fileToolStripMenuItem.Size = size;
			this.FileToolStripMenuItem.Text = "File";
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem openToolStripMenuItem = this.OpenToolStripMenuItem;
			size = new global::System.Drawing.Size(163, 22);
			openToolStripMenuItem.Size = size;
			this.OpenToolStripMenuItem.Text = "Open";
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem saveToolStripMenuItem2 = this.SaveToolStripMenuItem;
			size = new global::System.Drawing.Size(163, 22);
			saveToolStripMenuItem2.Size = size;
			this.SaveToolStripMenuItem.Text = "Save";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			size = new global::System.Drawing.Size(160, 6);
			toolStripSeparator.Size = size;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(163, 22);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Import Block File";
			this.ExportAsBlockFileToolStripMenuItem.Name = "ExportAsBlockFileToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exportAsBlockFileToolStripMenuItem = this.ExportAsBlockFileToolStripMenuItem;
			size = new global::System.Drawing.Size(163, 22);
			exportAsBlockFileToolStripMenuItem.Size = size;
			this.ExportAsBlockFileToolStripMenuItem.Text = "Export Block File";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator2;
			size = new global::System.Drawing.Size(160, 6);
			toolStripSeparator2.Size = size;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exitToolStripMenuItem = this.ExitToolStripMenuItem;
			size = new global::System.Drawing.Size(163, 22);
			exitToolStripMenuItem.Size = size;
			this.ExitToolStripMenuItem.Text = "Exit";
			this.Edit.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CutToolStripMenuItem1,
				this.CopyToolStripMenuItem2,
				this.PasteToolStripMenuItem1,
				this.ToolStripSeparator3,
				this.FastFileNameToolStripMenuItem
			});
			this.Edit.Enabled = false;
			this.Edit.Name = "Edit";
			global::System.Windows.Forms.ToolStripItem edit = this.Edit;
			size = new global::System.Drawing.Size(39, 20);
			edit.Size = size;
			this.Edit.Text = "Edit";
			this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem cutToolStripMenuItem = this.CutToolStripMenuItem1;
			size = new global::System.Drawing.Size(152, 22);
			cutToolStripMenuItem.Size = size;
			this.CutToolStripMenuItem1.Text = "Cut";
			this.CopyToolStripMenuItem2.Name = "CopyToolStripMenuItem2";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem2 = this.CopyToolStripMenuItem2;
			size = new global::System.Drawing.Size(152, 22);
			copyToolStripMenuItem2.Size = size;
			this.CopyToolStripMenuItem2.Text = "Copy";
			this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem pasteToolStripMenuItem = this.PasteToolStripMenuItem1;
			size = new global::System.Drawing.Size(152, 22);
			pasteToolStripMenuItem.Size = size;
			this.PasteToolStripMenuItem1.Text = "Paste";
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator3;
			size = new global::System.Drawing.Size(149, 6);
			toolStripSeparator3.Size = size;
			this.KeyToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Xbox360ToolStripMenuItem,
				this.PS3ToolStripMenuItem
			});
			this.KeyToolStripMenuItem.Name = "KeyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem keyToolStripMenuItem = this.KeyToolStripMenuItem;
			size = new global::System.Drawing.Size(38, 20);
			keyToolStripMenuItem.Size = size;
			this.KeyToolStripMenuItem.Text = "Key";
			this.Xbox360ToolStripMenuItem.CheckOnClick = true;
			this.Xbox360ToolStripMenuItem.Name = "Xbox360ToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem xbox360ToolStripMenuItem = this.Xbox360ToolStripMenuItem;
			size = new global::System.Drawing.Size(121, 22);
			xbox360ToolStripMenuItem.Size = size;
			this.Xbox360ToolStripMenuItem.Text = "Xbox 360";
			this.PS3ToolStripMenuItem.Checked = true;
			this.PS3ToolStripMenuItem.CheckOnClick = true;
			this.PS3ToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.PS3ToolStripMenuItem.Name = "PS3ToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem ps3ToolStripMenuItem = this.PS3ToolStripMenuItem;
			size = new global::System.Drawing.Size(121, 22);
			ps3ToolStripMenuItem.Size = size;
			this.PS3ToolStripMenuItem.Text = "PS3";
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem aboutToolStripMenuItem = this.AboutToolStripMenuItem;
			size = new global::System.Drawing.Size(52, 20);
			aboutToolStripMenuItem.Size = size;
			this.AboutToolStripMenuItem.Text = "About";
			this.CodeMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CutToolStripMenuItem,
				this.CopyToolStripMenuItem1,
				this.PasteToolStripMenuItem
			});
			this.CodeMenu.Name = "CodeMenu";
			global::System.Windows.Forms.Control codeMenu = this.CodeMenu;
			size = new global::System.Drawing.Size(103, 70);
			codeMenu.Size = size;
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem cutToolStripMenuItem2 = this.CutToolStripMenuItem;
			size = new global::System.Drawing.Size(102, 22);
			cutToolStripMenuItem2.Size = size;
			this.CutToolStripMenuItem.Text = "Cut";
			this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem3 = this.CopyToolStripMenuItem1;
			size = new global::System.Drawing.Size(102, 22);
			copyToolStripMenuItem3.Size = size;
			this.CopyToolStripMenuItem1.Text = "Copy";
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem pasteToolStripMenuItem2 = this.PasteToolStripMenuItem;
			size = new global::System.Drawing.Size(102, 22);
			pasteToolStripMenuItem2.Size = size;
			this.PasteToolStripMenuItem.Text = "Paste";
			this.Code.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Code.ContextMenuStrip = this.CodeMenu;
			this.Code.Enabled = false;
			this.Code.IsReadOnly = false;
			global::System.Windows.Forms.Control code = this.Code;
			location = new global::System.Drawing.Point(322, 24);
			code.Location = location;
			this.Code.Name = "Code";
			global::System.Windows.Forms.Control code2 = this.Code;
			size = new global::System.Drawing.Size(631, 454);
			code2.Size = size;
			this.Code.TabIndex = 6;
			this.FastFileNameToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.FastFileName
			});
			this.FastFileNameToolStripMenuItem.Name = "FastFileNameToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem fastFileNameToolStripMenuItem = this.FastFileNameToolStripMenuItem;
			size = new global::System.Drawing.Size(152, 22);
			fastFileNameToolStripMenuItem.Size = size;
			this.FastFileNameToolStripMenuItem.Text = "FastFile Name";
			this.FastFileName.MaxLength = 32;
			this.FastFileName.Name = "FastFileName";
			global::System.Windows.Forms.ToolStripControlHost fastFileName = this.FastFileName;
			size = new global::System.Drawing.Size(100, 23);
			fastFileName.Size = size;
			this.FastFileName.TextBoxTextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			size = new global::System.Drawing.Size(953, 479);
			this.ClientSize = size;
			this.Controls.Add(this.Code);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.FileList);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MainMenu;
			this.Name = "Form1";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Black Ops - FastFile Viewer";
			this.ListMenu.ResumeLayout(false);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.CodeMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;
	}
}
