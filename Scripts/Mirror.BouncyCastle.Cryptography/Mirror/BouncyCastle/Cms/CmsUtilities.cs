using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Operators.Utilities;
using Mirror.BouncyCastle.Utilities.Collections;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

internal static class CmsUtilities
{
	private static readonly HashSet<DerObjectIdentifier> ECAlgorithms;

	private static readonly HashSet<DerObjectIdentifier> GostAlgorithms;

	private static readonly HashSet<DerObjectIdentifier> MqvAlgorithms;

	internal static int MaximumMemory => 0;

	static CmsUtilities()
	{
	}

	internal static bool IsEC(DerObjectIdentifier oid)
	{
		return false;
	}

	internal static bool IsGost(DerObjectIdentifier oid)
	{
		return false;
	}

	internal static bool IsMqv(DerObjectIdentifier oid)
	{
		return false;
	}

	internal static ContentInfo ReadContentInfo(byte[] input)
	{
		return null;
	}

	internal static ContentInfo ReadContentInfo(Stream input)
	{
		return null;
	}

	private static ContentInfo ReadContentInfo(Asn1InputStream asn1In)
	{
		return null;
	}

	internal static byte[] StreamToByteArray(Stream inStream)
	{
		return null;
	}

	internal static byte[] StreamToByteArray(Stream inStream, int limit)
	{
		return null;
	}

	internal static List<Asn1TaggedObject> GetAttributeCertificatesFromStore(IStore<X509V2AttributeCertificate> attrCertStore)
	{
		return null;
	}

	internal static List<X509CertificateStructure> GetCertificatesFromStore(IStore<X509Certificate> certStore)
	{
		return null;
	}

	internal static List<CertificateList> GetCrlsFromStore(IStore<X509Crl> crlStore)
	{
		return null;
	}

	internal static List<Asn1TaggedObject> GetOtherRevocationInfosFromStore(IStore<OtherRevocationInfoFormat> otherRevocationInfoStore)
	{
		return null;
	}

	internal static List<DerTaggedObject> GetOtherRevocationInfosFromStore(IStore<Asn1Encodable> otherRevInfoStore, DerObjectIdentifier otherRevInfoFormat)
	{
		return null;
	}

	internal static void AddDigestAlgs(Asn1EncodableVector digestAlgs, SignerInformation signer, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
	}

	internal static void AddDigestAlgs(ISet<AlgorithmIdentifier> digestAlgs, SignerInformation signer, IDigestAlgorithmFinder digestAlgorithmFinder)
	{
	}

	internal static Asn1Set ConvertToDLSet(ISet<AlgorithmIdentifier> digestAlgs)
	{
		return null;
	}

	internal static Asn1Set CreateBerSetFromList(IEnumerable<Asn1Encodable> elements)
	{
		return null;
	}

	internal static Asn1Set CreateDerSetFromList(IEnumerable<Asn1Encodable> elements)
	{
		return null;
	}

	internal static IssuerAndSerialNumber GetIssuerAndSerialNumber(X509Certificate cert)
	{
		return null;
	}

	internal static Mirror.BouncyCastle.Asn1.Cms.AttributeTable ParseAttributeTable(Asn1SetParser parser)
	{
		return null;
	}

	internal static void ValidateOtherRevocationInfo(OtherRevocationInfoFormat otherRevocationInfo)
	{
	}
}
