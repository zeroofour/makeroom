using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Team/Team Interest Management")]
public class TeamInterestManagement : InterestManagement
{
	private readonly Dictionary<string, HashSet<NetworkTeam>> teamObjects;

	private readonly HashSet<string> dirtyTeams;

	[ServerCallback]
	private void LateUpdate()
	{
	}

	[ServerCallback]
	private void RebuildTeamObservers(string teamId)
	{
	}

	[ServerCallback]
	internal void OnTeamChanged(NetworkTeam networkTeam, string oldTeam)
	{
	}

	[ServerCallback]
	public override void OnSpawned(NetworkIdentity identity)
	{
	}

	[ServerCallback]
	public override void OnDestroyed(NetworkIdentity identity)
	{
	}

	public override bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver)
	{
		return false;
	}

	public override void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers)
	{
	}

	private void AddAllConnections(HashSet<NetworkConnectionToClient> newObservers)
	{
	}
}
