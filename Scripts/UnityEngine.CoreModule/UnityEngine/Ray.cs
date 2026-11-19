using System;

namespace UnityEngine;

public struct Ray(Vector3 origin, Vector3 direction) : IFormattable
{
	private Vector3 m_Origin = default;

	private Vector3 m_Direction = default;

	public Vector3 origin => default;

	public Vector3 direction => default;

	public Vector3 GetPoint(float distance)
	{
		return default;
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
