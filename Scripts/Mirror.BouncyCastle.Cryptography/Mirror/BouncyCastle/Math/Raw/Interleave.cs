namespace Mirror.BouncyCastle.Math.Raw;

internal static class Interleave
{
	private const ulong M32 = 1431655765uL;

	private const ulong M64 = 6148914691236517205uL;

	private const ulong M64R = 12297829382473034410uL;

	internal static uint Expand8to16(byte x)
	{
		return 0u;
	}

	internal static uint Expand16to32(ushort x)
	{
		return 0u;
	}

	internal static ulong Expand32to64(uint x)
	{
		return 0uL;
	}

	internal static void Expand64To128(ulong x, ulong[] z, int zOff)
	{
	}

	internal static void Expand64To128(ulong[] xs, int xsOff, int xsLen, ulong[] zs, int zsOff)
	{
	}

	internal static ulong Expand64To128Rev(ulong x, out ulong low)
	{
		low = default;
		return 0uL;
	}

	internal static uint Shuffle(uint x)
	{
		return 0u;
	}

	internal static ulong Shuffle(ulong x)
	{
		return 0uL;
	}

	internal static uint Shuffle2(uint x)
	{
		return 0u;
	}

	internal static ulong Shuffle2(ulong x)
	{
		return 0uL;
	}

	internal static uint Unshuffle(uint x)
	{
		return 0u;
	}

	internal static ulong Unshuffle(ulong x)
	{
		return 0uL;
	}

	internal static ulong Unshuffle(ulong x, out ulong even)
	{
		even = default;
		return 0uL;
	}

	internal static ulong Unshuffle(ulong x0, ulong x1, out ulong even)
	{
		even = default;
		return 0uL;
	}

	internal static uint Unshuffle2(uint x)
	{
		return 0u;
	}

	internal static ulong Unshuffle2(ulong x)
	{
		return 0uL;
	}

	internal static ulong Transpose(ulong x)
	{
		return 0uL;
	}
}
