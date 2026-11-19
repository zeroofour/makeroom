namespace Mirror.BouncyCastle.Tls;

internal class TlsSessionImpl : TlsSession
{
	private readonly byte[] m_sessionID;

	private readonly SessionParameters m_sessionParameters;

	private bool m_resumable;

	public byte[] SessionID => null;

	public bool IsResumable => false;

	internal TlsSessionImpl(byte[] sessionID, SessionParameters sessionParameters)
	{
	}

	public SessionParameters ExportSessionParameters()
	{
		return null;
	}

	public void Invalidate()
	{
	}
}
