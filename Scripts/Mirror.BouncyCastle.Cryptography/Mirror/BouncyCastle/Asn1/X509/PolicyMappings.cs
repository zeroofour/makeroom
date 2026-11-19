using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class PolicyMappings : Asn1Encodable
{
	private readonly Asn1Sequence seq;

	public PolicyMappings(Asn1Sequence seq)
	{
	}

	public PolicyMappings(IDictionary<string, string> mappings)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
