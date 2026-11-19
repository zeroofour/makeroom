using UnityEngine;

public class Environment : MonoBehaviour
{
	[Header("Properties")]
	public bool foliage;

	public string seed;

	public int amount;

	public float offset;

	public bool onStart;

	[Header("Components")]
	public Material material;

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
