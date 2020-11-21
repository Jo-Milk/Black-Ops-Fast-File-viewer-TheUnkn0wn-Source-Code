using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Black_Ops_FF_Viewer.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0004A2CC File Offset: 0x000486CC
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0004A304 File Offset: 0x00048704
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			this.IsSingleInstance = false;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0004A32C File Offset: 0x0004872C
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form1;
		}
	}
}
