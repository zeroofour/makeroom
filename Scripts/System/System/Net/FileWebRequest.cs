using System.IO;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net;

[Serializable]
public class FileWebRequest : WebRequest, ISerializable
{
	private static WaitCallback s_GetRequestStreamCallback;

	private static WaitCallback s_GetResponseCallback;

	private string m_connectionGroupName;

	private long m_contentLength;

	private FileAccess m_fileAccess;

	private WebHeaderCollection m_headers;

	private string m_method;

	private IWebProxy m_proxy;

	private ManualResetEvent m_readerEvent;

	private WebResponse m_response;

	private Stream m_stream;

	private bool m_syncHint;

	private int m_timeout;

	private Uri m_uri;

	private bool m_writePending;

	private bool m_writing;

	private int m_Aborted;

	internal bool Aborted => false;

	internal FileWebRequest(Uri uri)
	{
	}

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private static void GetRequestStreamCallback(object state)
	{
	}

	private static void GetResponseCallback(object state)
	{
	}

	internal void UnblockReader()
	{
	}
}
