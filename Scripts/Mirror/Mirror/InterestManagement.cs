using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
public abstract class InterestManagement : InterestManagementBase
{
	private readonly HashSet<NetworkConnectionToClient> newObservers;

	public abstract void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers);

	[ServerCallback]
	protected void RebuildAll()
	{
	}

	public override void Rebuild(NetworkIdentity identity, bool initialize)
	{
	}
}
