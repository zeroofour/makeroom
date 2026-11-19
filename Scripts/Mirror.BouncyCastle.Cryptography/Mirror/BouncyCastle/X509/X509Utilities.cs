using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Pkcs;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.X509;

internal static class X509Utilities
{
	private static readonly Dictionary<string, DerObjectIdentifier> m_algorithms;

	private static readonly Dictionary<string, Asn1Encodable> m_exParams;

	private static readonly HashSet<DerObjectIdentifier> m_noParams;

	static X509Utilities()
	{
	}

	internal static byte[] CalculateDigest(AlgorithmIdentifier digestAlgorithm, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static byte[] CalculateDigest(IDigestFactory digestFactory, byte[] buf, int off, int len)
	{
		return null;
	}

	internal static byte[] CalculateDigest(IDigestFactory digestFactory, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static TResult CalculateResult<TResult>(IStreamCalculator<TResult> streamCalculator, byte[] buf, int off, int len)
	{
		return default;
	}

	internal static TResult CalculateResult<TResult>(IStreamCalculator<TResult> streamCalculator, Asn1Encodable asn1Encodable)
	{
		return default;
	}

	private static RsassaPssParameters CreatePssParams(AlgorithmIdentifier hashAlgId, int saltSize)
	{
		return null;
	}

	internal static DerBitString CollectDerBitString(IBlockResult result)
	{
		return null;
	}

	internal static DerObjectIdentifier GetAlgorithmOid(string algorithmName)
	{
		return null;
	}

	internal static AlgorithmIdentifier GetSigAlgID(DerObjectIdentifier sigOid, string algorithmName)
	{
		return null;
	}

	internal static IEnumerable<string> GetAlgNames()
	{
		return null;
	}

	internal static DerBitString GenerateBitString(IStreamCalculator<IBlockResult> streamCalculator, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static DerBitString GenerateDigest(IDigestFactory digestFactory, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static DerBitString GenerateMac(IMacFactory macFactory, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static DerBitString GenerateSignature(ISignatureFactory signatureFactory, Asn1Encodable asn1Encodable)
	{
		return null;
	}

	internal static bool VerifyMac(IMacFactory macFactory, Asn1Encodable asn1Encodable, DerBitString expected)
	{
		return false;
	}

	internal static bool VerifySignature(IVerifierFactory verifierFactory, Asn1Encodable asn1Encodable, DerBitString signature)
	{
		return false;
	}

	internal static Asn1TaggedObject TrimExtensions(int tagNo, X509Extensions exts)
	{
		return null;
	}
}
