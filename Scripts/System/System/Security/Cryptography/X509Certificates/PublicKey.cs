namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private const string rsaOid = "1.2.840.113549.1.1.1";

	private const string dsaOid = "1.2.840.10040.4.1";

	private AsymmetricAlgorithm _key;

	private AsnEncodedData _keyValue;

	private AsnEncodedData _params;

	private Oid _oid;

	private static byte[] Empty;

	public AsnEncodedData EncodedKeyValue => null;

	public AsnEncodedData EncodedParameters => null;

	public AsymmetricAlgorithm Key => null;

	public Oid Oid => null;

	public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
	{
	}

	private static byte[] GetUnsignedBigInteger(byte[] integer)
	{
		return null;
	}

	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters)
	{
		return null;
	}

	internal static RSA DecodeRSA(byte[] rawPublicKey)
	{
		return null;
	}
}
