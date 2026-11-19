using System;

namespace UnityEngine.UIElements;

public struct Length : IEquatable<Length>
{
	private enum Unit
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3
	}

	private const float k_MaxValue = 8388608f;

	private float m_Value = 0f;

	private Unit m_Unit = Unit.Pixel;

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public LengthUnit unit => LengthUnit.Pixel;

	public static Length Percent(float value)
	{
		return default;
	}

	internal static Length Auto()
	{
		return default;
	}

	internal static Length None()
	{
		return default;
	}

	internal bool IsAuto()
	{
		return false;
	}

	internal bool IsNone()
	{
		return false;
	}

	public Length(float value)
	{
	}

	public Length(float value, LengthUnit unit)
	{
	}

	private Length(float value, Unit unit)
	{
	}

	public static implicit operator Length(float value)
	{
		return default;
	}

	public static bool operator ==(Length lhs, Length rhs)
	{
		return false;
	}

	public static bool operator !=(Length lhs, Length rhs)
	{
		return false;
	}

	public bool Equals(Length other)
	{
		return false;
	}

	public override bool Equals(object obj)
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
