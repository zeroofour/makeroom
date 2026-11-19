using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SimpleImageEffect : MonoBehaviour
{
	public Material effectMaterial;

	private void OnEnable()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
