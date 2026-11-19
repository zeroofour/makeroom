using UnityEngine;

namespace Pixelplacement;

public class LayerMaskHelper
{
	public static int OnlyIncluding(params int[] layers)
	{
		return 0;
	}

	public static int Everything()
	{
		return 0;
	}

	public static int Default()
	{
		return 0;
	}

	public static int Nothing()
	{
		return 0;
	}

	public static int EverythingBut(params int[] layers)
	{
		return 0;
	}

	public static bool ContainsLayer(LayerMask layerMask, int layer)
	{
		return false;
	}

	private static int MakeMask(params int[] layers)
	{
		return 0;
	}
}
