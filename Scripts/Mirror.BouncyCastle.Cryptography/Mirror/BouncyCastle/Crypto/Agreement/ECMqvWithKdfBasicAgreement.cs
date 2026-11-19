using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public class ECMqvWithKdfBasicAgreement : ECMqvBasicAgreement
{
	private readonly string m_algorithm;

	private readonly IDerivationFunction m_kdf;

	public ECMqvWithKdfBasicAgreement(string algorithm, IDerivationFunction kdf)
	{
	}

	public override BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		return null;
	}
}
