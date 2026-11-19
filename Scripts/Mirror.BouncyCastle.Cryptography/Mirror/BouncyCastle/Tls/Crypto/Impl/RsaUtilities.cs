using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl;

public abstract class RsaUtilities
{
	private static readonly byte[] RSAPSSParams_256_A;

	private static readonly byte[] RSAPSSParams_384_A;

	private static readonly byte[] RSAPSSParams_512_A;

	private static readonly byte[] RSAPSSParams_256_B;

	private static readonly byte[] RSAPSSParams_384_B;

	private static readonly byte[] RSAPSSParams_512_B;

	static RsaUtilities()
	{
	}

	public static bool SupportsPkcs1(AlgorithmIdentifier pubKeyAlgID)
	{
		return false;
	}

	public static bool SupportsPss_Pss(short signatureAlgorithm, AlgorithmIdentifier pubKeyAlgID)
	{
		return false;
	}

	public static bool SupportsPss_Rsae(AlgorithmIdentifier pubKeyAlgID)
	{
		return false;
	}
}
