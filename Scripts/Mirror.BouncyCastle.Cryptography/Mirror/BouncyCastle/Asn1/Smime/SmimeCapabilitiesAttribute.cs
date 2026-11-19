using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Smime;

public class SmimeCapabilitiesAttribute : AttributeX509
{
	public SmimeCapabilitiesAttribute(SmimeCapabilityVector capabilities)
		: base(null, null)
	{
	}
}
