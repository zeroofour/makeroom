using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class PskIdentity
{
	private readonly byte[] m_identity;

	private readonly long m_obfuscatedTicketAge;

	public byte[] Identity => null;

	public long ObfuscatedTicketAge => 0L;

	public PskIdentity(byte[] identity, long obfuscatedTicketAge)
	{
	}

	public int GetEncodedLength()
	{
		return 0;
	}

	public void Encode(Stream output)
	{
	}

	public static PskIdentity Parse(Stream input)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
