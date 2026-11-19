using System;
using System.IO;

namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Check for 'Asn1OctetStringParser' instead")]
public class BerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
{
	private readonly Asn1StreamParser m_parser;

	internal BerOctetStringParser(Asn1StreamParser parser)
	{
	}

	public Stream GetOctetStream()
	{
		return null;
	}

	public Asn1Object ToAsn1Object()
	{
		return null;
	}

	internal static BerOctetString Parse(Asn1StreamParser sp)
	{
		return null;
	}
}
