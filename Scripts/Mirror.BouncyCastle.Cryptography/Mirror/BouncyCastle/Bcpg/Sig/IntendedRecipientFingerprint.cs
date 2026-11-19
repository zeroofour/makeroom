namespace Mirror.BouncyCastle.Bcpg.Sig;

public class IntendedRecipientFingerprint : SignatureSubpacket
{
	public int KeyVersion => 0;

	public IntendedRecipientFingerprint(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public IntendedRecipientFingerprint(bool critical, int keyVersion, byte[] fingerprint)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public byte[] GetFingerprint()
	{
		return null;
	}
}
