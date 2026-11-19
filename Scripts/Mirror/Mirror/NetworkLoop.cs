using System;
using UnityEngine;
using UnityEngine.LowLevel;

namespace Mirror;

public static class NetworkLoop
{
	internal enum AddMode
	{
		Beginning = 0,
		End = 1
	}

	public static Action OnEarlyUpdate;

	public static Action OnLateUpdate;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void ResetStatics()
	{
	}

	internal static int FindPlayerLoopEntryIndex(PlayerLoopSystem.UpdateFunction function, PlayerLoopSystem playerLoop, Type playerLoopSystemType)
	{
		return 0;
	}

	internal static bool AddToPlayerLoop(PlayerLoopSystem.UpdateFunction function, Type ownerType, ref PlayerLoopSystem playerLoop, Type playerLoopSystemType, AddMode addMode)
	{
		return false;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void RuntimeInitializeOnLoad()
	{
	}

	private static void NetworkEarlyUpdate()
	{
	}

	private static void NetworkLateUpdate()
	{
	}
}
