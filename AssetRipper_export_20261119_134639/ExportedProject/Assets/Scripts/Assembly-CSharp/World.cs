using UnityEngine;
using UnityEngine.UI;

public class World : MonoBehaviour
{
	public Transform model;

	public Transform menu;

	[Header("Components")]
	public WorldPrompt prompt;

	public Text progressLabel;

	[Header("Materials")]
	public Material materialTrees;

	public Material materialWorld;

	public Material materialBuilding;

	[Header("Audio")]
	public AudioClip audioAmbienceClip;

	public AudioSource audioAmbience;

	private bool active;

	private Vector2 mousePosition;

	private GameObject objectHover;

	private float fadeTarget;

	private Objective objectiveStarting;

	public static World instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Generate()
	{
	}

	public void Return()
	{
	}

	public void StartTutorialObjective()
	{
	}

	public void StartObjective(Objective _objective, GameObject _object = null)
	{
	}

	public void TransitionComplete()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate(bool _fade = true)
	{
	}

	public bool Active()
	{
		return false;
	}

	public void ShowProgress()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
