using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class AsconXof : IXof, IDigest
{
	public enum AsconParameters
	{
		AsconXof = 0,
		AsconXofA = 1
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

	private bool m_squeezing;

	public string AlgorithmName => null;

	public AsconXof(AsconParameters parameters)
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

	public int OutputFinal(byte[] output, int outOff, int outLen)
	{
		return 0;
	}

	public int Output(byte[] output, int outOff, int outLen)
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
