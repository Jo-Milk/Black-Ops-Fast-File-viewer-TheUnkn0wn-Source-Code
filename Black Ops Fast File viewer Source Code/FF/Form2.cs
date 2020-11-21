using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Black_Ops_FF_Viewer.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Black_Ops_FF_Viewer
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class Form2 : Form
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0004C568 File Offset: 0x0004A968
		public Form2()
		{
			base.Load += this.Form2_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0004C7E4 File Offset: 0x0004ABE4
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0004C7F8 File Offset: 0x0004ABF8
		internal virtual TextBox FileName
		{
			get
			{
				return this._FileName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FileName = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0004C804 File Offset: 0x0004AC04
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0004C818 File Offset: 0x0004AC18
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0004C864 File Offset: 0x0004AC64
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0004C878 File Offset: 0x0004AC78
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0004C8C4 File Offset: 0x0004ACC4
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0004C8CC File Offset: 0x0004ACCC
		private void Button1_Click(object sender, EventArgs e)
		{
			int selectedIndex = MyProject.Forms.Form1.FileList.SelectedIndex;
			MyProject.Forms.Form1.FileList.Items.RemoveAt(selectedIndex);
			MyProject.Forms.Form1.FileList.Items.Insert(selectedIndex, this.FileName.Text);
			MyProject.Forms.Form1.FileList.SelectedIndex = selectedIndex;
			int selectedIndex2 = MyProject.Forms.Form1.FileList.SelectedIndex;
			string text = this.FileName.Text.ToLower();
			Form1.Viewer_Rename(selectedIndex2, ref text);
			this.Close();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0004C974 File Offset: 0x0004AD74
		private void Form2_Load(object sender, EventArgs e)
		{
			this.FileName.Text = MyProject.Forms.Form1.FileList.Items[MyProject.Forms.Form1.FileList.SelectedIndex].ToString();
			this.FileName.MaxLength = this.FileName.Text.Length;
			this.FileName.SelectionStart = this.FileName.Text.Length;
			this.FileName.SelectionLength = 0;
			Application.DoEvents();
		}

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("FileName")]
		private TextBox _FileName;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("Button2")]
		private Button _Button2;
	}
}
