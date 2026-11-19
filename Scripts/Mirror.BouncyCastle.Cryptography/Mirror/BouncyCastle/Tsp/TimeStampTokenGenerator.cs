using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.Ess;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Tsp;

public class TimeStampTokenGenerator
{
	private class TableGen : CmsAttributeTableGenerator
	{
		private readonly SignerInfoGenerator infoGen;

		private readonly EssCertID essCertID;

		public TableGen(SignerInfoGenerator infoGen, EssCertID essCertID)
		{
		}

		public Mirror.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(IDictionary<CmsAttributeTableParameter, object> parameters)
		{
			return null;
		}
	}

	private class TableGen2 : CmsAttributeTableGenerator
	{
		private readonly SignerInfoGenerator infoGen;

		private readonly EssCertIDv2 essCertID;

		public TableGen2(SignerInfoGenerator infoGen, EssCertIDv2 essCertID)
		{
		}

		public Mirror.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(IDictionary<CmsAttributeTableParameter, object> parameters)
		{
			return null;
		}
	}

	private int accuracySeconds;

	private int accuracyMillis;

	private int accuracyMicros;

	private bool ordering;

	private GeneralName tsa;

	private DerObjectIdentifier tsaPolicyOID;

	private IStore<X509Certificate> x509Certs;

	private IStore<X509Crl> x509Crls;

	private IStore<X509V2AttributeCertificate> x509AttrCerts;

	private SignerInfoGenerator signerInfoGenerator;

	private IDigestFactory digestCalculator;

	private Resolution resolution;

	public Resolution Resolution
	{
		get
		{
			return Resolution.R_SECONDS;
		}
		set
		{
		}
	}

	public TimeStampTokenGenerator(AsymmetricKeyParameter key, X509Certificate cert, string digestOID, string tsaPolicyOID)
	{
	}

	public TimeStampTokenGenerator(SignerInfoGenerator signerInfoGen, IDigestFactory digestCalculator, DerObjectIdentifier tsaPolicy, bool isIssuerSerialIncluded)
	{
	}

	public TimeStampTokenGenerator(AsymmetricKeyParameter key, X509Certificate cert, string digestOID, string tsaPolicyOID, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
	}

	internal static SignerInfoGenerator MakeInfoGenerator(AsymmetricKeyParameter key, X509Certificate cert, DerObjectIdentifier digestOid, Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
	{
		return null;
	}

	public void SetAttributeCertificates(IStore<X509V2AttributeCertificate> attributeCertificates)
	{
	}

	public void SetCertificates(IStore<X509Certificate> certificates)
	{
	}

	public void SetCrls(IStore<X509Crl> crls)
	{
	}

	public void SetAccuracySeconds(int accuracySeconds)
	{
	}

	public void SetAccuracyMillis(int accuracyMillis)
	{
	}

	public void SetAccuracyMicros(int accuracyMicros)
	{
	}

	public void SetOrdering(bool ordering)
	{
	}

	public void SetTsa(GeneralName tsa)
	{
	}

	public TimeStampToken Generate(TimeStampRequest request, BigInteger serialNumber, DateTime genTime)
	{
		return null;
	}

	public TimeStampToken Generate(TimeStampRequest request, BigInteger serialNumber, DateTime genTime, X509Extensions additionalExtensions)
	{
		return null;
	}

	private static DateTime WithResolution(DateTime dateTime, Resolution resolution)
	{
		return default;
	}
}
