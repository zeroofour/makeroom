using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
	[Header("Components")]
	public GameObject objective;

	public Text textDescription;

	public Text textProgress;

	public GameObject iconCleaning;

	[Header("Elements")]
	public GameObject progressLabel;

	public RectTransform elementCharacter;

	public RectTransform elementBalloon;

	[Header("Elements")]
	public GameObject inputPromptContainer;

	public InputPromptSprite inputPromptSprite;

	[Header("Properties")]
	[HideInInspector]
	public Objective[] objectivesList;

	private Objective activeObjective;

	private int index;

	private bool returningToGameplay;

	private List<string> toolHintsShown;

	public static ObjectiveManager instance { get; private set; }

	private void Awake()
	{
	}

	private void GatherObjectives()
	{
	}

	public Objective GetObjective(string _name)
	{
		return null;
	}

	public void CheckObjective()
	{
	}

	public void Set(string _name)
	{
	}

	public void Set(Objective _objective, DioramaData _alternativeData = null)
	{
	}

	public void SetToolDescription(string _tool)
	{
	}

	public void SetDescription(string _text, bool _voice = true)
	{
	}

	public void HideDescription()
	{
	}

	public void UpdateTask()
	{
	}

	private bool MatchesTags(Transform _object, ChapterObject _chapter)
	{
		return false;
	}

	public void CompleteObjective()
	{
	}

	public void ReturnToGameplay()
	{
	}

	public void Hide()
	{
	}

	public void TransitionOut(bool _sound = true)
	{
	}

	public void TransitionInCharacter()
	{
	}

	public void TransitionIn()
	{
	}

	public void TransitionIn(bool _character = false)
	{
	}

	public Objective Get()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Action(string _action)
	{
	}

	public void TaskComplete()
	{
	}

	public void NextTask()
	{
	}
}
