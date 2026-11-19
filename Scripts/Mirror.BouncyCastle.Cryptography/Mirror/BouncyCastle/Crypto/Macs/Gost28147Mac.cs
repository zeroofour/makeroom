namespace Mirror.BouncyCastle.Crypto.Macs;

public class Gost28147Mac : IMac
{
	private const int BlockSize = 8;

	private const int MacSize = 4;

	private int bufOff;

	private byte[] buf;

	private byte[] mac;

	private bool firstStep;

	private int[] workingKey;

	private byte[] macIV;

	private byte[] S;

	public string AlgorithmName => null;

	private static int[] GenerateWorkingKey(byte[] userKey)
	{
		return null;
	}

	public void Init(ICipherParameters parameters)
	{
	}

	public int GetMacSize()
	{
		return 0;
	}

	private int Gost28147_mainStep(int n1, int key)
	{
		return 0;
	}

	private void Gost28147MacFunc(int[] workingKey, byte[] input, int inOff, byte[] output, int outOff)
	{
	}

	public void Update(byte input)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
	}

	public int DoFinal(byte[] output, int outOff)
	{
		return 0;
	}

	public void Reset()
	{
	}

	private static void Cm5Func(byte[] buf, int bufOff, byte[] mac, byte[] sum)
	{
	}
}
