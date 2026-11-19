using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

public class CmcePrivateKey : Asn1Object
{
	private int version;

	private byte[] delta;

	private byte[] c;

	private byte[] g;

	private byte[] alpha;

	private byte[] s;

	private CmcePublicKey publicKey;

	public int Version => 0;

	public byte[] Delta => null;

	public byte[] C => null;

	public byte[] G => null;

	public byte[] Alpha => null;

	public byte[] S => null;

	public CmcePublicKey PublicKey => null;

	public static CmcePrivateKey GetInstance(object o)
	{
		return null;
	}

	public static CmcePrivateKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public CmcePrivateKey(int version, byte[] delta, byte[] c, byte[] g, byte[] alpha, byte[] s, CmcePublicKey pubKey = null)
	{
	}

	private CmcePrivateKey(Asn1Sequence seq)
	{
	}

	public Asn1Object ToAsn1Primitive()
	{
		return null;
	}

	internal override IAsn1Encoding GetEncoding(int encoding)
	{
		return null;
	}

	internal override IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo)
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal sealed override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
	{
		return null;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}
}
