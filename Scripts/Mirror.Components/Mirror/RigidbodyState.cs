using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public struct RigidbodyState : PredictedState
{
	public double timestamp
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private set;
	} = 0.0;

	public Vector3 positionDelta
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Vector3 position
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Quaternion rotationDelta
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Quaternion rotation
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Vector3 velocityDelta
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Vector3 velocity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Vector3 angularVelocityDelta
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public Vector3 angularVelocity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	} = default;

	public RigidbodyState(double timestamp, Vector3 positionDelta, Vector3 position, Quaternion rotationDelta, Quaternion rotation, Vector3 velocityDelta, Vector3 velocity, Vector3 angularVelocityDelta, Vector3 angularVelocity)
	{
	}

	public static RigidbodyState Interpolate(RigidbodyState a, RigidbodyState b, float t)
	{
		return default;
	}
}
