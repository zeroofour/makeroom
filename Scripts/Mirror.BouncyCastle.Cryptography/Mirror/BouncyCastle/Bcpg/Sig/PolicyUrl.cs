namespace Mirror.BouncyCastle.Bcpg.Sig;

public class PolicyUrl : SignatureSubpacket
{
	public string Url => null;

	public PolicyUrl(bool critical, string url)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public PolicyUrl(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public byte[] GetRawUrl()
	{
		return null;
	}
}
