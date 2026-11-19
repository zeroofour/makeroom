using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public struct MinMaxBounds : IEquatable<Bounds>
{
	public Vector3 min;

	public Vector3 max;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Encapsulate(Vector3 point)
	{
	}

	public void Encapsulate(MinMaxBounds bounds)
	{
	}

	public static bool operator ==(MinMaxBounds lhs, Bounds rhs)
	{
		return false;
	}

	public static bool operator !=(MinMaxBounds lhs, Bounds rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(MinMaxBounds other)
	{
		return false;
	}

	public bool Equals(Bounds other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
