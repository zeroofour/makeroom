using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Scene/Scene Distance Interest Management")]
public class SceneDistanceInterestManagement : InterestManagement
{
	[Tooltip("The maximum range that objects will be visible at. Add DistanceInterestManagementCustomRange onto NetworkIdentities for custom ranges.")]
	public int visRange;

	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval;

	private double lastRebuildTime;

	private readonly Dictionary<NetworkIdentity, DistanceInterestManagementCustomRange> CustomRanges;

	private readonly Dictionary<Scene, HashSet<NetworkIdentity>> sceneObjects;

	private readonly Dictionary<NetworkIdentity, Scene> lastObjectScene;

	private HashSet<Scene> dirtyScenes;

	[ServerCallback]
	private int GetVisRange(NetworkIdentity identity)
	{
		return 0;
	}

	[ServerCallback]
	public override void ResetState()
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
	private void LateUpdate()
	{
	}

	private void RebuildSceneObservers(Scene scene)
	{
	}

	public override bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver)
	{
		return false;
	}

	public override void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers)
	{
	}
}
