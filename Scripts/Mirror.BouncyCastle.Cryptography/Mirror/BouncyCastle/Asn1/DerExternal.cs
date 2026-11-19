using System;

namespace Mirror.BouncyCastle.Asn1;

public class DerExternal : Asn1Object
{
	internal class Meta : Asn1UniversalType
	{
		internal static readonly Asn1UniversalType Instance;

		private Meta()
			: base(null, 0)
		{
		}

		internal override Asn1Object FromImplicitConstructed(Asn1Sequence sequence)
		{
			return null;
		}
	}

	internal readonly DerObjectIdentifier directReference;

	internal readonly DerInteger indirectReference;

	internal readonly Asn1ObjectDescriptor dataValueDescriptor;

	internal readonly int encoding;

	internal readonly Asn1Object externalContent;

	public Asn1ObjectDescriptor DataValueDescriptor => null;

	public DerObjectIdentifier DirectReference => null;

	public int Encoding => 0;

	public Asn1Object ExternalContent => null;

	public DerInteger IndirectReference => null;

	public static DerExternal GetInstance(object obj)
	{
		return null;
	}

	public static DerExternal GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public DerExternal(Asn1EncodableVector vector)
	{
	}

	public DerExternal(Asn1Sequence sequence)
	{
	}

	[Obsolete("Pass 'externalData' at type Asn1TaggedObject")]
	public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1ObjectDescriptor dataValueDescriptor, DerTaggedObject externalData)
	{
	}

	public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1ObjectDescriptor dataValueDescriptor, Asn1TaggedObject externalData)
	{
	}

	public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1ObjectDescriptor dataValueDescriptor, int encoding, Asn1Object externalData)
	{
	}

	internal virtual Asn1Sequence BuildSequence()
	{
		return null;
	}

	internal sealed override IAsn1Encoding GetEncoding(int encoding)
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

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	private static Asn1ObjectDescriptor CheckDataValueDescriptor(Asn1Object dataValueDescriptor)
	{
		return null;
	}

	private static int CheckEncoding(int encoding)
	{
		return 0;
	}

	private static Asn1Object CheckExternalContent(int tagNo, Asn1Object externalContent)
	{
		return null;
	}

	private static Asn1Object GetExternalContent(Asn1TaggedObject encoding)
	{
		return null;
	}

	private static Asn1Object GetObjFromSequence(Asn1Sequence sequence, int index)
	{
		return null;
	}
}
