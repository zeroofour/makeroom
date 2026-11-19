using UnityEngine;
using UnityEngine.UI;

public class LocalizationText : MonoBehaviour
{
	public bool performTranslation;

	[Header("Override")]
	public string overrideId;

	public bool overrideCase;

	private string id;

	private Text component;

	private Font defaultFont;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetText(string _text)
	{
	}

	[ContextMenu("Update Text")]
	public void UpdateText()
	{
	}

	private string Capitalize(string _input)
	{
		return null;
	}
}
