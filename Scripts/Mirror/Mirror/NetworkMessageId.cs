namespace Mirror;

public static class NetworkMessageId<T> where T : struct, NetworkMessage
{
	public static readonly ushort Id;

	private static ushort CalculateId()
	{
		return 0;
	}
}
