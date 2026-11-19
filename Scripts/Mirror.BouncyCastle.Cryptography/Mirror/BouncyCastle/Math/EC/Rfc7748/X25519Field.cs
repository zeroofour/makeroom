using System;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Math.EC.Rfc7748;

public static class X25519Field
{
	public const int Size = 10;

	private const int M24 = 16777215;

	private const int M25 = 33554431;

	private const int M26 = 67108863;

	private static readonly uint[] P32;

	private static readonly int[] RootNegOne;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add(int[] x, int[] y, int[] z)
	{
	}

	public static void AddOne(int[] z)
	{
	}

	public static void AddOne(int[] z, int zOff)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Apm(int[] x, int[] y, int[] zp, int[] zm)
	{
	}

	public static int AreEqual(int[] x, int[] y)
	{
		return 0;
	}

	public static bool AreEqualVar(int[] x, int[] y)
	{
		return false;
	}

	public static void Carry(int[] z)
	{
	}

	public static void CMov(int cond, int[] x, int xOff, int[] z, int zOff)
	{
	}

	public static void CNegate(int negate, int[] z)
	{
	}

	public static void Copy(int[] x, int xOff, int[] z, int zOff)
	{
	}

	public static int[] Create()
	{
		return null;
	}

	public static int[] CreateTable(int n)
	{
		return null;
	}

	public static void CSwap(int swap, int[] a, int[] b)
	{
	}

	[CLSCompliant(false)]
	public static void Decode(uint[] x, int xOff, int[] z)
	{
	}

	public static void Decode(byte[] x, int[] z)
	{
	}

	public static void Decode(byte[] x, int xOff, int[] z)
	{
	}

	public static void Decode(byte[] x, int xOff, int[] z, int zOff)
	{
	}

	private static void Decode128(uint[] x, int xOff, int[] z, int zOff)
	{
	}

	private static void Decode128(byte[] bs, int off, int[] z, int zOff)
	{
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static void Encode(int[] x, uint[] z, int zOff)
	{
	}

	public static void Encode(int[] x, byte[] z)
	{
	}

	public static void Encode(int[] x, byte[] z, int zOff)
	{
	}

	public static void Encode(int[] x, int xOff, byte[] z, int zOff)
	{
	}

	private static void Encode128(int[] x, int xOff, uint[] z, int zOff)
	{
	}

	private static void Encode128(int[] x, int xOff, byte[] bs, int off)
	{
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
	}

	public static void Inv(int[] x, int[] z)
	{
	}

	public static void InvVar(int[] x, int[] z)
	{
	}

	public static int IsOne(int[] x)
	{
		return 0;
	}

	public static bool IsOneVar(int[] x)
	{
		return false;
	}

	public static int IsZero(int[] x)
	{
		return 0;
	}

	public static bool IsZeroVar(int[] x)
	{
		return false;
	}

	public static void Mul(int[] x, int y, int[] z)
	{
	}

	public static void Mul(int[] x, int[] y, int[] z)
	{
	}

	public static void Negate(int[] x, int[] z)
	{
	}

	public static void Normalize(int[] z)
	{
	}

	public static void One(int[] z)
	{
	}

	private static void PowPm5d8(int[] x, int[] rx2, int[] rz)
	{
	}

	private static void Reduce(int[] z, int x)
	{
	}

	public static void Sqr(int[] x, int[] z)
	{
	}

	public static void Sqr(int[] x, int n, int[] z)
	{
	}

	public static bool SqrtRatioVar(int[] u, int[] v, int[] z)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Sub(int[] x, int[] y, int[] z)
	{
	}

	public static void SubOne(int[] z)
	{
	}

	public static void Zero(int[] z)
	{
	}
}
