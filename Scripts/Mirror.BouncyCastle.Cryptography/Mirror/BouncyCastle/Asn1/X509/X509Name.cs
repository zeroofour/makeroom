using System.Collections.Generic;
using System.Text;

namespace Mirror.BouncyCastle.Asn1.X509;

public class X509Name : Asn1Encodable
{
	public static readonly DerObjectIdentifier C;

	public static readonly DerObjectIdentifier O;

	public static readonly DerObjectIdentifier OU;

	public static readonly DerObjectIdentifier T;

	public static readonly DerObjectIdentifier CN;

	public static readonly DerObjectIdentifier Street;

	public static readonly DerObjectIdentifier SerialNumber;

	public static readonly DerObjectIdentifier L;

	public static readonly DerObjectIdentifier ST;

	public static readonly DerObjectIdentifier Surname;

	public static readonly DerObjectIdentifier GivenName;

	public static readonly DerObjectIdentifier Initials;

	public static readonly DerObjectIdentifier Generation;

	public static readonly DerObjectIdentifier UniqueIdentifier;

	public static readonly DerObjectIdentifier BusinessCategory;

	public static readonly DerObjectIdentifier PostalCode;

	public static readonly DerObjectIdentifier DnQualifier;

	public static readonly DerObjectIdentifier Pseudonym;

	public static readonly DerObjectIdentifier DateOfBirth;

	public static readonly DerObjectIdentifier PlaceOfBirth;

	public static readonly DerObjectIdentifier Gender;

	public static readonly DerObjectIdentifier CountryOfCitizenship;

	public static readonly DerObjectIdentifier CountryOfResidence;

	public static readonly DerObjectIdentifier NameAtBirth;

	public static readonly DerObjectIdentifier PostalAddress;

	public static readonly DerObjectIdentifier DmdName;

	public static readonly DerObjectIdentifier TelephoneNumber;

	public static readonly DerObjectIdentifier OrganizationIdentifier;

	public static readonly DerObjectIdentifier Name;

	public static readonly DerObjectIdentifier EmailAddress;

	public static readonly DerObjectIdentifier UnstructuredName;

	public static readonly DerObjectIdentifier UnstructuredAddress;

	public static readonly DerObjectIdentifier E;

	public static readonly DerObjectIdentifier DC;

	public static readonly DerObjectIdentifier UID;

	private static long defaultReverse;

	private static readonly IDictionary<DerObjectIdentifier, string> DefaultSymbolsInternal;

	public static readonly IDictionary<DerObjectIdentifier, string> DefaultSymbols;

	private static readonly IDictionary<DerObjectIdentifier, string> RFC2253SymbolsInternal;

	public static readonly IDictionary<DerObjectIdentifier, string> RFC2253Symbols;

	private static readonly IDictionary<DerObjectIdentifier, string> RFC1779SymbolsInternal;

	public static readonly IDictionary<DerObjectIdentifier, string> RFC1779Symbols;

	private static readonly IDictionary<string, DerObjectIdentifier> DefaultLookupInternal;

	public static readonly IDictionary<string, DerObjectIdentifier> DefaultLookup;

	private readonly List<DerObjectIdentifier> m_ordering;

	private readonly X509NameEntryConverter converter;

	private List<string> m_values;

	private List<bool> m_added;

	private Asn1Sequence seq;

	public static bool DefaultReverse
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	static X509Name()
	{
	}

	public static X509Name GetInstance(object obj)
	{
		return null;
	}

	public static X509Name GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	protected X509Name()
	{
	}

	protected X509Name(Asn1Sequence seq)
	{
	}

	public X509Name(IList<DerObjectIdentifier> ordering, IDictionary<DerObjectIdentifier, string> attributes)
	{
	}

	public X509Name(IList<DerObjectIdentifier> ordering, IDictionary<DerObjectIdentifier, string> attributes, X509NameEntryConverter converter)
	{
	}

	public X509Name(IList<DerObjectIdentifier> oids, IList<string> values)
	{
	}

	public X509Name(IList<DerObjectIdentifier> oids, IList<string> values, X509NameEntryConverter converter)
	{
	}

	public X509Name(string dirName)
	{
	}

	public X509Name(string dirName, X509NameEntryConverter converter)
	{
	}

	public X509Name(bool reverse, string dirName)
	{
	}

	public X509Name(bool reverse, string dirName, X509NameEntryConverter converter)
	{
	}

	public X509Name(bool reverse, IDictionary<string, DerObjectIdentifier> lookup, string dirName)
	{
	}

	private DerObjectIdentifier DecodeOid(string name, IDictionary<string, DerObjectIdentifier> lookup)
	{
		return null;
	}

	public X509Name(bool reverse, IDictionary<string, DerObjectIdentifier> lookup, string dirName, X509NameEntryConverter converter)
	{
	}

	public IList<DerObjectIdentifier> GetOidList()
	{
		return null;
	}

	public IList<string> GetValueList()
	{
		return null;
	}

	public IList<string> GetValueList(DerObjectIdentifier oid)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	public bool Equivalent(X509Name other, bool inOrder)
	{
		return false;
	}

	public bool Equivalent(X509Name other)
	{
		return false;
	}

	public string ToString(bool reverse, IDictionary<DerObjectIdentifier, string> oidSymbols)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private void AddAttribute(IDictionary<string, DerObjectIdentifier> lookup, string token, bool added)
	{
	}

	private static void AppendValue(StringBuilder buf, IDictionary<DerObjectIdentifier, string> oidSymbols, DerObjectIdentifier oid, string val)
	{
	}

	private static string Canonicalize(string s)
	{
		return null;
	}

	private static Asn1Object DecodeObject(string v)
	{
		return null;
	}

	private static bool EquivalentStrings(string s1, string s2)
	{
		return false;
	}

	private static string NextToken(X509NameTokenizer tokenizer)
	{
		return null;
	}

	private static string NextToken(X509NameTokenizer tokenizer, bool expectMoreTokens)
	{
		return null;
	}

	private static string StripInternalSpaces(string str)
	{
		return null;
	}
}
