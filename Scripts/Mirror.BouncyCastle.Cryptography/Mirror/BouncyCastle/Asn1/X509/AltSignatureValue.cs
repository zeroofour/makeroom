namespace Mirror.BouncyCastle.Asn1.X509;

public class AltSignatureValue : Asn1Encodable
{
	private readonly DerBitString m_signature;

	public DerBitString Signature => null;

	public static AltSignatureValue GetInstance(object obj)
	{
		return null;
	}

	public static AltSignatureValue GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static AltSignatureValue FromExtensions(X509Extensions extensions)
	{
		return null;
	}

	private AltSignatureValue(DerBitString signature)
	{
	}

	public AltSignatureValue(byte[] signature)
	{
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
