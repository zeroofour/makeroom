using System;
using UnityEngine;

[Serializable]
public class ConditionPlaceItems : ChecklistConditionBase
{
	public string tagsPositive;

	public string tagsNegative;

	[Range(0f, 10f)]
	public int count;

	public override bool IsMet()
	{
		return false;
	}
}
