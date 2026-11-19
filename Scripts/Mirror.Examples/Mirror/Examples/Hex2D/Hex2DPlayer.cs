using UnityEngine;

namespace Mirror.Examples.Hex2D;

[AddComponentMenu(null)]
public class Hex2DPlayer : NetworkBehaviour
{
	[Range(1f, 20f)]
	public float speed;

	[SerializeField]
	[Header("Diagnostics")]
	[ReadOnly]
	private HexSpatialHash2DInterestManagement.CheckMethod checkMethod;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
