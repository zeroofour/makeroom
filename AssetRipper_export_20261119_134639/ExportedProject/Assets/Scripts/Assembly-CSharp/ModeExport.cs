using System.Collections.Generic;
using UnityEngine;

public class ModeExport : Mode
{
	public class Swatch
	{
		public string id;

		public Gradient gradient;

		public Vector2Int index;

		public int colorIndex;

		public Swatch(string _id, Gradient _gradient)
		{
		}
	}

	[Header("Components")]
	public ComponentInput inputName;

	public GameObject buttonFolder;

	private GameObject generated;

	private Material materialReplacement;

	private int sizeTexture;

	private Vector2Int sizeSwatch;

	private Dictionary<string, Swatch> table;

	private List<Swatch> swatches;

	public void Prepare()
	{
	}

	public void Export()
	{
	}

	public void ApplyColormap(Transform _container)
	{
	}

	public Swatch GetSwatch(string _id)
	{
		return null;
	}

	public Texture2D GenerateColorTexture(string _path)
	{
		return null;
	}

	public void OpenFolder()
	{
	}

	public void ColormapSet(Color[] _pixels, Swatch _swatch, Vector2Int _position)
	{
	}

	private Vector2 ColormapGetGradient(Swatch _swatch, float _value)
	{
		return default;
	}

	public override void Open()
	{
	}
}
