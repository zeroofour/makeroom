using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Utilities.Collections;

namespace Mirror.BouncyCastle.X509.Store;

public class X509CertStoreSelector : ISelector<X509Certificate>, ICloneable
{
	private byte[] authorityKeyIdentifier;

	private int basicConstraints;

	private X509Certificate certificate;

	private DateTime? certificateValid;

	private ISet<DerObjectIdentifier> extendedKeyUsage;

	private bool ignoreX509NameOrdering;

	private X509Name issuer;

	private bool[] keyUsage;

	private ISet<DerObjectIdentifier> policy;

	private DateTime? privateKeyValid;

	private BigInteger serialNumber;

	private X509Name subject;

	private byte[] subjectKeyIdentifier;

	private SubjectPublicKeyInfo subjectPublicKey;

	private DerObjectIdentifier subjectPublicKeyAlgID;

	public byte[] AuthorityKeyIdentifier
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int BasicConstraints
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public X509Certificate Certificate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DateTime? CertificateValid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ISet<DerObjectIdentifier> ExtendedKeyUsage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IgnoreX509NameOrdering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public X509Name Issuer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool[] KeyUsage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ISet<DerObjectIdentifier> Policy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DateTime? PrivateKeyValid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BigInteger SerialNumber
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public X509Name Subject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public byte[] SubjectKeyIdentifier
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SubjectPublicKeyInfo SubjectPublicKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DerObjectIdentifier SubjectPublicKeyAlgID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public X509CertStoreSelector()
	{
	}

	public X509CertStoreSelector(X509CertStoreSelector o)
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public virtual bool Match(X509Certificate c)
	{
		return false;
	}

	protected internal int GetHashCodeOfSubjectKeyIdentifier()
	{
		return 0;
	}

	protected internal bool MatchesIssuer(X509CertStoreSelector other)
	{
		return false;
	}

	protected internal bool MatchesSerialNumber(X509CertStoreSelector other)
	{
		return false;
	}

	protected internal bool MatchesSubjectKeyIdentifier(X509CertStoreSelector other)
	{
		return false;
	}

	private static bool IssuersMatch(X509Name a, X509Name b)
	{
		return false;
	}

	private static ISet<T> CopySet<T>(ISet<T> s)
	{
		return null;
	}

	private static bool MatchExtension(byte[] b, X509Certificate c, DerObjectIdentifier oid)
	{
		return false;
	}
}
