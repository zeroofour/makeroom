namespace UnityEngine;

public class GUILayout
{
	private sealed class LayoutedWindow
	{
		private readonly GUI.WindowFunction m_Func;

		private readonly Rect m_ScreenRect;

		private readonly GUILayoutOption[] m_Options;

		private readonly GUIStyle m_Style;

		internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
		{
		}

		public void DoWindow(int windowID)
		{
		}
	}

	public static void Label(string text, params GUILayoutOption[] options)
	{
	}

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
	}

	public static void Box(string text, params GUILayoutOption[] options)
	{
	}

	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
	}

	public static bool Button(string text, params GUILayoutOption[] options)
	{
		return false;
	}

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return false;
	}

	public static string TextField(string text, params GUILayoutOption[] options)
	{
		return null;
	}

	public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
	{
		return null;
	}

	public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
	{
		return null;
	}

	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
	{
		return null;
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
	{
		return 0f;
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
	{
		return 0f;
	}

	public static void FlexibleSpace()
	{
	}

	public static void BeginHorizontal(params GUILayoutOption[] options)
	{
	}

	public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void EndHorizontal()
	{
	}

	public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void EndVertical()
	{
	}

	public static void BeginArea(Rect screenRect)
	{
	}

	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
	{
	}

	public static void EndArea()
	{
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
	{
		return default;
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
	{
		return default;
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
	{
		return default;
	}

	public static void EndScrollView()
	{
	}

	internal static void EndScrollView(bool handleScrollWheel)
	{
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
	{
		return default;
	}

	private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return default;
	}

	public static GUILayoutOption Width(float width)
	{
		return null;
	}

	public static GUILayoutOption Height(float height)
	{
		return null;
	}

	public static GUILayoutOption ExpandWidth(bool expand)
	{
		return null;
	}

	public static GUILayoutOption ExpandHeight(bool expand)
	{
		return null;
	}
}
