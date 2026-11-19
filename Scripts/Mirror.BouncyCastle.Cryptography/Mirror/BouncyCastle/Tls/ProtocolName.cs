using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ProtocolName
{
	public static readonly ProtocolName Http_1_1;

	public static readonly ProtocolName Spdy_1;

	public static readonly ProtocolName Spdy_2;

	public static readonly ProtocolName Spdy_3;

	public static readonly ProtocolName Stun_Turn;

	public static readonly ProtocolName Stun_Nat_Discovery;

	public static readonly ProtocolName Http_2_Tls;

	public static readonly ProtocolName Http_2_Tcp;

	public static readonly ProtocolName WebRtc;

	public static readonly ProtocolName WebRtc_Confidential;

	public static readonly ProtocolName Ftp;

	public static readonly ProtocolName Imap;

	public static readonly ProtocolName Pop3;

	public static readonly ProtocolName ManageSieve;

	public static readonly ProtocolName Coap;

	public static readonly ProtocolName Xmpp_Client;

	public static readonly ProtocolName Xmpp_Server;

	public static readonly ProtocolName Acme_Tls_1;

	public static readonly ProtocolName Oasis_Mqtt;

	public static readonly ProtocolName Dns_Over_Tls;

	public static readonly ProtocolName Ntske_1;

	public static readonly ProtocolName Sun_Rpc;

	public static readonly ProtocolName Http_3;

	public static readonly ProtocolName Smb_2;

	public static readonly ProtocolName Irc;

	public static readonly ProtocolName Nntp_Reading;

	public static readonly ProtocolName Nntp_Transit;

	public static readonly ProtocolName Dns_Over_Quic;

	private readonly byte[] m_bytes;

	public static ProtocolName AsRawBytes(byte[] bytes)
	{
		return null;
	}

	public static ProtocolName AsUtf8Encoding(string name)
	{
		return null;
	}

	private ProtocolName(byte[] bytes)
	{
	}

	public byte[] GetBytes()
	{
		return null;
	}

	public string GetUtf8Decoding()
	{
		return null;
	}

	public void Encode(Stream output)
	{
	}

	public static ProtocolName Parse(Stream input)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
