using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsSigner : IMessageSigner
{
	private LmsPrivateKeyParameters m_privateKey;

	private LmsPublicKeyParameters m_publicKey;

	public void Init(bool forSigning, ICipherParameters param)
	{
	}

	public byte[] GenerateSignature(byte[] message)
	{
		return null;
	}

	public bool VerifySignature(byte[] message, byte[] signature)
	{
		return false;
	}
}
