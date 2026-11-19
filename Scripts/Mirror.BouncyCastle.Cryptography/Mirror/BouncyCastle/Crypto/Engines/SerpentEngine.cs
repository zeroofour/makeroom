namespace Mirror.BouncyCastle.Crypto.Engines;

public sealed class SerpentEngine : SerpentEngineBase
{
	internal override int[] MakeWorkingKey(byte[] key)
	{
		return null;
	}

	internal override void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
	}

	internal override void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
	}
}
