using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Match/Match Interest Management")]
public class MatchInterestManagement : InterestManagement
{
	[SerializeField]
	[ReadOnly]
	[Header("Diagnostics")]
	internal ushort matchCount;

	private readonly Dictionary<Guid, HashSet<NetworkMatch>> matchObjects;

	private readonly HashSet<Guid> dirtyMatches;

	[ServerCallback]
	private void LateUpdate()
	{
	}

	[ServerCallback]
	private void RebuildMatchObservers(Guid matchId)
	{
	}

	[ServerCallback]
	internal void OnMatchChanged(NetworkMatch networkMatch, Guid oldMatch)
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

	[ServerCallback]
	public override bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver)
	{
		return false;
	}

	[ServerCallback]
	public override void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers)
	{
	}
}
