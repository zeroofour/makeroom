using Mirror.BouncyCastle.Crypto.Macs;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Generators;

public sealed class HkdfBytesGenerator : IDerivationFunction
{
	private HMac hMacHash;

	private int hashLen;

	private byte[] info;

	private byte[] currentT;

	private int generatedBytes;

	public IDigest Digest => null;

	public HkdfBytesGenerator(IDigest hash)
	{
	}

	public void Init(IDerivationParameters parameters)
	{
	}

	private KeyParameter Extract(byte[] salt, byte[] ikm)
	{
		return null;
	}

	private void ExpandNext()
	{
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		return 0;
	}
}
