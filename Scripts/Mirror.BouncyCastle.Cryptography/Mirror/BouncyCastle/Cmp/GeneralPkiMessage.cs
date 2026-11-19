using Mirror.BouncyCastle.Asn1.Cmp;

namespace Mirror.BouncyCastle.Cmp;

public class GeneralPkiMessage
{
	private readonly PkiMessage m_pkiMessage;

	public virtual PkiHeader Header => null;

	public virtual PkiBody Body => null;

	public virtual bool HasProtection => false;

	private static PkiMessage ParseBytes(byte[] encoding)
	{
		return null;
	}

	public GeneralPkiMessage(PkiMessage pkiMessage)
	{
	}

	public GeneralPkiMessage(byte[] encoding)
	{
	}

	public virtual PkiMessage ToAsn1Structure()
	{
		return null;
	}
}
