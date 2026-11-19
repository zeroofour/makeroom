using System.IO;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1OctetString : Asn1Object, Asn1OctetStringParser, IAsn1Convertible
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

		internal override Asn1Object FromImplicitConstructed(Asn1Sequence sequence)
		{
			return null;
		}
	}

	internal static readonly byte[] EmptyOctets;

	internal readonly byte[] contents;

	public Asn1OctetStringParser Parser => null;

	public static Asn1OctetString GetInstance(object obj)
	{
		return null;
	}

	public static Asn1OctetString GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	internal Asn1OctetString(byte[] contents)
	{
	}

	public Stream GetOctetStream()
	{
		return null;
	}

	public virtual byte[] GetOctets()
	{
		return null;
	}

	public virtual int GetOctetsLength()
	{
		return 0;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	internal static Asn1OctetString CreatePrimitive(byte[] contents)
	{
		return null;
	}
}
