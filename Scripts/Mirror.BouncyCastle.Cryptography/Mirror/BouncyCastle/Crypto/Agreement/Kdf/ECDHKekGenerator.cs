using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Agreement.Kdf;

public sealed class ECDHKekGenerator : IDerivationFunction
{
	private readonly IDerivationFunction m_kdf;

	private DerObjectIdentifier algorithm;

	private int keySize;

	private byte[] z;

	public IDigest Digest => null;

	public ECDHKekGenerator(IDigest digest)
	{
	}

	public void Init(IDerivationParameters param)
	{
	}

	public int GenerateBytes(byte[] outBytes, int outOff, int length)
	{
		return 0;
	}
}
