using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Category", menuName = "Data/Category", order = 1)]
public class LibraryCategory : ScriptableObject
{
	[Header("Visuals")]
	public string title;

	public GameObject prefab;

	public string prefabPath;

	[Header("Properties")]
	public LibraryType type;

	public GenerationType generation;

	public bool hidden;

	[Header("Generated")]
	[HideInInspector]
	public byte[] icon;

	public Sprite thumbnail;

	public List<LibraryObject> objects;

	public Sprite GetThumbnail()
	{
		return null;
	}

	public GameObject GetPrefab()
	{
		return null;
	}
}
