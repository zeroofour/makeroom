using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace System.Net;

[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	internal class DesignerWebRequestCreate
	{
	}

	private static object s_InternalSyncObject;

	private static TimerThread.Queue s_DefaultTimerQueue;

	private AuthenticationLevel m_AuthenticationLevel;

	private TokenImpersonationLevel m_ImpersonationLevel;

	private static DesignerWebRequestCreate webRequestCreate;

	private static IWebProxy s_DefaultWebProxy;

	private static bool s_DefaultWebProxyInitialized;

	private static object InternalSyncObject => null;

	internal static IWebProxy InternalDefaultWebProxy => null;

	protected WebRequest()
	{
	}

	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
