using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Spatial Hashing Interest Management")]
public class SpatialHashingInterestManagement : InterestManagement
{
	public enum CheckMethod
	{
		XZ_FOR_3D = 0,
		XY_FOR_2D = 1
	}

	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange;

	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval;

	private double lastRebuildTime;

	[Tooltip("Spatial Hashing supports 3D (XZ) and 2D (XY) games.")]
	public CheckMethod checkMethod;

	[Header("Debug Settings")]
	public bool showSlider;

	private Grid2D<NetworkConnectionToClient> grid;

	public int resolution => 0;

	private Vector2Int ProjectToGrid(Vector3 position)
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
