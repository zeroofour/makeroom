namespace Mirror.BouncyCastle.Asn1.Nist;

public class KMacWithShake256Params : Asn1Encodable
{
	private static readonly byte[] EMPTY_STRING;

	private static readonly int DEF_LENGTH;

	private readonly int outputLength;

	private readonly byte[] customizationString;

	public int OutputLength => 0;

	public byte[] CustomizationString => null;

	public KMacWithShake256Params(int outputLength)
	{
	}

	public KMacWithShake256Params(int outputLength, byte[] customizationString)
	{
	}

	public static KMacWithShake256Params GetInstance(object o)
	{
		return null;
	}

	private KMacWithShake256Params(Asn1Sequence seq)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
