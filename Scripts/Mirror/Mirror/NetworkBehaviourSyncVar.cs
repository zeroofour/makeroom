using System;

namespace Mirror;

public struct NetworkBehaviourSyncVar(uint netId, int componentIndex) : IEquatable<NetworkBehaviourSyncVar>
{
	public uint netId = 0u;

	public byte componentIndex = 0;

	public bool Equals(NetworkBehaviourSyncVar other)
	{
		return false;
	}

	public bool Equals(uint netId, int componentIndex)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
