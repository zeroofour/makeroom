using UnityEngine;

namespace FPL;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class BuiltIn_CameraDepthNormal : MonoBehaviour
{
	[SerializeField]
	private Camera cam;

	private void OnEnable()
	{
	}
}
