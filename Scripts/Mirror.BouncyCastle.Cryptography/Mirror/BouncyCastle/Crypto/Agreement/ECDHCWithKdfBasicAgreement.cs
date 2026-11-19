using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public sealed class ECDHCWithKdfBasicAgreement : ECDHCBasicAgreement
{
	private readonly string m_algorithm;

	private readonly IDerivationFunction m_kdf;

	public ECDHCWithKdfBasicAgreement(string algorithm, IDerivationFunction kdf)
	{
	}

	public override BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		return null;
	}
}
