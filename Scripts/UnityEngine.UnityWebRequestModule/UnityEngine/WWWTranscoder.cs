using UnityEngine.Bindings;

namespace UnityEngine;

[VisibleToOtherModules(new string[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder
{
	private static byte[] ucHexChars;

	private static byte[] lcHexChars;

	private static byte urlEscapeChar;

	private static byte[] urlSpace;

	private static byte[] dataSpace;

	private static byte[] urlForbidden;

	private static byte qpEscapeChar;

	private static byte[] qpSpace;

	private static byte[] qpForbidden;

	private static byte Hex2Byte(byte[] b, int offset)
	{
		return 0;
	}

	public static byte[] URLDecode(byte[] toEncode)
	{
		return null;
	}

	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand)
	{
		return false;
	}

	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space)
	{
		return null;
	}
}
