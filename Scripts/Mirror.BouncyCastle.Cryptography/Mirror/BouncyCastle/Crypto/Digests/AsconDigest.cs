using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class AsconDigest : IDigest
{
	public enum AsconParameters
	{
		AsconHash = 0,
		AsconHashA = 1
	}

	private readonly AsconParameters m_asconParameters;

	private readonly int ASCON_PB_ROUNDS;

	private ulong x0;

	private ulong x1;

	private ulong x2;

	private ulong x3;

	private ulong x4;

	private readonly byte[] m_buf;

	private int m_bufPos;

	public string AlgorithmName => null;

	public AsconDigest(AsconParameters parameters)
	{
	}

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

	private void FinishAbsorbing()
	{
	}

	private void P(int nr)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ROUND(ulong c)
	{
	}
}
