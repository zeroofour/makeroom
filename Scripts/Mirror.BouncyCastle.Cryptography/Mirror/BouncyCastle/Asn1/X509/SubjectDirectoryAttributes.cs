using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class SubjectDirectoryAttributes : Asn1Encodable
{
	private readonly List<AttributeX509> m_attributes;

	public IEnumerable<AttributeX509> Attributes => null;

	public static SubjectDirectoryAttributes GetInstance(object obj)
	{
		return null;
	}

	private SubjectDirectoryAttributes(Asn1Sequence seq)
	{
	}

	public SubjectDirectoryAttributes(IList<AttributeX509> attributes)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
