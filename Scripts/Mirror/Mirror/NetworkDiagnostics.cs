using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public static class NetworkDiagnostics
{
	public readonly struct MessageInfo
	{
		public readonly NetworkMessage message = null;

		public readonly int channel = 0;

		public readonly int bytes = 0;

		public readonly int count = 0;

		internal MessageInfo(NetworkMessage message, int channel, int bytes, int count)
		{
		}
	}

	[CompilerGenerated]
	private static Action<MessageInfo> m_OutMessageEvent;

	[CompilerGenerated]
	private static Action<MessageInfo> m_InMessageEvent;

	public static event Action<MessageInfo> OutMessageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<MessageInfo> InMessageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void ResetStatics()
	{
	}

	internal static void OnSend<T>(T message, int channel, int bytes, int count) where T : struct, NetworkMessage
	{
	}

	internal static void OnReceive<T>(T message, int channel, int bytes) where T : struct, NetworkMessage
	{
	}
}
