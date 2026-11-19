namespace Mirror.BouncyCastle.Tls;

internal sealed class DtlsReplayWindow
{
	private const long ValidSeqMask = 281474976710655L;

	private const long WindowSize = 64L;

	private long m_latestConfirmedSeq;

	private ulong m_bitmap;

	internal bool ShouldDiscard(long seq)
	{
		return false;
	}

	internal void ReportAuthenticated(long seq, out bool isLatestConfirmed)
	{
		isLatestConfirmed = default;
	}

	internal void Reset(long seq)
	{
	}
}
