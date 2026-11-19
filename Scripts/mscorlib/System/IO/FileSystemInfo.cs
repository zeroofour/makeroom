using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data;

	private int _dataInitialized;

	protected string FullPath;

	protected string OriginalPath;

	internal string _name;

	public FileAttributes Attributes => (FileAttributes)0;

	internal DateTimeOffset LastWriteTimeCore => default;

	internal long LengthCore => 0L;

	internal string NormalizedPath => null;

	public virtual string FullName => null;

	public virtual string Name => null;

	public DateTime LastWriteTime => default;

	public DateTime LastWriteTimeUtc => default;

	protected FileSystemInfo()
	{
	}

	internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData)
	{
		return null;
	}

	internal unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
	{
	}

	private void EnsureDataInitialized()
	{
	}

	public void Refresh()
	{
	}

	protected FileSystemInfo(SerializationInfo info, StreamingContext context)
	{
	}

	[ComVisible(false)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
