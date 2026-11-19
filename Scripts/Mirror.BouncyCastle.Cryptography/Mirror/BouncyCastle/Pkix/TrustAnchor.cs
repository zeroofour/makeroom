using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Pkix;

public class TrustAnchor
{
	private readonly AsymmetricKeyParameter pubKey;

	private readonly string caName;

	private readonly X509Name caPrincipal;

	private readonly X509Certificate trustedCert;

	private byte[] ncBytes;

	private NameConstraints nc;

	public X509Certificate TrustedCert => null;

	public X509Name CA => null;

	public string CAName => null;

	public AsymmetricKeyParameter CAPublicKey => null;

	public byte[] GetNameConstraints => null;

	public TrustAnchor(X509Certificate trustedCert, byte[] nameConstraints)
	{
	}

	public TrustAnchor(X509Name caPrincipal, AsymmetricKeyParameter pubKey, byte[] nameConstraints)
	{
	}

	public TrustAnchor(string caName, AsymmetricKeyParameter pubKey, byte[] nameConstraints)
	{
	}

	private void setNameConstraints(byte[] bytes)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
