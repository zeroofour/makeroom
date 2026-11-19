namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public sealed class NtruPublicKeyParameters : NtruKeyParameters
{
	private byte[] _publicKey;

	public byte[] PublicKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public NtruPublicKeyParameters(NtruParameters parameters, byte[] key)
		: base(privateKey: false, null)
	{
	}

	public override byte[] GetEncoded()
	{
		return null;
	}
}
