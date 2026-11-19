using System;
using UnityEngine;

[Serializable]
public class ChapterObject
{
	[Tooltip("Object name should include all of these (comma separated)")]
	public string tagsPositive;

	[Tooltip("Object name should include none of these (comma separated)")]
	public string tagsNegative;
}
