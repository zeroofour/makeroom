namespace Mirror.BouncyCastle.Bcpg.Sig;

public class SignerUserId : SignatureSubpacket
{
	public SignerUserId(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public SignerUserId(bool critical, string userId)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public string GetId()
	{
		return null;
	}

	public byte[] GetRawId()
	{
		return null;
	}
}
