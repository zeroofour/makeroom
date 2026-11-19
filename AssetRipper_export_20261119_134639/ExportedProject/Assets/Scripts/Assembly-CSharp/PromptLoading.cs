using UnityEngine;
using UnityEngine.UI;

public class PromptLoading : MonoBehaviour
{
	[Header("Components")]
	public Text text;

	public Transform spinner;

	public AudioSource audioSource;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Message(string _text)
	{
	}
}
