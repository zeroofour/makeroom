using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public class ECDHWithKdfBasicAgreement : ECDHBasicAgreement
{
	private readonly string m_algorithm;

	private readonly IDerivationFunction m_kdf;

	public ECDHWithKdfBasicAgreement(string algorithm, IDerivationFunction kdf)
	{
	}

	public override BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		return null;
	}
}
