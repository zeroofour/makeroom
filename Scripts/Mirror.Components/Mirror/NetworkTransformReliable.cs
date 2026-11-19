using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/Network Transform (Reliable)")]
public class NetworkTransformReliable : NetworkTransformBase
{
	private uint sendIntervalCounter;

	private double lastSendIntervalTime;

	private TransformSnapshot? pendingSnapshot;

	[Tooltip("If we only sync on change, then we need to correct old snapshots if more time than sendInterval * multiplier has elapsed.\n\nOtherwise the first move will always start interpolating from the last move sequence's time, which will make it stutter when starting every time.")]
	[Header("Additional Settings")]
	public float onlySyncOnChangeCorrectionMultiplier;

	public bool useFixedUpdate;

	[Header("Rotation")]
	[Tooltip("Sensitivity of changes needed before an updated state is sent over the network")]
	public float rotationSensitivity;

	[Header("Precision")]
	[Tooltip("Position is rounded in order to drastically minimize bandwidth.\n\nFor example, a precision of 0.01 rounds to a centimeter. In other words, sub-centimeter movements aren't synced until they eventually exceeded an actual centimeter.\n\nDepending on how important the object is, a precision of 0.01-0.10 (1-10 cm) is recommended.\n\nFor example, even a 1cm precision combined with delta compression cuts the Benchmark demo's bandwidth in half, compared to sending every tiny change.")]
	[Range(0.0001f, 1f)]
	public float positionPrecision;

	[Range(0.0001f, 1f)]
	public float scalePrecision;

	protected Vector3Long lastSerializedPosition;

	protected Vector3Long lastDeserializedPosition;

	protected Vector3Long lastSerializedScale;

	protected Vector3Long lastDeserializedScale;

	protected TransformSnapshot last;

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void UpdateServer()
	{
	}

	protected virtual void UpdateClient()
	{
	}

	protected virtual void CheckLastSendTime()
	{
	}

	protected virtual bool Changed(TransformSnapshot current)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected bool QuantizedChanged(Vector3 u, Vector3 v, float precision)
	{
		return false;
	}

	public override void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	protected virtual void OnClientToServerSync(Vector3? position, Quaternion? rotation, Vector3? scale)
	{
	}

	protected virtual void OnServerToClientSync(Vector3? position, Quaternion? rotation, Vector3? scale)
	{
	}

	private static bool NeedsCorrection(SortedList<double, TransformSnapshot> snapshots, double remoteTimestamp, double bufferTime, double toleranceMultiplier)
	{
		return false;
	}

	private static void RewriteHistory(SortedList<double, TransformSnapshot> snapshots, double remoteTimeStamp, double localTime, double sendInterval, Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	public override void ResetState()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
