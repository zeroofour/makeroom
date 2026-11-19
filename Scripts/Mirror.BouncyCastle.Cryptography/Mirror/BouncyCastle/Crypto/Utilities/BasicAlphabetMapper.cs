using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Utilities;

public class BasicAlphabetMapper : IAlphabetMapper
{
	private readonly IDictionary<char, int> m_indexMap;

	private readonly IList<char> m_charMap;

	public int Radix => 0;

	public BasicAlphabetMapper(string alphabet)
	{
	}

	public BasicAlphabetMapper(char[] alphabet)
	{
	}

	public byte[] ConvertToIndexes(char[] input)
	{
		return null;
	}

	public char[] ConvertToChars(byte[] input)
	{
		return null;
	}
}
