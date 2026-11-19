using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class TextInfo : ICloneable, IDeserializationCallback
{
	[OptionalField(VersionAdded = 2)]
	private string m_listSeparator;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[OptionalField(VersionAdded = 3)]
	private string m_cultureName;

	[NonSerialized]
	private CultureData m_cultureData;

	[NonSerialized]
	private string m_textInfoName;

	[NonSerialized]
	private bool? m_IsAsciiCasingSameAsInvariant;

	internal static TextInfo s_Invariant;

	[OptionalField(VersionAdded = 2)]
	private string customCultureName;

	[OptionalField(VersionAdded = 1)]
	internal int m_nDataItem;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID;

	private const int wordSeparatorMask = 536672256;

	internal static TextInfo Invariant => null;

	[ComVisible(false)]
	public string CultureName => null;

	private bool IsAsciiCasingSameAsInvariant => false;

	internal TextInfo(CultureData cultureData)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	private void OnDeserialized()
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	[ComVisible(false)]
	public virtual object Clone()
	{
		return null;
	}

	internal void SetReadOnlyState(bool readOnly)
	{
	}

	public virtual char ToLower(char c)
	{
		return '\0';
	}

	public virtual string ToLower(string str)
	{
		return null;
	}

	private static char ToLowerAsciiInvariant(char c)
	{
		return '\0';
	}

	public virtual char ToUpper(char c)
	{
		return '\0';
	}

	public virtual string ToUpper(string str)
	{
		return null;
	}

	internal static char ToUpperAsciiInvariant(char c)
	{
		return '\0';
	}

	private static bool IsAscii(char c)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToTitleCase(string str)
	{
		return null;
	}

	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		return 0;
	}

	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		return 0;
	}

	private static bool IsWordSeparator(UnicodeCategory category)
	{
		return false;
	}

	private static bool IsLetterCategory(UnicodeCategory uc)
	{
		return false;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	private string ToUpperInternal(string str)
	{
		return null;
	}

	private string ToLowerInternal(string str)
	{
		return null;
	}

	private char ToUpperInternal(char c)
	{
		return '\0';
	}

	private char ToLowerInternal(char c)
	{
		return '\0';
	}

	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
	{
	}

	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
	{
	}

	internal TextInfo()
	{
	}
}
