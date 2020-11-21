using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Black_Ops_FF_Viewer.My
{
	// Token: 0x0200000C RID: 12
	[CompilerGenerated]
	[HideModuleName]
	[DebuggerNonUserCode]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0004A2B8 File Offset: 0x000486B8
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
