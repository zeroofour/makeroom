using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Hex Spatial Hash (3D)")]
public class HexSpatialHash3DInterestManagement : InterestManagement
{
	[Range(1f, 60f)]
	[Tooltip("Time interval in seconds between observer rebuilds")]
	public byte rebuildInterval;

	[Range(1f, 60f)]
	[Tooltip("Time interval in seconds between static object rebuilds")]
	public byte staticRebuildInterval;

	[Range(10f, 5000f)]
	[Tooltip("Radius of super hex.\nSet to 10% larger than camera far clip plane.")]
	public ushort visRange;

	[Range(10f, 5000f)]
	[Tooltip("Cell3D height effects all 3 layers")]
	public ushort cellHeight;

	[Tooltip("Distance an object must move for updating cell positions")]
	[Range(1f, 100f)]
	public ushort minMoveDistance;

	private double lastRebuildTime;

	private byte rebuildCounter;

	private HexGrid3D grid;

	private readonly List<HashSet<NetworkIdentity>> cells;

	private readonly Dictionary<NetworkIdentity, (Cell3D cell, Vector3 worldPos)> lastIdentityPositions;

	private readonly Dictionary<NetworkConnectionToClient, (Cell3D cell, Vector3 worldPos)> lastConnectionPositions;

	private readonly Cell3D[] neighborCells;

	private readonly Dictionary<NetworkConnectionToClient, HashSet<NetworkIdentity>> connectionObservers;

	private readonly List<NetworkIdentity> identityKeys;

	private readonly Stack<HashSet<NetworkIdentity>> cellPool;

	private readonly HashSet<NetworkIdentity> staticObjects;

	private const int MAX_Q = 19;

	private const int MAX_R = 23;

	private const int LAYER_OFFSET = 18;

	private const int MAX_LAYERS = 36;

	private const ushort MAX_AREA = 9000;

	private void Awake()
	{
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

	private void AddToCell(Cell3D cell, NetworkIdentity identity)
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

	private int GetCellIndex(Cell3D cell)
	{
		return 0;
	}
}
