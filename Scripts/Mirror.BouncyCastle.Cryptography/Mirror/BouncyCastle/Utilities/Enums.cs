using System;

namespace Mirror.BouncyCastle.Utilities;

internal static class Enums
{
	internal static TEnum[] GetEnumValues<TEnum>() where TEnum : struct, Enum
	{
		return null;
	}

	internal static TEnum GetArbitraryValue<TEnum>() where TEnum : struct, Enum
	{
		return default;
	}

	internal static bool TryGetEnumValue<TEnum>(string s, out TEnum result) where TEnum : struct, Enum
	{
		result = default;
		return false;
	}
}
