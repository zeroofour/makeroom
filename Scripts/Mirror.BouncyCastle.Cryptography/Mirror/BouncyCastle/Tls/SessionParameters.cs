using System.Collections.Generic;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public sealed class SessionParameters
{
	public sealed class Builder
	{
		private int m_cipherSuite;

		private Certificate m_localCertificate;

		private TlsSecret m_masterSecret;

		private ProtocolVersion m_negotiatedVersion;

		private Certificate m_peerCertificate;

		private byte[] m_pskIdentity;

		private byte[] m_srpIdentity;

		private byte[] m_encodedServerExtensions;

		private bool m_extendedMasterSecret;

		public SessionParameters Build()
		{
			return null;
		}

		public Builder SetCipherSuite(int cipherSuite)
		{
			return null;
		}

		public Builder SetExtendedMasterSecret(bool extendedMasterSecret)
		{
			return null;
		}

		public Builder SetLocalCertificate(Certificate localCertificate)
		{
			return null;
		}

		public Builder SetMasterSecret(TlsSecret masterSecret)
		{
			return null;
		}

		public Builder SetNegotiatedVersion(ProtocolVersion negotiatedVersion)
		{
			return null;
		}

		public Builder SetPeerCertificate(Certificate peerCertificate)
		{
			return null;
		}

		public Builder SetPskIdentity(byte[] pskIdentity)
		{
			return null;
		}

		public Builder SetSrpIdentity(byte[] srpIdentity)
		{
			return null;
		}

		public Builder SetServerExtensions(IDictionary<int, byte[]> serverExtensions)
		{
			return null;
		}

		private void Validate(bool condition, string parameter)
		{
		}
	}

	private readonly int m_cipherSuite;

	private readonly Certificate m_localCertificate;

	private readonly TlsSecret m_masterSecret;

	private readonly ProtocolVersion m_negotiatedVersion;

	private readonly Certificate m_peerCertificate;

	private readonly byte[] m_pskIdentity;

	private readonly byte[] m_srpIdentity;

	private readonly byte[] m_encodedServerExtensions;

	private readonly bool m_extendedMasterSecret;

	public int CipherSuite => 0;

	public bool IsExtendedMasterSecret => false;

	public Certificate LocalCertificate => null;

	public TlsSecret MasterSecret => null;

	public ProtocolVersion NegotiatedVersion => null;

	public Certificate PeerCertificate => null;

	public byte[] PskIdentity => null;

	public byte[] SrpIdentity => null;

	private SessionParameters(int cipherSuite, Certificate localCertificate, TlsSecret masterSecret, ProtocolVersion negotiatedVersion, Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions, bool extendedMasterSecret)
	{
	}

	public void Clear()
	{
	}

	public SessionParameters Copy()
	{
		return null;
	}

	public IDictionary<int, byte[]> ReadServerExtensions()
	{
		return null;
	}
}
