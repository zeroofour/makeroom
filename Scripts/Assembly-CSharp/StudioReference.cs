using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudioReference : MonoBehaviour
{
	[Serializable]
	public class Reference
	{
		public string name;

		public Vector3 size;

		public float seatHeight;
	}

	[Header("Components")]
	public Text label;

	[Header("Properties")]
	public LibraryCategory library;

	public Material material;

	[Header("References")]
	public Reference[] references;

	private List<string> objects;

	private int index;

	private GameObject referenceModel;

	private void Awake()
	{
	}

	public void PreviousReference()
	{
	}

	public void NextReference()
	{
	}

	public void Refresh()
	{
	}

	private void SetModel(int _index)
	{
	}
}
