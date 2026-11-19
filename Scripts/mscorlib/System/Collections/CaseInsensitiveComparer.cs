using System.Globalization;

namespace System.Collections;

[Serializable]
public class CaseInsensitiveComparer : IComparer
{
	private CompareInfo _compareInfo;

	public static CaseInsensitiveComparer Default => null;

	public CaseInsensitiveComparer()
	{
	}

	public CaseInsensitiveComparer(CultureInfo culture)
	{
	}

	public int Compare(object a, object b)
	{
		return 0;
	}
}
