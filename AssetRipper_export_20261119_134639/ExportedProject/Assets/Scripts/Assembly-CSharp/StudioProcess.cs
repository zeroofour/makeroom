using System.Collections.Generic;
using UnityEngine;

public class StudioProcess : MonoBehaviour
{
	[Header("Containers")]
	public Transform container;

	public Transform containerCustomObjects;

	[Header("Library")]
	public LibraryCategory libraryCategory;

	public LibraryData library;

	[Header("Components")]
	public GameObject customObjectPrefab;

	public Material material;

	public Camera camera;

	private Material materialReplacement;

	private List<GameObject> generated;

	public static StudioProcess instance { get; private set; }

	private void Awake()
	{
	}

	public void Process()
	{
	}

	public void Load()
	{
	}

	public void LoadCustomObject(string _name, DioramaData _data)
	{
	}

	public void SetSingleMaterial(MeshRenderer _renderer, Material _material)
	{
	}

	private List<string> GetVertexColors(Mesh _mesh)
	{
		return null;
	}
}
