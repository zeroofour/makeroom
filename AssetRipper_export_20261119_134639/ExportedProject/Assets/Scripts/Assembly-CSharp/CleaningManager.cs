using System;
using System.Collections.Generic;
using Kenney;
using UnityEngine;
using UnityEngine.UI;

public class CleaningManager : MonoBehaviour
{
	[Serializable]
	public class ItemGroup
	{
		public string name;

		public CleanType type;
	}

	[Serializable]
	public class Tool
	{
		public string name;

		public string cursor;

		public AudioClip sound;

		public Kenney.Button button;
	}

	public List<Tool> tools;

	[Header("Audio")]
	public AudioSource ambience;

	[Header("Components")]
	public Image progressBar;

	public Text progressText;

	[Header("Objects")]
	public List<ItemGroup> objects;

	public List<ItemGroup> targets;

	public List<string> plants;

	private Tool tool;

	private int dirt;

	private int dirtTotal;

	private List<DioramaChunk> dirtList;

	public static CleaningManager instance { get; private set; }

	private void Awake()
	{
	}

	public void Initiate()
	{
	}

	private void AddDirt(DioramaChunk _chunk)
	{
	}

	private bool IsCleaningObject(string _name)
	{
		return false;
	}

	public IReadOnlyList<DioramaChunk> GetDirt()
	{
		return null;
	}

	public void RemoveChunk(DioramaChunk _chunk)
	{
	}

	public void ShowDirtLeft()
	{
	}

	public void HideDirtLeft()
	{
	}

	public void Cleaned()
	{
	}

	public void CompleteObjective()
	{
	}

	private void UpdateProgress()
	{
	}

	public void SetTool(string _tool)
	{
	}

	public void Vacuum(float _pitch = 1.01f)
	{
	}

	public void Reset()
	{
	}

	public bool Active()
	{
		return false;
	}

	public string GetTool()
	{
		return null;
	}

	public bool GetObject(string _name, CleanType _type)
	{
		return false;
	}

	public bool GetObject(string _name)
	{
		return false;
	}

	public bool GetTarget(string _name, CleanType _type)
	{
		return false;
	}
}
