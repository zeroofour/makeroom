using Mirror.BouncyCastle.Math.Field;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC;

public abstract class AbstractF2mCurve : ECCurve
{
	public virtual bool IsKoblitz => false;

	public static BigInteger Inverse(int m, int[] ks, BigInteger x)
	{
		return null;
	}

	private static IFiniteField BuildField(int m, int k1, int k2, int k3)
	{
		return null;
	}

	protected AbstractF2mCurve(int m, int k1, int k2, int k3)
		: base(null)
	{
	}

	public override ECPoint CreatePoint(BigInteger x, BigInteger y)
	{
		return null;
	}

	public override bool IsValidFieldElement(BigInteger x)
	{
		return false;
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		return null;
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		return null;
	}

	protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
	{
		return null;
	}

	internal ECFieldElement SolveQuadraticEquation(ECFieldElement beta)
	{
		return null;
	}

	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, int m)
	{
		return null;
	}
}
