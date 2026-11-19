using System.Collections.Generic;
using Kenney;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
	[Header("Targets")]
	public Image targetSprite;

	public Text targetText;

	[Header("Buttons")]
	public Kenney.Button buttonNext;

	public Kenney.Button buttonPrevious;

	[Header("Properties")]
	public bool repeat;

	public bool translate;

	public List<SwitcherOption> options;

	public UnityEvent<int> onChange;

	private int index;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void Toggle()
	{
	}

	public void Previous()
	{
	}

	public void Next()
	{
	}

	public void UpdateOption()
	{
	}

	public void AddOption(Sprite _sprite = null, string _text = null)
	{
	}

	public void SetIndex(int _index)
	{
	}

	public void SetIndex(string _id)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public string GetText()
	{
		return null;
	}
}
