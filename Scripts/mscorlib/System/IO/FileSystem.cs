using Microsoft.Win32.SafeHandles;

namespace System.IO;

internal static class FileSystem
{
	private class UnitySafeFindHandle : SafeFindHandle
	{
		private readonly IntPtr m_Handle;

		public override bool IsInvalid => false;

		public UnitySafeFindHandle(IntPtr handle)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	public static void CreateDirectory(string fullPath)
	{
	}

	public static void DeleteFile(string fullPath)
	{
	}

	public static bool DirectoryExists(string fullPath)
	{
		return false;
	}

	private static bool DirectoryExists(string path, out int lastError)
	{
		lastError = default;
		return false;
	}

	internal static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound)
	{
		return 0;
	}

	public static bool FileExists(string fullPath)
	{
		return false;
	}

	private static bool UnityCreateDirectory(string name)
	{
		return false;
	}

	private static bool UnityGetFileAttributesEx(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
	{
		return false;
	}

	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
	{
		return (IntPtr)0;
	}

	private static bool UnityDeleteFile(string path)
	{
		return false;
	}

	private static SafeFindHandle UnityFindFirstFile(string path, ref Interop.Kernel32.WIN32_FIND_DATA findData)
	{
		return null;
	}

	private static bool BrokeredCreateDirectory(string path)
	{
		return false;
	}

	private static bool BrokeredGetFileAttributes(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
	{
		return false;
	}

	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes)
	{
		return (IntPtr)0;
	}

	private static bool BrokeredDeleteFile(string path)
	{
		return false;
	}

	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes)
	{
		return (IntPtr)0;
	}

	private static int BrokeredSafeFindHandleDispose(IntPtr handle)
	{
		return 0;
	}

	private static string RemoveExtendedPathPrefix(string path)
	{
		return null;
	}
}
