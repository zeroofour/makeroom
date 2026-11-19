using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class OriginatorInformation
{
	private readonly OriginatorInfo originatorInfo;

	public OriginatorInformation(OriginatorInfo originatorInfo)
	{
	}

	public virtual IStore<X509Certificate> GetCertificates()
	{
		return null;
	}

	public virtual IStore<X509Crl> GetCrls()
	{
		return null;
	}

	public virtual OriginatorInfo ToAsn1Structure()
	{
		return null;
	}
}
