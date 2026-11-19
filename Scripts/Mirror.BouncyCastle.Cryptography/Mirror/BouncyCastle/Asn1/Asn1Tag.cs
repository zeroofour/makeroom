namespace Mirror.BouncyCastle.Asn1;

internal sealed class Asn1Tag
{
	private readonly int m_tagClass;

	private readonly int m_tagNo;

	internal int TagClass => 0;

	internal int TagNo => 0;

	internal static Asn1Tag Create(int tagClass, int tagNo)
	{
		return null;
	}

	private Asn1Tag(int tagClass, int tagNo)
	{
	}
}
