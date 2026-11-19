using System;
using System.IO;

namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Will be removed")]
public class LazyAsn1InputStream : Asn1InputStream
{
	public LazyAsn1InputStream(byte[] input)
		: base((byte[])null)
	{
	}

	public LazyAsn1InputStream(Stream inputStream)
		: base((byte[])null)
	{
	}

	public LazyAsn1InputStream(Stream input, int limit)
		: base((byte[])null)
	{
	}

	public LazyAsn1InputStream(Stream input, int limit, bool leaveOpen)
		: base((byte[])null)
	{
	}
}
