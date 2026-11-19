using System;

[Serializable]
public abstract class ChecklistConditionBase
{
	public string description;

	public abstract bool IsMet();
}
