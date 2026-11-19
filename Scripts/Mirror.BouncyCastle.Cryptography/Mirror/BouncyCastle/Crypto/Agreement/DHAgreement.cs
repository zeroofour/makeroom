using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public class DHAgreement
{
	private DHPrivateKeyParameters key;

	private DHParameters dhParams;

	private BigInteger privateValue;

	private SecureRandom random;

	public void Init(ICipherParameters parameters)
	{
	}

	public BigInteger CalculateMessage()
	{
		return null;
	}

	public BigInteger CalculateAgreement(DHPublicKeyParameters pub, BigInteger message)
	{
		return null;
	}
}
