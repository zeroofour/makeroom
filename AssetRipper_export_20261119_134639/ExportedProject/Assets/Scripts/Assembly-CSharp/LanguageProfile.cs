using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LanguageProfile
{
	public string name;

	public SystemLanguage[] systemLanguages;

	[Header("Assets")]
	public Font font;

	[NonSerialized]
	public Dictionary<string, string> translations;

	public string GetTranslation(string _id)
	{
		return null;
	}
}
