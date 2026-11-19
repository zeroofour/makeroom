namespace Mirror.BouncyCastle.Bcpg.Sig;

public class Revocable : SignatureSubpacket
{
	public Revocable(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public Revocable(bool critical, bool isRevocable)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public bool IsRevocable()
	{
		return false;
	}
}
