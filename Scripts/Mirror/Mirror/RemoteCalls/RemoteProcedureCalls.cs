using System;
using System.Collections.Generic;

namespace Mirror.RemoteCalls;

public static class RemoteProcedureCalls
{
	public const string InvokeRpcPrefix = "InvokeUserCode_";

	private static readonly Dictionary<ushort, Invoker> remoteCallDelegates;

	private static bool CheckIfDelegateExists(Type componentType, RemoteCallType remoteCallType, RemoteCallDelegate func, ushort functionHash)
	{
		return false;
	}

	internal static ushort RegisterDelegate(Type componentType, string functionFullName, RemoteCallType remoteCallType, RemoteCallDelegate func, bool cmdRequiresAuthority = true)
	{
		return 0;
	}

	public static void RegisterCommand(Type componentType, string functionFullName, RemoteCallDelegate func, bool requiresAuthority)
	{
	}

	public static void RegisterRpc(Type componentType, string functionFullName, RemoteCallDelegate func)
	{
	}

	internal static void RemoveDelegate(ushort hash)
	{
	}

	internal static bool GetFunctionMethodName(ushort functionHash, out string methodName)
	{
		methodName = null;
		return false;
	}

	private static bool GetInvokerForHash(ushort functionHash, RemoteCallType remoteCallType, out Invoker invoker)
	{
		invoker = null;
		return false;
	}

	internal static bool Invoke(ushort functionHash, RemoteCallType remoteCallType, NetworkReader reader, NetworkBehaviour component, NetworkConnectionToClient senderConnection = null)
	{
		return false;
	}

	internal static bool CommandRequiresAuthority(ushort cmdHash)
	{
		return false;
	}

	public static RemoteCallDelegate GetDelegate(ushort functionHash)
	{
		return null;
	}
}
