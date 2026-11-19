using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class SignatureAndHashAlgorithm
{
	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP256r1tls13_sha256;

	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP384r1tls13_sha384;

	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP512r1tls13_sha512;

	public static readonly SignatureAndHashAlgorithm ed25519;

	public static readonly SignatureAndHashAlgorithm ed448;

	public static readonly SignatureAndHashAlgorithm gostr34102012_256;

	public static readonly SignatureAndHashAlgorithm gostr34102012_512;

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha256;

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha384;

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha512;

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha256;

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha384;

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha512;

	private readonly short m_hash;

	private readonly short m_signature;

	public short Hash => 0;

	public short Signature => 0;

	public static SignatureAndHashAlgorithm GetInstance(short hashAlgorithm, short signatureAlgorithm)
	{
		return null;
	}

	private static SignatureAndHashAlgorithm GetInstanceIntrinsic(short signatureAlgorithm)
	{
		return null;
	}

	private static SignatureAndHashAlgorithm Create(int signatureScheme)
	{
		return null;
	}

	private static SignatureAndHashAlgorithm Create(short hashAlgorithm, short signatureAlgorithm)
	{
		return null;
	}

	public SignatureAndHashAlgorithm(short hash, short signature)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static SignatureAndHashAlgorithm Parse(Stream input)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
