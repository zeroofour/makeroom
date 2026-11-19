using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct Plane : IFormattable
{
	internal const int size = 16;

	private Vector3 m_Normal = default;

	private float m_Distance = 0f;

	public Vector3 normal => default;

	public float distance => 0f;

	public Plane(Vector3 inNormal, Vector3 inPoint)
	{
	}

	public Plane(Vector3 inNormal, float d)
	{
	}

	public Plane(Vector3 a, Vector3 b, Vector3 c)
	{
	}

	public bool Raycast(Ray ray, out float enter)
	{
		enter = default;
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
