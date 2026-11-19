namespace Mirror.BouncyCastle.Asn1.Nist;

public class KMacWithShake128Params : Asn1Encodable
{
	private static readonly byte[] EMPTY_STRING;

	private static readonly int DEF_LENGTH;

	private readonly int outputLength;

	private readonly byte[] customizationString;

	public int OutputLength => 0;

	public byte[] CustomizationString => null;

	public KMacWithShake128Params(int outputLength)
	{
	}

	public KMacWithShake128Params(int outputLength, byte[] customizationString)
	{
	}

	public static KMacWithShake128Params GetInstance(object o)
	{
		return null;
	}

	private KMacWithShake128Params(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
