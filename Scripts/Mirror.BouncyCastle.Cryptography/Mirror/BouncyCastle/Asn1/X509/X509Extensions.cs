using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class X509Extensions : Asn1Encodable
{
	public static readonly DerObjectIdentifier SubjectDirectoryAttributes;

	public static readonly DerObjectIdentifier SubjectKeyIdentifier;

	public static readonly DerObjectIdentifier KeyUsage;

	public static readonly DerObjectIdentifier PrivateKeyUsagePeriod;

	public static readonly DerObjectIdentifier SubjectAlternativeName;

	public static readonly DerObjectIdentifier IssuerAlternativeName;

	public static readonly DerObjectIdentifier BasicConstraints;

	public static readonly DerObjectIdentifier CrlNumber;

	public static readonly DerObjectIdentifier ReasonCode;

	public static readonly DerObjectIdentifier InstructionCode;

	public static readonly DerObjectIdentifier InvalidityDate;

	public static readonly DerObjectIdentifier DeltaCrlIndicator;

	public static readonly DerObjectIdentifier IssuingDistributionPoint;

	public static readonly DerObjectIdentifier CertificateIssuer;

	public static readonly DerObjectIdentifier NameConstraints;

	public static readonly DerObjectIdentifier CrlDistributionPoints;

	public static readonly DerObjectIdentifier CertificatePolicies;

	public static readonly DerObjectIdentifier PolicyMappings;

	public static readonly DerObjectIdentifier AuthorityKeyIdentifier;

	public static readonly DerObjectIdentifier PolicyConstraints;

	public static readonly DerObjectIdentifier ExtendedKeyUsage;

	public static readonly DerObjectIdentifier FreshestCrl;

	public static readonly DerObjectIdentifier InhibitAnyPolicy;

	public static readonly DerObjectIdentifier AuthorityInfoAccess;

	public static readonly DerObjectIdentifier SubjectInfoAccess;

	public static readonly DerObjectIdentifier LogoType;

	public static readonly DerObjectIdentifier BiometricInfo;

	public static readonly DerObjectIdentifier QCStatements;

	public static readonly DerObjectIdentifier AuditIdentity;

	public static readonly DerObjectIdentifier NoRevAvail;

	public static readonly DerObjectIdentifier TargetInformation;

	public static readonly DerObjectIdentifier ExpiredCertsOnCrl;

	public static readonly DerObjectIdentifier SubjectAltPublicKeyInfo;

	public static readonly DerObjectIdentifier AltSignatureAlgorithm;

	public static readonly DerObjectIdentifier AltSignatureValue;

	private readonly Dictionary<DerObjectIdentifier, X509Extension> m_extensions;

	private readonly List<DerObjectIdentifier> m_ordering;

	public IEnumerable<DerObjectIdentifier> ExtensionOids => null;

	public static X509Extension GetExtension(X509Extensions extensions, DerObjectIdentifier oid)
	{
		return null;
	}

	public static Asn1Object GetExtensionParsedValue(X509Extensions extensions, DerObjectIdentifier oid)
	{
		return null;
	}

	public static Asn1OctetString GetExtensionValue(X509Extensions extensions, DerObjectIdentifier oid)
	{
		return null;
	}

	public static X509Extensions GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	public static X509Extensions GetInstance(object obj)
	{
		return null;
	}

	private X509Extensions(Asn1Sequence seq)
	{
	}

	public X509Extensions(IDictionary<DerObjectIdentifier, X509Extension> extensions)
	{
	}

	public X509Extensions(IList<DerObjectIdentifier> ordering, IDictionary<DerObjectIdentifier, X509Extension> extensions)
	{
	}

	public X509Extensions(IList<DerObjectIdentifier> oids, IList<X509Extension> values)
	{
	}

	public X509Extension GetExtension(DerObjectIdentifier oid)
	{
		return null;
	}

	public Asn1Object GetExtensionParsedValue(DerObjectIdentifier oid)
	{
		return null;
	}

	public Asn1OctetString GetExtensionValue(DerObjectIdentifier oid)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}

	public bool Equivalent(X509Extensions other)
	{
		return false;
	}

	public DerObjectIdentifier[] GetExtensionOids()
	{
		return null;
	}

	public DerObjectIdentifier[] GetNonCriticalExtensionOids()
	{
		return null;
	}

	public DerObjectIdentifier[] GetCriticalExtensionOids()
	{
		return null;
	}

	private DerObjectIdentifier[] GetExtensionOids(bool isCritical)
	{
		return null;
	}
}
