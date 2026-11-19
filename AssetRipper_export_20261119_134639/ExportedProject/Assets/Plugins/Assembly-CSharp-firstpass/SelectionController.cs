using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class SelectionController : MonoBehaviour
{
	public Material stencilMaterial;

	public GameObject currentSelection;

	private CommandBuffer cb;

	private Camera mainCam;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void SetSelection(GameObject obj)
	{
	}

	private void UpdateBuffer()
	{
	}
}
