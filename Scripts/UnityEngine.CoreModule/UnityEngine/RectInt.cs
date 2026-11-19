using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable
{
	private int m_XMin = 0;

	private int m_YMin = 0;

	private int m_Width = 0;

	private int m_Height = 0;

	public int x
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int xMin => 0;

	public int yMin => 0;

	public int xMax => 0;

	public int yMax => 0;

	public RectInt(int xMin, int yMin, int width, int height)
	{
	}

	public bool Overlaps(RectInt other)
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

	public bool Equals(RectInt other)
	{
		return false;
	}
}
