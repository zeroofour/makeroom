using UnityEngine;

namespace Mirror.Examples.AdditiveLevels;

public class LookAtMainCamera : MonoBehaviour
{
	private void OnValidate()
	{
	}

	[ClientCallback]
	private void LateUpdate()
	{
	}
}
