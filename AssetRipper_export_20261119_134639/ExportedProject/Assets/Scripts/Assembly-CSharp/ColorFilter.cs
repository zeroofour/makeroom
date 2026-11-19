using System;
using UnityEngine;

[Serializable]
public class ColorFilter
{
	public string name;

	[Range(0f, 1f)]
	public float intensity;

	public Texture2D texture;
}
