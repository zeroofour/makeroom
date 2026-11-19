using System;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal class DtlsRecordLayer : DatagramTransport, DatagramReceiver, DatagramSender, TlsCloseable
{
	internal const int RecordHeaderLength = 13;

	private const int MAX_FRAGMENT_LENGTH = 16384;

	private const long TCP_MSL = 120000L;

	private const long RETRANSMIT_TIMEOUT = 240000L;

	private readonly TlsContext m_context;

	private readonly TlsPeer m_peer;

	private readonly DatagramTransport m_transport;

	private readonly ByteQueue m_recordQueue;

	private readonly object m_writeLock;

	private bool m_closed;

	private bool m_failed;

	private ProtocolVersion m_readVersion;

	private ProtocolVersion m_writeVersion;

	private bool m_inConnection;

	private bool m_inHandshake;

	private int m_plaintextLimit;

	private DtlsEpoch m_currentEpoch;

	private DtlsEpoch m_pendingEpoch;

	private DtlsEpoch m_readEpoch;

	private DtlsEpoch m_writeEpoch;

	private DtlsHandshakeRetransmit m_retransmit;

	private DtlsEpoch m_retransmitEpoch;

	private Timeout m_retransmitTimeout;

	private TlsHeartbeat m_heartbeat;

	private bool m_heartBeatResponder;

	private HeartbeatMessage m_heartbeatInFlight;

	private Timeout m_heartbeatTimeout;

	private int m_heartbeatResendMillis;

	private Timeout m_heartbeatResendTimeout;

	internal virtual bool IsClosed => false;

	internal virtual int ReadEpoch => 0;

	internal virtual ProtocolVersion ReadVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static int ReceiveClientHelloRecord(byte[] data, int dataOff, int dataLen)
	{
		return 0;
	}

	internal static void SendHelloVerifyRequestRecord(DatagramSender sender, long recordSeq, byte[] message)
	{
	}

	private static void SendDatagram(DatagramSender sender, byte[] buf, int off, int len)
	{
	}

	internal DtlsRecordLayer(TlsContext context, TlsPeer peer, DatagramTransport transport)
	{
	}

	internal virtual void ResetAfterHelloVerifyRequestServer(long recordSeq)
	{
	}

	internal virtual void SetPlaintextLimit(int plaintextLimit)
	{
	}

	internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
	{
	}

	internal virtual void InitPendingEpoch(TlsCipher pendingCipher)
	{
	}

	internal virtual void HandshakeSuccessful(DtlsHandshakeRetransmit retransmit)
	{
	}

	internal virtual void InitHeartbeat(TlsHeartbeat heartbeat, bool heartbeatResponder)
	{
	}

	internal virtual void ResetWriteEpoch()
	{
	}

	public virtual int GetReceiveLimit()
	{
		return 0;
	}

	public virtual int GetSendLimit()
	{
		return 0;
	}

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
	{
		return 0;
	}

	internal int Receive(byte[] buf, int off, int len, int waitMillis, DtlsRecordCallback recordCallback)
	{
		return 0;
	}

	internal int ReceivePending(byte[] buf, int off, int len, DtlsRecordCallback recordCallback)
	{
		return 0;
	}

	public virtual void Send(byte[] buf, int off, int len)
	{
	}

	public virtual void Close()
	{
	}

	internal virtual void Fail(short alertDescription)
	{
	}

	internal virtual void Failed()
	{
	}

	internal virtual void Warn(short alertDescription, string message)
	{
	}

	private void CloseTransport()
	{
	}

	private void RaiseAlert(short alertLevel, short alertDescription, string message, Exception cause)
	{
	}

	private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
	{
		return 0;
	}

	private int ProcessRecord(int received, byte[] record, byte[] buf, int off, int len, DtlsRecordCallback recordCallback)
	{
		return 0;
	}

	private int ReceivePendingRecord(byte[] buf, int off, int len)
	{
		return 0;
	}

	private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
	{
		return 0;
	}

	private void ResetHeartbeat()
	{
	}

	private void SendHeartbeatMessage(HeartbeatMessage heartbeatMessage)
	{
	}

	private void SendRecord(short contentType, byte[] buf, int off, int len)
	{
	}

	private static long GetMacSequenceNumber(int epoch, long sequence_number)
	{
		return 0L;
	}
}
