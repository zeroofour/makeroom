namespace System.IO;

internal static class Win32Marshal
{
	internal static Exception GetExceptionForWin32Error(int errorCode, string path = "")
	{
		return null;
	}

	internal static int MakeHRFromErrorCode(int errorCode)
	{
		return 0;
	}

	internal static string GetMessage(int errorCode)
	{
		return null;
	}
}
