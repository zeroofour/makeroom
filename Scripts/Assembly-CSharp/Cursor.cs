using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
	public static Dictionary<string, Texture2D> cursors;

	public static string cursor;

	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}

	private static void PreloadCursors()
	{
	}

	public static void SetDefault()
	{
	}

	public static void Set(string _id, bool _special = false)
	{
	}

	public static void Toggle(bool _visible)
	{
	}
}
