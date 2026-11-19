namespace Mirror.BouncyCastle.Asn1.Cmp;

public class ErrorMsgContent : Asn1Encodable
{
	private readonly PkiStatusInfo m_pkiStatusInfo;

	private readonly DerInteger m_errorCode;

	private readonly PkiFreeText m_errorDetails;

	public virtual PkiStatusInfo PkiStatusInfo => null;

	public virtual DerInteger ErrorCode => null;

	public virtual PkiFreeText ErrorDetails => null;

	public static ErrorMsgContent GetInstance(object obj)
	{
		return null;
	}

	public static ErrorMsgContent GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private ErrorMsgContent(Asn1Sequence seq)
	{
	}

	public ErrorMsgContent(PkiStatusInfo pkiStatusInfo)
	{
	}

	public ErrorMsgContent(PkiStatusInfo pkiStatusInfo, DerInteger errorCode, PkiFreeText errorDetails)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
