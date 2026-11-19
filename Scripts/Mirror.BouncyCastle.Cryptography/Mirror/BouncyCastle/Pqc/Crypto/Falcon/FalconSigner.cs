using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public class FalconSigner : IMessageSigner
{
	private byte[] encodedkey;

	private FalconNist nist;

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
