using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class DsaSigner : IDsa
{
	protected readonly IDsaKCalculator kCalculator;

	protected DsaKeyParameters key;

	protected SecureRandom random;

	public virtual string AlgorithmName => null;

	public virtual BigInteger Order => null;

	public DsaSigner()
	{
	}

	public DsaSigner(IDsaKCalculator kCalculator)
	{
	}

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

	protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
	{
		return null;
	}

	protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
	{
		return null;
	}
}
