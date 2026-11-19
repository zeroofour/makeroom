using UnityEngine;
using UnityEngine.Events;

public class StudioManager : MonoBehaviour
{
	public LibraryData data;

	[Header("Components")]
	public PlayerInput input;

	public Sidebar sidebar;

	[Header("Warnings")]
	public GameObject warningEditing;

	public GameObject warningHeavy;

	[Header("Properties")]
	public Color backgroundColor;

	public Material grassMaterial;

	[Header("Properties")]
	public UnityEvent onLanguageChange;

	private byte[] meshData;

	public static StudioManager instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Hotkeys()
	{
	}

	public void Menu()
	{
	}

	public void MenuNew()
	{
	}

	public void MenuOpen()
	{
	}

	public void MenuSave()
	{
	}

	public void MenuOptions()
	{
	}

	public void MenuExit()
	{
	}

	public void MenuHelp()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateLanguage()
	{
	}
}
