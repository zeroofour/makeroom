namespace Mirror.BouncyCastle.Asn1.Cmp;

public class KeyRecRepContent : Asn1Encodable
{
	private readonly PkiStatusInfo m_status;

	private readonly CmpCertificate m_newSigCert;

	private readonly Asn1Sequence m_caCerts;

	private readonly Asn1Sequence m_keyPairHist;

	public virtual PkiStatusInfo Status => null;

	public virtual CmpCertificate NewSigCert => null;

	public static KeyRecRepContent GetInstance(object obj)
	{
		return null;
	}

	public static KeyRecRepContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private KeyRecRepContent(Asn1Sequence seq)
	{
	}

	public virtual CmpCertificate[] GetCACerts()
	{
		return null;
	}

	public virtual CertifiedKeyPair[] GetKeyPairHist()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
