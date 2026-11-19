namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public sealed class NtruPrivateKeyParameters : NtruKeyParameters
{
	private byte[] _privateKey;

	public byte[] PrivateKey
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public NtruPrivateKeyParameters(NtruParameters parameters, byte[] key)
		: base(privateKey: false, null)
	{
	}

	public override byte[] GetEncoded()
	{
		return null;
	}
}
