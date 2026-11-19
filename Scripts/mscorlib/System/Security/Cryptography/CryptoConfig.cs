using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class CryptoConfig
{
	private static readonly object lockObject;

	private static Dictionary<string, Type> algorithms;

	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms => false;

	public static object CreateFromName(string name)
	{
		return null;
	}

	public static object CreateFromName(string name, params object[] args)
	{
		return null;
	}

	public static string MapNameToOID(string name)
	{
		return null;
	}

	public static byte[] EncodeOID(string str)
	{
		return null;
	}

	private static byte[] EncodeLongNumber(long x)
	{
		return null;
	}
}
