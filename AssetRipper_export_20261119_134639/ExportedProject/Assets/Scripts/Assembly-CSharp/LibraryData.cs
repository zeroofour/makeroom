using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "Data/Data", order = 1)]
public class LibraryData : ScriptableObject
{
	public ColorElement[] colorElements;

	[Header("Textures")]
	public Sprite[] textures;

	public Texture2D[] texturesArt;

	[Header("Groups")]
	public ElementGroup[] elementGroups;

	[Header("Settings")]
	public ColorFilter[] colorFilters;

	public Setting[] settings;

	[Header("Generator")]
	public string[] generatorColor;

	public string[] generatorTheme;

	public string[] generatorRoom;

	[Header("Libraries")]
	public LibraryTagGroup[] tagGroups;

	public Element[] GetElements(string _group)
	{
		return null;
	}

	public Element GetElement(string _group, int _index)
	{
		return null;
	}

	public Element GetElement(string _group, string _name)
	{
		return null;
	}

	public ColorElement GetColorElement(string _id)
	{
		return null;
	}

	public int GetColorElementIndex(string _id)
	{
		return 0;
	}
}
