using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pkcs;

public abstract class Pkcs12Entry
{
	private readonly IDictionary<DerObjectIdentifier, Asn1Encodable> m_attributes;

	public Asn1Encodable this[DerObjectIdentifier oid] => null;

	public IEnumerable<DerObjectIdentifier> BagAttributeKeys => null;

	protected internal Pkcs12Entry(IDictionary<DerObjectIdentifier, Asn1Encodable> attributes)
	{
	}
}
