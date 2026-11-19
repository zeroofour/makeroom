using System.IO;
using System.Runtime.Serialization;

namespace System.Net;

[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	private bool m_closed;

	private long m_contentLength;

	private FileAccess m_fileAccess;

	private WebHeaderCollection m_headers;

	private Stream m_stream;

	private Uri m_uri;

	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
	{
	}

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	public override void Close()
	{
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
	}
}
