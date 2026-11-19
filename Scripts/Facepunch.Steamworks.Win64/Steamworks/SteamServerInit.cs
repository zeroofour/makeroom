using System.Net;

namespace Steamworks;

public struct SteamServerInit(string modDir, string gameDesc)
{
	public IPAddress IpAddress = null;

	public ushort GamePort = 0;

	public ushort QueryPort = 0;

	public bool Secure = false;

	public string VersionString = null;

	public string ModDir = null;

	public string GameDescription = null;

	public bool DedicatedServer = false;

	public SteamServerInit WithQueryShareGamePort()
	{
		return default;
	}
}
