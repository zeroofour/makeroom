using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

namespace Mirror.BouncyCastle.Pqc.Crypto.Utilities;

public static class PqcPublicKeyFactory
{
	private delegate AsymmetricKeyParameter Converter(SubjectPublicKeyInfo keyInfo, object defaultParams);

	private static Dictionary<DerObjectIdentifier, Converter> Converters;

	static PqcPublicKeyFactory()
	{
	}

	public static AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo)
	{
		return null;
	}

	public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	internal static DilithiumPublicKeyParameters GetDilithiumPublicKey(DilithiumParameters dilithiumParameters, DerBitString publicKeyData)
	{
		return null;
	}

	private static AsymmetricKeyParameter LmsConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter SphincsPlusConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter CmceConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter FrodoConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter SaberConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter PicnicConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	private static AsymmetricKeyParameter SikeConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter DilithiumConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter KyberConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter FalconConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter BikeConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}

	private static AsymmetricKeyParameter HqcConverter(SubjectPublicKeyInfo keyInfo, object defaultParams)
	{
		return null;
	}
}
