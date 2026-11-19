namespace Mirror.BouncyCastle.Tls.Crypto;

public class TlsDHConfig
{
	protected readonly DHGroup m_explicitGroup;

	protected readonly int m_namedGroup;

	protected readonly bool m_padded;

	public virtual DHGroup ExplicitGroup => null;

	public virtual int NamedGroup => 0;

	public virtual bool IsPadded => false;

	public TlsDHConfig(DHGroup explicitGroup)
	{
	}

	public TlsDHConfig(int namedGroup, bool padded)
	{
	}
}
