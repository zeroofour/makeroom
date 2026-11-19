using System.Collections.Generic;
using SCPE;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
	public LibraryData data;

	public GameVersion gameVersionSelector;

	[Header("Components")]
	public PlayerInput input;

	public Sidebar sidebar;

	[Header("Components")]
	public PostProcessVolume postProcessVolume;

	[Header("Photography")]
	public Canvas canvas;

	public CanvasGroup canvasGroup;

	public Texture2D[] logos;

	private Dictionary<string, GameObject> prefabs;

	private Blur postProcessingBlur;

	public static List<Resolution> resolutions;

	public static bool demo;

	public static GameVersion gameVersion;

	public static bool editorMode;

	public static AudioMixer audioMixer;

	public static GameManager instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool GetBlur()
	{
		return false;
	}

	public void ToggleBlur(bool _enabled)
	{
	}

	private void Prepare()
	{
	}

	private void Preload()
	{
	}

	public GameObject GetPrefab(string _name)
	{
		return null;
	}

	public void OpenToolbar(Transform _transform)
	{
	}

	public void Screenshot(Vector2Int _resolution, bool _logo)
	{
	}

	public void ReturnToTitlescreen()
	{
	}

	public void ResetGame()
	{
	}

	public void MenuOpen()
	{
	}

	public void MenuSave()
	{
	}

	public void MenuHelp()
	{
	}

	public void MenuIdea()
	{
	}

	public void MenuDaily()
	{
	}

	public void MenuCode()
	{
	}

	public void MenuOptions()
	{
	}

	public void MenuExit()
	{
	}

	public void AudioToggle(bool _enabled)
	{
	}

	public void PrepareResolutions()
	{
	}

	public void TutorialPrompt()
	{
	}

	public void ShowTutorialPrompt()
	{
	}

	public void HideInterface()
	{
	}

	public void ShowInterface()
	{
	}

	public void ToggleInterface()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
