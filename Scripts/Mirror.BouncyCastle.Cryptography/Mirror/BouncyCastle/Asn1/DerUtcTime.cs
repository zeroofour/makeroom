using System;

namespace Mirror.BouncyCastle.Asn1;

public class DerUtcTime : Asn1UtcTime
{
	public DerUtcTime(string timeString)
		: base((string)null)
	{
	}

	[Obsolete("Use `DerUtcTime(DateTime, int)' instead")]
	public DerUtcTime(DateTime dateTime)
		: base((string)null)
	{
	}

	public DerUtcTime(DateTime dateTime, int twoDigitYearMax)
		: base((string)null)
	{
	}

	internal DerUtcTime(byte[] contents)
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
