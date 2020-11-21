using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Black_Ops_FF_Viewer.My.Resources
{
	// Token: 0x0200000A RID: 10
	[HideModuleName]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal sealed class Resources
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0004A1A4 File Offset: 0x000485A4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Black_Ops_FF_Viewer.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0004A1E4 File Offset: 0x000485E4
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0004A1F8 File Offset: 0x000485F8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000035 RID: 53
		private static ResourceManager resourceMan;

		// Token: 0x04000036 RID: 54
		private static CultureInfo resourceCulture;
	}
}
