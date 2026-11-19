using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
	public GameObject prefab;

	private string hintCategory;

	private string hintTarget;

	private Dictionary<string, Hint> registeredHints;

	private List<GameObject> generatedHints;

	public static HintManager instance { get; private set; }

	private void Awake()
	{
	}

	public void Set(string _hint)
	{
	}

	public void SetHint()
	{
	}

	public void SetHintInvoke()
	{
	}

	public void AddHint(GameObject _object)
	{
	}

	public void Reset()
	{
	}

	public void Register(Hint _hint)
	{
	}
}
