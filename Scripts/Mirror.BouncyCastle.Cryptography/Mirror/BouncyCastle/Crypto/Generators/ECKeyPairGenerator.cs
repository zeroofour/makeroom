using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X9;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math.EC.Multiplier;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class ECKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private readonly string algorithm;

	private ECDomainParameters parameters;

	private DerObjectIdentifier publicKeyParamSet;

	private SecureRandom random;

	public ECKeyPairGenerator()
	{
	}

	public ECKeyPairGenerator(string algorithm)
	{
	}

	public void Init(KeyGenerationParameters parameters)
	{
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		return null;
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return null;
	}

	internal static X9ECParameters FindECCurveByName(string name)
	{
		return null;
	}

	internal static X9ECParametersHolder FindECCurveByNameLazy(string name)
	{
		return null;
	}

	internal static X9ECParameters FindECCurveByOid(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static X9ECParametersHolder FindECCurveByOidLazy(DerObjectIdentifier oid)
	{
		return null;
	}

	internal static ECPublicKeyParameters GetCorrespondingPublicKey(ECPrivateKeyParameters privKey)
	{
		return null;
	}
}
