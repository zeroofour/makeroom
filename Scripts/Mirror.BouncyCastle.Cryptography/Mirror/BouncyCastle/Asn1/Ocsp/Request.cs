using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Ocsp;

public class Request : Asn1Encodable
{
	private readonly CertID m_reqCert;

	private readonly X509Extensions m_singleRequestExtensions;

	public CertID ReqCert => null;

	public X509Extensions SingleRequestExtensions => null;

	public static Request GetInstance(object obj)
	{
		return null;
	}

	public static Request GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public Request(CertID reqCert, X509Extensions singleRequestExtensions)
	{
	}

	private Request(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
