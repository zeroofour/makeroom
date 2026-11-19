namespace Mirror.BouncyCastle.Bcpg.Sig;

public class RegularExpression : SignatureSubpacket
{
	public string Regex => null;

	public RegularExpression(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public RegularExpression(bool critical, string regex)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public byte[] GetRawRegex()
	{
		return null;
	}

	private static byte[] ToNullTerminatedUtf8ByteArray(string str)
	{
		return null;
	}
}
