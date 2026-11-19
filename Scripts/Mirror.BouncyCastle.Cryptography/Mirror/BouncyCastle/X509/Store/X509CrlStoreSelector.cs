using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Utilities.Collections;

namespace Mirror.BouncyCastle.X509.Store;

public class X509CrlStoreSelector : ISelector<X509Crl>, ICloneable, ICheckingCertificate
{
	private X509Certificate certificateChecking;

	private DateTime? dateAndTime;

	private IList<X509Name> issuers;

	private BigInteger maxCrlNumber;

	private BigInteger minCrlNumber;

	private X509V2AttributeCertificate attrCertChecking;

	private bool completeCrlEnabled;

	private bool deltaCrlIndicatorEnabled;

	private byte[] issuingDistributionPoint;

	private bool issuingDistributionPointEnabled;

	private BigInteger maxBaseCrlNumber;

	public X509Certificate CertificateChecking
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DateTime? DateAndTime
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IList<X509Name> Issuers
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BigInteger MaxCrlNumber
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BigInteger MinCrlNumber
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public X509V2AttributeCertificate AttrCertChecking
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool CompleteCrlEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeltaCrlIndicatorEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public byte[] IssuingDistributionPoint
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IssuingDistributionPointEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BigInteger MaxBaseCrlNumber
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public X509CrlStoreSelector()
	{
	}

	public X509CrlStoreSelector(X509CrlStoreSelector o)
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public virtual bool Match(X509Crl c)
	{
		return false;
	}
}
