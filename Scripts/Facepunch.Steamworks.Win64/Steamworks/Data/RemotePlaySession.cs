namespace Steamworks.Data;

public struct RemotePlaySession
{
	public uint Id { get; set; }

	public bool IsValid => false;

	public SteamId SteamId => default;

	public string ClientName => null;

	public SteamDeviceFormFactor FormFactor => SteamDeviceFormFactor.Unknown;

	public override string ToString()
	{
		return null;
	}

	public static implicit operator RemotePlaySession(uint value)
	{
		return default;
	}

	public static implicit operator uint(RemotePlaySession value)
	{
		return 0u;
	}
}
