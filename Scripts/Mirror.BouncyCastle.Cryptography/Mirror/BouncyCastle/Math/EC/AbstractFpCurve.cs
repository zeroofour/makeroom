using System.Collections.Concurrent;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Math.EC;

public abstract class AbstractFpCurve : ECCurve
{
	private static readonly ConcurrentDictionary<BigInteger, bool> KnownPrimes;

	protected AbstractFpCurve(BigInteger q)
		: base(null)
	{
	}

	internal AbstractFpCurve(BigInteger q, bool isInternal)
		: base(null)
	{
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

	private static void ImplCheckQ(BigInteger q)
	{
	}

	private static int ImplGetIterations(int bits, int certainty)
	{
		return 0;
	}

	private static bool ImplIsPrime(BigInteger q)
	{
		return false;
	}

	private static BigInteger ImplRandomFieldElement(SecureRandom r, BigInteger p)
	{
		return null;
	}

	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, BigInteger p)
	{
		return null;
	}
}
