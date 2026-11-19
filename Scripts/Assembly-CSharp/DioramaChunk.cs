using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DioramaChunk
{
	public string id;

	public int group;

	public Vector3 position;

	public Vector3 rotation;

	public Vector3 scale;

	public int texture;

	public string painting;

	public bool activated;

	public bool locked;

	public bool hidden;

	public float damage;

	public List<ColorReplacement> colorReplacements;

	private Mesh mesh;

	[NonSerialized]
	public DioramaObject dioramaObject;

	[NonSerialized]
	public LibraryObject libraryObject;

	[NonSerialized]
	public bool forceLocked;

	[NonSerialized]
	public bool fromBox;

	[NonSerialized]
	public int uid;

	private static int uidCounter;

	public void SetMesh(Mesh _mesh)
	{
	}

	public Mesh GetMesh()
	{
		return null;
	}

	public GameObject GetObject()
	{
		return null;
	}

	public DioramaChunk Copy()
	{
		return null;
	}

	public void Set(DioramaChunk _source)
	{
	}

	public void AssignUid()
	{
	}

	public Color GetColor(LibraryData _libraryData, int _index)
	{
		return default;
	}
}
