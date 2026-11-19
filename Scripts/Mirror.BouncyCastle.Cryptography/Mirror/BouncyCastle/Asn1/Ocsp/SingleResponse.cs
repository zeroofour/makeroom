using System;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class SingleResponse : Asn1Encodable
{
	private readonly CertID m_certID;

	private readonly CertStatus m_certStatus;

	private readonly Asn1GeneralizedTime m_thisUpdate;

	private readonly Asn1GeneralizedTime m_nextUpdate;

	private readonly X509Extensions m_singleExtensions;

	public CertID CertId => null;

	public CertStatus CertStatus => null;

	public Asn1GeneralizedTime ThisUpdate => null;

	public Asn1GeneralizedTime NextUpdate => null;

	public X509Extensions SingleExtensions => null;

	public static SingleResponse GetInstance(object obj)
	{
		return null;
	}

	public static SingleResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public SingleResponse(CertID certID, CertStatus certStatus, Asn1GeneralizedTime thisUpdate, Asn1GeneralizedTime nextUpdate, X509Extensions singleExtensions)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public SingleResponse(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
