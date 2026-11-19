using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ServerName
{
	private readonly short nameType;

	private readonly byte[] nameData;

	public byte[] NameData => null;

	public short NameType => 0;

	public ServerName(short nameType, byte[] nameData)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static ServerName Parse(Stream input)
	{
		return null;
	}
}
