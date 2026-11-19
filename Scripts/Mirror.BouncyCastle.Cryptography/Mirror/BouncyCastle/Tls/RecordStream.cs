using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal sealed class RecordStream
{
	private sealed class Record
	{
		private readonly byte[] m_header;

		internal byte[] m_buf;

		internal int m_pos;

		internal Record()
		{
		}

		internal void FillTo(Stream input, int length)
		{
		}

		internal void ReadFragment(Stream input, int fragmentLength)
		{
		}

		internal bool ReadHeader(Stream input)
		{
			return false;
		}

		internal void Reset()
		{
		}

		private void Resize(int length)
		{
		}
	}

	private sealed class SequenceNumber
	{
		private long m_value;

		private bool m_exhausted;

		internal long CurrentValue => 0L;

		internal long NextValue(short alertDescription)
		{
			return 0L;
		}

		internal void Reset()
		{
		}
	}

	private const int DefaultPlaintextLimit = 16384;

	private readonly Record m_inputRecord;

	private readonly SequenceNumber m_readSeqNo;

	private readonly SequenceNumber m_writeSeqNo;

	private readonly TlsProtocol m_handler;

	private readonly Stream m_input;

	private readonly Stream m_output;

	private TlsCipher m_pendingCipher;

	private TlsCipher m_readCipher;

	private TlsCipher m_readCipherDeferred;

	private TlsCipher m_writeCipher;

	private ProtocolVersion m_writeVersion;

	private int m_plaintextLimit;

	private int m_ciphertextLimit;

	private bool m_ignoreChangeCipherSpec;

	internal int PlaintextLimit => 0;

	internal RecordStream(TlsProtocol handler, Stream input, Stream output)
	{
	}

	internal void SetPlaintextLimit(int plaintextLimit)
	{
	}

	internal void SetWriteVersion(ProtocolVersion writeVersion)
	{
	}

	internal void SetIgnoreChangeCipherSpec(bool ignoreChangeCipherSpec)
	{
	}

	internal void SetPendingCipher(TlsCipher tlsCipher)
	{
	}

	internal void NotifyChangeCipherSpecReceived()
	{
	}

	internal void EnablePendingCipherRead(bool deferred)
	{
	}

	internal void EnablePendingCipherWrite()
	{
	}

	internal void FinaliseHandshake()
	{
	}

	internal bool NeedsKeyUpdate()
	{
		return false;
	}

	internal void NotifyKeyUpdateReceived()
	{
	}

	internal void NotifyKeyUpdateSent()
	{
	}

	internal RecordPreview PreviewRecordHeader(byte[] recordHeader)
	{
		return null;
	}

	internal RecordPreview PreviewOutputRecord(int contentLength)
	{
		return null;
	}

	internal int PreviewOutputRecordSize(int contentLength)
	{
		return 0;
	}

	internal bool ReadFullRecord(byte[] input, int inputOff, int inputLen)
	{
		return false;
	}

	internal bool ReadRecord()
	{
		return false;
	}

	internal TlsDecodeResult DecodeAndVerify(short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int off, int len)
	{
		return null;
	}

	internal void WriteRecord(short contentType, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
	}

	internal void Close()
	{
	}

	private void CheckChangeCipherSpec(byte[] buf, int off, int len)
	{
	}

	private short CheckRecordType(byte[] buf, int off)
	{
		return 0;
	}

	private static void CheckLength(int length, int limit, short alertDescription)
	{
	}
}
