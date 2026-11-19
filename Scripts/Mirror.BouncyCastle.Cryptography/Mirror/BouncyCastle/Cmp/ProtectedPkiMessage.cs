using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crmf;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cmp;

public class ProtectedPkiMessage
{
	private readonly PkiMessage m_pkiMessage;

	public virtual PkiHeader Header => null;

	public virtual PkiBody Body => null;

	public virtual bool HasPasswordBasedMacProtected => false;

	public virtual AlgorithmIdentifier ProtectionAlgorithm => null;

	public ProtectedPkiMessage(GeneralPkiMessage pkiMessage)
	{
	}

	public ProtectedPkiMessage(PkiMessage pkiMessage)
	{
	}

	public virtual PkiMessage ToAsn1Message()
	{
		return null;
	}

	public virtual X509Certificate[] GetCertificates()
	{
		return null;
	}

	public virtual bool Verify(IVerifierFactory verifierFactory)
	{
		return false;
	}

	public virtual bool Verify(PKMacBuilder pkMacBuilder, char[] password)
	{
		return false;
	}

	private DerSequence CreateProtected()
	{
		return null;
	}
}
