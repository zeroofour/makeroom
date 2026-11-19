using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class AgreementUtilities
{
	private static readonly Dictionary<DerObjectIdentifier, string> AlgorithmOidMap;

	static AgreementUtilities()
	{
	}

	public static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IBasicAgreement GetBasicAgreement(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IBasicAgreement GetBasicAgreement(string algorithm)
	{
		return null;
	}

	private static IBasicAgreement GetBasicAgreementForMechanism(string mechanism)
	{
		return null;
	}

	public static IBasicAgreement GetBasicAgreementWithKdf(DerObjectIdentifier agreeAlgOid, DerObjectIdentifier wrapAlgOid)
	{
		return null;
	}

	public static IBasicAgreement GetBasicAgreementWithKdf(DerObjectIdentifier oid, string wrapAlgorithm)
	{
		return null;
	}

	public static IBasicAgreement GetBasicAgreementWithKdf(string agreeAlgorithm, string wrapAlgorithm)
	{
		return null;
	}

	private static IBasicAgreement GetBasicAgreementWithKdfForMechanism(string mechanism, string wrapAlgorithm)
	{
		return null;
	}

	public static IRawAgreement GetRawAgreement(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IRawAgreement GetRawAgreement(string algorithm)
	{
		return null;
	}

	private static IRawAgreement GetRawAgreementForMechanism(string mechanism)
	{
		return null;
	}

	private static string GetMechanism(string algorithm)
	{
		return null;
	}
}
