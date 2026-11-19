using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

internal sealed class EdDsaSigner : ISigner
{
	private readonly ISigner m_signer;

	private readonly IDigest m_digest;

	public string AlgorithmName => null;

	internal EdDsaSigner(ISigner signer, IDigest digest)
	{
	}

	public void Init(bool forSigning, ICipherParameters cipherParameters)
	{
	}

	public void Update(byte b)
	{
	}

	public void BlockUpdate(byte[] input, int inOff, int inLen)
	{
	}

	public int GetMaxSignatureSize()
	{
		return 0;
	}

	public byte[] GenerateSignature()
	{
		return null;
	}

	public bool VerifySignature(byte[] signature)
	{
		return false;
	}

	public void Reset()
	{
	}

	private void FinalizeDigest()
	{
	}
}
