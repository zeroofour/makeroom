using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.Ocsp;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class RevocationValues : Asn1Encodable
{
	private readonly Asn1Sequence m_crlVals;

	private readonly Asn1Sequence m_ocspVals;

	private readonly OtherRevVals m_otherRevVals;

	public OtherRevVals OtherRevVals => null;

	public static RevocationValues GetInstance(object obj)
	{
		return null;
	}

	public static RevocationValues GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	private RevocationValues(Asn1Sequence seq)
	{
	}

	public RevocationValues(CertificateList[] crlVals, BasicOcspResponse[] ocspVals, OtherRevVals otherRevVals)
	{
	}

	public RevocationValues(IEnumerable<CertificateList> crlVals, IEnumerable<BasicOcspResponse> ocspVals, OtherRevVals otherRevVals)
	{
	}

	public CertificateList[] GetCrlVals()
	{
		return null;
	}

	public BasicOcspResponse[] GetOcspVals()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
