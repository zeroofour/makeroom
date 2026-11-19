using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;

namespace Mirror.BouncyCastle.Cms;

public class DefaultAuthenticatedAttributeTableGenerator : CmsAttributeTableGenerator
{
	private readonly IDictionary<DerObjectIdentifier, object> m_table;

	public DefaultAuthenticatedAttributeTableGenerator()
	{
	}

	public DefaultAuthenticatedAttributeTableGenerator(AttributeTable attributeTable)
	{
	}

	protected virtual IDictionary<DerObjectIdentifier, object> CreateStandardAttributeTable(IDictionary<CmsAttributeTableParameter, object> parameters)
	{
		return null;
	}

	public virtual AttributeTable GetAttributes(IDictionary<CmsAttributeTableParameter, object> parameters)
	{
		return null;
	}
}
