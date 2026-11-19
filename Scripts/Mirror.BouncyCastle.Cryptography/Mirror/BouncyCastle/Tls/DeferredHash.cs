using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

internal sealed class DeferredHash : TlsHandshakeHash, TlsHash
{
	private const int BufferingHashLimit = 4;

	private readonly TlsContext m_context;

	private DigestInputBuffer m_buf;

	private IDictionary<int, TlsHash> m_hashes;

	private bool m_forceBuffering;

	private bool m_sealed;

	internal DeferredHash(TlsContext context)
	{
	}

	public void CopyBufferTo(Stream output)
	{
	}

	public void ForceBuffering()
	{
	}

	public void NotifyPrfDetermined()
	{
	}

	public void TrackHashAlgorithm(int cryptoHashAlgorithm)
	{
	}

	public void SealHashAlgorithms()
	{
	}

	public void StopTracking()
	{
	}

	public TlsHash ForkPrfHash()
	{
		return null;
	}

	public byte[] GetFinalHash(int cryptoHashAlgorithm)
	{
		return null;
	}

	public void Update(byte[] input, int inOff, int len)
	{
	}

	public byte[] CalculateHash()
	{
		return null;
	}

	public TlsHash CloneHash()
	{
		return null;
	}

	public void Reset()
	{
	}

	private void CheckStopBuffering()
	{
	}

	private void CheckTrackingHash(int cryptoHashAlgorithm)
	{
	}

	private TlsHash CloneHash(int cryptoHashAlgorithm)
	{
		return null;
	}

	private void CloneHash(IDictionary<int, TlsHash> newHashes, int cryptoHashAlgorithm)
	{
	}
}
