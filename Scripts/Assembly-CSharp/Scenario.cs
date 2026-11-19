using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenario", menuName = "Data/Scenario", order = 1)]
public class Scenario : ScriptableObject
{
	[Serializable]
	public class ObjectiveStep
	{
		[TextArea]
		public string dialogue;

		[SerializeReference]
		public ChecklistConditionBase[] checklist;
	}

	[Header("Properties")]
	public string title;

	public bool cleaning;

	[Header("Dialogue")]
	public ObjectiveStep[] steps;

	[TextArea]
	public string dialogueOutro;

	[Header("Reward")]
	public string unlock;

	public string unlockName;

	[Header("Diorama")]
	public DioramaData diorama;
}
