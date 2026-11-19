using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/ColorUtility.bindings.h")]
public class ColorUtility
{
	[FreeFunction]
	internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
	{
		color = default;
		return false;
	}

	public static bool TryParseHtmlString(string htmlString, out Color color)
	{
		color = default;
		return false;
	}

	public static string ToHtmlStringRGB(Color color)
	{
		return null;
	}
}
