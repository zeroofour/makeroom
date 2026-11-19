using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public sealed class PicnicSigner : IMessageSigner
{
	private PicnicPrivateKeyParameters privKey;

	private PicnicPublicKeyParameters pubKey;

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
