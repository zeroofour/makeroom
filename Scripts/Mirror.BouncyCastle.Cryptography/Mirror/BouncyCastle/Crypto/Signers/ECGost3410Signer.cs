using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC.Multiplier;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class ECGost3410Signer : IDsa
{
	private ECKeyParameters key;

	private SecureRandom random;

	private bool forSigning;

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

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return null;
	}
}
