using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class HssSigner : IMessageSigner
{
	private HssPrivateKeyParameters privKey;

	private HssPublicKeyParameters pubKey;

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
