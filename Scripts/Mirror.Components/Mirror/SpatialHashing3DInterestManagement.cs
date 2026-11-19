using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Spatial Hashing Interest Management")]
public class SpatialHashing3DInterestManagement : InterestManagement
{
	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange;

	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval;

	private double lastRebuildTime;

	[Header("Debug Settings")]
	public bool showSlider;

	private Grid3D<NetworkConnectionToClient> grid;

	public int resolution => 0;

	private Vector3Int ProjectToGrid(Vector3 position)
	{
		return default;
	}

	public override bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver)
	{
		return false;
	}

	public override void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers)
	{
	}

	[ServerCallback]
	public override void ResetState()
	{
	}

	[ServerCallback]
	internal void Update()
	{
	}
}
