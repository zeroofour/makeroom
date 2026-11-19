using System.IO;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class XoodyakDigest : IDigest
{
	private enum MODE
	{
		ModeHash = 0,
		ModeKeyed = 1
	}

	private const int Rkin = 44;

	private static readonly uint[] RC;

	private byte[] state;

	private int phase;

	private MODE mode;

	private int Rabsorb;

	private const int f_bPrime = 48;

	private const int Rkout = 24;

	private const int PhaseDown = 1;

	private const int PhaseUp = 2;

	private const int NLANES = 12;

	private const int NROWS = 3;

	private const int NCOLUMNS = 4;

	private const int MAXROUNDS = 12;

	private const int TAGLEN = 16;

	private const int Rhash = 16;

	private readonly MemoryStream buffer;

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

	private void Up(byte[] Yi, int YiOff, int YiLen, uint Cu)
	{
	}

	private void Down(byte[] Xi, int XiOff, int XiLen, uint Cd)
	{
	}

	private uint index(uint x, uint y)
	{
		return 0u;
	}
}
