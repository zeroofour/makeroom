using System.Globalization;

namespace System.Collections;

[Serializable]
[Obsolete("Please use StringComparer instead.")]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	private readonly CompareInfo _compareInfo;

	public static CaseInsensitiveHashCodeProvider Default => null;

	public CaseInsensitiveHashCodeProvider()
	{
	}

	public CaseInsensitiveHashCodeProvider(CultureInfo culture)
	{
	}

	public int GetHashCode(object obj)
	{
		return 0;
	}
}
