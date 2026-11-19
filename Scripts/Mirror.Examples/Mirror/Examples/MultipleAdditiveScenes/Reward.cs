using Mirror.Examples.Common;
using UnityEngine;

namespace Mirror.Examples.MultipleAdditiveScenes;

[RequireComponent(typeof(RandomColor))]
[AddComponentMenu(null)]
public class Reward : NetworkBehaviour
{
	[Header("Components")]
	public RandomColor randomColor;

	[Header("Diagnostics")]
	[ReadOnly]
	[SerializeField]
	private bool available;

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	public override void OnStartServer()
	{
	}

	[ServerCallback]
	private void OnTriggerEnter(Collider other)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
