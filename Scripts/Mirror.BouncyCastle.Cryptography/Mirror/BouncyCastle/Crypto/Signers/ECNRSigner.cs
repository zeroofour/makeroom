using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class ECNRSigner : IDsa
{
	private bool forSigning;

	private ECKeyParameters key;

	private SecureRandom random;

	public virtual string AlgorithmName => null;

	public virtual BigInteger Order => null;

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		return null;
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		return false;
	}
}
