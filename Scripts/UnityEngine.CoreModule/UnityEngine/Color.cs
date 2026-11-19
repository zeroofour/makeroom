using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[DefaultMember("Item")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeHeader("Runtime/Math/Color.h")]
[NativeClass("ColorRGBAf")]
public struct Color : IEquatable<Color>, IFormattable
{
	public float r = 0f;

	public float g = 0f;

	public float b = 0f;

	public float a = 0f;

	public static Color red
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color green
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color blue
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color white
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color black
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color yellow
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color cyan
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color magenta
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color gray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color grey
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public static Color clear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public float grayscale
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public Color linear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public float maxColorComponent
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Color(float r, float g, float b, float a)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Color(float r, float g, float b)
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
	public bool Equals(Color other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color operator +(Color a, Color b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color operator -(Color a, Color b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color operator *(Color a, Color b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color operator *(Color a, float b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color operator /(Color a, float b)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Color lhs, Color rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Color lhs, Color rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color Lerp(Color a, Color b, float t)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color LerpUnclamped(Color a, Color b, float t)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Color RGBMultiplied(float multiplier)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Vector4(Color c)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Color(Vector4 v)
	{
		return default;
	}

	public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
	{
		H = default;
		S = default;
		V = default;
	}

	private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
	{
		H = default;
		S = default;
		V = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color HSVToRGB(float H, float S, float V)
	{
		return default;
	}

	public static Color HSVToRGB(float H, float S, float V, bool hdr)
	{
		return default;
	}
}
