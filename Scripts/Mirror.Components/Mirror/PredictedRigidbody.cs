using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public class PredictedRigidbody : NetworkBehaviour
{
	private Transform tf;

	public Rigidbody predictedRigidbody;

	private Transform predictedRigidbodyTransform;

	private Vector3 lastPosition;

	[Tooltip("Prediction supports two different modes: Smooth and Fast:\n\nSmooth: Physics are separated from the GameObject & applied in the background. Rendering smoothly follows the physics for perfectly smooth interpolation results. Much softer, can be even too soft where sharp collisions won't look as sharp (i.e. Billiard balls avoid the wall before even hitting it).\n\nFast: Physics remain on the GameObject and corrections are applied hard. Much faster since we don't need to update a separate GameObject, a bit harsher, more precise.")]
	[Header("Motion Smoothing")]
	public PredictionMode mode;

	[Tooltip("Smoothing via Ghost-following only happens on demand, while moving with a minimum velocity.")]
	public float motionSmoothingVelocityThreshold;

	private float motionSmoothingVelocityThresholdSqr;

	public float motionSmoothingAngularVelocityThreshold;

	private float motionSmoothingAngularVelocityThresholdSqr;

	public float motionSmoothingTimeTolerance;

	private double motionSmoothingLastMovedTime;

	[Header("State History")]
	public int stateHistoryLimit;

	private readonly SortedList<double, RigidbodyState> stateHistory;

	public float recordInterval;

	[Tooltip("(Optional) performance optimization where FixedUpdate.RecordState() only inserts state into history if the state actually changed.\nThis is generally a good idea.")]
	public bool onlyRecordChanges;

	[Tooltip("(Optional) performance optimization where received state is compared to the LAST recorded state first, before sampling the whole history.\n\nThis can save significant traversal overhead for idle objects with a tiny chance of missing corrections for objects which revisisted the same position in the recent history twice.")]
	public bool compareLastFirst;

	[Header("Reconciliation")]
	[Tooltip("Correction threshold in meters. For example, 0.1 means that if the client is off by more than 10cm, it gets corrected.")]
	public double positionCorrectionThreshold;

	private double positionCorrectionThresholdSqr;

	[Tooltip("Correction threshold in degrees. For example, 5 means that if the client is off by more than 5 degrees, it gets corrected.")]
	public double rotationCorrectionThreshold;

	[Tooltip("Applying server corrections one frame ahead gives much better results. We don't know why yet, so this is an option for now.")]
	public bool oneFrameAhead;

	[Header("Smoothing")]
	[Tooltip("Snap to the server state directly when velocity is < threshold. This is useful to reduce jitter/fighting effects before coming to rest.\nNote this applies position, rotation and velocity(!) so it's still smooth.")]
	public float snapThreshold;

	[Tooltip("After creating the visual interpolation object, keep showing the original Rigidbody with a ghost (transparent) material for debugging.")]
	[Header("Visual Interpolation")]
	public bool showGhost;

	[Tooltip("Physics components are moved onto a ghost object beyond this threshold. Main object visually interpolates to it.")]
	public float ghostVelocityThreshold;

	[Tooltip("After creating the visual interpolation object, replace this object's renderer materials with the ghost (ideally transparent) material.")]
	public Material localGhostMaterial;

	public Material remoteGhostMaterial;

	[Tooltip("Performance optimization: only create/destroy ghosts every n-th frame is enough.")]
	public int checkGhostsEveryNthFrame;

	[Tooltip("How fast to interpolate to the target position, relative to how far we are away from it.\nHigher value will be more jitter but sharper moves, lower value will be less jitter but a little too smooth / rounded moves.")]
	public float positionInterpolationSpeed;

	public float rotationInterpolationSpeed;

	[Tooltip("Teleport if we are further than 'multiplier x collider size' behind.")]
	public float teleportDistanceMultiplier;

	[Header("Bandwidth")]
	[Tooltip("Reduce sends while velocity==0. Client's objects may slightly move due to gravity/physics, so we still want to send corrections occasionally even if an object is idle on the server the whole time.")]
	public bool reduceSendsWhileIdle;

	protected GameObject physicsCopy;

	private float smoothFollowThreshold;

	private float smoothFollowThresholdSqr;

	protected GameObject remoteCopy;

	private Vector3 initialPosition;

	private Quaternion initialRotation;

	private Color originalColor;

	private bool lastMoving;

	private RigidbodyState lastRecorded;

	private double lastRecordTime;

	protected virtual void Awake()
	{
	}

	protected virtual void CopyRenderersAsGhost(GameObject destination, Material material)
	{
	}

	protected virtual void CreateGhosts()
	{
	}

	protected virtual void DestroyGhosts()
	{
	}

	protected virtual void SmoothFollowPhysicsCopy()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static Vector3 MoveTowardsCustom(Vector3 current, Vector3 target, Vector3 _delta, float _sqrDistance, float _distance, float maxDistanceDelta)
	{
		return default;
	}

	public override void OnStopClient()
	{
	}

	private void UpdateServer()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected virtual bool IsMoving()
	{
		return false;
	}

	private void UpdateGhosting()
	{
	}

	private void UpdateState()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RecordState()
	{
	}

	protected virtual void OnSnappedIntoPlace()
	{
	}

	protected virtual void OnBeforeApplyState()
	{
	}

	protected virtual void OnCorrected()
	{
	}

	protected virtual void OnBeginPrediction()
	{
	}

	protected virtual void OnEndPrediction()
	{
	}

	private void ApplyState(double timestamp, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
	{
	}

	private void OnReceivedState(double timestamp, RigidbodyState state)
	{
	}

	public override void OnSerialize(NetworkWriter writer, bool initialState)
	{
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	protected override void OnValidate()
	{
	}

	public static bool IsPredicted(Rigidbody rb, out PredictedRigidbody predictedRigidbody)
	{
		predictedRigidbody = null;
		return false;
	}

	public static bool IsPredicted(Collider co, out PredictedRigidbody predictedRigidbody)
	{
		predictedRigidbody = null;
		return false;
	}

	public override bool Weaved()
	{
		return false;
	}
}
