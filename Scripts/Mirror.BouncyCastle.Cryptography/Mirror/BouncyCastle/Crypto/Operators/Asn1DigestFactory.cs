using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class Asn1DigestFactory : IDigestFactory
{
	private readonly IDigest m_digest;

	private readonly DerObjectIdentifier m_oid;

	public virtual object AlgorithmDetails => null;

	public virtual int DigestLength => 0;

	public static Asn1DigestFactory Get(DerObjectIdentifier oid)
	{
		return null;
	}

	public static Asn1DigestFactory Get(string mechanism)
	{
		return null;
	}

	public Asn1DigestFactory(IDigest digest, DerObjectIdentifier oid)
	{
	}

	public virtual IStreamCalculator<IBlockResult> CreateCalculator()
	{
		return null;
	}
}
