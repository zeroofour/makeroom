using System;

namespace Mirror.BouncyCastle.Asn1;

internal abstract class Asn1UniversalType : Asn1Type
{
	internal readonly Asn1Tag m_tag;

	internal Asn1Tag Tag => null;

	internal Asn1UniversalType(Type platformType, int tagNo)
		: base(null)
	{
	}

	internal Asn1Object CheckedCast(Asn1Object asn1Object)
	{
		return null;
	}

	internal virtual Asn1Object FromImplicitPrimitive(DerOctetString octetString)
	{
		return null;
	}

	internal virtual Asn1Object FromImplicitConstructed(Asn1Sequence sequence)
	{
		return null;
	}

	internal Asn1Object FromByteArray(byte[] bytes)
	{
		return null;
	}

	internal Asn1Object GetContextInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}
}
