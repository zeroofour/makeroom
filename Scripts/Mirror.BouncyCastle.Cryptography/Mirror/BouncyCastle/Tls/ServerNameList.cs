using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ServerNameList
{
	private readonly IList<ServerName> m_serverNameList;

	public IList<ServerName> ServerNames => null;

	public ServerNameList(IList<ServerName> serverNameList)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static ServerNameList Parse(Stream input)
	{
		return null;
	}

	private static short[] CheckNameType(short[] nameTypesSeen, short nameType)
	{
		return null;
	}
}
