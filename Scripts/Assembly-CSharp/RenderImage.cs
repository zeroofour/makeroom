using UnityEngine;

public class RenderImage : MonoBehaviour
{
	public static Texture2D RenderNew(string _name, Vector2Int _resolution, int _multiplier, Camera _camera = null, Texture2D _overlay = null, Vector2? _overlayPosition = null, float _overlayScale = 0.1f)
	{
		return null;
	}

	public static Texture2D Render(string name, int resolutionX, int resolutionY, int multiplier, Camera camera = null, Texture2D _overlay = null)
	{
		return null;
	}

	public static Texture2D RenderPromotional(string name, int resolutionX, int resolutionY, int multiplier, Camera camera = null)
	{
		return null;
	}

	public static Texture2D Composite(Texture2D baseImage, Texture2D compositeImage, int cx, int cy)
	{
		return null;
	}

	public static RectInt CropRect(Texture2D texture)
	{
		return default;
	}

	public static int CoordinateToGridIndex(int x, int y, int xMax, int yMax)
	{
		return 0;
	}
}
