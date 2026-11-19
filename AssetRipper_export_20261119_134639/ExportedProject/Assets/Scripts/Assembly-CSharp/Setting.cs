using System;
using UnityEngine;

[Serializable]
public class Setting
{
	public Color ambienceColor;

	[Range(0f, 1f)]
	public float ambienceLightIntensity;

	public Sprite icon;

	public bool availableInDemo;
}
