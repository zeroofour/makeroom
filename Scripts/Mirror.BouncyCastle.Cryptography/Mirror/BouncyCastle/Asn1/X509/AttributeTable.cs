using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class AttributeTable
{
	private readonly IDictionary<DerObjectIdentifier, AttributeX509> m_attributes;

	public AttributeTable(IDictionary<DerObjectIdentifier, AttributeX509> attrs)
	{
	}

	public AttributeTable(Asn1EncodableVector v)
	{
	}

	public AttributeTable(Asn1Set s)
	{
	}

	public AttributeX509 Get(DerObjectIdentifier oid)
	{
		return null;
	}

	public IDictionary<DerObjectIdentifier, AttributeX509> ToDictionary()
	{
		return null;
	}
}
