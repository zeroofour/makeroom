using System;

namespace Mirror.RemoteCalls;

internal class Invoker
{
	public Type componentType;

	public RemoteCallType callType;

	public RemoteCallDelegate function;

	public bool cmdRequiresAuthority;

	public bool AreEqual(Type componentType, RemoteCallType remoteCallType, RemoteCallDelegate invokeFunction)
	{
		return false;
	}
}
