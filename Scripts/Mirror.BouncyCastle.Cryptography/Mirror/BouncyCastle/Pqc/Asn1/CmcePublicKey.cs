using System;
using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Pqc.Asn1;

public class CmcePublicKey : Asn1Object
{
	private byte[] t;

	public byte[] T => null;

	public static CmcePublicKey GetInstance(object o)
	{
		return null;
	}

	public static CmcePublicKey GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public CmcePublicKey(byte[] t)
	{
	}

	[Obsolete("Use 'GetInstance' instead")]
	public CmcePublicKey(Asn1Sequence seq)
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

	internal override DerEncoding GetEncodingDer()
	{
		return null;
	}

	internal override DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo)
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
