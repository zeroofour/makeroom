namespace Mirror.BouncyCastle.Asn1;

public class DerExternalParser : Asn1Encodable
{
	private readonly Asn1StreamParser m_parser;

	internal DerExternalParser(Asn1StreamParser parser)
	{
	}

	public IAsn1Convertible ReadObject()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	internal static DerExternal Parse(Asn1StreamParser sp)
	{
		return null;
	}
}
