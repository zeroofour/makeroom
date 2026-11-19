using System;
using System.Globalization;

namespace Mirror.BouncyCastle.Utilities;

internal static class Platform
{
	private static readonly CompareInfo InvariantCompareInfo;

	internal static bool Is64BitProcess => false;

	internal static bool EqualsIgnoreCase(string a, string b)
	{
		return false;
	}

	internal static string GetEnvironmentVariable(string variable)
	{
		return null;
	}

	internal static int IndexOf(string source, char value)
	{
		return 0;
	}

	internal static int IndexOf(string source, string value)
	{
		return 0;
	}

	internal static int IndexOf(string source, char value, int startIndex)
	{
		return 0;
	}

	internal static int IndexOf(string source, string value, int startIndex)
	{
		return 0;
	}

	internal static int LastIndexOf(string source, string value)
	{
		return 0;
	}

	internal static bool StartsWith(string source, string prefix)
	{
		return false;
	}

	internal static bool StartsWithIgnoreCase(string source, string prefix)
	{
		return false;
	}

	internal static bool EndsWith(string source, string suffix)
	{
		return false;
	}

	internal static string GetTypeName(object obj)
	{
		return null;
	}

	internal static string GetTypeName(Type t)
	{
		return null;
	}
}
