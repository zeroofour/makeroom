using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWheel : MonoBehaviour
{
	public enum Target
	{
		None = 0,
		Tint = 1,
		Wheel = 2
	}

	[Serializable]
	public struct NamedColor(float h, float s, float v, string description)
	{
		public float h = 0f;

		public float s = 0f;

		public float v = 0f;

		public string description = null;
	}

	[Header("Components")]
	public RectTransform picker;

	public ComponentInput hexValue;

	public RawImage tint;

	public Text colorDescription;

	[Header("Icons")]
	public Sprite iconColor;

	[Header("Selectors")]
	public Transform selectorWheel;

	public Transform selectorTint;

	[Header("Previous Colors")]
	public List<PanelElement> previousColorElements;

	private Texture2D textureTint;

	private int tintSize;

	private Color color;

	private float colorHue;

	private float colorSaturation;

	private float colorBrightness;

	private Target target;

	private List<Color> previousColors;

	private int maximumMemory;

	private bool adjustedColor;

	private bool open;

	private string appliedHex;

	private List<NamedColor> referenceColors;

	private void Awake()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	private void Update()
	{
	}

	public static float Angle(Vector2 vector2)
	{
		return 0f;
	}

	public void SetColor(string _hex)
	{
	}

	public void SetColor(Color _color)
	{
	}

	public void SetColor(Color _color, bool _apply)
	{
	}

	private void UpdateColors(bool _apply = true)
	{
	}

	public void OnPointerDown()
	{
	}

	public void OnPointerUp()
	{
	}

	private void InteractionStart()
	{
	}

	private void GenerateTexture()
	{
	}

	public void RegisterColor()
	{
	}

	public void RenderPreviousColors()
	{
	}

	public void SelectPreviousColor(PanelElement _element)
	{
	}

	private bool ContainsColor(List<Color> list, Color target, float tolerance = 0.001f)
	{
		return false;
	}

	private float HSV_Distance(float h1, float s1, float v1, float h2, float s2, float v2)
	{
		return 0f;
	}

	public static string GetColorName(float h, float s, float v)
	{
		return null;
	}
}
