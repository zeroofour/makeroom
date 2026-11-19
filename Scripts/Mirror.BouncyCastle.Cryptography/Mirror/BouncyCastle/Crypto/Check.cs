namespace Mirror.BouncyCastle.Crypto;

internal static class Check
{
	internal static void DataLength(bool condition, string message)
	{
	}

	internal static void DataLength(byte[] buf, int off, int len, string message)
	{
	}

	internal static void OutputLength(bool condition, string message)
	{
	}

	internal static void OutputLength(byte[] buf, int off, int len, string message)
	{
	}

	internal static void ThrowDataLengthException(string message)
	{
	}

	internal static void ThrowOutputLengthException(string message)
	{
	}
}
