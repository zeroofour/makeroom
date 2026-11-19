using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LibraryObject
{
	public string name;

	public string clean;

	[Header("Components")]
	public GameObject prefab;

	[HideInInspector]
	public byte[] icon;

	[Header("Properties")]
	public Mesh mesh;

	public Bounds bounds;

	public List<string> colors;

	public int specialColor;

	[Header("Settings")]
	public bool mounted;

	public bool ceiling;

	public bool demo;

	public bool light;

	public bool secret;

	[Header("Tags")]
	public List<string> tags;

	[NonSerialized]
	[Header("Workshop")]
	public string workshopTitle;

	[NonSerialized]
	public string workshopID;

	private Sprite thumbnail;

	public GameObject GetPrefab()
	{
		return null;
	}

	public void SetThumbnail(Sprite _sprite)
	{
	}

	public Sprite GetThumbnail()
	{
		return null;
	}
}
