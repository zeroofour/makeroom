using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs
{
	[NativeMethod("SetString")]
	private static bool TrySetSetString(string key, string value)
	{
		return false;
	}

	public static void SetString(string key, string value)
	{
	}

	public static string GetString(string key, string defaultValue)
	{
		return null;
	}
}
