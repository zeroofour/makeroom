using Mirror.BouncyCastle.Pqc.Crypto.Ntru.ParameterSets;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru.Polynomials;

internal abstract class Polynomial
{
	internal ushort[] coeffs;

	private protected readonly NtruParameterSet ParameterSet;

	internal Polynomial(NtruParameterSet parameterSet)
	{
	}

	internal static short BothNegativeMask(short x, short y)
	{
		return 0;
	}

	internal static ushort Mod3(ushort a)
	{
		return 0;
	}

	internal static byte Mod3(byte a)
	{
		return 0;
	}

	internal static uint ModQ(uint x, uint q)
	{
		return 0u;
	}

	internal void Mod3PhiN()
	{
	}

	internal void ModQPhiN()
	{
	}

	internal static ushort Mod(double a, double b)
	{
		return 0;
	}

	public abstract byte[] SqToBytes(int len);

	public abstract void SqFromBytes(byte[] a);

	public byte[] RqSumZeroToBytes(int len)
	{
		return null;
	}

	public void RqSumZeroFromBytes(byte[] a)
	{
	}

	public byte[] S3ToBytes(int messageSize)
	{
		return null;
	}

	public void S3FromBytes(byte[] msg)
	{
	}

	public void RqMul(Polynomial a, Polynomial b)
	{
	}

	public void SqMul(Polynomial a, Polynomial b)
	{
	}

	public void S3Mul(Polynomial a, Polynomial b)
	{
	}

	public abstract void Lift(Polynomial a);

	public void RqToS3(Polynomial a)
	{
	}

	public abstract void R2Inv(Polynomial a);

	internal void R2Inv(Polynomial a, Polynomial f, Polynomial g, Polynomial v, Polynomial w)
	{
	}

	public abstract void RqInv(Polynomial a);

	internal void RqInv(Polynomial a, Polynomial ai2, Polynomial b, Polynomial c, Polynomial s)
	{
	}

	private void R2InvToRqInv(Polynomial ai, Polynomial a, Polynomial b, Polynomial c, Polynomial s)
	{
	}

	public abstract void S3Inv(Polynomial a);

	internal void S3Inv(Polynomial a, Polynomial f, Polynomial g, Polynomial v, Polynomial w)
	{
	}

	public void Z3ToZq()
	{
	}

	public void TrinaryZqToZ3()
	{
	}
}
