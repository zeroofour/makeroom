using Mirror.BouncyCastle.Crypto.Digests;

namespace Mirror.BouncyCastle.Crypto.Macs;

public class KMac : IMac, IXof, IDigest
{
	private static readonly byte[] padding;

	private readonly CShakeDigest cshake;

	private readonly int bitLength;

	private readonly int outputLength;

	private byte[] key;

	private bool initialised;

	private bool firstOutput;

	public string AlgorithmName => null;

	public KMac(int bitLength, byte[] S)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
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

	public int GetByteLength()
	{
		return 0;
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public int GetMacSize()
	{
		return 0;
	}

	public void Init(ICipherParameters parameters)
	{
	}

	public void Reset()
	{
	}

	private void bytePad(byte[] X, int w)
	{
	}

	private static byte[] encode(byte[] X)
	{
		return null;
	}

	public void Update(byte input)
	{
	}
}
