using System;

namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Check for 'Asn1SetParser' instead")]
public class BerSetParser : Asn1SetParser, IAsn1Convertible
{
	private readonly Asn1StreamParser m_parser;

	internal BerSetParser(Asn1StreamParser parser)
	{
	}

	public IAsn1Convertible ReadObject()
	{
		return null;
	}

	public Asn1Object ToAsn1Object()
	{
		return null;
	}

	internal static BerSet Parse(Asn1StreamParser sp)
	{
		return null;
	}
}
