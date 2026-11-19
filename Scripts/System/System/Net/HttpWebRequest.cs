using System.ComponentModel;
using System.Net.Cache;
using System.Runtime.Serialization;

namespace System.Net;

[Serializable]
public class HttpWebRequest : WebRequest, ISerializable
{
	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2
	}

	private struct AuthorizationState(HttpWebRequest request, bool isProxy)
	{
		private readonly HttpWebRequest request = null;

		private readonly bool isProxy = false;

		private bool isCompleted = false;

		private NtlmAuthState ntlm_auth_state = NtlmAuthState.None;

		public override string ToString()
		{
			return null;
		}
	}

	private Uri requestUri;

	private Uri actualUri;

	private bool hostChanged;

	private bool allowAutoRedirect;

	private bool allowBuffering;

	private long contentLength;

	private WebHeaderCollection webHeaders;

	private bool keepAlive;

	private int maxAutoRedirect;

	private string mediaType;

	private string method;

	private string initialMethod;

	private bool pipelined;

	private Version version;

	private IWebProxy proxy;

	private ServicePoint servicePoint;

	private int timeout;

	private int continueTimeout;

	private object locker;

	private static int defaultMaxResponseHeadersLength;

	private static int defaultMaximumErrorResponseLength;

	private static RequestCachePolicy defaultCachePolicy;

	private int readWriteTimeout;

	private ServerCertValidationCallback certValidationCallback;

	private bool hostHasPort;

	private Uri hostUri;

	private AuthorizationState auth_state;

	private AuthorizationState proxy_auth_state;

	public Uri Address => null;

	internal bool ThrowOnError { set; }

	public string Host => null;

	public ServicePoint ServicePoint => null;

	internal ServicePoint ServicePointNoLock => null;

	internal ServerCertValidationCallback ServerCertValidationCallback => null;

	static HttpWebRequest()
	{
	}

	public HttpWebRequest(Uri uri)
	{
	}

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void ResetAuthorization()
	{
	}

	internal ServicePoint GetServicePoint()
	{
		return null;
	}

	internal static Exception FlattenException(Exception e)
	{
		return null;
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HttpWebRequest()
	{
	}
}
