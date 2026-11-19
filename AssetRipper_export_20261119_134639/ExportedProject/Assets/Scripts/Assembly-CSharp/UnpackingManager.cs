using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnpackingManager : MonoBehaviour
{
	[Header("Components")]
	public Image progressBar;

	public Text progressText;

	public Text progressCount;

	private List<DioramaChunk> chunks;

	private int totalChunks;

	public static UnpackingManager instance { get; private set; }

	private void Awake()
	{
	}

	public void Initiate()
	{
	}

	public void Placed()
	{
	}

	public void Unpack()
	{
	}

	private void UpdateProgress()
	{
	}
}
