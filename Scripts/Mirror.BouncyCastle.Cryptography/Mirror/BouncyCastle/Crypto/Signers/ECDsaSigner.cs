using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;
using Mirror.BouncyCastle.Math.EC;
using Mirror.BouncyCastle.Math.EC.Multiplier;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Signers;

public class ECDsaSigner : IDsa
{
	private static readonly BigInteger Eight;

	protected readonly IDsaKCalculator kCalculator;

	protected ECKeyParameters key;

	protected SecureRandom random;

	public virtual string AlgorithmName => null;

	public virtual BigInteger Order => null;

	public ECDsaSigner()
	{
	}

	public ECDsaSigner(IDsaKCalculator kCalculator)
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

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return null;
	}

	protected virtual ECFieldElement GetDenominator(int coordinateSystem, ECPoint p)
	{
		return null;
	}

	protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
	{
		return null;
	}
}
