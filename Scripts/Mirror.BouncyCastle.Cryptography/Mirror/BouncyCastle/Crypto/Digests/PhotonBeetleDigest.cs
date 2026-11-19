using System.IO;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class PhotonBeetleDigest : IDigest
{
	private byte[] state;

	private byte[][] state_2d;

	private MemoryStream buffer;

	private const int INITIAL_RATE_INBYTES = 16;

	private int RATE_INBYTES;

	private int SQUEEZE_RATE_INBYTES;

	private int STATE_INBYTES;

	private int TAG_INBYTES;

	private int LAST_THREE_BITS_OFFSET;

	private int ROUND;

	private int D;

	private int Dq;

	private int Dr;

	private int DSquare;

	private int S;

	private int S_1;

	private byte[][] RC;

	private byte[][] MixColMatrix;

	private byte[] sbox;

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

	private void PHOTON_Permutation()
	{
	}
}
