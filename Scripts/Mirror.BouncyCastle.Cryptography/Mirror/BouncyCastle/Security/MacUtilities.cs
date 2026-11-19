using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class MacUtilities
{
	private static readonly Dictionary<string, string> AlgorithmMap;

	private static readonly Dictionary<DerObjectIdentifier, string> AlgorithmOidMap;

	static MacUtilities()
	{
	}

	public static byte[] CalculateMac(string algorithm, ICipherParameters cp, byte[] input)
	{
		return null;
	}

	public static byte[] DoFinal(IMac mac)
	{
		return null;
	}

	public static byte[] DoFinal(IMac mac, byte[] input)
	{
		return null;
	}

	public static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IMac GetMac(DerObjectIdentifier id)
	{
		return null;
	}

	public static IMac GetMac(string algorithm)
	{
		return null;
	}

	private static IMac GetMacForMechanism(string mechanism)
	{
		return null;
	}

	private static string GetMechanism(string algorithm)
	{
		return null;
	}
}
