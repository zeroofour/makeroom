using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class KeyShareEntry
{
	private readonly int m_namedGroup;

	private readonly byte[] m_keyExchange;

	public int NamedGroup => 0;

	public byte[] KeyExchange => null;

	private static bool CheckKeyExchangeLength(int length)
	{
		return false;
	}

	public KeyShareEntry(int namedGroup, byte[] keyExchange)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static KeyShareEntry Parse(Stream input)
	{
		return null;
	}
}
