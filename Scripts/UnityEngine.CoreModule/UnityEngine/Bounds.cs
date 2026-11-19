using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeClass("AABB")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
public struct Bounds(Vector3 center, Vector3 size) : IEquatable<Bounds>, IFormattable
{
	private Vector3 m_Center = default;

	[NativeName("m_Extent")]
	private Vector3 m_Extents = default;

	public Vector3 center
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 size
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 extents
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 min => default;

	public Vector3 max => default;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(Bounds other)
	{
		return false;
	}

	public static bool operator ==(Bounds lhs, Bounds rhs)
	{
		return false;
	}

	public static bool operator !=(Bounds lhs, Bounds rhs)
	{
		return false;
	}

	public void SetMinMax(Vector3 min, Vector3 max)
	{
	}

	public void Encapsulate(Vector3 point)
	{
	}

	public void Encapsulate(Bounds bounds)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	[NativeMethod("IsInside", IsThreadSafe = true)]
	public bool Contains(Vector3 point)
	{
		return false;
	}

	[FreeFunction("BoundsScripting::ClosestPoint", HasExplicitThis = true, IsThreadSafe = true)]
	public Vector3 ClosestPoint(Vector3 point)
	{
		return default;
	}

	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point)
	{
		return false;
	}

	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret)
	{
		ret = default;
	}
}
