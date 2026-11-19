using UnityEngine;

[ExecuteInEditMode]
public class SelectionMaskRenderer : MonoBehaviour
{
	public LayerMask selectionLayer;

	public Shader maskShader;

	private Camera maskCam;

	private RenderTexture maskRT;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}
}
