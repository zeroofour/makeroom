using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class TlsProtocol : TlsCloseable
{
	protected const short CS_START = 0;

	protected const short CS_CLIENT_HELLO = 1;

	protected const short CS_SERVER_HELLO_RETRY_REQUEST = 2;

	protected const short CS_CLIENT_HELLO_RETRY = 3;

	protected const short CS_SERVER_HELLO = 4;

	protected const short CS_SERVER_ENCRYPTED_EXTENSIONS = 5;

	protected const short CS_SERVER_SUPPLEMENTAL_DATA = 6;

	protected const short CS_SERVER_CERTIFICATE = 7;

	protected const short CS_SERVER_CERTIFICATE_STATUS = 8;

	protected const short CS_SERVER_CERTIFICATE_VERIFY = 9;

	protected const short CS_SERVER_KEY_EXCHANGE = 10;

	protected const short CS_SERVER_CERTIFICATE_REQUEST = 11;

	protected const short CS_SERVER_HELLO_DONE = 12;

	protected const short CS_CLIENT_END_OF_EARLY_DATA = 13;

	protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 14;

	protected const short CS_CLIENT_CERTIFICATE = 15;

	protected const short CS_CLIENT_KEY_EXCHANGE = 16;

	protected const short CS_CLIENT_CERTIFICATE_VERIFY = 17;

	protected const short CS_CLIENT_FINISHED = 18;

	protected const short CS_SERVER_SESSION_TICKET = 19;

	protected const short CS_SERVER_FINISHED = 20;

	protected const short CS_END = 21;

	protected const short ADS_MODE_1_Nsub1 = 0;

	protected const short ADS_MODE_0_N = 1;

	protected const short ADS_MODE_0_N_FIRSTONLY = 2;

	private readonly ByteQueue m_applicationDataQueue;

	private readonly ByteQueue m_alertQueue;

	private readonly ByteQueue m_handshakeQueue;

	internal readonly RecordStream m_recordStream;

	internal readonly object m_recordWriteLock;

	private int m_maxHandshakeMessageSize;

	internal TlsHandshakeHash m_handshakeHash;

	private TlsStream m_tlsStream;

	private bool m_closed;

	private bool m_failedWithError;

	private bool m_appDataReady;

	private bool m_appDataSplitEnabled;

	private bool m_keyUpdateEnabled;

	private bool m_keyUpdatePendingSend;

	private bool m_resumableHandshake;

	private int m_appDataSplitMode;

	protected TlsSession m_tlsSession;

	protected SessionParameters m_sessionParameters;

	protected TlsSecret m_sessionMasterSecret;

	protected byte[] m_retryCookie;

	protected int m_retryGroup;

	protected IDictionary<int, byte[]> m_clientExtensions;

	protected IDictionary<int, byte[]> m_serverExtensions;

	protected short m_connectionState;

	protected bool m_selectedPsk13;

	protected bool m_receivedChangeCipherSpec;

	protected bool m_expectSessionTicket;

	protected readonly bool m_blocking;

	protected readonly ByteQueueInputStream m_inputBuffers;

	protected readonly ByteQueueOutputStream m_outputBuffer;

	protected abstract TlsContext Context { get; }

	internal abstract AbstractTlsContext ContextAdmin { get; }

	protected abstract TlsPeer Peer { get; }

	public virtual int ApplicationDataAvailable => 0;

	public virtual int AppDataSplitMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsResumableHandshake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual Stream Stream => null;

	public virtual int ApplicationDataLimit => 0;

	internal bool IsApplicationDataReady => false;

	public virtual bool IsClosed => false;

	public virtual bool IsConnected => false;

	public virtual bool IsHandshaking => false;

	protected bool IsLegacyConnectionState()
	{
		return false;
	}

	protected bool IsTlsV13ConnectionState()
	{
		return false;
	}

	protected TlsProtocol()
	{
	}

	public TlsProtocol(Stream stream)
	{
	}

	public TlsProtocol(Stream input, Stream output)
	{
	}

	public virtual void ResumeHandshake()
	{
	}

	protected virtual void CloseConnection()
	{
	}

	protected virtual void HandleAlertMessage(short alertLevel, short alertDescription)
	{
	}

	protected virtual void HandleAlertWarningMessage(short alertDescription)
	{
	}

	protected virtual void HandleChangeCipherSpecMessage()
	{
	}

	protected virtual void HandleClose(bool user_canceled)
	{
	}

	protected virtual void HandleException(short alertDescription, string message, Exception e)
	{
	}

	protected virtual void HandleFailure()
	{
	}

	protected abstract void HandleHandshakeMessage(short type, HandshakeMessageInput buf);

	protected virtual void ApplyMaxFragmentLengthExtension(short maxFragmentLength)
	{
	}

	protected virtual void CheckReceivedChangeCipherSpec(bool expected)
	{
	}

	protected virtual void BlockForHandshake()
	{
	}

	protected virtual void BeginHandshake()
	{
	}

	protected virtual void CleanupHandshake()
	{
	}

	protected virtual void CompleteHandshake()
	{
	}

	internal void ProcessRecord(short protocol, byte[] buf, int off, int len)
	{
	}

	private void ProcessHandshakeQueue(ByteQueue queue)
	{
	}

	private void ProcessApplicationDataQueue()
	{
	}

	private void ProcessAlertQueue()
	{
	}

	private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
	{
	}

	public virtual int ReadApplicationData(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	protected virtual RecordPreview SafePreviewRecordHeader(byte[] recordHeader)
	{
		return null;
	}

	protected virtual void SafeReadRecord()
	{
	}

	protected virtual bool SafeReadFullRecord(byte[] input, int inputOff, int inputLen)
	{
		return false;
	}

	protected virtual void SafeWriteRecord(short type, byte[] buf, int offset, int len)
	{
	}

	public virtual void WriteApplicationData(byte[] buffer, int offset, int count)
	{
	}

	internal void WriteHandshakeMessage(byte[] buf, int off, int len)
	{
	}

	public virtual void CloseInput()
	{
	}

	public virtual RecordPreview PreviewInputRecord(byte[] recordHeader)
	{
		return null;
	}

	public virtual int PreviewOutputRecord()
	{
		return 0;
	}

	public virtual RecordPreview PreviewOutputRecord(int applicationDataSize)
	{
		return null;
	}

	public virtual void OfferInput(byte[] input)
	{
	}

	public virtual void OfferInput(byte[] input, int inputOff, int inputLen)
	{
	}

	public virtual int GetAvailableInputBytes()
	{
		return 0;
	}

	public virtual int ReadInput(byte[] buf, int off, int len)
	{
		return 0;
	}

	public virtual int GetAvailableOutputBytes()
	{
		return 0;
	}

	public virtual int ReadOutput(byte[] buffer, int offset, int length)
	{
		return 0;
	}

	protected virtual bool EstablishSession(TlsSession sessionToResume)
	{
		return false;
	}

	protected virtual void CancelSession()
	{
	}

	protected virtual void InvalidateSession()
	{
	}

	protected virtual void ProcessFinishedMessage(MemoryStream buf)
	{
	}

	protected virtual void Process13FinishedMessage(MemoryStream buf)
	{
	}

	protected virtual void RaiseAlertFatal(short alertDescription, string message, Exception cause)
	{
	}

	protected virtual void RaiseAlertWarning(short alertDescription, string message)
	{
	}

	protected virtual void Receive13KeyUpdate(MemoryStream buf)
	{
	}

	protected virtual void SendCertificateMessage(Certificate certificate, Stream endPointHash)
	{
	}

	protected virtual void Send13CertificateMessage(Certificate certificate)
	{
	}

	protected virtual void Send13CertificateVerifyMessage(DigitallySigned certificateVerify)
	{
	}

	protected virtual void SendChangeCipherSpec()
	{
	}

	protected virtual void SendChangeCipherSpecMessage()
	{
	}

	protected virtual void SendFinishedMessage()
	{
	}

	protected virtual void Send13FinishedMessage()
	{
	}

	protected virtual void Send13KeyUpdate(bool updateRequested)
	{
	}

	protected virtual void SendSupplementalDataMessage(IList<SupplementalDataEntry> supplementalData)
	{
	}

	public virtual void Close()
	{
	}

	public virtual void Flush()
	{
	}

	[Obsolete("Will be removed")]
	protected virtual short ProcessMaxFragmentLengthExtension(IDictionary<int, byte[]> clientExtensions, IDictionary<int, byte[]> serverExtensions, short alertDescription)
	{
		return 0;
	}

	protected virtual void RefuseRenegotiation()
	{
	}

	internal static void AssertEmpty(MemoryStream buf)
	{
	}

	internal static byte[] CreateRandomBlock(bool useGmtUnixTime, TlsContext context)
	{
		return null;
	}

	internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
	{
		return null;
	}

	internal static void EstablishMasterSecret(TlsContext context, TlsKeyExchange keyExchange)
	{
	}

	internal static IDictionary<int, byte[]> ReadExtensions(MemoryStream input)
	{
		return null;
	}

	internal static IDictionary<int, byte[]> ReadExtensionsData(byte[] extBytes)
	{
		return null;
	}

	internal static IDictionary<int, byte[]> ReadExtensionsData13(int handshakeType, byte[] extBytes)
	{
		return null;
	}

	internal static IDictionary<int, byte[]> ReadExtensionsDataClientHello(byte[] extBytes)
	{
		return null;
	}

	internal static IList<SupplementalDataEntry> ReadSupplementalDataMessage(MemoryStream input)
	{
		return null;
	}

	internal static void WriteExtensions(Stream output, IDictionary<int, byte[]> extensions)
	{
	}

	internal static void WriteExtensions(Stream output, IDictionary<int, byte[]> extensions, int bindersSize)
	{
	}

	internal static byte[] WriteExtensionsData(IDictionary<int, byte[]> extensions)
	{
		return null;
	}

	internal static byte[] WriteExtensionsData(IDictionary<int, byte[]> extensions, int bindersSize)
	{
		return null;
	}

	internal static void WriteExtensionsData(IDictionary<int, byte[]> extensions, MemoryStream buf)
	{
	}

	internal static void WriteExtensionsData(IDictionary<int, byte[]> extensions, MemoryStream buf, int bindersSize)
	{
	}

	internal static void WritePreSharedKeyExtension(MemoryStream buf, IDictionary<int, byte[]> extensions, int bindersSize)
	{
	}

	internal static void WriteSelectedExtensions(Stream output, IDictionary<int, byte[]> extensions, bool selectEmpty)
	{
	}

	internal static void WriteSupplementalData(Stream output, IList<SupplementalDataEntry> supplementalData)
	{
	}
}
