using UnityEngine;

public class PromotionalObjects : MonoBehaviour
{
	[Header("Properties")]
	public string[] objects;

	public Texture2D paintingTexture;

	[Header("Components")]
	public Transform container;

	public Material paintingMaterial;

	private void Start()
	{
	}
}
