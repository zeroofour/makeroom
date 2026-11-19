using System;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1TaggedObject : Asn1Object, Asn1TaggedObjectParser, IAsn1Convertible
{
	private const int DeclaredExplicit = 1;

	private const int DeclaredImplicit = 2;

	private const int ParsedExplicit = 3;

	private const int ParsedImplicit = 4;

	internal readonly int m_explicitness;

	internal readonly int m_tagClass;

	internal readonly int m_tagNo;

	internal readonly Asn1Encodable m_object;

	public int TagClass => 0;

	public int TagNo => 0;

	public static Asn1TaggedObject GetInstance(object obj)
	{
		return null;
	}

	public static Asn1TaggedObject GetInstance(object obj, int tagClass)
	{
		return null;
	}

	public static Asn1TaggedObject GetInstance(object obj, int tagClass, int tagNo)
	{
		return null;
	}

	public static Asn1TaggedObject GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static Asn1TaggedObject GetInstance(Asn1TaggedObject taggedObject, int tagClass, bool declaredExplicit)
	{
		return null;
	}

	public static Asn1TaggedObject GetInstance(Asn1TaggedObject taggedObject, int tagClass, int tagNo, bool declaredExplicit)
	{
		return null;
	}

	private static Asn1TaggedObject CheckInstance(object obj)
	{
		return null;
	}

	private static Asn1TaggedObject CheckInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	protected Asn1TaggedObject(bool isExplicit, int tagNo, Asn1Encodable obj)
	{
	}

	protected Asn1TaggedObject(bool isExplicit, int tagClass, int tagNo, Asn1Encodable obj)
	{
	}

	internal Asn1TaggedObject(int explicitness, int tagClass, int tagNo, Asn1Encodable obj)
	{
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return 0;
	}

	public bool HasContextTag()
	{
		return false;
	}

	public bool HasContextTag(int tagNo)
	{
		return false;
	}

	public bool HasTag(int tagClass, int tagNo)
	{
		return false;
	}

	public bool HasTagClass(int tagClass)
	{
		return false;
	}

	public bool IsExplicit()
	{
		return false;
	}

	internal bool IsParsed()
	{
		return false;
	}

	[Obsolete("Will be removed")]
	public Asn1Object GetObject()
	{
		return null;
	}

	public Asn1Encodable GetBaseObject()
	{
		return null;
	}

	public Asn1Encodable GetExplicitBaseObject()
	{
		return null;
	}

	public Asn1TaggedObject GetExplicitBaseTagged()
	{
		return null;
	}

	public Asn1TaggedObject GetImplicitBaseTagged(int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public Asn1Object GetBaseUniversal(bool declaredExplicit, int tagNo)
	{
		return null;
	}

	internal Asn1Object GetBaseUniversal(bool declaredExplicit, Asn1UniversalType universalType)
	{
		return null;
	}

	public IAsn1Convertible ParseBaseUniversal(bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public IAsn1Convertible ParseExplicitBaseObject()
	{
		return null;
	}

	public Asn1TaggedObjectParser ParseExplicitBaseTagged()
	{
		return null;
	}

	public Asn1TaggedObjectParser ParseImplicitBaseTagged(int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	internal abstract Asn1Sequence RebuildConstructed(Asn1Object asn1Object);

	internal abstract Asn1TaggedObject ReplaceTag(int tagClass, int tagNo);

	internal static Asn1Object CreateConstructedDL(int tagClass, int tagNo, Asn1EncodableVector contentsElements)
	{
		return null;
	}

	internal static Asn1Object CreateConstructedIL(int tagClass, int tagNo, Asn1EncodableVector contentsElements)
	{
		return null;
	}

	internal static Asn1Object CreatePrimitive(int tagClass, int tagNo, byte[] contentsOctets)
	{
		return null;
	}

	private static Asn1TaggedObject CheckedCast(Asn1Object asn1Object)
	{
		return null;
	}
}
