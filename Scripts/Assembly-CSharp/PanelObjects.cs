using System.Collections.Generic;
using Kenney;
using UnityEngine;
using UnityEngine.UI;

public class PanelObjects : Panel
{
	[Header("Settings")]
	public LibraryType displayCategories;

	[Header("Components")]
	public GameObject element;

	public GameObject elementReturn;

	[Header("Pagination")]
	public Transform pagination;

	public Kenney.Button paginationPrevious;

	public Kenney.Button paginationNext;

	public Text displayPage;

	[Header("Properties")]
	public Sprite iconSearch;

	public Color colorDisabled;

	public Color colorUnavailable;

	[Header("Seasonal tag")]
	public Sprite seasonalIcon;

	public string seasonalTag;

	private LibraryCategory library;

	private List<GameObject> generated;

	private List<string> highlightedCategories;

	private List<PanelElement> generatedElements;

	private bool selectDrag;

	private int page;

	private int pageMax;

	private string search;

	private int maximumElements;

	private int elementsGenerated;

	private int elementsTotal;

	public static PanelObjects instance { get; private set; }

	private void Awake()
	{
	}

	public void Generate(bool _animate = true)
	{
	}

	private void GenerateLibraryItems(int _offset, bool _animate)
	{
	}

	private void GenerateCategories(int _offset, bool _animate)
	{
	}

	private void GenerateSearch(int _offset, bool _animate)
	{
	}

	private bool ObjectUnlocked(LibraryObject _object)
	{
		return false;
	}

	private void Clear()
	{
	}

	private void ClearCounters()
	{
	}

	private void GenerateSearchIcon()
	{
	}

	private void GenerateObject(LibraryCategory _category, LibraryObject _object, bool _generate, bool _animate)
	{
	}

	private void GenerateCategory(LibraryCategory _category, bool _generate, bool _animate)
	{
	}

	private GameObject GenerateElement(LibraryObject _object, string _name, Sprite _icon, Color _color, float _scale = 1f, bool _available = true, bool _glow = false, bool _animate = true)
	{
		return null;
	}

	private void GenerateElement()
	{
	}

	private void GenerateEmptySlots()
	{
	}

	public void ChangePage(int _amount)
	{
	}

	private void FinalizePagination()
	{
	}

	public void SelectDrag(PanelElement _element)
	{
	}

	public void Select(PanelElement _element)
	{
	}

	public bool TryReturn()
	{
		return false;
	}

	public void Return()
	{
	}

	public void Search(string _search)
	{
	}

	public void AddHighlightedCategories(List<string> _categories)
	{
	}

	public void AddHighlightedCategory(string _category)
	{
	}

	public void PreviewShow(GameObject _object)
	{
	}

	public void PreviewHide()
	{
	}
}
