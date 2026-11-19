namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Null : Asn1Object
{
	internal class Meta : Asn1UniversalType
	{
		internal static readonly Asn1UniversalType Instance;

		private Meta()
			: base(null, 0)
		{
		}

		internal override Asn1Object FromImplicitPrimitive(DerOctetString octetString)
		{
			return null;
		}
	}

	public static Asn1Null GetInstance(object obj)
	{
		return null;
	}

	public static Asn1Null GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal Asn1Null()
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static Asn1Null CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
