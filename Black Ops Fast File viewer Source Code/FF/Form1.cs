using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Black_Ops_FF_Viewer.My;
using ICSharpCode.TextEditor;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

//This isn't my source code it's TheUnkn0wn : https://www.se7ensins.com/forums/threads/black-ops-fastfile-viewer.705229/
//I didn't know how to reach him to get the source so I reversed his exe and his dll
//I had my own source but wanted his import export code and I realize why just reverse it might as well use his it<s for educational purposes and for open source
//signed Jo-Milk

namespace Black_Ops_FF_Viewer
{
	// Token: 0x02000008 RID: 8
	//[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0004A6F0 File Offset: 0x00048AF0
		public Form1()
		{
			base.Load += this.Form1_Load;
			base.FormClosing += this.Form1_FormClosing;
			this.FFCount = 0;
			this.OldIndex = -1;
			this.Creator = "TheUnkn0wn";
			this.ShowInjectChanges = false;
			this.InitializeComponent();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0004B45C File Offset: 0x0004985C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0004B470 File Offset: 0x00049870
		internal virtual OpenFileDialog OD
		{
			get
			{
				return this._OD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OD = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0004B47C File Offset: 0x0004987C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0004B490 File Offset: 0x00049890
		internal virtual ListBox FileList
		{
			get
			{
				return this._FileList;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FileList_SelectedIndexChanged);
				if (this._FileList != null)
				{
					this._FileList.SelectedIndexChanged -= value2;
				}
				this._FileList = value;
				if (this._FileList != null)
				{
					this._FileList.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0004B4DC File Offset: 0x000498DC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0004B4F0 File Offset: 0x000498F0
		internal virtual ContextMenuStrip ListMenu
		{
			get
			{
				return this._ListMenu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListMenu = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0004B4FC File Offset: 0x000498FC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0004B510 File Offset: 0x00049910
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem_Click);
				if (this._CopyToolStripMenuItem != null)
				{
					this._CopyToolStripMenuItem.Click -= value2;
				}
				this._CopyToolStripMenuItem = value;
				if (this._CopyToolStripMenuItem != null)
				{
					this._CopyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0004B55C File Offset: 0x0004995C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0004B570 File Offset: 0x00049970
		internal virtual MenuStrip MainMenu
		{
			get
			{
				return this._MainMenu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainMenu = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0004B57C File Offset: 0x0004997C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0004B590 File Offset: 0x00049990
		internal virtual ToolStripMenuItem FileToolStripMenuItem
		{
			get
			{
				return this._FileToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FileToolStripMenuItem = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0004B59C File Offset: 0x0004999C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0004B5B0 File Offset: 0x000499B0
		internal virtual ToolStripMenuItem OpenToolStripMenuItem
		{
			get
			{
				return this._OpenToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenToolStripMenuItem_Click);
				if (this._OpenToolStripMenuItem != null)
				{
					this._OpenToolStripMenuItem.Click -= value2;
				}
				this._OpenToolStripMenuItem = value;
				if (this._OpenToolStripMenuItem != null)
				{
					this._OpenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0004B5FC File Offset: 0x000499FC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0004B610 File Offset: 0x00049A10
		internal virtual ToolStripMenuItem SaveToolStripMenuItem
		{
			get
			{
				return this._SaveToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem_Click);
				if (this._SaveToolStripMenuItem != null)
				{
					this._SaveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem = value;
				if (this._SaveToolStripMenuItem != null)
				{
					this._SaveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0004B65C File Offset: 0x00049A5C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0004B670 File Offset: 0x00049A70
		internal virtual ToolStripMenuItem InjectToolStripMenuItem
		{
			get
			{
				return this._InjectToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._InjectToolStripMenuItem = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0004B67C File Offset: 0x00049A7C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0004B690 File Offset: 0x00049A90
		internal virtual ToolStripMenuItem SaveToolStripMenuItem1
		{
			get
			{
				return this._SaveToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem1_Click);
				if (this._SaveToolStripMenuItem1 != null)
				{
					this._SaveToolStripMenuItem1.Click -= value2;
				}
				this._SaveToolStripMenuItem1 = value;
				if (this._SaveToolStripMenuItem1 != null)
				{
					this._SaveToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0004B6DC File Offset: 0x00049ADC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0004B6F0 File Offset: 0x00049AF0
		internal virtual ToolStripMenuItem RenameToolStripMenuItem
		{
			get
			{
				return this._RenameToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RenameToolStripMenuItem_Click);
				if (this._RenameToolStripMenuItem != null)
				{
					this._RenameToolStripMenuItem.Click -= value2;
				}
				this._RenameToolStripMenuItem = value;
				if (this._RenameToolStripMenuItem != null)
				{
					this._RenameToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0004B73C File Offset: 0x00049B3C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0004B750 File Offset: 0x00049B50
		internal virtual SaveFileDialog SD
		{
			get
			{
				return this._SD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SD = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0004B75C File Offset: 0x00049B5C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0004B770 File Offset: 0x00049B70
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0004B77C File Offset: 0x00049B7C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0004B790 File Offset: 0x00049B90
		internal virtual ToolStripMenuItem ExportAsBlockFileToolStripMenuItem
		{
			get
			{
				return this._ExportAsBlockFileToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExportAsBlockFileToolStripMenuItem_Click);
				if (this._ExportAsBlockFileToolStripMenuItem != null)
				{
					this._ExportAsBlockFileToolStripMenuItem.Click -= value2;
				}
				this._ExportAsBlockFileToolStripMenuItem = value;
				if (this._ExportAsBlockFileToolStripMenuItem != null)
				{
					this._ExportAsBlockFileToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0004B7DC File Offset: 0x00049BDC
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0004B7F0 File Offset: 0x00049BF0
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0004B7FC File Offset: 0x00049BFC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0004B810 File Offset: 0x00049C10
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitToolStripMenuItem_Click);
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click -= value2;
				}
				this._ExitToolStripMenuItem = value;
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0004B85C File Offset: 0x00049C5C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0004B870 File Offset: 0x00049C70
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem1_Click);
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click -= value2;
				}
				this._ToolStripMenuItem1 = value;
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0004B8BC File Offset: 0x00049CBC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0004B8D0 File Offset: 0x00049CD0
		internal virtual ToolStripMenuItem KeyToolStripMenuItem
		{
			get
			{
				return this._KeyToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KeyToolStripMenuItem = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0004B8DC File Offset: 0x00049CDC
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0004B8F0 File Offset: 0x00049CF0
		internal virtual ToolStripMenuItem Xbox360ToolStripMenuItem
		{
			get
			{
				return this._Xbox360ToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Xbox360ToolStripMenuItem_Click);
				if (this._Xbox360ToolStripMenuItem != null)
				{
					this._Xbox360ToolStripMenuItem.Click -= value2;
				}
				this._Xbox360ToolStripMenuItem = value;
				if (this._Xbox360ToolStripMenuItem != null)
				{
					this._Xbox360ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0004B93C File Offset: 0x00049D3C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0004B950 File Offset: 0x00049D50
		internal virtual ToolStripMenuItem PS3ToolStripMenuItem
		{
			get
			{
				return this._PS3ToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PS3ToolStripMenuItem_Click);
				if (this._PS3ToolStripMenuItem != null)
				{
					this._PS3ToolStripMenuItem.Click -= value2;
				}
				this._PS3ToolStripMenuItem = value;
				if (this._PS3ToolStripMenuItem != null)
				{
					this._PS3ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0004B99C File Offset: 0x00049D9C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0004B9B0 File Offset: 0x00049DB0
		internal virtual TextEditorControl Code
		{
			get
			{
				return this._Code;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Code_TextChanged);
				if (this._Code != null)
				{
					this._Code.TextChanged -= eventHandler;
				}
				this._Code = value;
				if (this._Code != null)
				{
					this._Code.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0004B9FC File Offset: 0x00049DFC
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0004BA10 File Offset: 0x00049E10
		internal virtual ToolStripMenuItem ExtractToolStripMenuItem
		{
			get
			{
				return this._ExtractToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExtractToolStripMenuItem_Click);
				if (this._ExtractToolStripMenuItem != null)
				{
					this._ExtractToolStripMenuItem.Click -= value2;
				}
				this._ExtractToolStripMenuItem = value;
				if (this._ExtractToolStripMenuItem != null)
				{
					this._ExtractToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0004BA5C File Offset: 0x00049E5C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0004BA70 File Offset: 0x00049E70
		internal virtual ContextMenuStrip CodeMenu
		{
			get
			{
				return this._CodeMenu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CodeMenu = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0004BA7C File Offset: 0x00049E7C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0004BA90 File Offset: 0x00049E90
		internal virtual ToolStripMenuItem CopyToolStripMenuItem1
		{
			get
			{
				return this._CopyToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem1_Click);
				if (this._CopyToolStripMenuItem1 != null)
				{
					this._CopyToolStripMenuItem1.Click -= value2;
				}
				this._CopyToolStripMenuItem1 = value;
				if (this._CopyToolStripMenuItem1 != null)
				{
					this._CopyToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0004BADC File Offset: 0x00049EDC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0004BAF0 File Offset: 0x00049EF0
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem_Click);
				if (this._PasteToolStripMenuItem != null)
				{
					this._PasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem = value;
				if (this._PasteToolStripMenuItem != null)
				{
					this._PasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0004BB3C File Offset: 0x00049F3C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0004BB50 File Offset: 0x00049F50
		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			get
			{
				return this._CutToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem_Click);
				if (this._CutToolStripMenuItem != null)
				{
					this._CutToolStripMenuItem.Click -= value2;
				}
				this._CutToolStripMenuItem = value;
				if (this._CutToolStripMenuItem != null)
				{
					this._CutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0004BB9C File Offset: 0x00049F9C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0004BBB0 File Offset: 0x00049FB0
		internal virtual ToolStripMenuItem AboutToolStripMenuItem
		{
			get
			{
				return this._AboutToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AboutToolStripMenuItem_Click);
				if (this._AboutToolStripMenuItem != null)
				{
					this._AboutToolStripMenuItem.Click -= value2;
				}
				this._AboutToolStripMenuItem = value;
				if (this._AboutToolStripMenuItem != null)
				{
					this._AboutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0004BBFC File Offset: 0x00049FFC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0004BC10 File Offset: 0x0004A010
		internal virtual ToolStripMenuItem Edit
		{
			get
			{
				return this._Edit;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Edit = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0004BC1C File Offset: 0x0004A01C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0004BC30 File Offset: 0x0004A030
		internal virtual ToolStripMenuItem CutToolStripMenuItem1
		{
			get
			{
				return this._CutToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem1_Click);
				if (this._CutToolStripMenuItem1 != null)
				{
					this._CutToolStripMenuItem1.Click -= value2;
				}
				this._CutToolStripMenuItem1 = value;
				if (this._CutToolStripMenuItem1 != null)
				{
					this._CutToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0004BC7C File Offset: 0x0004A07C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0004BC90 File Offset: 0x0004A090
		internal virtual ToolStripMenuItem CopyToolStripMenuItem2
		{
			get
			{
				return this._CopyToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem2_Click);
				if (this._CopyToolStripMenuItem2 != null)
				{
					this._CopyToolStripMenuItem2.Click -= value2;
				}
				this._CopyToolStripMenuItem2 = value;
				if (this._CopyToolStripMenuItem2 != null)
				{
					this._CopyToolStripMenuItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0004BCDC File Offset: 0x0004A0DC
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0004BCF0 File Offset: 0x0004A0F0
		internal virtual ToolStripMenuItem PasteToolStripMenuItem1
		{
			get
			{
				return this._PasteToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem1_Click);
				if (this._PasteToolStripMenuItem1 != null)
				{
					this._PasteToolStripMenuItem1.Click -= value2;
				}
				this._PasteToolStripMenuItem1 = value;
				if (this._PasteToolStripMenuItem1 != null)
				{
					this._PasteToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0004BD3C File Offset: 0x0004A13C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0004BD50 File Offset: 0x0004A150
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0004BD5C File Offset: 0x0004A15C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0004BD70 File Offset: 0x0004A170
		internal virtual ToolStripMenuItem FastFileNameToolStripMenuItem
		{
			get
			{
				return this._FastFileNameToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FastFileNameToolStripMenuItem = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0004BD7C File Offset: 0x0004A17C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0004BD90 File Offset: 0x0004A190
		internal virtual ToolStripTextBox FastFileName
		{
			get
			{
				return this._FastFileName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FastFileName = value;
			}
		}

		// Token: 0x06000066 RID: 102
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int Viewer_LoadFastFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string File);

		// Token: 0x06000067 RID: 103
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int Viewer_LoadBlockFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string File);

		// Token: 0x06000068 RID: 104
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr Viewer_GetFastFileName();

		// Token: 0x06000069 RID: 105
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr Viewer_GetFileName(int Index);

		// Token: 0x0600006A RID: 106
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr Viewer_GetDecompressedData(int Index);

		// Token: 0x0600006B RID: 107
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int Viewer_GetDecompressedDataSize(int Index);

		// Token: 0x0600006C RID: 108
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern bool Viewer_SetData(int Index, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Data, int Size);

		// Token: 0x0600006D RID: 109
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern void Viewer_Rename(int Index, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

		// Token: 0x0600006E RID: 110
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void Viewer_Save([MarshalAs(UnmanagedType.VBByRefStr)] ref string Destination, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FastFileName);

		// Token: 0x0600006F RID: 111
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void Viewer_SaveBlock([MarshalAs(UnmanagedType.VBByRefStr)] ref string Destination);

		// Token: 0x06000070 RID: 112
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void Viewer_Unload();

		// Token: 0x06000071 RID: 113
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void Viewer_ExtractDecompressedData(int Index, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Destination);

		// Token: 0x06000072 RID: 114
		[DllImport("FF32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void Keys_SetKey(int Platform);

		// Token: 0x06000073 RID: 115 RVA: 0x0004BD9C File Offset: 0x0004A19C
		public string LoadFileName(int Index)
		{
			return Marshal.PtrToStringAnsi(Form1.Viewer_GetFileName(Index));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0004BDB4 File Offset: 0x0004A1B4
		public string LoadDecompressedData(int Index)
		{
			return Marshal.PtrToStringAnsi(Form1.Viewer_GetDecompressedData(Index));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0004BDCC File Offset: 0x0004A1CC
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.FileList.Items.Count > 0)
			{
				Form1.Viewer_Unload();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0004BDE8 File Offset: 0x0004A1E8
		private void FileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ShowInjectChanges && MessageBox.Show("Any un-injected changes will be lost. Would you like to inject your changes?", "Inject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				int oldIndex = this.OldIndex;
				TextEditorControl code = this.Code;
				string text = code.Text;
				bool flag = Form1.Viewer_SetData(oldIndex, ref text, this.Code.Text.Length);
				code.Text = text;
				if (flag)
				{
					MessageBox.Show("Injected Successfully!", "Inject", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.ShowInjectChanges = false;
				}
				else
				{
					this.ShowInjectChanges = false;
					this.FileList.SelectedIndex = this.OldIndex;
					this.ShowInjectChanges = true;
				}
			}
			if (this.OldIndex != this.FileList.SelectedIndex)
			{
				this.OldIndex = this.FileList.SelectedIndex;
				this.Code.Text = "";
				this.Code.Refresh();
				this.Code.Text = this.LoadDecompressedData(this.FileList.SelectedIndex);
				this.ShowInjectChanges = false;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0004BEE8 File Offset: 0x0004A2E8
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(this.FileList.Text);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0004BF00 File Offset: 0x0004A300
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OD.FileName = "";
			this.OD.Filter = "Fast File|*.ff";
			checked
			{
				if (this.OD.ShowDialog() != DialogResult.Cancel & Operators.CompareString(this.OD.FileName, "", false) != 0)
				{
					this.FileList.Items.Clear();
					this.Code.Text = "";
					this.Code.Refresh();
					this.FFCount = 0;
					this.MainMenu.Enabled = false;
					OpenFileDialog od = this.OD;
					string fileName = od.FileName;
					int ffcount = Form1.Viewer_LoadFastFile(ref fileName);
					od.FileName = fileName;
					this.FFCount = ffcount;
					this.ShowInjectChanges = false;
					for (int num = 0; num != this.FFCount; num++)
					{
						this.FileList.Items.Add(this.LoadFileName(num));
					}
					if (this.FFCount > 0)
					{
						this.FileList.SelectedIndex = 0;
						this.Code.Text = this.LoadDecompressedData(this.FileList.SelectedIndex);
						this.ShowInjectChanges = false;
					}
					this.FastFileName.Text = Marshal.PtrToStringAnsi(Form1.Viewer_GetFastFileName());
					Application.DoEvents();
					this.Code.Enabled = true;
					this.FileList.Enabled = true;
					this.MainMenu.Enabled = true;
					this.Edit.Enabled = true;
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0004C074 File Offset: 0x0004A474
		private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.FileList.SelectedIndex;
			TextEditorControl code = this.Code;
			string text = code.Text;
			bool flag = Form1.Viewer_SetData(selectedIndex, ref text, this.Code.Text.Length);
			code.Text = text;
			if (flag)
			{
				MessageBox.Show("Injected Successfully!", "Inject", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.ShowInjectChanges = false;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0004C0D4 File Offset: 0x0004A4D4
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form2.Show();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0004C0E8 File Offset: 0x0004A4E8
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.FastFileName.Text, "", false) != 0)
			{
				this.SD.FileName = "";
				this.SD.Filter = "Fast File|*.ff";
				if (this.SD.ShowDialog() != DialogResult.Cancel & Operators.CompareString(this.SD.FileName, "", false) != 0)
				{
					string text;
					if (this.ShowInjectChanges)
					{
						int selectedIndex = this.FileList.SelectedIndex;
						TextEditorControl code = this.Code;
						text = code.Text;
						bool flag = Form1.Viewer_SetData(selectedIndex, ref text, this.Code.Text.Length);
						code.Text = text;
						if (flag)
						{
							this.ShowInjectChanges = false;
						}
					}
					SaveFileDialog sd = this.SD;
					text = sd.FileName;
					ToolStripTextBox fastFileName = this.FastFileName;
					string text2 = fastFileName.Text;
					Form1.Viewer_Save(ref text, ref text2);
					fastFileName.Text = text2;
					sd.FileName = text;
				}
			}
			else
			{
				MessageBox.Show("Error : Invalid FastFile Name!\r\n\r\n[Edit] > [FastFile Name]\r\nExample : patch_mp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0004C1F8 File Offset: 0x0004A5F8
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1.Viewer_Unload();
			this.Close();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0004C208 File Offset: 0x0004A608
		private void ExportAsBlockFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SD.FileName = "";
			this.SD.Filter = "Block File|*.block";
			if (this.SD.ShowDialog() != DialogResult.Cancel & Operators.CompareString(this.SD.FileName, "", false) != 0)
			{
				SaveFileDialog sd = this.SD;
				string fileName = sd.FileName;
				Form1.Viewer_SaveBlock(ref fileName);
				sd.FileName = fileName;
				Interaction.MsgBox("Saved Block File Successfully!", MsgBoxStyle.Information, "Black Ops - FastFile Viewer");
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0004C294 File Offset: 0x0004A694
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.OD.FileName = "";
			this.OD.Filter = "Block File|*.block";
			checked
			{
				if (this.OD.ShowDialog() != DialogResult.Cancel & Operators.CompareString(this.OD.FileName, "", false) != 0)
				{
					this.FileList.Items.Clear();
					this.Code.Text = "";
					this.Code.Refresh();
					this.FFCount = 0;
					this.MainMenu.Enabled = false;
					OpenFileDialog od = this.OD;
					string fileName = od.FileName;
					int ffcount = Form1.Viewer_LoadBlockFile(ref fileName);
					od.FileName = fileName;
					this.FFCount = ffcount;
					this.OD.Filter = "Fast File|*.ff";
					this.OD.FileName = "";
					this.ShowInjectChanges = false;
					for (int num = 0; num != this.FFCount; num++)
					{
						this.FileList.Items.Add(this.LoadFileName(num));
					}
					if (this.FFCount > 0)
					{
						this.FileList.SelectedIndex = 0;
						this.Code.Text = this.LoadDecompressedData(this.FileList.SelectedIndex);
						this.ShowInjectChanges = false;
					}
					this.FastFileName.Text = "";
					Application.DoEvents();
					this.Code.Enabled = true;
					this.FileList.Enabled = true;
					this.MainMenu.Enabled = true;
					this.Edit.Enabled = true;
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0004C424 File Offset: 0x0004A824
		private void Xbox360ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.PS3ToolStripMenuItem.Checked = false;
			Form1.Keys_SetKey(1);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0004C438 File Offset: 0x0004A838
		private void PS3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Xbox360ToolStripMenuItem.Checked = false;
			Form1.Keys_SetKey(2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0004C44C File Offset: 0x0004A84C
		private void Form1_Load(object sender, EventArgs e)
		{
			Form1.Keys_SetKey(2);
			this.Code.SetHighlighting("GSC");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0004C464 File Offset: 0x0004A864
		private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SD.FileName = this.FileList.Text;
			this.SD.Filter = "All Files|*.*";
			if (this.SD.ShowDialog() != DialogResult.Cancel & Operators.CompareString(this.SD.FileName, "", false) != 0)
			{
				int selectedIndex = this.FileList.SelectedIndex;
				SaveFileDialog sd = this.SD;
				string fileName = sd.FileName;
				Form1.Viewer_ExtractDecompressedData(selectedIndex, ref fileName);
				sd.FileName = fileName;
				Interaction.MsgBox("Extracted Successfully!", MsgBoxStyle.Information, "Black Ops - FastFile Viewer");
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0004C500 File Offset: 0x0004A900
		private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(c)");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0004C50C File Offset: 0x0004A90C
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(v)");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0004C518 File Offset: 0x0004A918
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(x)");
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0004C524 File Offset: 0x0004A924
		private void Code_TextChanged(object sender, EventArgs e)
		{
			this.ShowInjectChanges = true;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0004C530 File Offset: 0x0004A930
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Black Ops - FastFile Viewer\r\nCreated By : TheUnkn0wn\r\nBuild : 2.0.0.0\r\n\r\nEdited and Reversed by Jo-Milk\r\nCreated for educational purposes only.", "About");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0004C544 File Offset: 0x0004A944
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(x)");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0004C550 File Offset: 0x0004A950
		private void CopyToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(c)");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0004C55C File Offset: 0x0004A95C
		private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^(v)");
		}

		// Token: 0x0400000B RID: 11
		[AccessedThroughProperty("OD")]
		private OpenFileDialog _OD;

		// Token: 0x0400000C RID: 12
		[AccessedThroughProperty("FileList")]
		private ListBox _FileList;

		// Token: 0x0400000D RID: 13
		[AccessedThroughProperty("ListMenu")]
		private ContextMenuStrip _ListMenu;

		// Token: 0x0400000E RID: 14
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("MainMenu")]
		private MenuStrip _MainMenu;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("FileToolStripMenuItem")]
		private ToolStripMenuItem _FileToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("OpenToolStripMenuItem")]
		private ToolStripMenuItem _OpenToolStripMenuItem;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("SaveToolStripMenuItem")]
		private ToolStripMenuItem _SaveToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("InjectToolStripMenuItem")]
		private ToolStripMenuItem _InjectToolStripMenuItem;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("SaveToolStripMenuItem1")]
		private ToolStripMenuItem _SaveToolStripMenuItem1;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("SD")]
		private SaveFileDialog _SD;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("ExportAsBlockFileToolStripMenuItem")]
		private ToolStripMenuItem _ExportAsBlockFileToolStripMenuItem;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("KeyToolStripMenuItem")]
		private ToolStripMenuItem _KeyToolStripMenuItem;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("Xbox360ToolStripMenuItem")]
		private ToolStripMenuItem _Xbox360ToolStripMenuItem;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("PS3ToolStripMenuItem")]
		private ToolStripMenuItem _PS3ToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("Code")]
		private TextEditorControl _Code;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("ExtractToolStripMenuItem")]
		private ToolStripMenuItem _ExtractToolStripMenuItem;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("CodeMenu")]
		private ContextMenuStrip _CodeMenu;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("CopyToolStripMenuItem1")]
		private ToolStripMenuItem _CopyToolStripMenuItem1;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("PasteToolStripMenuItem")]
		private ToolStripMenuItem _PasteToolStripMenuItem;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("CutToolStripMenuItem")]
		private ToolStripMenuItem _CutToolStripMenuItem;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("AboutToolStripMenuItem")]
		private ToolStripMenuItem _AboutToolStripMenuItem;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("Edit")]
		private ToolStripMenuItem _Edit;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("CutToolStripMenuItem1")]
		private ToolStripMenuItem _CutToolStripMenuItem1;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("CopyToolStripMenuItem2")]
		private ToolStripMenuItem _CopyToolStripMenuItem2;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("PasteToolStripMenuItem1")]
		private ToolStripMenuItem _PasteToolStripMenuItem1;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("FastFileNameToolStripMenuItem")]
		private ToolStripMenuItem _FastFileNameToolStripMenuItem;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("FastFileName")]
		private ToolStripTextBox _FastFileName;

		// Token: 0x0400002D RID: 45
		private int FFCount;

		// Token: 0x0400002E RID: 46
		private int OldIndex;

		// Token: 0x0400002F RID: 47
		private string Creator;

		// Token: 0x04000030 RID: 48
		public bool ShowInjectChanges;
	}
}
