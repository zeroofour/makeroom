using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class OpenBsdBCrypt
{
	private static readonly byte[] EncodingTable;

	private static readonly byte[] DecodingTable;

	private static readonly string DefaultVersion;

	private static readonly HashSet<string> AllowedVersions;

	static OpenBsdBCrypt()
	{
	}

	private static string CreateBcryptString(string version, byte[] password, byte[] salt, int cost)
	{
		return null;
	}

	public static string Generate(char[] password, byte[] salt, int cost)
	{
		return null;
	}

	public static string Generate(string version, char[] password, byte[] salt, int cost)
	{
		return null;
	}

	public static bool CheckPassword(string bcryptString, char[] password)
	{
		return false;
	}

	private static string EncodeData(byte[] data)
	{
		return null;
	}

	private static byte[] DecodeSaltString(string saltString)
	{
		return null;
	}
}
