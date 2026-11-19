using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class HeartbeatMessage
{
	private readonly short m_type;

	private readonly byte[] m_payload;

	private readonly byte[] m_padding;

	public int PaddingLength => 0;

	public byte[] Payload => null;

	public short Type => 0;

	public static HeartbeatMessage Create(TlsContext context, short type, byte[] payload)
	{
		return null;
	}

	public static HeartbeatMessage Create(TlsContext context, short type, byte[] payload, int paddingLength)
	{
		return null;
	}

	public HeartbeatMessage(short type, byte[] payload, byte[] padding)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static HeartbeatMessage Parse(Stream input)
	{
		return null;
	}

	private static byte[] GetPayload(byte[] payloadBuffer, int payloadLength)
	{
		return null;
	}

	private static byte[] GetPadding(byte[] payloadBuffer, int payloadLength)
	{
		return null;
	}
}
