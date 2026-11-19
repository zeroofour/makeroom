using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Tls;

internal class DtlsReliableHandshake
{
	internal class Message
	{
		private readonly int m_message_seq;

		private readonly short m_msg_type;

		private readonly byte[] m_body;

		public int Seq => 0;

		public short Type => 0;

		public byte[] Body => null;

		internal Message(int message_seq, short msg_type, byte[] body)
		{
		}
	}

	internal class RecordLayerBuffer : MemoryStream
	{
		internal RecordLayerBuffer(int size)
		{
		}

		internal void SendToRecordLayer(DtlsRecordLayer recordLayer)
		{
		}
	}

	internal class Retransmit : DtlsHandshakeRetransmit
	{
		private readonly DtlsReliableHandshake m_outer;

		internal Retransmit(DtlsReliableHandshake outer)
		{
		}

		public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
		{
		}
	}

	internal const int MessageHeaderLength = 12;

	private const int MAX_RECEIVE_AHEAD = 16;

	private const int MAX_RESEND_MILLIS = 60000;

	private DtlsRecordLayer m_recordLayer;

	private Timeout m_handshakeTimeout;

	private TlsHandshakeHash m_handshakeHash;

	private IDictionary<int, DtlsReassembler> m_currentInboundFlight;

	private IDictionary<int, DtlsReassembler> m_previousInboundFlight;

	private IList<Message> m_outboundFlight;

	private readonly int m_initialResendMillis;

	private int m_resendMillis;

	private Timeout m_resendTimeout;

	private int m_next_send_seq;

	private int m_next_receive_seq;

	internal TlsHandshakeHash HandshakeHash => null;

	internal static MemoryStream ReceiveClientHelloMessage(byte[] msg, int msgOff, int msgLen)
	{
		return null;
	}

	internal static void SendHelloVerifyRequest(DatagramSender sender, long recordSeq, byte[] cookie)
	{
	}

	internal DtlsReliableHandshake(TlsContext context, DtlsRecordLayer transport, int timeoutMillis, int initialResendMillis, DtlsRequest request)
	{
	}

	internal void ResetAfterHelloVerifyRequestClient()
	{
	}

	internal void PrepareToFinish()
	{
	}

	internal void SendMessage(short msg_type, byte[] body)
	{
	}

	internal Message ReceiveMessage()
	{
		return null;
	}

	internal byte[] ReceiveMessageBody(short msg_type)
	{
		return null;
	}

	internal Message ReceiveMessageDelayedDigest(short msg_type)
	{
		return null;
	}

	internal void UpdateHandshakeMessagesDigest(Message message)
	{
	}

	internal void Finish()
	{
	}

	internal static int BackOff(int timeoutMillis)
	{
		return 0;
	}

	private void CheckInboundFlight()
	{
	}

	private Message GetPendingMessage()
	{
		return null;
	}

	private Message ImplReceiveMessage()
	{
		return null;
	}

	private void PrepareInboundFlight(IDictionary<int, DtlsReassembler> nextFlight)
	{
	}

	private void ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
	{
	}

	private void ResendOutboundFlight()
	{
	}

	private void WriteMessage(Message message)
	{
	}

	private void WriteHandshakeFragment(Message message, int fragment_offset, int fragment_length)
	{
	}

	private static bool CheckAll(IDictionary<int, DtlsReassembler> inboundFlight)
	{
		return false;
	}

	private static void ResetAll(IDictionary<int, DtlsReassembler> inboundFlight)
	{
	}
}
