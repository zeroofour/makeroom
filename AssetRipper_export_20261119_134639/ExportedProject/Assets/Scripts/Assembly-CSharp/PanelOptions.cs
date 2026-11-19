using System.Collections.Generic;
using Kenney;
using UnityEngine;
using UnityEngine.UI;

public class PanelOptions : Panel
{
	[Header("Components")]
	public GameObject element;

	public ColorWheel colorWheel;

	[Header("Panels")]
	public GameObject[] panels;

	[Header("Options")]
	public bool showColorWheel;

	[Header("Properties")]
	public Color colorDisabled;

	public Color colorUnavailable;

	[Header("Icons & materials")]
	public Sprite iconColor;

	public Sprite iconColorWheel;

	public Sprite iconCustom;

	public Material materialContrast;

	[Header("Pagination")]
	public Transform pagination;

	public Kenney.Button paginationPrevious;

	public Kenney.Button paginationNext;

	public Text displayPage;

	private List<GameObject> generated;

	private int generatedAmount;

	private int totalAmount;

	private string menu;

	private string target;

	private int page;

	private int pageMax;

	private bool open;

	private string panelTarget;

	private LibraryData data;

	private Dictionary<Texture2D, Sprite> spriteCache;

	public static PanelOptions instance { get; private set; }

	private void Awake()
	{
	}

	public void Display(GameObject _target, string _menu = null, bool _initial = false)
	{
	}

	public void Select(PanelElement _element)
	{
	}

	private void SelectProperty(string _tag, int _index, string _action = "")
	{
	}

	private void GenerateElements(string _tag, int _offset, int _max, bool _useIconName = false)
	{
	}

	private void GenerateTextureElements(int _offset, int _max)
	{
	}

	public Color GetDefaultColor()
	{
		return default;
	}

	public void AdjustColor(PanelElement _element = null, bool _useHex = false, string _color = "#FFFFFF")
	{
	}

	private GameObject GenerateElement(int _index, string _name, Texture2D _icon, Color _color, float _scale = 1f, bool _available = true, Material _material = null)
	{
		return null;
	}

	private GameObject GenerateElement(int _index, string _name, Sprite _icon, Color _color, float _scale = 1f, bool _available = true, Material _material = null)
	{
		return null;
	}

	private GameObject GenerateElement()
	{
		return null;
	}

	private void Clear()
	{
	}

	private void PruneSpriteCache()
	{
	}

	public bool TryClose()
	{
		return false;
	}

	public void Close(bool _sound = true)
	{
	}

	public void ChangePage(int _amount)
	{
	}

	public void SetActivePanel(string _id)
	{
	}

	public void TransitionActivePanel(string _id)
	{
	}

	public void SetActivePanel()
	{
	}
}
