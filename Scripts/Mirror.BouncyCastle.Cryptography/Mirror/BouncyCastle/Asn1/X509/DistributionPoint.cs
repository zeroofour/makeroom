using System.Text;

namespace Mirror.BouncyCastle.Asn1.X509;

public class DistributionPoint : Asn1Encodable
{
	private readonly DistributionPointName m_distributionPoint;

	private readonly ReasonFlags m_reasons;

	private readonly GeneralNames m_crlIssuer;

	public DistributionPointName DistributionPointName => null;

	public ReasonFlags Reasons => null;

	public GeneralNames CrlIssuer => null;

	public static DistributionPoint GetInstance(object obj)
	{
		return null;
	}

	public static DistributionPoint GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	private DistributionPoint(Asn1Sequence seq)
	{
	}

	public DistributionPoint(DistributionPointName distributionPointName, ReasonFlags reasons, GeneralNames crlIssuer)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private void AppendObject(StringBuilder buf, string name, string val)
	{
	}
}
