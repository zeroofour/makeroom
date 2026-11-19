using UnityEngine;

namespace Mirror.Examples.AdditiveScenes;

public class ZoneHandler : MonoBehaviour
{
	[Scene]
	[Tooltip("Assign the sub-scene to load for this zone")]
	public string subScene;

	[ServerCallback]
	private void OnTriggerEnter(Collider other)
	{
	}

	[ServerCallback]
	private void OnTriggerExit(Collider other)
	{
	}
}
