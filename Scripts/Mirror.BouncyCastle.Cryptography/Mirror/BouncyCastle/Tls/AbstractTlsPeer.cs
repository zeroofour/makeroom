using System;
using Mirror.BouncyCastle.Tls.Crypto;

namespace Mirror.BouncyCastle.Tls;

public abstract class AbstractTlsPeer : TlsPeer
{
	private readonly TlsCrypto m_crypto;

	private TlsCloseable m_closeHandle;

	public virtual TlsCrypto Crypto => null;

	public virtual bool IgnoreCorruptDtlsRecords => false;

	protected AbstractTlsPeer(TlsCrypto crypto)
	{
	}

	protected virtual ProtocolVersion[] GetSupportedVersions()
	{
		return null;
	}

	protected abstract int[] GetSupportedCipherSuites();

	public virtual void Cancel()
	{
	}

	public virtual void NotifyCloseHandle(TlsCloseable closeHandle)
	{
	}

	public abstract ProtocolVersion[] GetProtocolVersions();

	public abstract int[] GetCipherSuites();

	public virtual void NotifyHandshakeBeginning()
	{
	}

	public virtual int GetHandshakeTimeoutMillis()
	{
		return 0;
	}

	public virtual int GetHandshakeResendTimeMillis()
	{
		return 0;
	}

	public virtual bool AllowLegacyResumption()
	{
		return false;
	}

	public virtual int GetMaxCertificateChainLength()
	{
		return 0;
	}

	public virtual int GetMaxHandshakeMessageSize()
	{
		return 0;
	}

	public virtual short[] GetPskKeyExchangeModes()
	{
		return null;
	}

	public virtual bool RequiresCloseNotify()
	{
		return false;
	}

	public virtual bool RequiresExtendedMasterSecret()
	{
		return false;
	}

	public virtual bool ShouldCheckSigAlgOfPeerCerts()
	{
		return false;
	}

	public virtual bool ShouldUseExtendedMasterSecret()
	{
		return false;
	}

	public virtual bool ShouldUseExtendedPadding()
	{
		return false;
	}

	public virtual bool ShouldUseGmtUnixTime()
	{
		return false;
	}

	public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
	{
	}

	public virtual TlsKeyExchangeFactory GetKeyExchangeFactory()
	{
		return null;
	}

	public virtual void NotifyAlertRaised(short alertLevel, short alertDescription, string message, Exception cause)
	{
	}

	public virtual void NotifyAlertReceived(short alertLevel, short alertDescription)
	{
	}

	public virtual void NotifyConnectionClosed()
	{
	}

	public virtual void NotifyHandshakeComplete()
	{
	}

	public virtual TlsHeartbeat GetHeartbeat()
	{
		return null;
	}

	public virtual short GetHeartbeatPolicy()
	{
		return 0;
	}
}
