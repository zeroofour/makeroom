using System;
using UnityEngine;

[Serializable]
public class Chapter
{
	[TextArea]
	public string text;

	public string hint;

	public string prompt;

	[Header("Goal")]
	public string name;

	public string action;

	[Range(0f, 10f)]
	public int count;

	public ChapterObject[] objects;

	private int progress;

	public void SetProgress(int _progress)
	{
	}

	public int GetProgress()
	{
		return 0;
	}
}
