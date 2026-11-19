using System.Collections.Generic;
using UnityEngine;

public class DioramaEditColors : MonoBehaviour
{
	public class ColorReplacementCopy
	{
		public int index;

		public string original;

		public string replacement;
	}

	private List<ColorReplacementCopy> colorClipboard;

	public static DioramaEditColors instance { get; private set; }

	private void Awake()
	{
	}

	public void CopyColors()
	{
	}

	public void PasteColors()
	{
	}

	public void RandomColors()
	{
	}
}
