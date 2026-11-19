using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Pqc.Crypto.Bike;
using Mirror.BouncyCastle.Pqc.Crypto.Cmce;
using Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;
using Mirror.BouncyCastle.Pqc.Crypto.Falcon;
using Mirror.BouncyCastle.Pqc.Crypto.Frodo;
using Mirror.BouncyCastle.Pqc.Crypto.Hqc;
using Mirror.BouncyCastle.Pqc.Crypto.Picnic;
using Mirror.BouncyCastle.Pqc.Crypto.Saber;
using Mirror.BouncyCastle.Pqc.Crypto.Sike;
using Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

namespace Mirror.BouncyCastle.Pqc.Crypto.Utilities;

internal class PqcUtilities
{
	private static readonly Dictionary<CmceParameters, DerObjectIdentifier> mcElieceOids;

	private static readonly Dictionary<DerObjectIdentifier, CmceParameters> mcElieceParams;

	private static readonly Dictionary<FrodoParameters, DerObjectIdentifier> frodoOids;

	private static readonly Dictionary<DerObjectIdentifier, FrodoParameters> frodoParams;

	private static readonly Dictionary<SaberParameters, DerObjectIdentifier> saberOids;

	private static readonly Dictionary<DerObjectIdentifier, SaberParameters> saberParams;

	private static readonly Dictionary<PicnicParameters, DerObjectIdentifier> picnicOids;

	private static readonly Dictionary<DerObjectIdentifier, PicnicParameters> picnicParams;

	private static readonly Dictionary<SikeParameters, DerObjectIdentifier> sikeOids;

	private static readonly Dictionary<DerObjectIdentifier, SikeParameters> sikeParams;

	private static readonly Dictionary<KyberParameters, DerObjectIdentifier> kyberOids;

	private static readonly Dictionary<DerObjectIdentifier, KyberParameters> kyberParams;

	private static readonly Dictionary<DilithiumParameters, DerObjectIdentifier> dilithiumOids;

	private static readonly Dictionary<DerObjectIdentifier, DilithiumParameters> dilithiumParams;

	private static readonly Dictionary<FalconParameters, DerObjectIdentifier> falconOids;

	private static readonly Dictionary<DerObjectIdentifier, FalconParameters> falconParams;

	private static readonly Dictionary<BikeParameters, DerObjectIdentifier> bikeOids;

	private static readonly Dictionary<DerObjectIdentifier, BikeParameters> bikeParams;

	private static readonly Dictionary<HqcParameters, DerObjectIdentifier> hqcOids;

	private static readonly Dictionary<DerObjectIdentifier, HqcParameters> hqcParams;

	private static readonly Dictionary<SphincsPlusParameters, DerObjectIdentifier> sphincsPlusOids;

	private static readonly Dictionary<DerObjectIdentifier, SphincsPlusParameters> sphincsPlusParams;

	static PqcUtilities()
	{
	}

	internal static DerObjectIdentifier McElieceOidLookup(CmceParameters parameters)
	{
		return null;
	}

	internal static CmceParameters McElieceParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier FrodoOidLookup(FrodoParameters parameters)
	{
		return null;
	}

	internal static FrodoParameters FrodoParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier SaberOidLookup(SaberParameters parameters)
	{
		return null;
	}

	internal static SaberParameters SaberParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static KyberParameters KyberParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier KyberOidLookup(KyberParameters parameters)
	{
		return null;
	}

	internal static FalconParameters FalconParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier FalconOidLookup(FalconParameters parameters)
	{
		return null;
	}

	internal static DilithiumParameters DilithiumParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier DilithiumOidLookup(DilithiumParameters parameters)
	{
		return null;
	}

	internal static DerObjectIdentifier PicnicOidLookup(PicnicParameters parameters)
	{
		return null;
	}

	internal static PicnicParameters PicnicParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier SikeOidLookup(SikeParameters parameters)
	{
		return null;
	}

	internal static SikeParameters SikeParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier BikeOidLookup(BikeParameters parameters)
	{
		return null;
	}

	internal static BikeParameters BikeParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier HqcOidLookup(HqcParameters parameters)
	{
		return null;
	}

	internal static HqcParameters HqcParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static DerObjectIdentifier SphincsPlusOidLookup(SphincsPlusParameters parameters)
	{
		return null;
	}

	internal static SphincsPlusParameters SphincsPlusParamsLookup(DerObjectIdentifier oid)
	{
		return null;
	}
}
