using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

internal static class GcmUtilities
{
	internal struct FieldElement
	{
		internal ulong n0;

		internal ulong n1;
	}

	private const uint E1 = 3774873600u;

	private const ulong E1UL = 16212958658533785600uL;

	internal static void One(out FieldElement x)
	{
		x = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void AsBytes(ulong x0, ulong x1, byte[] z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void AsBytes(ref FieldElement x, byte[] z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void AsFieldElement(byte[] x, out FieldElement z)
	{
		z = default;
	}

	internal static void DivideP(ref FieldElement x, out FieldElement z)
	{
		z = default;
	}

	internal static void Multiply(byte[] x, byte[] y)
	{
	}

	internal static void Multiply(ref FieldElement x, ref FieldElement y)
	{
	}

	internal static void MultiplyP7(ref FieldElement x)
	{
	}

	internal static void MultiplyP8(ref FieldElement x)
	{
	}

	internal static void MultiplyP8(ref FieldElement x, out FieldElement y)
	{
		y = default;
	}

	internal static void MultiplyP16(ref FieldElement x)
	{
	}

	internal static void Square(ref FieldElement x)
	{
	}

	internal static void Xor(byte[] x, byte[] y)
	{
	}

	internal static void Xor(byte[] x, byte[] y, int yOff)
	{
	}

	internal static void Xor(byte[] x, byte[] y, int yOff, int yLen)
	{
	}

	internal static void Xor(byte[] x, int xOff, byte[] y, int yOff, int len)
	{
	}

	internal static void Xor(ref FieldElement x, ref FieldElement y)
	{
	}

	internal static void Xor(ref FieldElement x, ref FieldElement y, out FieldElement z)
	{
		z = default;
	}

	private static ulong ImplMul64(ulong x, ulong y)
	{
		return 0uL;
	}
}
