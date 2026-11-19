using System.Globalization;

namespace System.Numerics;

internal static class BigNumber
{
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
	{
		digits = default;
		return '\0';
	}

	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
	{
		charsWritten = default;
		spanSuccess = default;
		return null;
	}

	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
	{
		return null;
	}

	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
	{
		charsWritten = default;
		spanSuccess = default;
		return null;
	}
}
