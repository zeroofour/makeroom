using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public sealed class FileInfo : FileSystemInfo
{
	public long Length => 0L;

	public override string Name => null;

	private FileInfo()
	{
	}

	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	public FileStream OpenRead()
	{
		return null;
	}

	private FileInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
