using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public class ECMqvBasicAgreement : IBasicAgreement
{
	protected internal MqvPrivateParameters privParams;

	public virtual void Init(ICipherParameters parameters)
	{
	}

	public virtual int GetFieldSize()
	{
		return 0;
	}

	public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		return null;
	}

	private static ECPoint CalculateMqvAgreement(ECDomainParameters parameters, ECPrivateKeyParameters d1U, ECPrivateKeyParameters d2U, ECPublicKeyParameters Q2U, ECPublicKeyParameters Q1V, ECPublicKeyParameters Q2V)
	{
		return null;
	}
}
