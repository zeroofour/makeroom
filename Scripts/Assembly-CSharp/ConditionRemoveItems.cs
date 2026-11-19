using System;

[Serializable]
public class ConditionRemoveItems : ChecklistConditionBase
{
	public string tagsPositive;

	public string tagsNegative;

	public override bool IsMet()
	{
		return false;
	}
}
