using System.IO;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class IsapDigest : IDigest
{
	private readonly MemoryStream buffer;

	private ulong x0;

	private ulong x1;

	private ulong x2;

	private ulong x3;

	private ulong x4;

	public string AlgorithmName => null;

	public int GetDigestSize()
	{
		return 0;
	}

	public int GetByteLength()
	{
		return 0;
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int inLen)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private void P12()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ROUND(ulong C)
	{
	}
}
