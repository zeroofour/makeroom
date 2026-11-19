using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Crmf;

public class ProofOfPossessionSigningKeyBuilder
{
	private readonly CertRequest m_certRequest;

	private readonly SubjectPublicKeyInfo m_pubKeyInfo;

	private GeneralName m_name;

	private PKMacValue m_publicKeyMac;

	public ProofOfPossessionSigningKeyBuilder(CertRequest certRequest)
	{
	}

	public ProofOfPossessionSigningKeyBuilder(SubjectPublicKeyInfo pubKeyInfo)
	{
	}

	public ProofOfPossessionSigningKeyBuilder SetSender(GeneralName name)
	{
		return null;
	}

	public ProofOfPossessionSigningKeyBuilder SetPublicKeyMac(PKMacBuilder generator, char[] password)
	{
		return null;
	}

	public PopoSigningKey Build(ISignatureFactory signer)
	{
		return null;
	}
}
