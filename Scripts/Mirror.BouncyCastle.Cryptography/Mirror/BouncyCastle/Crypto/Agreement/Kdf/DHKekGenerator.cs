using Mirror.BouncyCastle.Asn1;

namespace Mirror.BouncyCastle.Crypto.Agreement.Kdf;

public sealed class DHKekGenerator : IDerivationFunction
{
	private readonly IDigest m_digest;

	private DerObjectIdentifier algorithm;

	private int keySize;

	private byte[] z;

	private byte[] partyAInfo;

	public IDigest Digest => null;

	public DHKekGenerator(IDigest digest)
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
