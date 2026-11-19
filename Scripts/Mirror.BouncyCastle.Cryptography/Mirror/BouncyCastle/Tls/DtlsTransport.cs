namespace Mirror.BouncyCastle.Tls;

public class DtlsTransport : DatagramTransport, DatagramReceiver, DatagramSender, TlsCloseable
{
	private readonly DtlsRecordLayer m_recordLayer;

	private readonly bool m_ignoreCorruptRecords;

	internal DtlsTransport(DtlsRecordLayer recordLayer, bool ignoreCorruptRecords)
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

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis, DtlsRecordCallback recordCallback)
	{
		return 0;
	}

	public virtual int ReceivePending(byte[] buf, int off, int len, DtlsRecordCallback recordCallback = null)
	{
		return 0;
	}

	public virtual void Send(byte[] buf, int off, int len)
	{
	}

	public virtual void Close()
	{
	}
}
