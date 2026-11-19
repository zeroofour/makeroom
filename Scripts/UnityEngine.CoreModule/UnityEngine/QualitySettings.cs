using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
public sealed class QualitySettings : Object
{
	public static int vSyncCount
	{
		set
		{
		}
	}

	public static int antiAliasing
	{
		set
		{
		}
	}

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
		get
		{
			return ColorSpace.Gamma;
		}
	}

	public static void SetQualityLevel(int index)
	{
	}

	[NativeName("SetCurrentIndex")]
	public static void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges)
	{
	}
}
