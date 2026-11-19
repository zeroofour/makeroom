using System;
using UnityEngine;
using UnityEngine.UI;

public class Splashscreen : MonoBehaviour
{
	[Serializable]
	public class Slide
	{
		public Sprite image;

		public Color color;

		public float time;

		public bool skip;
	}

	[Header("Components")]
	public CanvasGroup canvasGroup;

	public Image background;

	public Image image;

	[Header("Settings")]
	public string completeScene;

	public Slide[] slides;

	private int index;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Skip()
	{
	}

	private void FadeIn()
	{
	}

	private void FadeInComplete()
	{
	}

	private void FadeOut()
	{
	}

	private void FadeOutComplete()
	{
	}
}
