namespace Mirror.BouncyCastle.Utilities.Net;

public class IPAddress
{
	public static bool IsValid(string address)
	{
		return false;
	}

	public static bool IsValidWithNetMask(string address)
	{
		return false;
	}

	public static bool IsValidIPv4(string address)
	{
		return false;
	}

	public static bool IsValidIPv4WithNetmask(string address)
	{
		return false;
	}

	public static bool IsValidIPv6(string address)
	{
		return false;
	}

	public static bool IsValidIPv6WithNetmask(string address)
	{
		return false;
	}

	private static bool IsParseableIPv4Mask(string s)
	{
		return false;
	}

	private static bool IsParseableIPv4Octet(string s, int pos, int end)
	{
		return false;
	}

	private static bool IsParseableIPv6Mask(string s)
	{
		return false;
	}

	private static bool IsParseableIPv6Segment(string s, int pos, int end)
	{
		return false;
	}

	private static bool IsParseableDecimal(string s, int pos, int end, int maxLength, bool allowLeadingZero, int minValue, int maxValue)
	{
		return false;
	}

	private static bool IsParseableHexadecimal(string s, int pos, int end, int maxLength, bool allowLeadingZero, int minValue, int maxValue)
	{
		return false;
	}

	private static int GetDigitDecimal(string s, int pos)
	{
		return 0;
	}

	private static int GetDigitHexadecimal(string s, int pos)
	{
		return 0;
	}
}
