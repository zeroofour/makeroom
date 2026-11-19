namespace Mirror.BouncyCastle.Tls;

public sealed class DtlsRequest
{
	private readonly long m_recordSeq;

	private readonly byte[] m_message;

	private readonly ClientHello m_clientHello;

	internal ClientHello ClientHello => null;

	internal byte[] Message => null;

	internal int MessageSeq => 0;

	internal long RecordSeq => 0L;

	internal DtlsRequest(long recordSeq, byte[] message, ClientHello clientHello)
	{
	}
}
