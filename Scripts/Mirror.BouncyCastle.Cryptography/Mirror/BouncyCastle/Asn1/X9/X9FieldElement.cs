using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Asn1.X9;

public class X9FieldElement : Asn1Encodable
{
	private ECFieldElement f;

	public ECFieldElement Value => null;

	public X9FieldElement(ECFieldElement f)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
