using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Utilities.Collections;

namespace Mirror.BouncyCastle.X509.Store;

public class X509AttrCertStoreSelector : ISelector<X509V2AttributeCertificate>, ICloneable
{
	private X509V2AttributeCertificate attributeCert;

	private DateTime? attributeCertificateValid;

	private AttributeCertificateHolder holder;

	private AttributeCertificateIssuer issuer;

	private BigInteger serialNumber;

	private ISet<GeneralName> targetNames;

	private ISet<GeneralName> targetGroups;

	public X509V2AttributeCertificate AttributeCert
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DateTime? AttributeCertificateValid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AttributeCertificateHolder Holder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AttributeCertificateIssuer Issuer
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

	public X509AttrCertStoreSelector()
	{
	}

	private X509AttrCertStoreSelector(X509AttrCertStoreSelector o)
	{
	}

	public bool Match(X509V2AttributeCertificate attrCert)
	{
		return false;
	}

	public object Clone()
	{
		return null;
	}

	public void AddTargetName(GeneralName name)
	{
	}

	public void AddTargetName(byte[] name)
	{
	}

	public void SetTargetNames(IEnumerable<object> names)
	{
	}

	public IEnumerable<GeneralName> GetTargetNames()
	{
		return null;
	}

	public void AddTargetGroup(GeneralName group)
	{
	}

	public void AddTargetGroup(byte[] name)
	{
	}

	public void SetTargetGroups(IEnumerable<object> names)
	{
	}

	public IEnumerable<GeneralName> GetTargetGroups()
	{
		return null;
	}

	private ISet<GeneralName> ExtractGeneralNames(IEnumerable<object> names)
	{
		return null;
	}
}
