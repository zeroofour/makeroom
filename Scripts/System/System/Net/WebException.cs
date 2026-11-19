using System.Runtime.Serialization;

namespace System.Net;

[Serializable]
public class WebException : InvalidOperationException, ISerializable
{
	private WebExceptionStatus m_Status;

	private WebResponse m_Response;

	public WebException()
	{
	}

	public WebException(string message, Exception innerException)
	{
	}

	public WebException(string message, WebExceptionStatus status)
	{
	}

	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
	{
	}

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
	{
	}

	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
