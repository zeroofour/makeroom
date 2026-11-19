using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class OfferedPsks
{
	internal class BindersConfig
	{
		internal readonly TlsPsk[] m_psks;

		internal readonly short[] m_pskKeyExchangeModes;

		internal readonly TlsSecret[] m_earlySecrets;

		internal int m_bindersSize;

		internal BindersConfig(TlsPsk[] psks, short[] pskKeyExchangeModes, TlsSecret[] earlySecrets, int bindersSize)
		{
		}
	}

	internal class SelectedConfig
	{
		internal readonly int m_index;

		internal readonly TlsPsk m_psk;

		internal readonly short[] m_pskKeyExchangeModes;

		internal readonly TlsSecret m_earlySecret;

		internal SelectedConfig(int index, TlsPsk psk, short[] pskKeyExchangeModes, TlsSecret earlySecret)
		{
		}
	}

	private readonly IList<PskIdentity> m_identities;

	private readonly IList<byte[]> m_binders;

	private readonly int m_bindersSize;

	public IList<byte[]> Binders => null;

	public int BindersSize => 0;

	public IList<PskIdentity> Identities => null;

	public OfferedPsks(IList<PskIdentity> identities)
	{
	}

	private OfferedPsks(IList<PskIdentity> identities, IList<byte[]> binders, int bindersSize)
	{
	}

	public int GetIndexOfIdentity(PskIdentity pskIdentity)
	{
		return 0;
	}

	public void Encode(Stream output)
	{
	}

	internal static void EncodeBinders(Stream output, TlsCrypto crypto, TlsHandshakeHash handshakeHash, BindersConfig bindersConfig)
	{
	}

	internal static int GetBindersSize(TlsPsk[] psks)
	{
		return 0;
	}

	public static OfferedPsks Parse(Stream input)
	{
		return null;
	}
}
