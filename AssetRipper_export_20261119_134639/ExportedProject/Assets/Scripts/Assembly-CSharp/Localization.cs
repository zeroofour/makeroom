using System;
using UnityEngine;

public class Localization : MonoBehaviour
{
	public static Localization instance;

	public static LanguageProfile activeProfile;

	public static int languageIndex;

	public static Action onLanguageChange;

	private LanguageProfiles languageProfiles;

	private void Awake()
	{
	}

	private void Prepare()
	{
	}

	public static void SetLanguage(int _index)
	{
	}

	public static void SetLanguageAutomatic()
	{
	}

	public static string Translate(string _id)
	{
		return null;
	}

	public static string TranslateFormat(string _id, params object[] _arguments)
	{
		return null;
	}

	private static bool CheckNumber(string _value)
	{
		return false;
	}

	public static Font GetCurrentFont()
	{
		return null;
	}
}
