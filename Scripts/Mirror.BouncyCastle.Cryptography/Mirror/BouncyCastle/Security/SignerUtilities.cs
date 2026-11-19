using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class SignerUtilities
{
	private static readonly Dictionary<string, string> AlgorithmMap;

	private static readonly Dictionary<DerObjectIdentifier, string> AlgorithmOidMap;

	private static readonly HashSet<string> NoRandom;

	private static readonly Dictionary<string, DerObjectIdentifier> Oids;

	public static ICollection<string> Algorithms => null;

	static SignerUtilities()
	{
	}

	public static Asn1Encodable GetDefaultX509Parameters(DerObjectIdentifier id)
	{
		return null;
	}

	public static Asn1Encodable GetDefaultX509Parameters(string algorithm)
	{
		return null;
	}

	private static Asn1Encodable GetDefaultX509ParametersForMechanism(string mechanism)
	{
		return null;
	}

	public static string GetEncodingName(DerObjectIdentifier oid)
	{
		return null;
	}

	private static string GetMechanism(string algorithm)
	{
		return null;
	}

	public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
	{
		return null;
	}

	private static Asn1Encodable GetPssX509Parameters(string digestName)
	{
		return null;
	}

	public static ISigner GetSigner(DerObjectIdentifier id)
	{
		return null;
	}

	public static ISigner GetSigner(string algorithm)
	{
		return null;
	}

	private static ISigner GetSignerForMechanism(string mechanism)
	{
		return null;
	}

	public static ISigner InitSigner(DerObjectIdentifier algorithmOid, bool forSigning, AsymmetricKeyParameter privateKey, SecureRandom random)
	{
		return null;
	}

	public static ISigner InitSigner(string algorithm, bool forSigning, AsymmetricKeyParameter privateKey, SecureRandom random)
	{
		return null;
	}
}
