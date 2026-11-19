using System;

namespace Mirror.BouncyCastle.Asn1;

internal abstract class DerEncoding : IAsn1Encoding, IComparable<DerEncoding>
{
	protected internal readonly int m_tagClass;

	protected internal readonly int m_tagNo;

	protected internal DerEncoding(int tagClass, int tagNo)
	{
	}

	protected internal abstract int CompareLengthAndContents(DerEncoding other);

	public int CompareTo(DerEncoding other)
	{
		return 0;
	}

	public abstract void Encode(Asn1OutputStream asn1Out);

	public abstract int GetLength();
}
