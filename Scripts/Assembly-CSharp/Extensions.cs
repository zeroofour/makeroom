using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
	public static void SetLayerRecursively(this GameObject gameObject, int layer)
	{
	}

	public static void SetLayerRecursively(this GameObject gameObject, string layer)
	{
	}

	public static void SetCollisionRecursively(this GameObject gameObject, bool collide)
	{
	}

	public static void SetColor(this GameObject gameObject, Color color)
	{
	}

	public static Color Hex(string _hex)
	{
		return default;
	}

	public static string Hex(this Color _color)
	{
		return null;
	}

	public static Color SetAlpha(this Color color, float alpha)
	{
		return default;
	}

	public static Color AdjustBrightness(this Color _color, float _amount)
	{
		return default;
	}

	public static Gradient CreateGradient(Color _colorA, Color _colorB)
	{
		return null;
	}

	public static Component CopyComponent(this GameObject destination, Component original)
	{
		return null;
	}

	public static string UppercaseFirst(this string s)
	{
		return null;
	}

	public static Vector3 SnapToSurface(Vector3 _position, Vector3 _normal, float _grid)
	{
		return default;
	}

	public static Vector3 RoundVector(this Vector2 v, float grid = 1f)
	{
		return default;
	}

	public static Vector3 RoundVector(this Vector3 v, float grid = 1f)
	{
		return default;
	}

	public static bool Equals(this Vector2 vector2, Vector2 otherVector2)
	{
		return false;
	}

	public static bool Equals(this Vector3 vector3, Vector3 otherVector3)
	{
		return false;
	}

	public static float Remap(float a, float b, float c, float d, float x)
	{
		return 0f;
	}

	public static T RemapArray<T>(int _index, T[] _values)
	{
		return default;
	}

	public static void Shuffle<T>(this IList<T> ts)
	{
	}
}
