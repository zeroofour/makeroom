using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Cmp;

public sealed class RevocationDetailsBuilder
{
	private readonly CertTemplateBuilder m_templateBuilder;

	public RevocationDetailsBuilder SetPublicKey(SubjectPublicKeyInfo publicKey)
	{
		return null;
	}

	public RevocationDetailsBuilder SetIssuer(X509Name issuer)
	{
		return null;
	}

	public RevocationDetailsBuilder SetSerialNumber(BigInteger serialNumber)
	{
		return null;
	}

	public RevocationDetailsBuilder SetSubject(X509Name subject)
	{
		return null;
	}

	public RevocationDetails Build()
	{
		return default;
	}
}
