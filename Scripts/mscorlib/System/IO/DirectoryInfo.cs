using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public sealed class DirectoryInfo : FileSystemInfo
{
	public DirectoryInfo(string path)
	{
	}

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
	{
		return null;
	}

	private DirectoryInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
