using System.Collections.Generic;

namespace Mirror.SimpleWeb;

public class Request
{
	private static readonly char[] lineSplitChars;

	private static readonly char[] headerSplitChars;

	public string RequestLine;

	public Dictionary<string, string> Headers;

	public Request(string message)
	{
	}
}
