using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Distance/Distance Interest Management")]
public class DistanceInterestManagement : InterestManagement
{
	[Tooltip("The maximum range that objects will be visible at. Add DistanceInterestManagementCustomRange onto NetworkIdentities for custom ranges.")]
	public int visRange;

	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval;

	private double lastRebuildTime;

	private readonly Dictionary<NetworkIdentity, DistanceInterestManagementCustomRange> CustomRanges;

	[ServerCallback]
	private int GetVisRange(NetworkIdentity identity)
	{
		return 0;
	}

	[ServerCallback]
	public override void ResetState()
	{
	}

	public override void OnSpawned(NetworkIdentity identity)
	{
	}

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

	[ServerCallback]
	private void LateUpdate()
	{
	}
}
