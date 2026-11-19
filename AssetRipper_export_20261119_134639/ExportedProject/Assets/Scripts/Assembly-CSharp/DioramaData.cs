using System;
using System.Collections.Generic;
using Steamworks.Ugc;

[Serializable]
public class DioramaData
{
	public string title;

	public string version;

	public List<DioramaProperty> properties;

	public List<DioramaChunk> chunks;

	public byte[] thumbnail;

	public int nextGroup;

	public int type;

	public bool objective;

	public string tag;

	[NonSerialized]
	public DioramaEntry entry;

	[NonSerialized]
	public Item item;

	public byte[] mesh;

	public byte[] icon;

	public List<string> colors;

	public DioramaData(int _type = 0)
	{
	}

	public void SetProperty(DioramaProperty _property)
	{
	}

	public void SetProperty(string _id, int _integer = 0, string _string = "")
	{
	}

	public void SetProperty(string _id, string _string = "")
	{
	}

	public int GetPropertyInt(string _id)
	{
		return 0;
	}

	public void RemoveProperty(string _id)
	{
	}

	public DioramaProperty GetProperty(string _id)
	{
		return null;
	}

	public string GetPropertyString(string _id, string _default = "#FFFFFF")
	{
		return null;
	}
}
