using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Agreement;

public class ECDHCBasicAgreement : IBasicAgreement
{
	private ECPrivateKeyParameters privKey;

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
}
