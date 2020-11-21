namespace Black_Ops_FF_Viewer
{
	// Token: 0x02000009 RID: 9
	//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0004C58C File Offset: 0x0004A98C
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

		// Token: 0x0600008D RID: 141 RVA: 0x0004C5CC File Offset: 0x0004A9CC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Black_Ops_FF_Viewer.Form2));
			this.FileName = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			global::System.Windows.Forms.Control fileName = this.FileName;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 12);
			fileName.Location = location;
			this.FileName.Name = "FileName";
			global::System.Windows.Forms.Control fileName2 = this.FileName;
			global::System.Drawing.Size size = new global::System.Drawing.Size(320, 20);
			fileName2.Size = size;
			this.FileName.TabIndex = 0;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(186, 38);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(70, 22);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button3 = this.Button2;
			location = new global::System.Drawing.Point(262, 38);
			button3.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(70, 22);
			button4.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(344, 67);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.FileName);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form2";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rename";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.IContainer components;
	}
}
