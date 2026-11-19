using System;

namespace Mirror.BouncyCastle.Asn1;

public class DerGeneralizedTime : Asn1GeneralizedTime
{
	public DerGeneralizedTime(string timeString)
		: base((string)null)
	{
	}

	public DerGeneralizedTime(DateTime dateTime)
		: base((string)null)
	{
	}

	internal DerGeneralizedTime(byte[] contents)
		: base((string)null)
	{
	}

	internal override IAsn1Encoding GetEncoding(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}
}
