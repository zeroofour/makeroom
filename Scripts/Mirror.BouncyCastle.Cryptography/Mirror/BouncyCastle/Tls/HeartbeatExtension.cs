using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class HeartbeatExtension
{
	private readonly short m_mode;

	public short Mode => 0;

	public HeartbeatExtension(short mode)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static HeartbeatExtension Parse(Stream input)
	{
		return null;
	}
}
