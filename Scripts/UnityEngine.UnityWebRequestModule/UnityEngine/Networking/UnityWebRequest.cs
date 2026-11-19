using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable
{
	internal enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4
	}

	internal enum UnityWebRequestError
	{
		OK = 0,
		Unknown = 1,
		SDKError = 2,
		UnsupportedProtocol = 3,
		MalformattedUrl = 4,
		CannotResolveProxy = 5,
		CannotResolveHost = 6,
		CannotConnectToHost = 7,
		AccessDenied = 8,
		GenericHttpError = 9,
		WriteError = 10,
		ReadError = 11,
		OutOfMemory = 12,
		Timeout = 13,
		HTTPPostError = 14,
		SSLCannotConnect = 15,
		Aborted = 16,
		TooManyRedirects = 17,
		ReceivedNoData = 18,
		SSLNotSupported = 19,
		FailedToSendData = 20,
		FailedToReceiveData = 21,
		SSLCertificateError = 22,
		SSLCipherNotAvailable = 23,
		SSLCACertError = 24,
		UnrecognizedContentEncoding = 25,
		LoginFailed = 26,
		SSLShutdownFailed = 27,
		NoInternetConnection = 28
	}

	public enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4
	}

	[NonSerialized]
	internal IntPtr m_Ptr;

	[NonSerialized]
	internal DownloadHandler m_DownloadHandler;

	[NonSerialized]
	internal UploadHandler m_UploadHandler;

	[NonSerialized]
	internal CertificateHandler m_CertificateHandler;

	[NonSerialized]
	internal Uri m_Uri;

	public bool disposeCertificateHandlerOnDispose { get; set; }

	public bool disposeDownloadHandlerOnDispose { get; set; }

	public bool disposeUploadHandlerOnDispose { get; set; }

	public string method
	{
		set
		{
		}
	}

	public string error => null;

	public string url
	{
		set
		{
		}
	}

	public long responseCode => 0L;

	public bool isModifiable
	{
		[NativeMethod("IsModifiable")]
		get
		{
			return false;
		}
	}

	public bool isDone => false;

	public Result result
	{
		[NativeMethod("GetResult")]
		get
		{
			return Result.InProgress;
		}
	}

	public UploadHandler uploadHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DownloadHandler downloadHandler
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CertificateHandler certificateHandler => null;

	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = true)]
	private static string GetWebErrorString(UnityWebRequestError err)
	{
		return null;
	}

	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode)
	{
		return null;
	}

	[NativeThrows]
	internal static IntPtr Create()
	{
		return (IntPtr)0;
	}

	[NativeMethod(IsThreadSafe = true)]
	private void Release()
	{
	}

	internal void InternalDestroy()
	{
	}

	private void InternalSetDefaults()
	{
	}

	public UnityWebRequest(string url, string method)
	{
	}

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
	{
	}

	~UnityWebRequest()
	{
	}

	public void Dispose()
	{
	}

	private void DisposeHandlers()
	{
	}

	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest()
	{
		return null;
	}

	public UnityWebRequestAsyncOperation SendWebRequest()
	{
		return null;
	}

	[NativeMethod(IsThreadSafe = true)]
	public void Abort()
	{
	}

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType)
	{
		return UnityWebRequestError.OK;
	}

	internal void InternalSetMethod(UnityWebRequestMethod methodType)
	{
	}

	private UnityWebRequestError SetCustomMethod(string customMethodName)
	{
		return UnityWebRequestError.OK;
	}

	internal void InternalSetCustomMethod(string customMethodName)
	{
	}

	private UnityWebRequestError GetError()
	{
		return UnityWebRequestError.OK;
	}

	private UnityWebRequestError SetUrl(string url)
	{
		return UnityWebRequestError.OK;
	}

	private void InternalSetUrl(string url)
	{
	}

	[NativeMethod("SetRequestHeader")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value)
	{
		return UnityWebRequestError.OK;
	}

	public void SetRequestHeader(string name, string value)
	{
	}

	private UnityWebRequestError SetUploadHandler(UploadHandler uh)
	{
		return UnityWebRequestError.OK;
	}

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
	{
		return UnityWebRequestError.OK;
	}

	public static UnityWebRequest Get(string uri)
	{
		return null;
	}
}
