namespace Mirror.BouncyCastle.Bcpg.Sig;

public class IssuerFingerprint : SignatureSubpacket
{
	public int KeyVersion => 0;

	public IssuerFingerprint(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public IssuerFingerprint(bool critical, int keyVersion, byte[] fingerprint)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public byte[] GetFingerprint()
	{
		return null;
	}
}
