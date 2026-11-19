using Mirror.BouncyCastle.Asn1.X500;

namespace Mirror.BouncyCastle.Asn1.Esf;

public class SignerLocation : Asn1Encodable
{
	private readonly DirectoryString m_countryName;

	private readonly DirectoryString m_localityName;

	private readonly Asn1Sequence m_postalAddress;

	public DirectoryString Country => null;

	public DirectoryString Locality => null;

	public Asn1Sequence PostalAddress => null;

	public static SignerLocation GetInstance(object obj)
	{
		return null;
	}

	public static SignerLocation GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public SignerLocation(Asn1Sequence seq)
	{
	}

	private SignerLocation(DirectoryString countryName, DirectoryString localityName, Asn1Sequence postalAddress)
	{
	}

	public SignerLocation(DirectoryString countryName, DirectoryString localityName, DirectoryString[] postalAddress)
	{
	}

	public SignerLocation(DerUtf8String countryName, DerUtf8String localityName, Asn1Sequence postalAddress)
	{
	}

	public DirectoryString[] GetPostal()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
