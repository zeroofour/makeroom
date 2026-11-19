using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.Cms;

public class AttributeTable
{
	private readonly Dictionary<DerObjectIdentifier, object> m_attributes;

	public Attribute this[DerObjectIdentifier oid] => null;

	public int Count => 0;

	public AttributeTable(IDictionary<DerObjectIdentifier, object> attrs)
	{
	}

	public AttributeTable(Asn1EncodableVector v)
	{
	}

	public AttributeTable(Asn1Set s)
	{
	}

	public AttributeTable(Attributes attrs)
	{
	}

	private void AddAttribute(Attribute a)
	{
	}

	public Asn1EncodableVector GetAll(DerObjectIdentifier oid)
	{
		return null;
	}

	public IDictionary<DerObjectIdentifier, object> ToDictionary()
	{
		return null;
	}

	public Asn1EncodableVector ToAsn1EncodableVector()
	{
		return null;
	}

	public Attributes ToAttributes()
	{
		return null;
	}

	public AttributeTable Add(params Attribute[] attributes)
	{
		return null;
	}

	public AttributeTable Add(DerObjectIdentifier attrType, Asn1Encodable attrValue)
	{
		return null;
	}

	public AttributeTable Remove(DerObjectIdentifier attrType)
	{
		return null;
	}
}
