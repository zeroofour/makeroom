namespace Mirror.BouncyCastle.Bcpg.Sig;

public class SignatureTarget : SignatureSubpacket
{
	public int PublicKeyAlgorithm => 0;

	public int HashAlgorithm => 0;

	public SignatureTarget(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public SignatureTarget(bool critical, int publicKeyAlgorithm, int hashAlgorithm, byte[] hashData)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public byte[] GetHashData()
	{
		return null;
	}
}
