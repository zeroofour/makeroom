using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public class DilithiumSigner : IMessageSigner
{
	private DilithiumPrivateKeyParameters privKey;

	private DilithiumPublicKeyParameters pubKey;

	private SecureRandom random;

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
