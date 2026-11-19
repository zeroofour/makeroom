using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mirror;

public static class NetworkMessages
{
	public const int IdSize = 2;

	public static readonly Dictionary<ushort, Type> Lookup;

	public static void LogTypes()
	{
	}

	public static int MaxContentSize(int channelId)
	{
		return 0;
	}

	public static int MaxMessageSize(int channelId)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort GetId<T>() where T : struct, NetworkMessage
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Pack<T>(T message, NetworkWriter writer) where T : struct, NetworkMessage
	{
	}

	public static bool UnpackId(NetworkReader reader, out ushort messageId)
	{
		messageId = default;
		return false;
	}

	internal static NetworkMessageDelegate WrapHandler<T, C>(Action<C, T, int> handler, bool requireAuthentication, bool exceptionsDisconnect) where T : struct, NetworkMessage where C : NetworkConnection
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static NetworkMessageDelegate WrapHandler<T, C>(Action<C, T> handler, bool requireAuthentication, bool exceptionsDisconnect) where T : struct, NetworkMessage where C : NetworkConnection
	{
		return null;
	}
}
