using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Hex Spatial Hash (2D)")]
public class HexSpatialHash2DInterestManagement : InterestManagement
{
	public enum CheckMethod
	{
		XZ_FOR_3D = 0,
		XY_FOR_2D = 1
	}

	[Tooltip("Time interval in seconds between observer rebuilds")]
	[Range(1f, 60f)]
	public byte rebuildInterval;

	[Tooltip("Time interval in seconds between static object rebuilds")]
	[Range(1f, 60f)]
	public byte staticRebuildInterval;

	[Range(10f, 5000f)]
	[Tooltip("Radius of super hex.\nSet to 10% larger than camera far clip plane.")]
	public ushort visRange;

	[Tooltip("Distance an object must move for updating cell positions")]
	[Range(1f, 100f)]
	public ushort minMoveDistance;

	[Tooltip("Spatial Hashing supports XZ for 3D games or XY for 2D games.")]
	public CheckMethod checkMethod;

	private double lastRebuildTime;

	private byte rebuildCounter;

	private HexGrid2D grid;

	private readonly List<HashSet<NetworkIdentity>> cells;

	private readonly Dictionary<NetworkIdentity, (Cell2D cell, Vector2 worldPos)> lastIdentityPositions;

	private readonly Dictionary<NetworkConnectionToClient, (Cell2D cell, Vector2 worldPos)> lastConnectionPositions;

	private readonly Cell2D[] neighborCells;

	private readonly Dictionary<NetworkConnectionToClient, HashSet<NetworkIdentity>> connectionObservers;

	private readonly List<NetworkIdentity> identityKeys;

	private readonly Stack<HashSet<NetworkIdentity>> cellPool;

	private readonly HashSet<NetworkIdentity> staticObjects;

	private const int MAX_Q = 19;

	private const int MAX_R = 23;

	private const ushort MAX_AREA = 9000;

	private void Awake()
	{
	}

	private Vector2 ProjectToGrid(Vector3 position)
	{
		return default;
	}

	private void LateUpdate()
	{
	}

	public override void OnSpawned(NetworkIdentity identity)
	{
	}

	private void UpdateIdentityPosition(NetworkIdentity identity)
	{
	}

	private void AddToCell(Cell2D cell, NetworkIdentity identity)
	{
	}

	public override bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver)
	{
		return false;
	}

	public override void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers)
	{
	}

	public override void ResetState()
	{
	}

	public override void OnDestroyed(NetworkIdentity identity)
	{
	}

	private int GetCellIndex(Cell2D cell)
	{
		return 0;
	}
}
