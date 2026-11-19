using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Scene/Scene Interest Management")]
public class SceneInterestManagement : InterestManagement
{
	private readonly Dictionary<Scene, HashSet<NetworkIdentity>> sceneObjects;

	private readonly Dictionary<NetworkIdentity, Scene> lastObjectScene;

	private HashSet<Scene> dirtyScenes;

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
