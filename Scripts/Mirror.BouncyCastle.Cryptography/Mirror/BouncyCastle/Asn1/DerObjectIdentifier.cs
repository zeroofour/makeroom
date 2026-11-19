namespace Mirror.BouncyCastle.Asn1;

public class DerObjectIdentifier : Asn1Object
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

	private const int MaxContentsLength = 4096;

	private const int MaxIdentifierLength = 16385;

	private const long LongLimit = 72057594037927808L;

	private static readonly DerObjectIdentifier[] Cache;

	private readonly byte[] m_contents;

	private string m_identifier;

	public string Id => null;

	public static DerObjectIdentifier FromContents(byte[] contents)
	{
		return null;
	}

	public static DerObjectIdentifier GetInstance(object obj)
	{
		return null;
	}

	public static DerObjectIdentifier GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static bool TryFromID(string identifier, out DerObjectIdentifier oid)
	{
		oid = null;
		return false;
	}

	public DerObjectIdentifier(string identifier)
	{
	}

	private DerObjectIdentifier(byte[] contents, string identifier)
	{
	}

	public virtual DerObjectIdentifier Branch(string branchID)
	{
		return null;
	}

	public string GetID()
	{
		return null;
	}

	public virtual bool On(DerObjectIdentifier stem)
	{
		return false;
	}

	public override string ToString()
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

	internal static void CheckContentsLength(int contentsLength)
	{
	}

	internal static void CheckIdentifier(string identifier)
	{
	}

	internal static DerObjectIdentifier CreatePrimitive(byte[] contents, bool clone)
	{
		return null;
	}

	private static bool IsValidIdentifier(string identifier)
	{
		return false;
	}

	private static string ParseContents(byte[] contents)
	{
		return null;
	}

	private static byte[] ParseIdentifier(string identifier)
	{
		return null;
	}
}
