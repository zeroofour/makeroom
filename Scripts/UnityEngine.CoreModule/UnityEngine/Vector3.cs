using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeType(Header = "Runtime/Math/Vector3.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeClass("Vector3f")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	public const float kEpsilon = 1E-05f;

	public const float kEpsilonNormalSqrt = 1E-15f;

	public float x = 0f;

	public float y = 0f;

	public float z = 0f;

	private static readonly Vector3 zeroVector;

	private static readonly Vector3 oneVector;

	private static readonly Vector3 upVector;

	private static readonly Vector3 downVector;

	private static readonly Vector3 leftVector;

	private static readonly Vector3 rightVector;

	private static readonly Vector3 forwardVector;

	private static readonly Vector3 backVector;

	private static readonly Vector3 positiveInfinityVector;

	private static readonly Vector3 negativeInfinityVector;

	public float this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public Vector3 normalized
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public float magnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public float sqrMagnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public static Vector3 zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 one
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 forward
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 back
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 up
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 down
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 left
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Vector3 right
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromDocs]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
	{
		return default;
	}

	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3(float x, float y, float z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3(float x, float y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Scale(Vector3 a, Vector3 b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3 other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Normalize(Vector3 value)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Normalize()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dot(Vector3 lhs, Vector3 rhs)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Project(Vector3 vector, Vector3 onNormal)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Distance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Magnitude(Vector3 vector)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SqrMagnitude(Vector3 vector)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator +(Vector3 a, Vector3 b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator -(Vector3 a, Vector3 b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator -(Vector3 a)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(Vector3 a, float d)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(float d, Vector3 a)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator /(Vector3 a, float d)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3 lhs, Vector3 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector3 lhs, Vector3 rhs)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}
