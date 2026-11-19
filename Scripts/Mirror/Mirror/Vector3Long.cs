using System.Runtime.CompilerServices;

namespace Mirror;

public struct Vector3Long(long x, long y, long z)
{
	public long x = 0L;

	public long y = 0L;

	public long z = 0L;

	public static readonly Vector3Long zero;

	public static readonly Vector3Long one;

	public static readonly Vector3Long forward;

	public static readonly Vector3Long back;

	public static readonly Vector3Long left;

	public static readonly Vector3Long right;

	public static readonly Vector3Long up;

	public static readonly Vector3Long down;

	public long this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long operator +(Vector3Long a, Vector3Long b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long operator -(Vector3Long a, Vector3Long b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long operator -(Vector3Long v)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long operator *(Vector3Long a, long n)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3Long operator *(long n, Vector3Long a)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3Long a, Vector3Long b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector3Long a, Vector3Long b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3Long other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}
}
