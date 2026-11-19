using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Object : Asn1Encodable
{
	public override void EncodeTo(Stream output)
	{
	}

	public override void EncodeTo(Stream output, string encoding)
	{
	}

	internal virtual byte[] InternalGetEncoded(string encoding)
	{
		return null;
	}

	public bool Equals(Asn1Object other)
	{
		return false;
	}

	public static Asn1Object FromByteArray(byte[] data)
	{
		return null;
	}

	public static Asn1Object FromStream(Stream inStr)
	{
		return null;
	}

	public sealed override Asn1Object ToAsn1Object()
	{
		return null;
	}

	internal abstract IAsn1Encoding GetEncoding(int encoding);

	internal abstract IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo);

	internal abstract DerEncoding GetEncodingDer();

	internal abstract DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo);

	protected abstract bool Asn1Equals(Asn1Object asn1Object);

	protected abstract int Asn1GetHashCode();

	internal bool CallAsn1Equals(Asn1Object obj)
	{
		return false;
	}

	internal int CallAsn1GetHashCode()
	{
		return 0;
	}
}
