using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;

namespace Mirror.BouncyCastle.Cms;

public class DefaultSignedAttributeTableGenerator : CmsAttributeTableGenerator
{
	private readonly IDictionary<DerObjectIdentifier, object> m_table;

	public DefaultSignedAttributeTableGenerator()
	{
	}

	public DefaultSignedAttributeTableGenerator(AttributeTable attributeTable)
	{
	}

	protected virtual IDictionary<DerObjectIdentifier, object> CreateStandardAttributeTable(IDictionary<CmsAttributeTableParameter, object> parameters)
	{
		return null;
	}

	private void DoCreateStandardAttributeTable(IDictionary<CmsAttributeTableParameter, object> parameters, IDictionary<DerObjectIdentifier, object> std)
	{
	}

	public virtual AttributeTable GetAttributes(IDictionary<CmsAttributeTableParameter, object> parameters)
	{
		return null;
	}
}
