using System;
using System.Text;

namespace Mirror.BouncyCastle.Asn1.X509;

public class DistributionPointName : Asn1Encodable, IAsn1Choice
{
	public const int FullName = 0;

	public const int NameRelativeToCrlIssuer = 1;

	private readonly int m_type;

	private readonly Asn1Encodable m_name;

	[Obsolete("Use 'Type' instead")]
	public int PointType => 0;

	public Asn1Encodable Name => null;

	public int Type => 0;

	public static DistributionPointName GetInstance(object obj)
	{
		return null;
	}

	public static DistributionPointName GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public DistributionPointName(GeneralNames name)
	{
	}

	public DistributionPointName(int type, Asn1Encodable name)
	{
	}

	public DistributionPointName(Asn1TaggedObject obj)
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
