using Pixelplacement.TweenSystem;
using UnityEngine;
using UnityEngine.UI;

public class PromptIdea : MonoBehaviour
{
	[Header("Components")]
	public GameObject tagObjectA;

	public GameObject tagObjectB;

	public GameObject tagObjectC;

	public Text tagA;

	public Text tagB;

	public Text tagC;

	public Text description;

	[Header("Buttons")]
	public GameObject buttonGetStarted;

	public GameObject buttonRandomize;

	private int index;

	private TweenBase tweenA;

	private TweenBase tweenB;

	private TweenBase tweenC;

	private void Awake()
	{
	}

	public void Generate(bool _daily = false)
	{
	}

	public void Reveal()
	{
	}

	public void Close()
	{
	}

	public void GetStarted()
	{
	}
}
