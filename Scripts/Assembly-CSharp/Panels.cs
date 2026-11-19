using System;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
	[Serializable]
	public class Group
	{
		public string name;

		public List<GameObject> objects;
	}

	public Dictionary<string, Panel> panels;

	public List<Group> groups;

	public static Panels instance { get; private set; }

	private void Awake()
	{
	}

	public void Show(params string[] _panels)
	{
	}

	public void Hide(params string[] _panels)
	{
	}

	public void Register(Panel _panel)
	{
	}

	public void ShowGroup(string _name)
	{
	}

	public void HideGroup(string _name)
	{
	}
}
