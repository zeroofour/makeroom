using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AnimatedSprite : MonoBehaviour
{
	[Header("Properties")]
	public Sprite[] frames;

	public float speed;

	[Header("Effects")]
	public bool randomOpacity;

	[Header("Events")]
	public UnityEvent afterCompletion;

	private int index;

	private Image image;

	private void Awake()
	{
	}

	public void Frame()
	{
	}

	public void Remove()
	{
	}
}
