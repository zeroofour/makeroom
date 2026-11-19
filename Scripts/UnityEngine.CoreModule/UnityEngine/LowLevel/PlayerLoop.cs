using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop
{
	public static PlayerLoopSystem GetCurrentPlayerLoop()
	{
		return default;
	}

	public static void SetPlayerLoop(PlayerLoopSystem loop)
	{
	}

	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
	{
		return 0;
	}

	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset)
	{
		return default;
	}

	[NativeMethod(IsFreeFunction = true)]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal()
	{
		return null;
	}

	[NativeMethod(IsFreeFunction = true)]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop)
	{
	}
}
