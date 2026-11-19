using System.Runtime.CompilerServices;

namespace Mirror;

public struct Vector4Long(long x, long y, long z, long w)
{
	public long x = 0L;

	public long y = 0L;

	public long z = 0L;

	public long w = 0L;

	public static readonly Vector4Long zero;

	public static readonly Vector4Long one;

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
	public static Vector4Long operator +(Vector4Long a, Vector4Long b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4Long operator -(Vector4Long a, Vector4Long b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4Long operator -(Vector4Long v)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4Long operator *(Vector4Long a, long n)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4Long operator *(long n, Vector4Long a)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector4Long a, Vector4Long b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector4Long a, Vector4Long b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector4Long other)
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
