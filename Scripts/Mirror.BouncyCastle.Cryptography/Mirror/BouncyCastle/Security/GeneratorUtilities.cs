using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class GeneratorUtilities
{
	private static readonly IDictionary<string, string> KgAlgorithms;

	private static readonly IDictionary<string, string> KpgAlgorithms;

	private static readonly IDictionary<string, int> DefaultKeySizes;

	static GeneratorUtilities()
	{
	}

	private static void AddDefaultKeySizeEntries(int size, params string[] algorithms)
	{
	}

	private static void AddKgAlgorithm(string canonicalName, params object[] aliases)
	{
	}

	private static void AddKpgAlgorithm(string canonicalName, params object[] aliases)
	{
	}

	private static void AddHMacKeyGenerator(string algorithm, params object[] aliases)
	{
	}

	internal static string GetCanonicalKeyGeneratorAlgorithm(string algorithm)
	{
		return null;
	}

	internal static string GetCanonicalKeyPairGeneratorAlgorithm(string algorithm)
	{
		return null;
	}

	public static CipherKeyGenerator GetKeyGenerator(DerObjectIdentifier oid)
	{
		return null;
	}

	public static CipherKeyGenerator GetKeyGenerator(string algorithm)
	{
		return null;
	}

	public static IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(string algorithm)
	{
		return null;
	}

	internal static int GetDefaultKeySize(DerObjectIdentifier oid)
	{
		return 0;
	}

	internal static int GetDefaultKeySize(string algorithm)
	{
		return 0;
	}

	private static int FindDefaultKeySize(string canonicalName)
	{
		return 0;
	}
}
