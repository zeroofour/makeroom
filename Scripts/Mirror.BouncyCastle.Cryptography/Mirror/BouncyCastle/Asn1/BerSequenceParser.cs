using System;

namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Check for 'Asn1SequenceParser' instead")]
public class BerSequenceParser : Asn1SequenceParser, IAsn1Convertible
{
	private readonly Asn1StreamParser m_parser;

	internal BerSequenceParser(Asn1StreamParser parser)
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

	internal static BerSequence Parse(Asn1StreamParser sp)
	{
		return null;
	}
}
