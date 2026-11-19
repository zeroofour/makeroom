using System;
using UnityEngine;

[Serializable]
public class Element
{
	public string name;

	public Sprite icon;

	public UnityEngine.Object prefab;

	public Vector2 additionalData;

	public bool availableInDemo;

	public bool hidden;
}
