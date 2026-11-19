using UnityEngine;

namespace Mirror.Examples.CharacterSelection;

public class SceneCamera : NetworkBehaviour
{
	[Header("Components")]
	[SerializeField]
	private CharacterSelection characterSelection;

	[SerializeField]
	private Transform cameraTarget;

	[Header("Diagnostics")]
	[ReadOnly]
	[SerializeField]
	private SceneReferencer sceneReferencer;

	[ReadOnly]
	[SerializeField]
	private Transform cameraObj;

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	public override void OnStartAuthority()
	{
	}

	public override void OnStopAuthority()
	{
	}

	private void Update()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
