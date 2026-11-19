using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal sealed class DtlsEpoch
{
	private readonly DtlsReplayWindow m_replayWindow;

	private readonly int m_epoch;

	private readonly TlsCipher m_cipher;

	private readonly int m_recordHeaderLengthRead;

	private readonly int m_recordHeaderLengthWrite;

	private long m_sequenceNumber;

	internal TlsCipher Cipher => null;

	internal int Epoch => 0;

	internal int RecordHeaderLengthRead => 0;

	internal int RecordHeaderLengthWrite => 0;

	internal DtlsReplayWindow ReplayWindow => null;

	internal long SequenceNumber
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	internal DtlsEpoch(int epoch, TlsCipher cipher, int recordHeaderLengthRead, int recordHeaderLengthWrite)
	{
	}

	internal long AllocateSequenceNumber()
	{
		return 0L;
	}
}
