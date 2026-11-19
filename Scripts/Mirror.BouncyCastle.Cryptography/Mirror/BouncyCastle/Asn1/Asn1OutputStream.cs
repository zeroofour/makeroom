using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Asn1;

public class Asn1OutputStream : FilterStream
{
	internal const int EncodingBer = 1;

	internal const int EncodingDL = 2;

	internal const int EncodingDer = 3;

	private readonly bool m_leaveOpen;

	internal virtual int Encoding => 0;

	public static Asn1OutputStream Create(Stream output)
	{
		return null;
	}

	public static Asn1OutputStream Create(Stream output, string encoding)
	{
		return null;
	}

	public static Asn1OutputStream Create(Stream output, string encoding, bool leaveOpen)
	{
		return null;
	}

	internal static int GetEncodingType(string encoding)
	{
		return 0;
	}

	protected internal Asn1OutputStream(Stream output, bool leaveOpen)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public virtual void WriteObject(Asn1Encodable asn1Encodable)
	{
	}

	public virtual void WriteObject(Asn1Object asn1Object)
	{
	}

	internal void EncodeContents(IAsn1Encoding[] contentsEncodings)
	{
	}

	private void FlushInternal()
	{
	}

	internal void WriteDL(int dl)
	{
	}

	internal void WriteIdentifier(int flags, int tagNo)
	{
	}

	internal static IAsn1Encoding[] GetContentsEncodings(int encoding, Asn1Encodable[] elements)
	{
		return null;
	}

	internal static DerEncoding[] GetContentsEncodingsDer(Asn1Encodable[] elements)
	{
		return null;
	}

	internal static int GetLengthOfContents(IAsn1Encoding[] contentsEncodings)
	{
		return 0;
	}

	internal static int GetLengthOfDL(int dl)
	{
		return 0;
	}

	internal static int GetLengthOfEncodingDL(int tagNo, int contentsLength)
	{
		return 0;
	}

	internal static int GetLengthOfEncodingIL(int tagNo, IAsn1Encoding contentsEncoding)
	{
		return 0;
	}

	internal static int GetLengthOfEncodingIL(int tagNo, IAsn1Encoding[] contentsEncodings)
	{
		return 0;
	}

	internal static int GetLengthOfIdentifier(int tagNo)
	{
		return 0;
	}
}
