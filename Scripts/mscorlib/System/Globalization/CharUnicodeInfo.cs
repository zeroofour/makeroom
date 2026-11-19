namespace System.Globalization;

public static class CharUnicodeInfo
{
	private static ReadOnlySpan<byte> CategoryLevel1Index => default;

	private static ReadOnlySpan<byte> CategoryLevel2Index => default;

	private static ReadOnlySpan<byte> CategoryLevel3Index => default;

	private static ReadOnlySpan<byte> CategoriesValue => default;

	internal static int InternalConvertToUtf32(string s, int index)
	{
		return 0;
	}

	internal static int InternalConvertToUtf32(string s, int index, out int charLength)
	{
		charLength = default;
		return 0;
	}

	public static UnicodeCategory GetUnicodeCategory(char ch)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	public static UnicodeCategory GetUnicodeCategory(int codePoint)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	internal static byte InternalGetCategoryValue(int ch, int offset)
	{
		return 0;
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
	{
		return UnicodeCategory.UppercaseLetter;
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
	{
		charLength = default;
		return UnicodeCategory.UppercaseLetter;
	}

	internal static bool IsWhiteSpace(string s, int index)
	{
		return false;
	}

	internal static bool IsWhiteSpace(char c)
	{
		return false;
	}
}
